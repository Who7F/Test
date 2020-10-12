using System;
using System.Drawing;
using System.Windows.Forms;



namespace AutoDecep
{
    public partial class Form1 : Form
    {
        public Form1(string setTurn, Boolean ActionLog)
        {
            InitializeComponent();

            //Added to constructor of Form1 is Set player turn.  I feel like there are too many lines.     
            label1.Tag = setTurn;
            EndOfTurn g = new EndOfTurn();
            object newLable = g.NewTrun(label1);
            label1 = (Label)newLable;

            //Added to constructor of Form1 is the Action Logger. If enabled it will resize this form, and make textbox1 visible   
            if (ActionLog == true)
            {
                this.Size = new Size(560, 480);
                textBox1.Visible = true;
                textBox1.Text = "Action logger Enabled";
            }
            
        }

        

        private void button_Click(object sender, EventArgs e)
        {
            //Exit Form1
            this.Close();    
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)//This event with pictureBox_MouseLeave makes a mouse rollover 
        {
            
            if (((PictureBox)sender).Tag.ToString() == "tagMe")//tagMe is a place holder name. Note: ((PictureBox)sender) is the same as (sender as PictureBox)
            { 
                string playerTurn = label1.Tag.ToString();//label1 is not part of the sender, so the Tag value is grab here
                
                MyMouseEvents f = new MyMouseEvents();
                f.MouseEnter(sender, playerTurn);//void MouseEnter(object, string).   The image effected and the player turn

                MyLogger h = new MyLogger(); //Log shows if enabled
                h.DoStuff(textBox1, "Player has entered " + ((PictureBox)sender).Name.ToString());
            }
            

        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Tag.ToString() == "tagMe")
            {
                MyMouseEvents f = new MyMouseEvents();
                f.MouseLeave(sender);//void MouseLeave(object). The image effected 

            }
              
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Tag.ToString() == "tagMe")
            {
                MyMouseEvents f = new MyMouseEvents();
                MyLogger h = new MyLogger(); 
                EndOfTurn g = new EndOfTurn();
                
                // DoStuff is a callback to antiRTFM 
                h.DoStuff(textBox1, "Player Clicked " + ((PictureBox)sender).Name.ToString()); 
                
                f.MouseClick(sender, label1.Tag.ToString());//MyMouseEvent.  void MouseClick(object, string).  Set immage.

                //Makes an array of 9(0 to 8) to hand in to EndOfTurn
                string[] DoStuff = { pictureBoxTL.Tag.ToString(), pictureBoxTM.Tag.ToString(), pictureBoxTR.Tag.ToString(), pictureBoxML.Tag.ToString(), pictureBoxMM.Tag.ToString(), pictureBoxMR.Tag.ToString(), pictureBoxBL.Tag.ToString(), pictureBoxBM.Tag.ToString(), pictureBoxBR.Tag.ToString() };
                Boolean gameWin = g.DoYouWin(DoStuff, label1.Tag.ToString());//Boolean DoYouWin(string[], string).  Returns true if there is a line of 3

                if(gameWin == true)
                {
                    MessageBox.Show("Winner");
                    this.Close();
                }
                else// if there is no winner then a change of turn happens
                {
                    object newLable = g.NewTrun(label1);
                    label1 = (Label)newLable;
                }
                
            
            }        
        }
    }


    

   

}
