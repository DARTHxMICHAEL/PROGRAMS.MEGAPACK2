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
using System.Windows.Automation;
using Microsoft.Win32;
using System.IO;

namespace B2_Snake2D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string nickname = "nickname";  //current player nickname

        

        private void button_Copy1_Click(object sender, RoutedEventArgs e)  //EXIT BUTTON
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)  //LEADERBOARD
        {
            button.Visibility = Visibility.Hidden;
            button_Copy.Visibility = Visibility.Hidden;  //ui-menu
            button_Copy1.Visibility = Visibility.Hidden;

            button_Copy5.Visibility = Visibility.Visible;
            button_Copy2.Visibility = Visibility.Visible;  //ui-board
            button_Copy3.Visibility = Visibility.Visible;
            button_Copy4.Visibility = Visibility.Visible;
            textBlock.Visibility = Visibility.Visible;
            textBlock_Copy.Visibility = Visibility.Visible;
            textBlock_Copy1.Visibility = Visibility.Visible;

            try
            {
                textBlock.Text = File.ReadAllText("data/scre_uno.txt")
                    + " - " + File.ReadAllText("data/scre_uno_.txt");
            }
            catch (Exception) { textBlock.Text = "no score"; }

            try
            {
                textBlock_Copy.Text = File.ReadAllText("data/scre_due.txt")
                    + " - " + File.ReadAllText("data/scre_due_.txt");
            }
            catch (Exception) { textBlock_Copy.Text = "no score"; }

            try
            {
                textBlock_Copy1.Text = File.ReadAllText("data/scre_tre.txt")
                    + " - " + File.ReadAllText("data/scre_tre_.txt");
            }
            catch (Exception) { textBlock_Copy1.Text = "no score"; }  //try to download scores
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)  //RETURN TO MENU
        {                                                                  //LEADERBOARD
            button.Visibility = Visibility.Visible;
            button_Copy.Visibility = Visibility.Visible;
            button_Copy1.Visibility = Visibility.Visible;  //ui-menu

            button_Copy5.Visibility = Visibility.Hidden;
            button_Copy2.Visibility = Visibility.Hidden;  //ui-board
            button_Copy3.Visibility = Visibility.Hidden;
            button_Copy4.Visibility = Visibility.Hidden;
            textBlock.Visibility = Visibility.Hidden;
            textBlock_Copy.Visibility = Visibility.Hidden;
            textBlock_Copy1.Visibility = Visibility.Hidden;
        }

        private void returntomenu(object sender, RoutedEventArgs e)  //RETURN TO MENU
        {
            button.Visibility = Visibility.Visible;
            button_Copy.Visibility = Visibility.Visible;
            button_Copy1.Visibility = Visibility.Visible;  //ui-menu

            button_Copy6.Visibility = Visibility.Hidden;  //return button
            Main.Content = new CLEAR_page();  //load empty-clear page
            button_Copy7.Visibility = Visibility.Hidden; //hide PLAY button
            button_Copy8.Visibility = Visibility.Hidden;
            textBox.Visibility = Visibility.Hidden;  //hide name-ui
        }

        private void startgame_Click(object sender, RoutedEventArgs e)  //START GAME
        {
            button_Copy6.Visibility = Visibility.Visible;  //return to menu button
            button_Copy7.Visibility = Visibility.Visible;  //PLAY button
            button_Copy8.Visibility = Visibility.Visible;
            textBox.Visibility = Visibility.Visible;  //name-ui

            button.Visibility = Visibility.Hidden;
            button_Copy.Visibility = Visibility.Hidden;
            button_Copy1.Visibility = Visibility.Hidden;  //hide ui-menu
        }

        private void play_Click(object sender, RoutedEventArgs e)  //PLAY!
        {
            button_Copy7.Visibility = Visibility.Hidden; //hide PLAY button
            button_Copy8.Visibility = Visibility.Hidden;
            textBox.Visibility = Visibility.Hidden;  //hide name-ui

            try
            {
                nickname = textBox.Text;
                File.WriteAllText("data/temp_nick.txt", nickname);
            } catch (Exception) { File.WriteAllText("data/temp_nick.txt", "nickname"); }

            Main.Content = new Game_page();  //loag page with game           
        }

        private void MainWindow_keydown(object sender, KeyEventArgs e)  //KEY BIDING-RESET
        {
            if (e.Key == Key.Enter)  //new game - reset all
            {
                Main.Content = new Game_page();
            }
            button_Copy6.Visibility = Visibility.Visible;  //return to menu button
            button.Visibility = Visibility.Hidden;
            button_Copy.Visibility = Visibility.Hidden;
            button_Copy1.Visibility = Visibility.Hidden;  //hide ui-menu    
        }





    }
}
