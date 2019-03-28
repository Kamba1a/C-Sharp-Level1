using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ОЛЬГА НАЗАРОВА
//2. Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = numericUpDown.Value.ToString();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox.Text = numericUpDown.Value.ToString();
            numericUpDown.Focus();
        }
    }
}
