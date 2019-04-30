/*
        normal turns

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    
    class AI
    {
        private char[] playField = new char[9];
        private bool playerFirst;
        private List<Button> buttonList;
        private char lastSign;
        private char playerSign = 'X';
        private char botSign = 'O';
        private char[,] playField2d = new char[3,3];
        private Char gameEnd = 'n';
        private bool fTurn = true;


        public AI(bool playerFirst, char[] playField, List<Button> buttonList)
        {
            this.playField = playField;
            this.playerFirst = playerFirst;
            this.buttonList = buttonList;

        }
        

        public void AITurn()
        {
            update2dArray();
            if(playField.All(char.IsDigit) == true)
            {
                botSign = 'X';
                playerSign = 'O';
                fTurn = false;
                firstMove();         
            }else
            {
                if(checkIfAbleToWin() != true)
                {
                    if(checkIfBlockNeeded() != true)
                    {
                        turn();
                    }
                }
            }           
        }

        private int randomChoice(int numb)
        {
            Random rnd = new Random();
            return rnd.Next(1, numb);
        }


        private void firstMove()
        {

            int choice = randomChoice(5);
            switch (choice)
            {
                case 1:
                    
                    AddSign b1 = new AddSign('n', buttonList[0]);
                    lastSign = b1.GetSign();
                    playField[0] = b1.GetSign();
                    break;
                case 2:
                    AddSign b3 = new AddSign('n', buttonList[2]);
                    lastSign = b3.GetSign();
                    playField[2] = b3.GetSign();
                    break;
                case 3:
                    AddSign b7 = new AddSign('n', buttonList[6]);
                    lastSign = b7.GetSign();
                    playField[6] = b7.GetSign();
                    break;
                case 4:
                    AddSign b9 = new AddSign('n', buttonList[8]);
                    lastSign = b9.GetSign();
                    playField[8] = b9.GetSign();
                    break;
            }
            
        }



        private bool checkIfAbleToWin()                
        {
            int counter = 0;
            int oCounter = 0, xCounter = 0;

                for(int i = 0; i < 3; i++)                  //HORIZONTAL LINES
                {
                    for(int j = 0; j < 3; j++)
                    {
                        counter++;
                        if (playField2d[i, j] == playerSign)
                            oCounter++;
                        if (playField2d[i, j] == botSign)
                            xCounter++;
                    }
                    if((xCounter == 2) && (oCounter == 0))
                    {
                        
                        for (int j = 0; j < 3; j++)
                        {
                            if((playField2d[i,j] != playerSign) && (playField2d[i,j] !=botSign) )
                            {
                               
                                AddSign b = new AddSign(playerSign, buttonList[counter - Math.Abs(3 - j)]);
                                lastSign = b.GetSign();

                                playField2d[i, j] = botSign;
                                updateArray();
                                gameEnd = b.checkWin(playField);
                                return true;
                            }
                        }
                    }
                    xCounter = 0;
                    oCounter = 0;
                }

                counter = 0;
                xCounter = 0;
                oCounter = 0;
                                                                    //vertical lines
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        counter++;
                        if (playField2d[j, i] == botSign)
                            xCounter++;
                        if (playField2d[j, i] == playerSign)
                            oCounter++;
                    }

                    if((xCounter == 2) && (oCounter == 0))
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if ((playField2d[j, i] != playerSign) && playField2d[j, i] != botSign)
                            {
                                AddSign b = new AddSign(playerSign, buttonList[3 * (j + 1) - Math.Abs(3 - i)]);
                                lastSign = b.GetSign();

                                playField2d[j, i] = botSign;
                                updateArray();

                                gameEnd = b.checkWin(playField);
                            }
                        }
                        return true;
                    }
                    xCounter = 0;
                    oCounter = 0;

                }

                counter = 0;
                xCounter = 0;
                oCounter = 0;

                for(int i = 0; i < 3; i++)              /*   1  5  9   buttons    */
                {
                    if (playField2d[i, i] == playerSign)
                        oCounter++;
                    if (playField2d[i, i] == botSign)
                        xCounter++;
                }

                if((xCounter == 2) && (oCounter == 0))
                {
                    for(int i = 0; i < 3; i++)
                    {
                        if(playField2d[i, i] != botSign)
                        {
                            AddSign b = new AddSign(playerSign, buttonList[(i+1) * 3 - Math.Abs(3 - i)]);
                            lastSign = b.GetSign();

                            playField2d[i, i] = botSign;
                            updateArray();

                            gameEnd = b.checkWin(playField);
                            return true;
                        }
                    }
                }
                xCounter = 0;
                oCounter = 0;
                counter = 0;

                for (int i = 0; i < 3; i++)              /*   3  5  7   buttons    */
                {
                    if (playField2d[i, 2-i] == playerSign)
                        oCounter++;
                    if (playField2d[i, 2-i] == botSign)
                        xCounter++;
                }
                if((xCounter == 2) && (oCounter == 0))
                {
                    for(int i = 0; i < 3; i++)
                    {
                        if(playField2d[i, 2-i] != botSign)
                        {
                            AddSign b = new AddSign(playerSign, buttonList[(i*3 + (3-i))-1]);
                            lastSign = b.GetSign();

                            playField2d[i, 2-i] = botSign;
                            updateArray();

                            gameEnd = b.checkWin(playField);
                            return true;
                        }
                    }
                }
            
            return false;
        }



        private bool checkIfBlockNeeded()             
        {
            
                int counter = 0;
                int oCounter = 0, xCounter = 0;
                for (int i = 0; i< 3; i++)                  //check horizontal lines
                {
                    
                    for (int j = 0; j < 3; j++)
                    {
                        counter++;
                        if (playField2d[i, j] == playerSign)
                            oCounter++;
                        if (playField2d[i, j] == botSign)
                            xCounter++;
                    }
                    if((oCounter == 2) && (xCounter == 0))
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            if (playField2d[i, j] != playerSign && playField2d[i, j] != botSign)
                            {
                                
                                AddSign b = new AddSign(playerSign, buttonList[counter - Math.Abs(3-j)]);
                                lastSign = b.GetSign();
                              
                                playField2d[i, j] = botSign;
                                updateArray();
                                gameEnd = b.checkWin(playField);                                    
                            }                             
                        }
                        return true;
                    }
                    oCounter = 0;
                    xCounter = 0;

                }





                /*PRADZIA*/
                counter = 0;

                oCounter = 0;           //check vertical lines
                xCounter = 0;

                for(int i =0; i < 3; i++)
                {

                    for(int j = 0; j < 3; j++)
                    {
                        counter++;
                        if (playField2d[j, i] == playerSign)
                            oCounter++;
                        if (playField2d[j, i] == botSign)
                            xCounter++;
                    }

                    if ((oCounter == 2) && (xCounter == 0))
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            if (playField2d[j, i] != playerSign)
                            {
                                AddSign b = new AddSign(playerSign, buttonList[3*(j+1)- Math.Abs(3- i) ]);
                                lastSign = b.GetSign();

                                playField2d[j, i] = botSign;
                                updateArray();
                                gameEnd = b.checkWin(playField);
                            }
                        }
                        return true;

                    }
                    xCounter = 0;
                    oCounter = 0;
                }

            /*PABAIGA*/

            counter = 0;
            xCounter = 0;
            oCounter = 0;

            digitCountInCharArray();
            if (digitCountInCharArray() == 6 && checkHalfCross())
            {
                int number = randomChoice(5);
                switch(number)
                {
                    case 1:
                        AddSign b2 = new AddSign(playerSign, buttonList[1]);
                        lastSign = b2.GetSign();
                        playField[1] = b2.GetSign();
                        return true;
                        break;
                    case 2:
                        AddSign b4 = new AddSign(playerSign, buttonList[3]);
                        lastSign = b4.GetSign();
                        playField[3] = b4.GetSign();
                        return true;
                        break;
                    case 3:
                        AddSign b6 = new AddSign(playerSign, buttonList[5]);
                        lastSign = b6.GetSign();
                        playField[5] = b6.GetSign();
                        return true;
                        break;
                    case 4:
                        AddSign b8 = new AddSign(playerSign, buttonList[7]);
                        lastSign = b8.GetSign();
                        playField[7] = b8.GetSign();
                        return true;
                        break;
                }
            }



            counter = 0;
            xCounter = 0;               //istrizai
            oCounter = 0;

            for (int i = 0; i < 3; i++)              /*   1  5  9   buttons    */
            {
                if (playField2d[i, i] == playerSign)
                    oCounter++;
                if (playField2d[i, i] == botSign)
                    xCounter++;
            }
            if(oCounter == 2 && xCounter == 0)
            {

                for(int i = 0; i < 3; i++)
                {
                    if(playField2d[i, i] != playerSign)
                    {
                        AddSign b = new AddSign(playerSign, buttonList[(i + 1) * 3 - Math.Abs(3 - i)]);
                        lastSign = b.GetSign();

                        playField2d[i, i] = botSign;
                        updateArray();

                        gameEnd = b.checkWin(playField);
                        return true;
                    }
                }

            }

            counter = 0;
            xCounter = 0;
            oCounter = 0;

            for (int i = 0; i < 3; i++)              /*   3  5  7   buttons    */
            {
                if (playField2d[i, 2 - i] == playerSign)
                    oCounter++;
                if (playField2d[i, 2 - i] == botSign)
                    xCounter++;
            }

            if ((xCounter == 0) && (oCounter == 2))
            {
                for (int i = 0; i < 3; i++)
                {
                    if (playField2d[i, 2 - i] != playerSign)
                    {
                        AddSign b = new AddSign(playerSign, buttonList[(i * 3 + (3 - i)) - 1]);
                        lastSign = b.GetSign();

                        playField2d[i, 2 - i] = botSign;
                        updateArray();

                        gameEnd = b.checkWin(playField);
                        return true;
                    }
                }
            }



            return false;
        }


    

        private void turn()         //plays in random corner
        {
            if(digitCountInCharArray() == 7 && checkQuarteCross())
            {
                int place = 0;
                for(int i = 0; i < 9; i++)
                {
                    if (!Char.IsDigit(playField[i]) && i != 4)
                        place = 10 - (i + 1) -1;
                }

                AddSign b = new AddSign(playerSign, buttonList[place]);
                lastSign = b.GetSign();
                playField[place] = b.GetSign();
                return;
            }

            if(fTurn == true && Char.IsDigit(playField[4]))
            {
                AddSign b5 = new AddSign(playerSign, buttonList[4]);
                lastSign = b5.GetSign();
                playField[4] = b5.GetSign();

                fTurn = false;
                return;
            }

            if((Char.IsDigit(playField[0])) || (Char.IsDigit(playField[2]))
                    || (Char.IsDigit(playField[6])) || (Char.IsDigit(playField[8])))
            {
                int choice = randomChoice(5);
                while(choice != -1)
                {
                    switch (choice)
                    {
                        case 1:
                            if (Char.IsDigit(playField[0]))
                            {
                                AddSign b1 = new AddSign(playerSign, buttonList[0]);
                                lastSign = b1.GetSign();
                                playField[0] = b1.GetSign();
                                choice = -1;
                            }
                            else                       
                                choice = randomChoice(5);                      
                            break;
                        case 2:
                            if (Char.IsDigit(playField[2]))
                            {
                               AddSign b3 = new AddSign(playerSign, buttonList[2]);
                                lastSign = b3.GetSign();
                                playField[2] = b3.GetSign();
                                choice = -1;
                            }
                            else
                                choice = randomChoice(5);

                            break;
                        case 3:
                            if(Char.IsDigit(playField[6]))
                            {
                              AddSign b7 = new AddSign(playerSign, buttonList[6]);
                                lastSign = b7.GetSign();
                                playField[6] = b7.GetSign();
                                choice = -1;
                            }
                            else
                                choice = randomChoice(5);

                            break;
                        case 4:
                            if (Char.IsDigit(playField[8]))
                            {
                                AddSign b9 = new AddSign(playerSign, buttonList[8]);
                                lastSign = b9.GetSign();
                                playField[8] = b9.GetSign();
                                choice = -1;
                            }
                            else
                                choice = randomChoice(5);

                            break;
                        default:
                            choice = randomChoice(5);
                            break;
                    }

                }
            }


        }




        private void update2dArray()
        {
            int counter = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    playField2d[i, j] = playField[counter];
                    counter++;
                }
            }
        }

        private void updateArray()
        {
            int counter = 0;
            for (int i = 0; i < 3; i++)
                for(int j = 0; j < 3; j++)
                {
                    playField[counter] = playField2d[i, j];
                    counter++;
                }
        }

        private bool checkHalfCross()
        {
            if ((playField2d[0, 0] == playerSign && playField2d[1, 1] == botSign && playField2d[2, 2] == playerSign)
                || (playField2d[0, 2] == playerSign && playField2d[1, 1] == botSign && playField2d[2, 0] == playerSign))
                return true;

            return false;
        }

        private bool checkQuarteCross()
        {
            if ((playField2d[0, 0] == botSign && playField2d[1, 1] == playerSign)
                || (playField2d[0, 2] == botSign && playField2d[1, 1] == playerSign)
                || (playField2d[2, 0] == botSign && playField2d[1, 1] == playerSign)
                || (playField2d[2, 2] == botSign && playField2d[1, 1] == playerSign))
                return true;

            return false;
        }



        private int digitCountInCharArray()
        {
            int counter = 0;
            for(int i = 0; i < 9; i++)
            {
                if (Char.IsDigit(playField[i]))
                    counter++;

            }
            return counter;
        }


        public char GetLastSign()
        {
            return lastSign;
        }

        public char GetGameEnd()
        {
            return gameEnd;
        }

    }
}
