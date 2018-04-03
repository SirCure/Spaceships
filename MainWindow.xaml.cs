//Andrew Markham
//March 26, 2018
//A spaceship program that has two ships that can be controlled by players. The program will stop if a collision between the two ships is detected.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace U2Spaceships
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global variables.
        Spaceships s = new Spaceships(200, 237.5);
        Spaceships s2 = new Spaceships(300, 237.5);

        public MainWindow()
        {
            InitializeComponent();

            //Create rectangle on screen that will represent the ship.
            canvas.Children.Add(s.ship);
            canvas.Children.Add(s2.ship);

            //Set location of the ship.
            Canvas.SetLeft(s.ship, s.locationX);
            Canvas.SetTop(s.ship, s.locationY);
            Canvas.SetLeft(s2.ship, s2.locationX);
            Canvas.SetTop(s2.ship, s2.locationY);
            
        }

        
        private void key(object sender, KeyEventArgs e)
        {
                //Movement for the first ship.
                //Moves up.
                if (Keyboard.IsKeyDown(Key.W))
                {
                s.Fly(s.ship, s.currentDir);
                }

                //Moves down.
                if (Keyboard.IsKeyDown(Key.S))
                {
                s.Fly(s.ship, s.currentDir - 180);
                }

                //Turns left.
                if (Keyboard.IsKeyDown(Key.A))
                {
                s.Turn(true);
                }

                //Turns right.
                if (Keyboard.IsKeyDown(Key.D))
                {
                s.Turn(false);
                }

            //Movement for the second ship.
            //Moves up.
            if (Keyboard.IsKeyDown(Key.Up))
            {
                s2.Fly(s2.ship, s2.currentDir);
            }

            //Moves down.
            if (Keyboard.IsKeyDown(Key.Down))
            {
                s2.Fly(s2.ship, s2.currentDir - 180);
            }

            //Turns left.
            if (Keyboard.IsKeyDown(Key.Left))
            {
                s2.Turn(true);
            }

            //Turns right.
            if (Keyboard.IsKeyDown(Key.Right))
            {
                s2.Turn(false);
            }
        }
    }
}
