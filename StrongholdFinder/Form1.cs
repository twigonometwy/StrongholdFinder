using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongholdFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double z1, z2, x1, x2, a1, a2, distance, displacement, displacementAngle, angleA, angleB, angleC, xCoordinate, zCoordinate;
        private void calculateButton_Click(object sender, EventArgs e)
        {
            z1 = Convert.ToDouble(z1input.Text);
            z2 = Convert.ToDouble(z2input.Text);
            x1 = Convert.ToDouble(x1input.Text);
            x2 = Convert.ToDouble(x2input.Text);
            a1 = Convert.ToDouble(a1input.Text);
            a2 = Convert.ToDouble(a2input.Text);

            displacement = Math.Sqrt((z2 - z1) * (z2 - z1) + (x2 - x1) * (x2 - x1));
            displacementAngle = (Math.Atan((x2 - x1) / (z2 - z1)))*(180/Math.PI);

            if (a1 < 0)
            {
                a1 = 360 + a1;
            }
            if (a2 < 0)
            {
                a2 = 360 + a2;
            }

            if (((x2 - x1) < 0 && (z2 - z1) < 0) || ((x2 - x1) > 0 && (z2 - z1) < 0))
            {
                displacementAngle = 180 - displacementAngle;

                angleA = a1 - displacementAngle;
                angleB = 360 - (a2 + 180 - displacementAngle);
                angleC = 180 - angleB - angleA;

                distance = (displacement * Math.Sin(angleA * (Math.PI / 180)) / Math.Sin(angleC * (Math.PI / 180)));
            }
            else if (((x2 - x1) < 0 && (z2 - z1) > 0) || ((x2 - x1) > 0 && (z2 - z1) > 0))
            {
                displacementAngle = 180 - displacementAngle;

                angleA = a1 - displacementAngle;
                angleB = 360 - (a2 + 180 - displacementAngle);
                angleC = 180 - angleB - angleA;

                distance = -(displacement * Math.Sin(angleA * (Math.PI / 180)) / Math.Sin(angleC * (Math.PI / 180)));
            }
         
            answerLabel.Text = "the stronghold is " + Math.Round(distance) + " blocks away";

            xCoordinate = x2 - (distance * Math.Cos((a2 - 90) * (Math.PI / 180)));
            zCoordinate = z2 - (distance * Math.Sin((a2 - 90) * (Math.PI / 180)));

            coordinateLabel.Text = "the coordinates of the strong hold are: " + Math.Round(xCoordinate) + ", ~ , " + Math.Round(zCoordinate);
        }
    }
}
