using System;
using System.Windows.Forms;
using System.Media;


namespace AutoDecep
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }



        private void button1_Click(object sender, EventArgs e) //This event makes an instance of form1(string and Boolean)
        {

            SystemSounds.Beep.Play(); //Uses system Sounds.  If there is no sound from this event, please check your application system sound volume.  

            Form1 MrForm = new Form1((sender as Button).Tag.ToString(), checkBox1.Checked); //checkBox1.Checked is a Boolean  
            MrForm.Show();
            //Note: Form2 is left open  
        }

 
    }

}
