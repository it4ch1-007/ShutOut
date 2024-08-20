# ppt_controller_

### DLL Method
- Based on C++
- Master software :
    - This will be created in Qt5 gui and will have various options and features.
    - It will spawn a child process with all its own access where the child process will inject the dll inside the powerpoint presentation process.
    - The gui must have buttons for all the things like controlling access and must have the peer-to-peer connection with the child process so that all the info gathered by the DLL will be displayed on the master software.
    - If any feature is changed or requested:
        - The Father process will communicate to the child process.
        - The child process will communicate to the DLL and tell it to change the configuration. (IPC or pipes or APC queues).
        - The DLL should be able to change the config once the info is received through the IPC.
- Injected DLL:
    - The DLL should be able to establish network through all the listed devices and control the access of all the devices presentation.
    - The Father process (Master software) will be able to communicate with the child process that can make the alterations in the access of the presentation in various devices that all will be handled by the (Communication between the father and child process in the host device) and (Communication between the DLLs in different devices in all connected devices.).
    - For Networking, TCP will be used.
    - No data encryption yet.
    - Mutexes will be used in order to limit the access of a sequence of presentation slides to the particular users.
### Add-in C# Method
- The C# plugin acts like a frontend that implements all the features for the MS powerpoint.
- The DLL will be able to communicate with each other and to the host using channel communication.
