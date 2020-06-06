using NewProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeomCalculator
{
    public partial class Form1 : Form
    {
        Dictionary<int, int> figureTypes;
        // index <-> figure type

        public Form1()
        {
            InitializeComponent();

            figureTypes = new Dictionary<int, int>();
            figureTypes.Add(0, 0); // circle
            figureTypes.Add(1, 1); // triangle
            figureTypes.Add(2, 2); // square
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = (comboBox1.SelectedIndex == 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void coordinatesX_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void coordinatesY_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void coordinatesX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double x = double.Parse(coordinatesX.Text);
            double y = double.Parse(coordinatesY.Text);
            double a = double.Parse(baseBox.Text);
            double b = double.Parse(heightBox.Text);

            if (!figureTypes.ContainsKey(comboBox1.SelectedIndex))
            {
                MessageBox.Show("Выберете тип фигуры");
                
                return;
            }

            int type = figureTypes[comboBox1.SelectedIndex];
            
            
            Figure figure = new Figure();
            figure.init(type, a, b, x, y);

            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Вычисления в процессе");

                return;
            }

            backgroundWorker1.RunWorkerAsync(figure);
        }

        private void coordinatesY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Figure figure = (Figure)e.Argument;

            figure.doHeavyComputation();

            e.Result = figure;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            baseBox.Clear();
            heightBox.Clear();
            coordinatesX.Clear();
            coordinatesY.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Figure figure = (Figure)e.Result;

            textBox3.Text = figure.getP().ToString();
            textBox4.Text = figure.getS().ToString();
            textBox5.Text = "(" + figure.getX().ToString() + ", " + figure.getY().ToString() + ")";

            if (figure.getType() == 0)
            {
                textBox6.Text = figure.getR().ToString();
            }
        }
    }
}
