namespace methodsc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;    

            Random random = new Random();

            for (int i = 0; i<10; i++)
			{
                Console.WriteLine("press any key to roll dice!");
                Console.ReadKey();
                //generating a random number between 1 to 6

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a "+ playerRandomNum);

                // delaying for 1 second between enemy roll and player roll.
                Console.WriteLine("..."  );
                System.Threading.Thread.Sleep(1000);    

                //enemy random number
                enemyRandomNum = random.Next(1, 7); 
                Console.WriteLine("enemy rolled a " + enemyRandomNum);  
                //
                // Scores and giving points to enemy and player
                if (playerRandomNum > enemyRandomNum ) {
                    playerPoints++;
                    Console.WriteLine( "player wins this round!");
                }
                else if(playerRandomNum < enemyRandomNum ) { enemyPoints++;
                    Console.WriteLine("enemy wins this round");
                }
                else
                {
                    Console.WriteLine("draw!");
                }
                Console.WriteLine( "The score is now - player : " + playerPoints + ". Enemy :" + enemyPoints + ".");
                Console.WriteLine( );

            }
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("Player wins!");
            }
            else if(playerPoints< enemyPoints)
            {
                Console.WriteLine("enemy wins!");
            }
            else { Console.WriteLine("Its a draw!"); }
           

        
        
            
        }
        
    }
}
