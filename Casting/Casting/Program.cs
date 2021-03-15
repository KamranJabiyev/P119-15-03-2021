using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Casting
            #region upcasting,boxing,implicit
            //Eagle eagle1 = new Eagle();
            //Shark shark1 = new Shark();
            //Animal eagle2 = eagle1;
            //int a = 5;
            //char letter = 'r';
            //string word = "Soz";
            //object[] arr = { eagle1, shark1, a, letter, word };

            //Print(eagle1);
            //Print(shark1);
            #endregion

            #region Downcating,unboxing,explicit
            //Animal animal1 = new Eagle();
            //Animal animal2 = new Shark();

            //downcasting security way-1 - is
            //if(animal2 is Eagle)
            //{
            //    Eagle eagle =(Eagle)animal2;
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    Console.WriteLine("not eagle type");
            //}

            //downcasting security way-2 - as
            //Eagle eagle = animal2 as Eagle;
            //if (eagle != null)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    Console.WriteLine("not eagle type");
            //}

            //Eagle eagle1 = new Eagle();
            //Shark shark1 = new Shark();
            //Animal eagle2 = eagle1;
            //int a = 5;
            //char letter = 'r';
            //string word = "Soz";
            //object[] arr = { shark1, a, eagle1, letter, word };
            //foreach (var item in arr)
            //{
            //    Eagle eagle = item as Eagle;
            //    if (eagle != null)
            //    {
            //        eagle.Age = 100;
            //        Console.WriteLine(eagle.Age);
            //    }
            //}
            //int n = 1000;
            //long l = n;

            //long l = 10000000000;
            //int n = (int)l;

            //double d = 10.5;
            //int n = (int)d;

            //Console.WriteLine(n);
            #endregion
            #endregion

            #region Implicit,explicit
            //Manat manat = new Manat(540);
            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region Operators in custom type
            //int n1 = 10;
            //int n2 = 100;
            //Console.WriteLine(n2==n1);
            //Person p1 = new Person("Gulbahar", "Memmedova", 27);
            //Person p2 = new Person("Nermin", "Aslanova", 21);
            //Console.WriteLine(p1>p2);
            #endregion

            #region Nullable value types
            //int? n = 10;
            //n = null;
            //int n1 = (int)n;
            //bool? test = null;
            #endregion
        }

        #region upcasting,boxing,implicit
        //public static void Print(Animal animal)
        //{
        //    animal.Eat();
        //}
        #endregion
    }

    #region Operators in custom type
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        //public static string operator +(Person p1,Person p2)
        //{
        //    return p1.Name + " " + p2.Name;
        //}

        public static int operator +(Person p1, Person p2)
        {
            return p1.Age + p2.Age;
        }

        public static bool operator >(Person p1,Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
    }
    #endregion

    #region Implicit,explicit
    //class Manat
    //{
    //    public double Azn { get; set; }
    //    public Manat(double azn)
    //    {
    //        Azn = azn;
    //    }

    //    //public static implicit operator Dollar(Manat manat)
    //    //{
    //    //    return new Dollar(manat.Azn / 1.7);
    //    //}

    //    public static explicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.Azn / 1.7);
    //    }
    //}

    //class Dollar
    //{
    //    public double Usd { get; set; }
    //    public Dollar(double usd)
    //    {
    //        Usd = usd;
    //    }
    //}
    #endregion

    #region Casting
    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    class Eagle : Bird
    {
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    class Shark : Fish
    {
        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Fly as Shark");
        }
    }
    #endregion
}
