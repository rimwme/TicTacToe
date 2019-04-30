using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameWindowControl : UserControl
    {
        private bool withAI = false;
        private bool playerFirst;
        
        public GameWindowControl(string head)
        {
            InitializeComponent();
            playGroundPanel.Controls.Add(new GameControl());
            headerLable.Text = head;
        }

        public GameWindowControl(string head, bool playerFirst)
        {
            this.playerFirst = playerFirst;
            InitializeComponent();
            playGroundPanel.Controls.Add(new GameControl(playerFirst));
            headerLable.Text = head;
            withAI = true;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            if(withAI == true)
            {
                playGroundPanel.Controls.Clear();
                playGroundPanel.Controls.Add(new GameControl(playerFirst));
            }
            else
            {

                playGroundPanel.Controls.Clear();
                playGroundPanel.Controls.Add(new GameControl());

            }

        }


    }
}
