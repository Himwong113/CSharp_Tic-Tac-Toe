

using System.Data;
using System.Threading.Channels;
using Tic_Tac_Toe;

int[,] Blockconfig = new int[3, 3];
int round = 0;
int userinput;

while (Block.End(Blockconfig))
{
    Block.Show();
    Console.WriteLine("Round :"+(round+1).ToString());
   
        Console.WriteLine("User "+ Convert.ToString(round%2+1)+" ,please select cell");
        
    
   
    userinput = Convert.ToInt32(Console.ReadLine());
    Block.userinput = userinput;

    if (Block.Valid(userinput, Blockconfig))
    {
        Blockconfig = Block.assign(userinput, Blockconfig,round);


      


    }


    else
    {
        Console.WriteLine("Not valid! Please check input!");
        Console.ReadLine();
        round--;
    }

    

    
    Console.Clear();
    round++;
}



Block.Show();
int buff=0;
int buff2 = 0;
int buff3 = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
       

        buff+= Blockconfig[i, j];
        buff2 += Blockconfig[i, j];
        if (i == j)
        {
            buff3 += Blockconfig[i, j];
        }
        
    }

    
    
    
}

int buff4 = Blockconfig[0, 2]+ Blockconfig[1, 1]+Blockconfig[2, 0] ;


if (buff == 3 || buff2 == 3 || buff3 == 3|| buff4 == 3)
{
    Console.WriteLine("Winner :User1");
   
}
else if (buff == 6 || buff2 == 6 || buff3 == 6|| buff4 == 6)
{
    Console.WriteLine("Winner :User2");
   
}






if (buff != 3 && buff2 != 3 && buff3 != 3 && buff != 6 && buff2 != 6 && buff3 != 6 && buff4  != 6)
{
    Console.WriteLine("Ddraw");
}


//Block.Show();
