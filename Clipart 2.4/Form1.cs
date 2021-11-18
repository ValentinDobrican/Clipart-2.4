using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipart_2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        interface IArea
        {
            double BeräknaArea();
        }

        class Figur
        {
            public double bredd;
            public double höjd;

            public Figur(double bredd, double höjd)
            {
                this.bredd = bredd;
                this.höjd = höjd;
            }
        }

        class Triangel : Figur, IArea
        {
            public Triangel(double bredd, double höjd) : base(bredd, höjd) { }
            public double BeräknaArea()
            {
                return (bredd * höjd) / 2;
            }
            public override string ToString()
            {
                return "Triangel: " + bredd + "x" + höjd;
            }
        }

        class Cirkel : Figur, IArea
        {
            public Cirkel(double bredd, double höjd) : base(bredd, höjd) { }
            public double BeräknaArea()
            {
                return Math.Pow((bredd / 2), 2) * Math.PI;
            }
            public override string ToString()
            {
                return "Cirkel: " + bredd + "x" + bredd;
            }
        }

        class Linje : Figur
        {
            public Linje(double bredd, double höjd) : base(bredd, höjd) { }
            public override string ToString()
            {
                return "Linje: " + bredd + "x" + höjd;
            }
        }

        private void btnTriangel_Click(object sender, EventArgs e)
        {
            try
            {
                Triangel nyTriangel = new Triangel(double.Parse(tbxBredd.Text), double.Parse(tbxHöjd.Text));
                lbxFigur.Items.Add(nyTriangel);
            }
            catch (FormatException)
            {
                MessageBox.Show("Fel värden.");
            }
        }

        private void btnCirkel_Click(object sender, EventArgs e)
        {
            try
            {
                Cirkel nyCirkel = new Cirkel(double.Parse(tbxBredd.Text), double.Parse(tbxHöjd.Text));
                lbxFigur.Items.Add(nyCirkel);
            }
            catch (FormatException)
            {
                MessageBox.Show("Fel värden.");
            }
        }

        private void btnLinje_Click(object sender, EventArgs e)
        {
            try
            {
                Linje nyLinje = new Linje(double.Parse(tbxBredd.Text), double.Parse(tbxHöjd.Text));
                lbxFigur.Items.Add(nyLinje);
            }
            catch (FormatException)
            {
                MessageBox.Show("Fel inmatade värden.");
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double summa = 0;
            foreach (Figur f in lbxFigur.Items)
            {
                if (f is Triangel)
                {
                    summa += (f as Triangel).BeräknaArea();
                }
                else if (f is Cirkel)
                {
                    summa += (f as Cirkel).BeräknaArea();
                }
            }
            tbxArea.Text = Convert.ToString(Math.Round(summa, 2) + " cm²");
        }
    }
}

