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
using Microsoft.Win32;
using System.IO;

namespace B2_Snake2D
{
    /// <summary>
    /// Interaction logic for Game_page.xaml
    /// </summary>

    public partial class Game_page : Page
    {

        Random random = new Random();  //random source
        DispatcherTimer timer;  //game timer
        string nickname;

        double x = 160;
        double y = 160;  //start position

        int score = 0;  //score!
        int direction = 0;
        int right = 6;  
        int left = 4;  //controls
        int up = 8;
        int down = 2;
        int count = 0;
        
        List<Snake> snakebody;
        List<Green_apple> greenbody;
        List<Red_apple> redbody;  //heirdom from classes


       
        void download_nick()  //DOWNLOAD NICKNAME
            {
                try
                {
                    nickname = File.ReadAllText("data/temp_nick.txt");
                }
                catch (Exception) { nickname = "nickname"; }
            }  
 

        public Game_page()  //MAIN LOGIC
        {
            InitializeComponent();

            timer = new DispatcherTimer();  //game timer
            timer.Interval = new TimeSpan(0, 0, 0, 0, 80);

            snakebody = new List<Snake>();
            snakebody.Add(new Snake(x, y));  //spawn snake

            greenbody = new List<Green_apple>();  //spawn green apple
            greenbody.Add(new Green_apple(random.Next(0, 36) * 20, random.Next(0, 21) * 20));

            redbody = new List<Red_apple>();  //spawn red apple
            redbody.Add(new Red_apple(random.Next(0, 36) * 20, random.Next(0, 21) * 20));

            timer.Tick += time_Tick;  //event when timer tick 

            timer.Start();
            addsnaketocanvas();
            addgreentocanvas();
            addredtocanvas();  //draw game objects

            download_nick();
            textBlock.Text = nickname;
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);  //KEY BIDING
            window.KeyDown += _KeyDown;
        }


        private void _KeyDown(object sender, KeyEventArgs e)  //KEY BIDING
        {
            if (e.Key == Key.Up && direction != down)
                direction = up; 
            if (e.Key == Key.Down && direction != up)
                direction = down;
            if (e.Key == Key.Left && direction != right)
                direction = left;
            if (e.Key == Key.Right && direction != left)
                direction = right;  
        }


        void addsnaketocanvas()  //SNAKE DRAWING
        {
            foreach (Snake snake in snakebody)
            {
                snake.setsnake();
                canvas.Children.Add(snake.snakecube);
            }
        }


        void addgreentocanvas()  //GREEN APPLE DRAWING
        {
            greenbody[0].setgreen();
            canvas.Children.Insert(0, greenbody[0].greeneli);
        }
          

        void addredtocanvas()  //RED APPLE DRAWING
        {
            redbody[0].sertred();
            canvas.Children.Insert(0, redbody[0].redeli);
        }


        void time_Tick(object sender, EventArgs e)  //TIMER TICK EVENT
        {

            if (direction != 0)
            {
                for (int i = snakebody.Count - 1; i > 0; i--)
                {
                    snakebody[i] = snakebody[i - 1];
                }
            }  //delete last cubes

            if (direction == up)
                y -= 20;
            if (direction == down)
                y += 20;
            if (direction == left)  //move cubes every tick
                x -= 20;
            if (direction == right)
                x += 20;


            /*  THE GAME RULES SECTION  */

            if (score >= 1300)  //SHOW WOW TITLE
            {
                    textBox.Visibility = Visibility.Visible;               
            }

            if (score >= 1340)  //HIDE WOW TITLE
            {
                textBox.Visibility = Visibility.Hidden;
            }

            if (snakebody[0].x == greenbody[0].x && snakebody[0].y == greenbody[0].y)  //EATING GREEN APPLE
            {
                snakebody.Add(new Snake(greenbody[0].x, greenbody[0].y));
                greenbody[0] = new Green_apple(random.Next(0, 36) * 20, random.Next(0, 21) * 20);
                canvas.Children.RemoveAt(0);
                addgreentocanvas();
                score +=40;
                textBlock_Copy1.Text = score.ToString();
            }


            if (snakebody[0].x == redbody[0].x && snakebody[0].y == redbody[0].y)  //EATING RED APPLE
            {
                snakebody.Add(new Snake(redbody[0].x, redbody[0].y));
                redbody[0] = new Red_apple(random.Next(0, 36) * 20, random.Next(0, 21) * 20);
                canvas.Children.RemoveAt(0);
                addredtocanvas();
                score += 35;
                textBlock_Copy1.Text = score.ToString();
            }

            snakebody[0] = new Snake(x, y);  //new snake cubes

            if (snakebody[0].x > 720 || snakebody[0].y > 400 || snakebody[0].x < 0 || snakebody[0].y < 0)
            {
                Game_over();
            }  //HITTING WALL - GAME OVER

            for (int i = 1; i < snakebody.Count; i++)  //HITTING SNAKE - GAME OVER
            {
                if (snakebody[0].x == snakebody[i].x && snakebody[0].y == snakebody[i].y)
                    Game_over();
            }

            /*  END OF THE GAME RULES SECTION  */


            for (int i = 0; i < canvas.Children.Count; i++)
            {
                if (canvas.Children[i] is Rectangle)
                    count++;  //moving snake cubes
            }
            canvas.Children.RemoveRange(1, count);
            count = 0;
            addsnaketocanvas();
        }


        private void Game_over()  //GAME OVER
        {
            canvas.Visibility = Visibility.Hidden;  //hide canvas
            end.Visibility = Visibility.Visible;
            end2.Visibility = Visibility.Visible;
            end3.Visibility = Visibility.Visible;  //ui - game over

            string strscore = score.ToString();  //string of score

            end2.Text = strscore + " points";  //show score

            string str_score_one; int score_one;
            string str_score_two; int score_two;  //to read score variables
            string str_score_three; int score_three;

            download_nick();  //try to download nickname

            try
            {
                str_score_one = File.ReadAllText("data/scre_uno.txt");
                score_one = Int32.Parse(str_score_one);
            }
            catch (Exception) { score_one = 0; }  //1-load first score

            try
            {
                str_score_two = File.ReadAllText("data/scre_due.txt");
                score_two = Int32.Parse(str_score_two);
            }
            catch (Exception) { score_two = 0; }  //2-load second score

            try
            {
                str_score_three = File.ReadAllText("data/scre_tre.txt");
                score_three = Int32.Parse(str_score_three);
            }
            catch (Exception) { score_three = 0; }  //3-load third score

            try
            {
            if(score > score_one)  //SAVE RECORD SCORES
            {
                File.WriteAllText("data/scre_uno.txt", strscore);
                File.WriteAllText("data/scre_uno_.txt", nickname);
            }

            if (score > score_two  && score < score_one)
            {
                File.WriteAllText("data/scre_due.txt", strscore);
                File.WriteAllText("data/scre_due_.txt", nickname);
            }

            if (score > score_three && score < score_two)
            {
                File.WriteAllText("data/scre_tre.txt", strscore);
                File.WriteAllText("data/scre_tre_.txt", nickname);
            }
            } catch(Exception) { }




        }








    }
}
