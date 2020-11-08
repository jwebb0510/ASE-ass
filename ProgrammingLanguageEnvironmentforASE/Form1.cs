using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgrammingLanguageEnvironmentforASE
{

    public partial class Form1 : Form
    {

       // public int canvassizex = 692;
       // public int canvassizey = 855;

        Bitmap OutputBitmap = new Bitmap(629,855);
        Picturebox MyOutputWindow;
        Picturebox xPos;
        Picturebox yPos;
        Picturebox toY;
        Picturebox toX;
        Picturebox g;
        //Picturebox P1;
        public static int positionx;
        public static int positiony;
        public static int positionz;
        public static int positionshape;
        
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
            //MyOutputWindow = Invalidate;
            Refresh();
            Console.WriteLine("CLEAR CLICKED");

        }

        private void buttonRun_Click(object sender, EventArgs e) //what happens when run is clicked - main part of code
        {
            Console.WriteLine("RUN PROGRAM ");
            int lineno = 0;
            string Commandc1 = ProgramCommandWindow.Text.Trim().ToLower();
            //string[] consolec1 = Command;
            //while ((ProgramCommandWindow = Commandc1.ReadLine()) != "end")
            StringReader strReader = new StringReader(Commandc1);

            while(true)
            {
                Commandc1 = strReader.ReadLine(); //reads line of text
                while (Commandc1 != null)
                {
                    //Commandc1 = strReader.ReadLine();
                    string[] Commandc = Commandc1.Split(' ', ',');
                    while (Commandc[lineno].Equals("moveto") == true)
                    {
                        if (!Int32.TryParse(Commandc[lineno + 1], out positionx)) ; //translate string to int
                        if (!Int32.TryParse(Commandc[lineno + 2], out positiony)) ;

                        Picturebox.xPos = positionx;
                        Picturebox.yPos = positiony;
                        Commandc1 = strReader.ReadLine();
                        Refresh();//refresh display
                        lineno++;                        
                    }
                     while (Commandc[0].Equals("line") == true) //what happens if draw line command is used
                    {
                        if (!Int32.TryParse(Commandc[lineno + 1], out positionx)) ; //translate string to int
                        if (!Int32.TryParse(Commandc[lineno + 2], out positiony)) ;

                        Picturebox.toX = positionx;
                        Picturebox.toY = positiony;
                        MyOutputWindow.DrawLine(Picturebox.toX, Picturebox.toY);
                        Console.WriteLine("COMMAND - DRAW LINE");
                        Commandc1 = strReader.ReadLine();
                        Refresh();//refresh display
                        
                        lineno++;
                    }
                    while (Commandc[0].Equals("square") == true) //what happens if draw square command is used
                    {
                        if (!Int32.TryParse(Commandc[lineno + 1], out positionshape)) ; //translate string to int 

                        Picturebox.sizes = positionshape;
                        MyOutputWindow.DrawSquare(Picturebox.sizes);
                        Console.WriteLine("COMMAND - DRAW SQUARE");
                        Commandc1 = strReader.ReadLine();
                        Refresh();//refresh display

                        lineno++;

                    }
                          
                    break;
                }
                //else while (Commandc1 == "end")
                //{
                 //   break;
                //}

                Refresh();//refresh display
                break;
            }


            
                
            


        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Picturebox.xPos = 0;
            Picturebox.yPos = 0;
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
            //Console.WriteLine("Key Down"); <- Prints in console when a key is pressed (annoying)
            
            string[] Command4 = Command.Split(' ', ',');
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("ENTER KEY PRESSED");

                if (Command4[0].Equals("moveto") == true) //what happens if moveto command is used
                {
                    if (!Int32.TryParse(Command4[1], out positionx)) ; //translate string to int
                    if (!Int32.TryParse(Command4[2], out positiony)) ;

                    Picturebox.xPos = positionx;
                    Picturebox.yPos = positiony;
                }

                else if (Command4[0].Equals("line") == true) //what happens if draw line command is used
                {
                    if (!Int32.TryParse(Command4[1], out positionx)) ; //translate string to int
                    if (!Int32.TryParse(Command4[2], out positiony)) ;

                    Picturebox.toX = positionx;
                    Picturebox.toY = positiony;
                    MyOutputWindow.DrawLine(Picturebox.toX, Picturebox.toY);
                    Console.WriteLine("COMMAND - DRAW LINE");
                }
                else if (Command4[0].Equals("square") == true) //what happens if draw square command is used
                {
                    if (!Int32.TryParse(Command4[1], out positionshape)) ; //translate string to int 

                    Picturebox.sizes = positionshape;
                    MyOutputWindow.DrawSquare(Picturebox.sizes);
                    Console.WriteLine("COMMAND - DRAW SQUARE");
                }
                else if (Command4[0].Equals("rect") == true) //what happens if draw rectangle command is used
                {
                    if (!Int32.TryParse(Command4[1], out positionx)) ; //translate string to int
                    if (!Int32.TryParse(Command4[2], out positiony)) ;

                    Picturebox.sizerx = positionx;
                    Picturebox.sizery = positiony;
                    MyOutputWindow.DrawRect(Picturebox.sizerx, Picturebox.sizery);
                    Console.WriteLine("COMMAND - DRAW RECTANGLE");
                }
                else if (Command4[0].Equals("circle") == true)
                {
                    if (!Int32.TryParse(Command4[1], out positionx)) ;

                    Picturebox.sizec = positionx;
                    MyOutputWindow.DrawCircle(Picturebox.sizec);

                    Console.WriteLine("COMMAND - DRAW CIRCLE");
                }
                else if (Command4[0].Equals("triangle") == true)
                {
                    if (!Int32.TryParse(Command4[1], out positionx)) ; //translate string to int
                    if (!Int32.TryParse(Command4[2], out positiony)) ;
                    //if (!Int32.TryParse(Command4[3], out positionz)) ;



                    MyOutputWindow.DrawTriangle(Picturebox.sizet1, Picturebox.sizet2, Picturebox.sizet3);
                    //Picturebox.sizet1 = 


                }
                else if (Command4[0].Equals("colour") == true) //changes colour of the pen
                {
                    if (Command4[1].Equals("red") == true) { 
                        Picturebox.P1.Color = Color.Red; }
                else if (Command4[1].Equals("blue") == true) {
                    Picturebox.P1.Color = Color.Blue; }
                else if (Command4[1].Equals("black") == true) {
                    Picturebox.P1.Color = Color.Black; }
                else if (Command4[1].Equals("green") == true) {
                    Picturebox.P1.Color = Color.Green; }
                else if (Command4[1].Equals("yellow") == true) {
                    Picturebox.P1.Color = Color.Yellow; }


                }
                
                
                commandline.Text = ""; //clears text from command line
                Console.WriteLine("CONSOLE CLEARED");
                Refresh();//refresh display

              
            }

            
        }
        private void ProgramCommandWindow_KeyDown(object sender, KeyEventArgs e)
        {/*
            string Command2 = ProgramCommandWindow.Text.Trim().ToLower();
            //Console.WriteLine("Key Down"); <- Prints in console when a key is pressed (annoying)
            //int positionx1;
            //int positiony1;
            string[] Command3 = Command2.Split(' ', ',');

            //this.xPos = positionx;


            //string[] Command4 = Command3.Split(',');
            if (e.KeyCode == Keys.Enter)
            {
                if (Command3[0].Equals("moveto") == true) //what happens if moveto command is used
                {
                    if (!Int32.TryParse(Command3[1], out positionx)) ; //translate string to int
                    if (!Int32.TryParse(Command3[2], out positiony)) ;

                    Picturebox.xPos = positionx;
                    Picturebox.yPos = positiony;
                }

                else if (Command3[0].Equals("line") == true) //what happens if draw line command is used
                {
                    if (!Int32.TryParse(Command3[1], out positionx)) ; //translate string to int
                    if (!Int32.TryParse(Command3[2], out positiony)) ;

                    Picturebox.toX = positionx;
                    Picturebox.toY = positiony;
                    MyOutputWindow.DrawLine(Picturebox.toX, Picturebox.toY);
                    Console.WriteLine("COMMAND - DRAW LINE");
                }
                else if (Command3[0].Equals("square") == true) //what happens if draw square command is used
                {
                    if (!Int32.TryParse(Command3[1], out positionshape)) ; //translate string to int 

                    Picturebox.sizes = positionshape;
                    MyOutputWindow.DrawSquare(Picturebox.sizes);
                    Console.WriteLine("COMMAND - DRAW SQUARE");
                }
                else if (Command3[0].Equals("rect") == true) //what happens if draw rectangle command is used
                {
                    if (!Int32.TryParse(Command3[1], out positionx)) ; //translate string to int
                    if (!Int32.TryParse(Command3[2], out positiony)) ;

                    Picturebox.sizerx = positionx;
                    Picturebox.sizery = positiony;
                    MyOutputWindow.DrawRect(Picturebox.sizerx, Picturebox.sizery);
                    Console.WriteLine("COMMAND - DRAW RECTANGLE");
                }
                else if (Command3[0].Equals("circle") == true)
                {
                    if (!Int32.TryParse(Command3[1], out positionx)) ;

                    Picturebox.sizec = positionx;
                    MyOutputWindow.DrawCircle(Picturebox.sizec);

                    Console.WriteLine("COMMAND - DRAW CIRCLE");
                }

                ProgramCommandWindow.Text = ""; //clears text from command line
                Console.WriteLine("CONSOLE CLEARED");
                Refresh();//refresh display
            }*/
            
        }


            //output box on form
            private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //gets the context of the graphics form
            g.DrawImageUnscaled(OutputBitmap, 0, 0); //puts the bitmap that has been edited onto the form itself


           
        }

        
    }
}
