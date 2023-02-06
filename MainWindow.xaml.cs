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
using static System.Net.Mime.MediaTypeNames;

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
        Button[] btn = new Button[9]  ;
        static bool gm = true;
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
                            btn[i].Content = "X";
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
                            btn[i].Content = "O";
                            Xod.Text = "Ходят крестики";
                            click = "Крестики";
                            ar[i] = 0;
                            btn[i].IsEnabled = false;
                            break;
                        }
                    }

                }
                if (gm) { Bot(); }
            
                else { gm = false; }
            Win();


        }  
        
        private void Win()
        {
            string win = "";
            if(Xod.Text == "Ходят нолики") { win = "крестики"; }
            else if (Xod.Text == "Ходят крестики") { win = "нолики"; }
            if (buttonOne.Content == buttonTwo.Content && buttonThree.Content == buttonTwo && buttonOne.Content == buttonThree.Content && (string)buttonOne.Content != "" ) { Xod.Text = "Победили -" + win ; }
            else if (buttonOne.Content == buttonFour.Content && buttonSeven.Content == buttonFour.Content && buttonOne.Content == buttonSeven.Content && (string)buttonOne.Content != "") { Xod.Text = "Победили -" + win; }
            else if (buttonOne.Content == buttonFive.Content && buttonNine.Content == buttonFive.Content && buttonOne.Content == buttonNine.Content && (string)buttonOne.Content != "") { Xod.Text = "Победили -" + win; }
            else if (buttonTwo.Content == buttonFive.Content && buttonFive.Content == buttonEight.Content && buttonTwo.Content == buttonEight.Content && (string)buttonTwo.Content != "") { Xod.Text = "Победили - " + win; }
            else if (buttonThree.Content == buttonSix.Content && buttonSix.Content == buttonNine.Content && buttonThree.Content == buttonNine.Content && (string)buttonThree.Content != "") { Xod.Text = "Победили - " + win; }
            else if (buttonThree.Content == buttonFive.Content && buttonFive.Content == buttonSeven.Content && buttonThree.Content == buttonSeven.Content && (string)buttonThree.Content != "") { Xod.Text = "Победили -" + win; }
            else if (buttonFour.Content == buttonFive.Content && buttonFive.Content == buttonSix.Content && buttonFour.Content == buttonSix.Content && (string)buttonFour.Content != "") { Xod.Text = "Победили - " + win; }
            else if (buttonSeven.Content == buttonEight.Content && buttonEight.Content == buttonNine.Content && buttonSeven.Content == buttonNine.Content && (string)buttonSeven.Content != "") { Xod.Text = "Победили - " + win; }
            else { Xod.Text = "Ничья"; }
            for (int i = 0; i < btn.Length; i++)
            {
                ar[i] = 123;
                btn[i].IsEnabled = false;
            }
        }
        private void Bot()
        {
            Random random = new Random();
            string xd = "";
            if (click == "Крестики") { xd = "X"; }
            else { xd = "O"; }
            for (int i = 0; i < btn.Length; i++)
            {
                if (btn[i].IsEnabled && (string)btn[i].Content == "")
                {
                    random.Next(i);
                    btn[i].Content = xd;
                    btn[i].IsEnabled = false;
                    break;
                }
            }

        }
    }

    
}


