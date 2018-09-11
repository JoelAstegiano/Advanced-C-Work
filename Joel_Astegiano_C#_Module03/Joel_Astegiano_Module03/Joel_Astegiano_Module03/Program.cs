using System;


namespace Joel_Astegiano_Module03
{
    class Program
    {
        static void Main(string[] args)
        {
              int score=0;
              int scoresEntered = 0;


              while (score < 999)
              {
                  Console.Write("Enter a Score from 0 to 100: ");
                  int scoreIn=Convert.ToInt32(Console.ReadLine());
                  if (scoreIn<=100 && scoreIn >= 0) // add to score
                  {
                      score += scoreIn;
                      scoresEntered++;
                      Console.Write("Success");
                  }
                  else // error out on bad input
                  {
                      Console.Write("Error, Enter a Score from 0 to 100: ");
                  }
                  Console.ReadKey();

              }
              Console.Write(scoresEntered + " Scores entered. Average: " + (score/scoresEntered)); //Avg
              Console.ReadKey();  

            Console.Write("Enter a String: "); //Prompt
            String vowels = Console.ReadLine();
            char[] vowelBreakdown = vowels.ToCharArray(); //to array
            int i = 0;
            int j = 0;
            while (i<vowelBreakdown.Length) //go until all checked
            {
                if (vowelBreakdown[i]=='a'|| //Check Vowel
                    vowelBreakdown[i] == 'e'||
                    vowelBreakdown[i] == 'i' ||
                    vowelBreakdown[i] == 'o' ||
                    vowelBreakdown[i] == 'u' ||
                    vowelBreakdown[i] == 'A' ||
                    vowelBreakdown[i] == 'E' ||
                    vowelBreakdown[i] == 'I' ||
                    vowelBreakdown[i] == 'O' ||
                    vowelBreakdown[i] == 'U')
                {
                    j++;
                }
                i++;
            }
            Console.Write(vowels+" has "+ j + " Vowels"); //Read off Nunber of Vowels
            Console.ReadKey(); 

            Random Rand = new Random(); //Get random Nums and Incrementors
            int randomNum = Rand.Next(1, 100);
            int numIn = 0;
            int[] guesses= new int[10];
            i = 0; 
            while (numIn != randomNum && i<10)
            {
                Console.WriteLine("Enter a Number from 1 to 100: "); // Get Num
                numIn = Convert.ToInt32(Console.ReadLine());
                if (numIn == randomNum) //Sucess
                {
                    guesses[i] = numIn;
                    Console.WriteLine("Success! Guesses were : " + string.Join(" ", guesses));
                    Console.ReadKey();
                }
                else if(numIn>randomNum){ //Too High
                    guesses[i] = numIn;
                    Console.WriteLine("Too High Press any Key");
                    i++;
                    Console.ReadKey();
                }
                else if (numIn < randomNum) //Too Low
                {
                    guesses[i] = numIn;
                    Console.WriteLine("Too Low Press any Key");
                    i++;
                    Console.ReadKey();
                }
            }
            if (numIn != randomNum) // On Fail
            {
                Console.WriteLine("Fail! Guesses were : " + string.Join(" ", guesses));
                Console.ReadKey();
            }
        }
    }
}
