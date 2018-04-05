//Andrew Markham
//March 26, 2018
//A program that will have spaceships that the users will fly around and the program will check if the ships collide.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace U2Spaceships
{
    class Spaceships
    {
        public int currentDir = 0;
        public Rectangle ship;
        public double locationX;
        public double locationY;

        //Constructor method.
        public Spaceships(double locationx, double locationy)
        {
            this.ship = new Rectangle();
            this.ship.Fill = Brushes.Salmon;
            this.ship.StrokeThickness = 2;
            this.ship.Stroke = Brushes.Black;
            this.ship.Width = 25;
            this.ship.Height = 25;
            locationX = locationx;
            locationY = locationy;
        }

        //Moves spaceship's location based on user input.
        public void Fly(Rectangle r, int direction)
        {
            //Checks to see if the direction is 0, and if so, makes it positive.
            if (direction < 0)
            {
                direction += 360;
            }

            if (direction % 360 == 0)
            {
                locationY--;
                Canvas.SetTop(r, locationY);
            }

            if (direction % 360 == 90)
            {
                locationX++;
                Canvas.SetLeft(r, locationX);
            }

            if ( direction % 360 == 180)
            {
                locationY++;
                Canvas.SetTop(r, locationY);
            }

            if ( direction % 360 == 270)
            {
                locationX--;
                Canvas.SetLeft(r, locationX);
            }
        }

        //Checks the value of the boolean and turns either left or right depending on the value. Changes the value of the current direction.
        public void Turn(bool TurnLeftIsTrue)
        {
            if (TurnLeftIsTrue == true)
            {
                currentDir -= 90;
            }

            if (TurnLeftIsTrue == false)
            {
                currentDir += 90;
            }
        }

        //Checks to see if the spaceships are overlapping one another, returns true if they are overlapping, false if they are apart.
        public bool checkCollision(Spaceships s2)
        {
            if (Math.Abs(this. locationX - s2.locationX) <= 25 && Math.Abs(this.locationY - s2.locationY) <=25)
            {
                MessageBox.Show("Crash! \nGAME OVER");
                System.Windows.Application.Current.Shutdown();
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
