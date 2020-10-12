using System.Drawing;
using System.Windows.Forms;
using AutoDecep.Properties;

//All mouse events are in this class
namespace AutoDecep
{
    class MyMouseEvents
    {
        public void MouseEnter(object sender, string playerTurn)//sender is a PictureBox and playerTurn is label1.Tag.toString()
        {
            PictureBox mouseAction = (PictureBox)sender;

            switch (playerTurn) //Sets a hover image depending on player turn
            {
                case "auto":
                    mouseAction.Image = (Bitmap)Resources.autoHover;
                    break;

                case "decep":
                    mouseAction.Image = (Bitmap)Resources.decepHover;
                    break;

                default:
                    MessageBox.Show("Error with MouseEnter");//it was more vulgar language
                    break;
            }
        }
        public void MouseLeave(object sender)
        {
            
            PictureBox mouseAction = (PictureBox)sender;
            mouseAction.Image = (Bitmap)Resources.autodecep; //reset image to default  

        }
        public void MouseClick(object sender, string playerTurn)//sender is a PictureBox and playerTurn is label1.Tag.toString()
        {
            PictureBox mouseAction = (PictureBox)sender;

            switch (playerTurn) //Sets a click image depending on player turn
            {
                case "auto":
                    mouseAction.Image = (Bitmap)Resources.autobots;
                    mouseAction.Tag = "auto";
                    break;

                case "decep":
                    mouseAction.Image = (Bitmap)Resources.decepticon;
                    mouseAction.Tag = "decep";
                    break;

                default:
                    MessageBox.Show("Error with mouseAction");
                    break;
            }
            
        }

    }
}
