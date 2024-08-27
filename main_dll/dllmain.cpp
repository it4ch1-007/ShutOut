// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include <iostream>
#include <thread>
#include <boost/asio.hpp>
#include <deque>
#include <memory>
#include <set>
#include <mutex>

using boost::asio::ip::tcp;
//We will be using the tcp method of the boost library to make sure the connection is asynchronous


//This dll should be able to communicate using broadcasting channels and a broadcasting channel from the server
extern "C" _declspec(dllexport)
void start_server(int port);

//The class to handle each session of the client
class Session : public std::enable_shared_from_this<Session> {
public:
    Session(tcp::socket socket, std::set<std::shared_ptr<Session>>& clients,std::mutex& clients_mutex)
        : socket_(std::move(socket)), clients_(clients), clients_mutex_(clients_mutex) {}

    //as more than two things can access the same client thus the clients will be stores as a shared pointer type
    //Also when sharing we have ti create a mutex for the clients to be able to share the resources between clients
    
        void start() {
            {
                std::lock_guard<std::mutex> lock(clients_mutex_);
                clients_.insert(shared_from_this());
            }
            do_read();
    }
    void deliver(const std::string& message) {
        auto self(shared_from_this());
        boost::asio::async_write(socket_, boost::asio::buffer(message),
            [this, self](boost::system::error_code ec, std::size_t length) {
                if (ec) {
                    stop();
                }
            });
    }
private:
    void do_read() {
        auto self(shared_from_this());
        //dynamic buffer is used to make sure that the buffer has no limited size and can grow according to the data given by the clients
        boost::asio::async_read_until(socket_, boost::asio::dynamic_buffer(data_), '\n', [this, self](boost::system::error_code ec, std::size_t length) {
            if (!ec) {
                std::string message = data_.substr(0, length);
                data_.erase(0, length);//This will delete the whole data_ buffer and makes space for the next message to be accomnodated
                std::cout << "Received: " << message;
                echo_message(message);
                do_read();
            }
            else {
                stop();//The server will stop when there is any error connecting to the client
            }
            });
    }

    //This fn will be responsible to send the data back to the client
    void echo_message(const std::string & message) {
        std::lock_guard<std::recursive_mutex> lock(clients_mutex_);
        //This is the way to acquire the lock on the clients mutex
        for(auto& client : clients_) {
            //the shared from this makes the resource able to ghet a reference lock to itself
            if (client != shared_from_this()) {
                client->deliver(message);
            }
        }
        deliver(message);
    }

    void stop() {
        socket_.close();
        std::lock_guard<std::mutex> lock(clients_mutex_);
        clients_.erase(shared_from_this());
    }

    tcp::socket socket_;
    std::string data_;
    std::set<std::shared_ptr<Session>>& clients_;
    //This is the set of all the shared pointers to the Session basically having reference to all the active sessions.


    };

class Server {
public: 
    //As soon as the server is initialized then it will start receiving connections from all the clients
    Server(boost::asio::io_context& io_context, const tcp::endpoint& endpoint)
        : acceptor_(io_context, endpoint) {
        do_accept();
    }
private:
    void do_accept() {
        acceptor_.async_accept(
            [this](boost::system::error_code ec, tcp::socket socket) {
                if (!ec) {
                    std::make_shared<Session>(std::move(socket), clients_, clients_mutex_)->start();
                }
                do_accept();
            });
    }

    tcp::acceptor acceptor_;
    std::set<std::shared_ptr<Session>>& clients_;
    std::mutex& clients_mutex_;
};

void start_server(int port) {
    try {
        boost::asio::io_context io_context;
        //This is the main instance of boost library that allows async events dispatching

        tcp::endpoint endpoint(tcp::v4(), port);
        Server server(io_context, endpoint);
        io_context.run();
    }
    catch (std::exception& err) {
        std::cerr << "Exception: " << err.what() << std::endl;
    }
}


BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    //DONOT ADD ANY COMPLEX CALCULATION INSIDE THE DLLMAIN FUNCTION
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
        break;
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
        break;
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

