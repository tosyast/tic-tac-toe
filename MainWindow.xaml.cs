using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vrorayashertva
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        string click = "";
        Random random = new Random();
        int[] ar = new int[9];
        Button[] btn = new Button[9];
        string cross = "Крестики";
        string circle = "Нолики";
        public MainWindow()
        {
            InitializeComponent();

            btn[0] = buttonOne;
            btn[1] = buttonTwo;
            btn[2] = buttonThree;
            btn[3] = buttonFour;
            btn[4] = buttonFive;
            btn[5] = buttonSix;
            btn[6] = buttonSeven;
            btn[7] = buttonEight;
            btn[8] = buttonNine;
            buttonOne.IsEnabled = false;
            buttonTwo.IsEnabled = false;
            buttonThree.IsEnabled = false;
            buttonFour.IsEnabled = false;
            buttonFive.IsEnabled = false;
            buttonSix.IsEnabled = false;
            buttonSeven.IsEnabled = false;
            buttonEight.IsEnabled = false;
            buttonNine.IsEnabled = false;
            Start.IsEnabled = true;
            Xod.Text = "";
            if (random.Next(1, 10) <= 5)
            {
                click = "Крестики";
                Xod.Text = "Ходят крестики";

            }
            else
            {
                click = "Нолики";
                Xod.Text = "Ходят нолики";
            }


        }
       
        private void Start_Click_1(object sender, EventArgs e)
        {
            
            if (random.Next(1, 10) <= 5)
            {
                click = "Крестики";
                Xod.Text = "Ходят крестики";

            }
            else
            {
                click = "Нолики";
                Xod.Text = "Ходят нолики";
            }
            buttonOne.IsEnabled = true;
            buttonTwo.IsEnabled = true;
            buttonThree.IsEnabled = true;
            buttonFour.IsEnabled = true;
            buttonFive.IsEnabled = true;
            buttonSix.IsEnabled = true;
            buttonSeven.IsEnabled = true;
            buttonEight.IsEnabled = true;
            buttonNine.IsEnabled = true;
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Content = "";
            }

        }
        
        private void buttonOne_Click_1(object sender, RoutedEventArgs e)
        {
           
            if (click == "Крестики")
            {
                for (int i = 0; i < btn.Length; i++)
                {

                    if (sender == btn[i])
                    {
                        ((Button)sender).Content = "X";
                        Xod.Text = "Ходят нолики";
                        click = "Нолики";
                        ar[i] = 1;
                        btn[i].IsEnabled = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        ((Button)sender).Content = "O";
                        Xod.Text = "Ходят крестики";
                        click = "Крестики";
                        ar[i] = 0;
                        btn[i].IsEnabled = false;
                        break;
                    }
                }

            }
            //проверка на выигрыши крестики
           /* for (int i = 0; i < btn.Length; i++)
            {
                if (i == btn.Length - 1)
                {
                    Xod.Text = "Ничья";
                }
            }*/

            if (ar[0] == 0 && ar[1] == 0 && ar[2] == 0)
            {

                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + circle;
                click = cross;
                for (int i = 0; i < btn.Length; i++)
                {

                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[0] == 0 && ar[3] == 0 && ar[6] == 0)
            {

                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + circle;

                click = cross;
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[0] == 0 && ar[4] == 0 && ar[8] == 0)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + circle;

                click = cross;
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[1] == 0 && ar[4] == 0 && ar[7] == 0)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + circle;

                click = cross;
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[2] == 0 && ar[5] == 0 && ar[8] == 0)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + circle;

               click = cross;
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[2] == 0 && ar[4] == 0 && ar[7] == 0)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + circle;

                click = cross;
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[3] == 0 && ar[4] == 0 && ar[5] == 0)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + circle;

                click = cross;
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[6] == 0 && ar[7] == 0 && ar[8] == 0)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + circle;

                click = cross;
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
                 
            if (ar[0] == 1 && ar[1] == 1 && ar[2] == 1)
            {

                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + cross;
                click = "Нолики";
                for (int i = 0; i < btn.Length; i++)
                {

                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[0] == 1 && ar[3] == 1 && ar[6] == 1)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + cross;

                click = "Нолики";
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[0] == 1 && ar[4] == 1 && ar[8] == 1)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + cross;

                click = "Нолики";
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[1] == 1 && ar[4] == 1 && ar[7] == 1)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + cross;

                click = "Нолики";
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[2] == 1 && ar[5] == 1 && ar[8] == 1)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + cross;

                click = "Нолики";
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[2] == 1 && ar[4] == 1 && ar[7] == 1)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + cross;

                click = "Нолики";
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[3] == 1 && ar[4] == 1 && ar[5] == 1)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + cross;

                click = "Нолики";
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            else if (ar[6] == 1 && ar[7] == 1 && ar[8] == 1)
            {


                Start.IsEnabled = true;
                Xod.Text = "Выиграли" + cross;

                click = "Нолики";
                for (int i = 0; i < btn.Length; i++)
                {
                    ar[i] = 123;
                    btn[i].IsEnabled = false;
                }

            }
            

        }

    }
}


