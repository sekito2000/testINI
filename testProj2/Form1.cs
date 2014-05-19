using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testProj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoundArray a = new BoundArray(1,9);
            for (int i = 1; i <= 9; ++i)
                a[i] = i;

            for (int i = 1; i <= 9; ++i)
                Console.Write("a[{0}] = {1}\n", i, a[i]);
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            Matrix a = new Matrix(4,4);
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    a[i, j] = (i + 1) * (j + 3);
        }
    }
}
