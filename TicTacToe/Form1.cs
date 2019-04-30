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
    public partial class Form1 : Form
    {
        private bool playerStartsFirst;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gamePanel.Controls.Clear();
            gamePanel.Controls.Add(new GameWindowControl("Player vs Player"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoiceForm choiceForm = new ChoiceForm();
            choiceForm.ShowDialog();
            playerStartsFirst = choiceForm.GetPlFirst();

            gamePanel.Controls.Clear();
            gamePanel.Controls.Add(new GameWindowControl("Player vs AI", playerStartsFirst));
            

        }
    }
}
