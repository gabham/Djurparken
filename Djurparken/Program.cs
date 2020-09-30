using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Djurparken
{
    class Program
    {
        List<Animal> Animals = new List<Animal>();
        static void Main()
        {
            Program p = new Program();
            p.Start();
        }

        void Start()
        {
            Console.WriteLine("Welcome to the zoo register!");
            Console.WriteLine("\nHere you can register and remove animals");
            Console.WriteLine("You can also search and acquire information about different animals in the zoo");
            Console.WriteLine("Animals currently available for registration are: tigers, elephants and owls");
            Console.WriteLine("If you want to receive a list of useful commands, please type 'help'");

            while (true)
            {
                Console.WriteLine("\nPlease enter a command in the register:");
                string input = Console.ReadLine().ToLower();

                if (input == "register")
                {
                    Register();
                }
                else if (input == "remove")
                {
                    Remove();
                }
                else if (input == "search")
                {
                    Search();
                }
                else if (input == "help")
                {
                    Help();
                }
                else if (input == "quit")
                {
                    Quit();
                }
            }




        }

        void Register()
        {
            Console.WriteLine("Which animal do you want to register?\nYou can choose: tiger, elephant, owl");
            string input = Console.ReadLine().ToLower();

            if (input == "tiger")
            {
                
                Console.WriteLine("Please enter a name for the tiger:");
                string name = Console.ReadLine().ToLower();

                Console.WriteLine("Please enter the weight of the tiger (kg):");
                int weight = int.Parse(Console.ReadLine());

                string three = name.Substring(0, 3);
                // string three används för att ta fram de tre första bokstäverna ur en string, som t.ex namn i detta fall

                int id = weight;

                Tiger tiger = new Tiger(name, id, weight);
                Animals.Add(tiger);


                   

            }

            
            

        }

        void Remove()
        {

        }

        void Quit()
        {
            Environment.Exit(0);
        }

        void Help()
        {
            Console.WriteLine("\nregister - register an animal of your choice");
            Console.WriteLine("remove - remove an animal from the zoo");
            Console.WriteLine("search - search for a specific animal based on  ");
            Console.WriteLine("quit - exits the register/program");
            Console.WriteLine("help - displays a helpful list of commands");
        }

        void Search()
        {


        }

        void TigerID(string name)
        {
            string res = name.Substring(0, 3);
            
        }
    }



    class Tiger : Animal
    {
        public int Weight { get; private set; }

        public Tiger (string name, int id, int weight) : base (name, id)
        {
            Weight = weight;
        }
    }

    class Elephant : Animal
    {
        public int Trunk { get; private set; }

        public Elephant (string name, int id, int trunk) : base (name, id)
        {
            Trunk = trunk;
        }
    }

    class Owl : Animal
    {
        public float Wingspan { get; private set; }

        public Owl (string name, int id, float wingspan) : base (name, id)
        {
            Wingspan = wingspan;
        }
    }

    class Animal
    {
        public string Name { get; private set; }
        public int ID { get; private set; }

        public Animal(string name, int id)
        {
            Name = name;
            ID = id;
        }
   
    }




}
