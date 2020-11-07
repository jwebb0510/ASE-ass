using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgrammingLanguageEnvironmentforASE
///<summary>
///Holds information in regard to what is shown on form/picturebox and what is drawn
///</summary>

{
    class Picturebox
    {
        //data for pen and it's position
        //also the graphics box instance

        Graphics g;
        Pen Pen;
        int xPos, yPos; // position of pen
        


        /// <summary>
        /// sets position of pen to 0,0 and the colour to black
        /// </summary>
        /// <param name="g"></param>

        public Picturebox(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1); //sets initial pen to black and 1 pixel wide size

        }


        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(Pen, xPos, yPos, toX, toY); //draw line
            xPos = toX;
            yPos = toY; //updates the pen position to where drawn to or end of line

        }

        public void DrawSquare(int sizes)
        {
            g.DrawRectangle(Pen, xPos, yPos, xPos + sizes, yPos + sizes); //draw a square
        }

        public void DrawCircle(int sizec)
        {
            //g.DrawPie(Pen, xPos, yPos, xPos + sizec, yPos + sizec); //draw circle <- fix
        }


    }
}
