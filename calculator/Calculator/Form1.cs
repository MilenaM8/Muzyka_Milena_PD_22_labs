using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Caclulator calc = new Caclulator();
        public Form1()
        {
            InitializeComponent();
            calc.CreateNumberField(this);
            calc.Display(calc.buttonsList, this);
            this.Size = new Size(366, 367);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Text = "TheBestCalculatorEver";
        }

        
    }
}
