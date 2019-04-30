using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class AddSign
    {
        private char sign = 'n';
        private Button button;

        private readonly string crossPath = "E:\\Visual Studio projects\\WindowsFroms\\TicTacToe\\Cross.png";
        private readonly string circlePath = "E:\\Visual Studio projects\\WindowsFroms\\TicTacToe\\Circle.png";


        public AddSign(char lastSign, Button button)
        {
            sign = lastSign;
            this.button = button;
            ChangePicture();
        }


        public char GetSign()
        {
            return sign;
        }

      

        public void ChangePicture()
        {
            if((sign == 'n')||(sign == 'O'))
            {
                button.BackgroundImage = System.Drawing.Image.FromFile(crossPath);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                sign = 'X';
            }else if(sign == 'X')
            {
                button.BackgroundImage = System.Drawing.Image.FromFile(circlePath);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                sign = 'O';
            }
        }


       /* Returns X - if X wins
        * Returns O - if O wins
        * Returns D - if Draw
        * Returnt G - if the game is still going
       */
        public char checkWin(char[] playField)
        {
            if ((playField[0] == playField[1]) && (playField[1] == playField[2]))
                return playField[0];
            else if ((playField[3] == playField[4]) && (playField[4] == playField[5]))
                return playField[3];
            else if ((playField[6] == playField[7]) && (playField[7] == playField[8]))
                return playField[6];
            else if ((playField[0] == playField[3]) && (playField[3] == playField[6]))
                return playField[0];
            else if ((playField[1] == playField[4]) && (playField[4] == playField[7]))
                return playField[1];
            else if ((playField[2] == playField[5]) && (playField[5] == playField[8]))
                return playField[2];
            else if ((playField[0] == playField[4]) && (playField[4] == playField[8]))
                return playField[0];
            else if ((playField[2] == playField[4]) && (playField[4] == playField[6]))
                return playField[2];
            else if (playField.Any(char.IsDigit) == false)
                return 'D';
            else return 'G';

        }


    }
}
