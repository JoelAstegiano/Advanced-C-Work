using System;

namespace Joel_Astegiano_C_Module05
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Chief", 5, 7);
            player1.displayPlayerStats();
            Player player2 = new Player("Sarge", 7, 5);
            player2.displayPlayerStats();

            Console.ReadKey();
        }

    }

    class Person
    {
        private string name;
        private int age;

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            } }
        public int Age {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Person()
        {
            name = "Steve";
            age = 18;
        }

        public Person(string givenName, int givenAge)
        {
            name = givenName;
            age = givenAge;
        }



    }

    class book
    {
        private string name;
        private int iSBN;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int ISBN
        {
            get { return iSBN; }
            set { iSBN= value; }
        }
    }

    class Player
    {
        public string username { get; set; }

        public int Kills { get; set; }

        public int Deaths { get; set; }

        public Player(string un, int k, int d)
        {
            username = un;
            Kills = k;
            Deaths = d;
        }

        public void displayPlayerStats()
        {
            Console.WriteLine("Player {0} has {1} kills and {2} deaths", this.username, this.Kills, this.Deaths);
        }

    }

}
