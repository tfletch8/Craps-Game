/*Thomas Fletcher 
  ITCS 3112 Craps Game
*/
using System;

public class Craps
{
    public static void Main(string[] args)
    {
        bool cont = true;
        int chips = 100; // starting amount of chips
        while (cont == true && chips > 0){
            Random random = new Random();
            int die1 = 0;
            int die2 = 0;
            die1 = random.Next(1, 7); //randomizes the dice amount
            die2 = random.Next(1, 7);
            int roll = die1 + die2; //determines the sum of the dices thrown
            Console.WriteLine("How many chips would you like to wager?");
            int wager = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first roll is: {0}", roll);
            if (roll == 7 || roll == 11) {
                Console.WriteLine("You won!");
                chips = chips + wager; //adds to chip total when user wins on first roll
            }
            if (roll == 2 || roll == 3 || roll == 12) {
                Console.WriteLine("You lost."); 
                chips = chips - wager; //deducts from chip total when user loses on first roll
            }
            if (roll == 4 || roll == 5 || roll == 6 || roll == 8 || roll == 9 || roll == 10) {
                int point = roll;
                bool foo = true;
                while (foo == true) {
                    int roll2 = random.Next(1, 7) + random.Next(1, 7);
                    Console.WriteLine("This roll is: {0}", roll2);
                    /*if the point is equal to the second roll, the user wins and adds to their chip total, 
                    if it is equal to 7, the user loses and deducts from their chip total.*/
                    if (roll2 == point) {
                        Console.WriteLine("You won!");
                        chips = chips + wager;
                        foo = false;
                    }
                    if (roll2 == 7) {
                        Console.WriteLine("You lost.");
                        chips = chips - wager;
                        foo = false;
                    }
                }
            }
            Console.WriteLine("You now have {0} chips.", chips); //tells the user how many chips they have left after the game
            if (chips > 0) {
                Console.WriteLine("Would you like to continue? Y/N");
                string response = Console.ReadLine();
                if (response == "N") {
                    cont = false; //exits the game if user responds no
                } 
            }
        }
    }
}