using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _13.Turtle_Graphics
{
    public partial class Turtle : Form
    {
        public Turtle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Rotate(30);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(120);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(120);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            // Assign a delay to visualize the drawing process
            Nakov.TurtleGraphics.Turtle.Delay = 200;

            // Draw a equilateral triangle
            Nakov.TurtleGraphics.Turtle.Rotate(30);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(120);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(120);
            Nakov.TurtleGraphics.Turtle.Forward(200);

            // Draw a line in the triangle
            Nakov.TurtleGraphics.Turtle.Rotate(-30);
            Nakov.TurtleGraphics.Turtle.PenUp();
            Nakov.TurtleGraphics.Turtle.Backward(50);
            Nakov.TurtleGraphics.Turtle.PenDown();
            Nakov.TurtleGraphics.Turtle.Backward(100);
            Nakov.TurtleGraphics.Turtle.PenUp();
            Nakov.TurtleGraphics.Turtle.Forward(150);
            Nakov.TurtleGraphics.Turtle.PenDown();
            Nakov.TurtleGraphics.Turtle.Rotate(30);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Nakov.TurtleGraphics.Turtle.ShowTurtle)
            {
                Nakov.TurtleGraphics.Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Nakov.TurtleGraphics.Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(100);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(100);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(100);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(100);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(100);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(100);
            Nakov.TurtleGraphics.Turtle.Delay = 200;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 200;
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(144);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(144);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(144);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(144);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(144);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 300;
            Nakov.TurtleGraphics.Turtle.Forward(20);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(30);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(40);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(50);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(60);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(70);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(80);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(90);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(100);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(110);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(120);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(130);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(140);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(150);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(160);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(170);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(180);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(190);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(210);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(220);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(230);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(240);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(250);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(260);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
            Nakov.TurtleGraphics.Turtle.Forward(270);
            Nakov.TurtleGraphics.Turtle.Rotate(60);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Delay = 200;
            for (int i = 0; i < 36; i++)
            {
                Nakov.TurtleGraphics.Turtle.Forward(250);
                Nakov.TurtleGraphics.Turtle.Rotate(170);
            }
        }
    }
}
