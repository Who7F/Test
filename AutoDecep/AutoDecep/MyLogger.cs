using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoDecep.Properties;

namespace AutoDecep
{
    class MyLogger
    {
        public void DoStuff(object sender, string logPring)
        {
            TextBox TextLogBox = (TextBox)sender;
            TextLogBox.Text = TextLogBox.Text.ToString() + Environment.NewLine + logPring;
            TextLogBox.SelectionLength = TextLogBox.TextLength;
            TextLogBox.ScrollToCaret();
        }
    }
    
}
