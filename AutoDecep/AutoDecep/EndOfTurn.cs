using System;
using System.Drawing;


namespace AutoDecep
{
    class EndOfTurn
    {
        public Boolean DoYouWin(string[] ClickCheck, string playerTurn)//ClickCheck is array of Tag.ToString() propertys of all the images.  playertrun is lable1.Tag.ToString()
        {
            Boolean GameWin = false;

            if (ClickCheck[0] == playerTurn && ClickCheck[1] == playerTurn && ClickCheck[2] == playerTurn)
            {
                GameWin = true;
            }
            else if (ClickCheck[0] == playerTurn && ClickCheck[3] == playerTurn && ClickCheck[6] == playerTurn)
            {
                GameWin = true;
            }
            else if (ClickCheck[0] == playerTurn && ClickCheck[4] == playerTurn && ClickCheck[8] == playerTurn)
            {
                GameWin = true;
            }
            else if (ClickCheck[1] == playerTurn && ClickCheck[4] == playerTurn && ClickCheck[7] == playerTurn)
            {
                GameWin = true;
            }
            else if (ClickCheck[2] == playerTurn && ClickCheck[5] == playerTurn && ClickCheck[8] == playerTurn)
            {
                GameWin = true;
            }
            else if (ClickCheck[2] == playerTurn && ClickCheck[4] == playerTurn && ClickCheck[6] == playerTurn)
            {
                GameWin = true;
            }
            else if (ClickCheck[3] == playerTurn && ClickCheck[4] == playerTurn && ClickCheck[5] == playerTurn)
            {
                GameWin = true;
            }
            else if (ClickCheck[6] == playerTurn && ClickCheck[7] == playerTurn && ClickCheck[8] == playerTurn)
            {
                GameWin = true;
            }

            return GameWin;
        }

        

        public object NewTrun(object sender)//Take in an object.  Returns an object
        {
            
            Random rnd = new Random();
            int ii = rnd.Next(0, 9);

            //Some funky text going on. Note: 'using System.Windows.Forms;' is missing


            switch (((System.Windows.Forms.Label)sender).Tag.ToString())
            {
                case "decep":
                    ((System.Windows.Forms.Label)sender).Tag = "auto";
                    ((System.Windows.Forms.Label)sender).ForeColor = Color.Red;
                    switch (ii)
                        {
                        case 1:
                            ((System.Windows.Forms.Label)sender).Text = "Autobots, roll out";
                            break;
                        case 2:
                            ((System.Windows.Forms.Label)sender).Text = "We've suffered losses, but we've not lost the war";
                            break;
                        case 3:
                            ((System.Windows.Forms.Label)sender).Text = "Stick ot on neureal, Megatron";
                            break;
                        case 4:
                            ((System.Windows.Forms.Label)sender).Text = "One shell stard, one shell fall!";
                            break;
                        case 5:
                            ((System.Windows.Forms.Label)sender).Text = "There's a thin line between being a hero, and being a memory";
                            break;
                        case 6:
                            ((System.Windows.Forms.Label)sender).Text = "I must catch the bad guy!";
                            break;
                        case 7:
                            ((System.Windows.Forms.Label)sender).Text = "I'm the fastest thing on wheels and nobody will ever change it";
                            break;
                        case 8:
                            ((System.Windows.Forms.Label)sender).Text = "All Hail Megatron! Whats a Megatron?";
                            break;
                        case 9:
                            ((System.Windows.Forms.Label)sender).Text = "Is it always like this on this crazy planet?";
                            break;
                        case 0:
                            ((System.Windows.Forms.Label)sender).Text = "They're indestructible!";
                            break;
                    }
                     

                    break;
                case "auto":
                    ((System.Windows.Forms.Label)sender).Tag = "decep";
                    ((System.Windows.Forms.Label)sender).ForeColor = Color.Purple;
                    switch (ii)
                    {
                        case 1:
                            ((System.Windows.Forms.Label)sender).Text = "No, merely a cheap imitation";
                            break;
                        case 2:
                            ((System.Windows.Forms.Label)sender).Text = "You're a persistant little Autobot";
                            break;
                        case 3:
                            ((System.Windows.Forms.Label)sender).Text = "Traitor!";
                            break;
                        case 4:
                            ((System.Windows.Forms.Label)sender).Text = "Decepticons, Transform and Rise up!";
                            break;
                        case 5:
                            ((System.Windows.Forms.Label)sender).Text = "Oh you got to be kidding me";
                            break;
                        case 6:
                            ((System.Windows.Forms.Label)sender).Text = "Are you willing to sacrifice this?";
                            break;
                        case 7:
                            ((System.Windows.Forms.Label)sender).Text = "I am ready to serve as your fateful second in command!";
                            break;
                        case 8:
                            ((System.Windows.Forms.Label)sender).Text = "ITS MORE POWERFUL THAN I EVER IMAGINE!?";
                            break;
                        case 9:
                            ((System.Windows.Forms.Label)sender).Text = "Only this time the Allspark is mine!";
                            break;
                        case 0:
                            ((System.Windows.Forms.Label)sender).Text = "Lugnut? Attack! Your glorious leader commands you!";
                            break;
                    }
                    break;

            }
            return sender;
        }

        
    }
    
}
