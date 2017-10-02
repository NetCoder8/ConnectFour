using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Program2
{
    public class Token
    {
        private PictureBox theToken = new PictureBox();
        
        public Token() { }

        public Token(string teamName)
        {

            string name = teamName;

            if (name == "red")
            {

                TheToken.BackgroundImage = Resource1.SingleRedToken;
                TheToken.Width = 110;
                TheToken.Height = 110;
                TheToken.Tag = "red";

            }
            else if (name == "black")
            {

                TheToken.BackgroundImage = Resource1.SingleBlackToken;
                TheToken.Width = 110;
                TheToken.Height = 110;
                TheToken.Tag = "black";
            }
           
        }

        public PictureBox TheToken
        {
            get { return theToken; }
            set { theToken = value; }
        }
       


       
    }
}