using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public decimal hiddenNumber;
        public int counter =-1;
        
        public Form1()
        {
            InitializeComponent();
            //check for attemps counter befor starting the app and game
            checkForCounter();
        }

        //To guess the number by clicking the first button
        private void GuessTheNumber(object sender, EventArgs e)
        {
            //counter for attemps
            counter += 1;
            int op = 0;
            if (number.Value > hiddenNumber) op = 1;
            if (number.Value < hiddenNumber) op = 2;
            if (number.Value == hiddenNumber) op = 3;

             switch (op)
             {

                 case (1):
                     Output.Text += "Hidden number is SMALLER\r\n";
                     break;
                case (2):
                    Output.Text += "Hidden number is BIGGER\r\n";
                    break;
                case (3):                    
                    Output.Text += "Number is " + hiddenNumber + ". You are WINNER! ";
                    GuessBtn.Enabled = false;
                    break;
             }
            if (!checkForCounter())
            {
                Output.Text += "You lose!";
            }

            
        }

        //To create new game by clicking the second button
        private void CreateNew(object sender, EventArgs e)
        {
            //create random number between 1 and 10
            this.hiddenNumber = rnd.Next(1, 10);
            this.counter = 0;
            checkForCounter();
            Output.Text = "New Game started. You have 5 guesses!";
        }

        //To check for attemps
        private bool checkForCounter()
        {
            if (counter >= 5 || counter ==-1)
            {
                GuessBtn.Enabled = false;
                return false;
                
            }
            else {
                GuessBtn.Enabled = true;
                return true;
            }
        }
    }
}
