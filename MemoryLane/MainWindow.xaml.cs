using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MemoryLane
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool playing;

        public MainWindow()
        {
            InitializeComponent();
            playing = false; // Playing is false in the beginning as the user has not moved the mouse to the 'Enter' label. 

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Play.IsEnabled = false;
            Play.Visibility = Visibility.Hidden;
        }

        private void Exit_Mouse_Enter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You Have Found The Right Path !");

            Close();
           
        }

        private void Start_Mouse_Enter(object sender, MouseEventArgs e) //Created a event for the rectangles.  
        {

            if (playing)
            {
                MessageBoxResult ms = MessageBox.Show("Ha Ha Ha, Touched! Go Back To The Start"); // Made an IF statement, so that if the mouse touches the wall it will display a message and then 
                playing = false;                                                                  //the player will need to go back to the enter label to start the game again.
                
            }

        }

        private void Enter_position_reached(object sender, MouseEventArgs e)
        {
            playing = true; //When the mouse is placed in the 'Enter' label the game will start again.
     
        }
    }
}
