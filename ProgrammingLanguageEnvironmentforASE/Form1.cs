using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingLanguageEnvironmentforASE
{

    public partial class Form1 : Form
    {

        //public int canvassizex = 692;
       // public int canvassizey = 855;

        Bitmap OutputBitmap = new Bitmap(629,855);
        Picturebox MyOutputWindow;
        public Form1()
        {
            InitializeComponent();
            MyOutputWindow= new Picturebox(Graphics.FromImage(OutputBitmap));
        }

        /// <summary>
        /// Initializes what happens when buttons are clicked
        /// </summary>

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLEAR CLICKED");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("RUN CLICKED");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Console.WriteLine("RESET CLICKED");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SAVE CLICKED");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LOAD CLICKED");
        }


        /// <summary>
        /// Initializes what happens when keys are pressed in the command line textbox
        /// </summary>
     
        private void commandline_KeyDown(object sender, KeyEventArgs e)
        {
            string Command = commandline.Text.Trim().ToLower();
            Console.WriteLine("Key Down");
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("ENTER KEY PRESSED");

                if (Command.Equals("Line") == true)
                {
                    MyOutputWindow.DrawLine(160, 120);
                    Console.WriteLine("COMMAND - DRAW LINE");
                }
                else if (Command.Equals("Square") == true);
                {
                    MyOutputWindow.DrawSquare(50);
                    Console.WriteLine("COMMAND - DRAW SQUARE");
                }
                commandline.Text = ""; //clears text from command line
                Console.WriteLine("CONSOLE CLEARED");
                Refresh();
            }

            
        }


        //output box on form
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //gets the context of the graphics form
            g.DrawImageUnscaled(OutputBitmap, 0, 0); //puts the bitmap that has been edited onto the form itself
        }
    }
}
