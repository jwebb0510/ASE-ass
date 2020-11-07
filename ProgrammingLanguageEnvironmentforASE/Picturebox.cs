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
   public class Picturebox
    {
        //data for pen and it's position
        //also the graphics box instance

      
        public Graphics g;
        public static Pen P1;
        public static int xPos = 0; // x position of pen
        public static int yPos = 0; // y position of pen
        public static int toX = 0; //what x position is changing to
        public static int toY = 0; //what y position is changing to
        public static int sizes = 0; //int used for square
        public static int sizec = 0; //int used for circle
        public static int sizerx = 0; //int used for rectangle x
        public static int sizery = 0; //int used for rectangle y
        //public static PointF sizet1 = new PointF(0, 0); //point used for triangle point 1
        //public static PointF sizet2 = new PointF(0, 0); //point used for triangle point 1
        //public static PointF sizet3 = new PointF(0, 0); //point used for triangle point 1
        public static int sizet1 = 0; //int used for triangle point 1
        public static int sizet2 = 0; //int used for triangle point 2
        public static int sizet3 = 0; //int used for triangle point 3
        //PointF[] points = { sizet1, sizet2, sizet3 };
        public static string colour = "black";



        /// <summary>
        /// sets position of pen to 0,0 and the colour to black
        /// </summary>
        /// <param name="g"></param>
        /// 


        public Picturebox(Graphics g)
        {
            this.g = g;
            //xPos = yPos = 0;
            P1 = new Pen(Color.Black, 1); //sets initial pen to black and 1 pixel wide size

        }


        public void DrawLine(int toX,int toY)
        {
            g.DrawLine(P1, xPos, yPos, toX, toY); //draw line
            xPos = toX;
            yPos = toY; //updates the pen position to where drawn to or end of line

        }

        public void DrawSquare(int sizes)
        {
            //yPos = xPos;
            g.DrawRectangle(P1, xPos-sizes/2, yPos-sizes/2, sizes, sizes); //draw a square
        }

        public void DrawRect(int sizerx, int sizery)
        {
            g.DrawRectangle(P1, xPos-sizerx/2, yPos-sizery/2, sizerx, sizery); //draw a rectangle
        }


        public void DrawCircle(int sizec)
        {
           g.DrawEllipse(P1, xPos-sizec/2, yPos-sizec/2, sizec, sizec); //draw a circle
        }

        public void DrawTriangle(int sizet1, int sizet2, int sizet3)
        {
            //g.DrawPolygon(Pen, points); //draw triangle
            g.DrawLine(P1, xPos, yPos, toX, toY);

        }


    }
}
