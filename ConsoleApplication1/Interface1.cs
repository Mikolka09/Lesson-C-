using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IProgrammer
    {
        void CreateCode();
        void DebagingCode();
    }

    interface IWorker
    {
        bool IsWorker { get; set; }
        void Work();

    }

    interface IManager
    {
        List<IWorker> ListOfWorkers { get; set; }

        void Planing();
        void MakeBudget();
        void Control();
    }

    abstract class People
    {
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, BirthDay: {BirthDay.ToShortDateString()}, ";
        }

    }

    abstract class Employee : People
    {
        public string Position { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Position: {Position}, Salary: ${Salary}";
        }
    }

    class Director : Employee, IManager
    {
        public List<IWorker> ListOfWorkers { get; set; }
        public void Planing()
        {
            Console.WriteLine("I`m planing");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I`m budget");
        }

        public void Control()
        {
            Console.WriteLine("I`m controling");
        }

    }
    class Seller : Employee, IWorker
    {
        public bool IsWorker { get; set; } = true;


        public void Work()
        {
            Console.WriteLine("Я продаю товары");
        }
    }

    class Casher : Employee, IWorker
    {
        public bool IsWorker { get; set; } = true;


        public void Work()
        {
            Console.WriteLine("Я принимаю деньги за товар");
        }
    }

    class Cleaner : Employee, IWorker
    {
        public bool IsWorker { get; set; } = true;

        public void Work()
        {
            Console.WriteLine("Я убираю помещение");
        }
    }



    interface IIndexer
    {
        string this[int ind] { get; set; }

        string this[string key] { get; }

        }

    enum Numbers { one, two, three, four, five };

    class IndexerClass: IIndexer
    {
        string[] names = new string[5];

        public string this [int ind]
        {
            get { return names[ind]; }
            set { names[ind] = value; }
        }

        public string this [string key]
        {
            get
            {
                if (Enum.IsDefined(typeof(Numbers), key))
                    return names[(int)Enum.Parse(typeof(Numbers), key)];
                else
                    return "";
            }
        }


        public IndexerClass()
        {
            this[0] = "Ivan";
            this[1] = "Nikolay";
            this[2] = "Svetlana";
            this[3] = "Olga";
            this[4] = "Petro";
        }

    }


    interface IA
    {
        void Show();

    }

    interface IB
    {
        
        void Show();
    }

    interface IC
    {
        void Show();
    }

    class IterC: IA, IB, IC
    {
        public void Show()
        {
            Console.WriteLine("Show C");
        }

        void IA.Show()
        {
            Console.WriteLine("Show A");
        }

        void IB.Show()
        {
            Console.WriteLine("Show B");
        }

        //void IC.Show()
        //{
        //    Console.WriteLine("Show C");
        //}
    }


    class TestNull
    {
        public string Name { get; set; }
        public TestNull(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            Name = name;
        }
    }

    
    


}






