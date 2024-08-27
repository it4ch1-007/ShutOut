using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Libraries to interact with the PowerPoint application at runtime
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using Microsoft.Office.Core;

namespace MasterApp
{
    public partial class Ribbon1
    {
        private int startingSlide;
        private int endingSlide;
        private void AddNewSlide(String slideName)
        {
            //Making an instance of the application of PowerPoint
            PowerPoint.Application appln = Globals.ThisAddIn.Application;
            //Making an instance to interact with the slides of the powerpoint
            PowerPoint.Slides slides = appln.ActivePresentation.Slides;
            //ActivePresentation here refers to the current presentation inside the Powerpoint 

            //This is to add some custom layout or just add some custom configuration to the presentation
            PowerPoint.CustomLayout layout = appln.ActivePresentation.Designs[1].SlideMaster.CustomLayouts[1];
            slides.Add(slides.Count + 1, PowerPoint.PpSlideLayout.ppLayoutText);
            //This is to describe the type of the slide that will be added.
        }
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //This will be executed when the visual of the ribbon inside the task pane is executed and shown.

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //This will be executed when the button is clicked
            //Creating a new slide
            try
            {
                MessageBox.Show("New Slide button clicked");
                AddNewSlide("New0");
            }
            catch (Exception err){ MessageBox.Show("Error: {err.message}"); }
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {

        }
            

        //EVENT HANDLERS SHOULD ALWAYS HAVE THE TYPE OF VOID AND NOT ANYTHING ELSE
        private void dropDown2_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            
            RibbonDropDown dropdown2 = sender as RibbonDropDown;

            //checking if the item selected is not null
            if (dropdown2 != null && dropdown2.SelectedItem != null)
            {
                string selectedValue = dropdown2.SelectedItem.Label;
                MessageBox.Show($"selected value: {selectedValue}");
                if (int.TryParse(dropdown2.SelectedItem.Label, out int slideNumber))
                {
                    MessageBox.Show("endingSlide changed");
                    endingSlide = slideNumber;
                }
            }

        }

        private void dropDown1_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            
            RibbonDropDown dropdown1 = sender as RibbonDropDown;

            //checking if the item selected is not null
            if (dropdown1 != null && dropdown1.SelectedItem != null)
            {
                string selectedValue = dropdown1.SelectedItem.Label;
                MessageBox.Show($"selected value: {selectedValue}");
                if (int.TryParse(dropdown1.SelectedItem.Label, out int slideNumber))
                {
                    MessageBox.Show("Changed startingSlide");
                    startingSlide = slideNumber;
                }
            }
        }
        private void restrictControl()
        {
            MessageBox.Show(startingSlide.ToString());
            MessageBox.Show(endingSlide.ToString());
            //Make an instance of the application
            PowerPoint.Application application = Globals.ThisAddIn.Application;
            PowerPoint.Presentation presentation = application.ActivePresentation;
            PowerPoint.SlideShowSettings slideShowSettings = application.ActivePresentation.SlideShowSettings;
            //Setting the range of the slides
            slideShowSettings.StartingSlide = startingSlide;
            slideShowSettings.EndingSlide = endingSlide;

            slideShowSettings.AdvanceMode = PowerPoint.PpSlideShowAdvanceMode.ppSlideShowUseSlideTimings;
            MessageBox.Show($"Restricting slides from {startingSlide} to {endingSlide}");
            MessageBox.Show($"Running the restricted slideshow");
            PowerPoint.SlideShowWindow slideShowWindow = slideShowSettings.Run();
            slideShowWindow.View.GotoSlide(4);
            PowerPoint.Slide slide = presentation.Slides[3];
            slide.SlideShowTransition.Hidden = MsoTriState.msoTrue;


        }

        private void button14_Click(object sender, RibbonControlEventArgs e)
        {
            
                restrictControl();
        }
    }
}
