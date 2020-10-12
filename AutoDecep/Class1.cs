using System;
namespace AutoDecep
{
	public class Class1
    {
        public Class1()
        {   
        }

        public void mouseEnter(object sender)
        {
            PictureBox mouseEnter = (PictureBox)sender;
            mouseEnter.Image = (Bitmap)Resources.Altobot;
        }
        public int mouseDosomthing()
        {
            return(1);
        }
    }
}