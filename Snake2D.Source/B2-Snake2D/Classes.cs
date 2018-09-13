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
using System.Windows.Threading;

namespace B2_Snake2D
{


    class Snake
    {
        public Rectangle snakecube = new Rectangle();
        public double x, y;  //cube position

        public Snake(double x, double y)
        {
            this.x = x;
            this.y = y;     //CONSTRUCTOR
        }

        public void setsnake()
        {
            snakecube.Width = 20;  //properties
            snakecube.Height = 20;
            snakecube.Fill = Brushes.Green;
            Canvas.SetTop(snakecube, y);
            Canvas.SetLeft(snakecube, x);
        }
    }


    class Green_apple
    {
        public Ellipse greeneli = new Ellipse();
        public double x, y;  //default properties

        public Green_apple(double x, double y)
        {
            this.x = x;
            this.y = y;  //CONSTRUCTOR
        }

        public void setgreen()
        {
            greeneli.Height = 20;
            greeneli.Width = 20;
            greeneli.Fill = Brushes.GreenYellow;
            Canvas.SetTop(greeneli, y);
            Canvas.SetLeft(greeneli, x);
        }
    }


    class Red_apple
    {
        public Ellipse redeli = new Ellipse();
        public double x, y;

        public Red_apple(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void sertred()
        {
            redeli.Width = 20;
            redeli.Height = 20;
            redeli.Fill = Brushes.Red;
            Canvas.SetTop(redeli, y);
            Canvas.SetLeft(redeli, x);
        }
    }



}
