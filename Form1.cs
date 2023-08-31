using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr1(object sender, EventArgs e)
        {
            int X = Enemigo1.Location.X;
            int Y = Enemigo1.Location.Y;
            X += 10;
            

            Enemigo1.Location = new Point(X, Y);

            if (true)
            {
                int x = Enemigo1.Location.X;
                if (x >= 660)
                {
                    x -= 660;
                    Y +=50;
                    Enemigo1.Location = new Point(x, Y);
                }

                if (Y >= 354)
                {
                    Y -= 354;
                    Enemigo3.Location = new Point(x, Y);
                }

            }
            
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            int X = Enemigo2.Location.X;
            int Y = Enemigo2.Location.Y;
            X += 10;

            Enemigo2.Location = new Point(X, Y);

            if (true)
            {
                int x = Enemigo2.Location.X;
                if (x >= 660)
                {
                    x -= 660;
                    Y += 50;
                    Enemigo2.Location = new Point(x, Y);
                }

                if (Y >= 354)
                {
                    Y -= 354;
                    Enemigo3.Location = new Point(x, Y);
                }
            }
        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            int X = Enemigo3.Location.X;
            int Y = Enemigo3.Location.Y;
            X += 10;

            Enemigo3.Location = new Point(X, Y);

            if (true)
            {
                int x = Enemigo3.Location.X;
                if (x >= 660)
                {
                    x -= 660;
                    Y += 50;
                    Enemigo3.Location = new Point(x, Y);
                }

                if (Y >= 354)
                {
                    Y -= 354;
                    Enemigo3.Location = new Point(x, Y);
                }

            }
        }
    }
}

