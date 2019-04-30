using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class ChoiceForm : Form
    {
        private bool plFirst;

        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plFirst = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plFirst = false;
            this.Close();
        }

        public bool GetPlFirst()
        {
            return plFirst;
        }

    }
}
