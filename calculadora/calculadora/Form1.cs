using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.ClaseSuma obj = new Clases.ClaseSuma();
        Clases.ClaseResta obj2 = new Clases.ClaseResta();
        Clases.ClaseMultip obj3 = new Clases.ClaseMultip();
        Clases.ClaseDiv obj4 = new Clases.ClaseDiv();

        private void button15_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            double s;
            double r;
            double m;
            double d;

            switch(operador){
                case "+":
                    s = obj.Suma((primero),(segundo));
                    pantalla.Text = s.ToString();
                    break;
                case "-":
                    r = obj2.Resta((primero), (segundo));
                    pantalla.Text = r.ToString();
                    break;
                case "*":
                    m = obj3.Multipl((primero), (segundo));
                    pantalla.Text = m.ToString();
                    break;
                case "/":
                    d = obj4.Divide((primero), (segundo));
                    pantalla.Text = d.ToString();
                    break;
            }

        }

        private void borrar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }
    }
}
