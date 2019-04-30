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
    public partial class GameControl : UserControl
    {
        private bool playerFirst, vsAI = false;

        private char gameEnd;
        private bool endState = false;
        private char lastSign = 'n';
        private List<Button> buttonList = new List<Button>();
        private char[] playField = new char[9];
        AI ai;

        public char GetGameEnd()
        {
            return gameEnd;
        }
        
        public void SetLastSign(char lastSign)
        {
            this.lastSign = lastSign;
        }


        public GameControl()
        {
            InitializeComponent();
            InitializeCharArray();
        }

        public GameControl(bool playerFirst)
        {
            InitializeComponent();
            InitializeCharArray();
            this.playerFirst = playerFirst;
            vsAI = true;
            buttonList.Add(button1);
            buttonList.Add(button2);
            buttonList.Add(button3);
            buttonList.Add(button4);
            buttonList.Add(button5);
            buttonList.Add(button6);
            buttonList.Add(button7);
            buttonList.Add(button8);
            buttonList.Add(button9);

            ai = new AI(playerFirst, playField, buttonList);

            if(playerFirst == false)
            {
                ai.AITurn();
                lastSign = ai.GetLastSign();
            }
            

        }


        private void button6_Click(object sender, EventArgs e)
        {
            if((button6.BackgroundImage == null) && (endState == false) )
            {
               
                AddSign b6 = new AddSign(lastSign, button6);
                lastSign = b6.GetSign();
                playField[5] = b6.GetSign();

                gameEnd = b6.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();
                
                if(vsAI == true)
                {
                    ai.AITurn();            
                    lastSign = ai.GetLastSign();


                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                }           
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((button1.BackgroundImage == null) && (endState == false))
            {
                AddSign b1 = new AddSign(lastSign, button1);
                lastSign = b1.GetSign();
                playField[0] = b1.GetSign();

                gameEnd = b1.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();
                if(vsAI == true)
                {
                    ai.AITurn();
                    lastSign = ai.GetLastSign();

                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                }

            }
            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if ((button2.BackgroundImage == null) && (endState == false))
            {
                AddSign b2 = new AddSign(lastSign, button2);
                lastSign = b2.GetSign();
                playField[1] = b2.GetSign();

                gameEnd = b2.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();

                if (vsAI == true)
                {
                    ai.AITurn();
                    lastSign = ai.GetLastSign();

                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            if ((button3.BackgroundImage == null) && (endState == false))
            {
                AddSign b3 = new AddSign(lastSign, button3);
                lastSign = b3.GetSign();
                playField[2] = b3.GetSign();

                gameEnd = b3.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();

                if (vsAI == true)
                {
                    ai.AITurn();
                    lastSign = ai.GetLastSign();


                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                }
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {

            
                if ((button4.BackgroundImage == null) && (endState == false))
            {
                AddSign b4 = new AddSign(lastSign, button4);
                lastSign = b4.GetSign();
                playField[3] = b4.GetSign();

                gameEnd = b4.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();


                if (vsAI == true)
                {
                    ai.AITurn();
                    lastSign = ai.GetLastSign();

                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                }

            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if ((button5.BackgroundImage == null) && (endState == false))
            {
                AddSign b5 = new AddSign(lastSign, button5);
                lastSign = b5.GetSign();
                playField[4] = b5.GetSign();

                gameEnd = b5.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();

                if (vsAI == true)
                {
                    ai.AITurn();
                    lastSign = ai.GetLastSign();

                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                }
            }




        }

        private void button7_Click(object sender, EventArgs e)
        {

            
            if ((button7.BackgroundImage == null) && (endState == false))
            {
                AddSign b7 = new AddSign(lastSign, button7);
                lastSign = b7.GetSign();
                playField[6] = b7.GetSign();

                gameEnd = b7.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();

                if (vsAI == true)
                {
                    ai.AITurn();
                    lastSign = ai.GetLastSign();

                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                }
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if ((button8.BackgroundImage == null) && (endState == false))
            {
                AddSign b8 = new AddSign(lastSign, button8);
                lastSign = b8.GetSign();
                playField[7] = b8.GetSign();

                gameEnd = b8.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();

                if (vsAI == true)
                {
                    ai.AITurn();
                    lastSign = ai.GetLastSign();

                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                }
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if ((button9.BackgroundImage == null) && endState == false)
            {
                AddSign b9 = new AddSign(lastSign, button9);
                lastSign = b9.GetSign();
                playField[8] = b9.GetSign();

                gameEnd = b9.checkWin(playField);
                if ((gameEnd == 'X') || (gameEnd == 'O') || (gameEnd == 'D'))
                    EndOfGame();

                if (vsAI == true)
                {
                    ai.AITurn();
                    lastSign = ai.GetLastSign();

                    if ((ai.GetGameEnd() == 'X') || (ai.GetGameEnd() == 'O') || (ai.GetGameEnd() == 'D'))
                    {
                        gameEnd = ai.GetGameEnd();
                        EndOfGame();

                    }
                    
                } 
            }


        }

        private void EndOfGame()
        {
            endState = true;
            if ((gameEnd == 'X') || (gameEnd == 'O'))
            {
                MessageBox.Show("PLAYER " + gameEnd.ToString() + " WON THE GAME");
                
            }     
            else MessageBox.Show("DRAW");
        }

        private void InitializeCharArray()
        {
            for(int i = 0; i < 9; i++)
            {
                playField[i] = '1';
                playField[i] = (Char)(Convert.ToUInt16(playField[i]) + i);
            }
        }

    }
}
