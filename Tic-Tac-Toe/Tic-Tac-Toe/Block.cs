using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe 
{
    class Block
    {
        public static int userinput;
        public static int round;
        public static int row;
        public static int col;
        public static char[] OXarr = { '1','2','3','4','5','6','7','8','9'};





        public static bool Valid(int userinput, int[,] Blockconfig)
        {

            if (userinput >= 1 && userinput <= 9)
            {
                userinput -= 1;
                row = userinput / 3;
                col = userinput % 3;
                if (Blockconfig[row, col] == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                return false;
            }

        }

        public static int[,] assign(int userinput, int[,] Blockconfig, int round)
        {
            if (round % 2 == 0)
            {
                Blockconfig[row, col] = 1;
            }
            else
            {
                Blockconfig[row, col] = 2;
            }


            int k;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   k = 3*i + j;
                    if (Blockconfig[i, j] == 1)
                    {

                        OXarr[k] = 'O';
                    }
                    else if (Blockconfig[i, j] == 2)
                    {
                        OXarr[k] = 'X';
                    }



                }
            }

            return Blockconfig;


        }



        public static void Show()
        {

          



            Console.WriteLine(
                        "\t" + OXarr[0] + "     ||" + OXarr[1] + "     ||"+ OXarr[2] + "\n"+ 
                        "\t====================\n" +
                      "\t" + OXarr[3] + "     ||" + OXarr[4] + "     ||" + OXarr[5] + "\n" +
                        "\t====================\n" +
                     "\t" + OXarr[6] + "     ||" + OXarr[7] + "     ||" + OXarr[8] + "\n" 


                    );

        }

        public static bool End(int[,] Blockconfig)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (Blockconfig[i, j] == 0)
                    {
                        return true;


                    }


                }
            }

            return false;

        }

    }

}
