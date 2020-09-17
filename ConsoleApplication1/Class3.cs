using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    partial class Rocket
    {
        static int CountPusk;
        static int Dal;

        private string Name;

        public string Name_R
        {
            get { return Name; }
            set { Name = value; }
        }

        private string Naznach;

        public string Naznach_R
        {
            get { return Naznach; }
            set { Naznach = value; }
        }

        private string Razrabot;

        public string Razrabot_R
        {
            get { return Razrabot; }
            set { Razrabot = value; }
        }

        private int Ves;

        public int Ves_R
        {
            get { return Ves; }
            set { Ves = value; }
        }



        static Rocket()
        {
            CountPusk = 0;
            Dal = 1000;
        }

        public Rocket(): this("No name", "No name", "No", 0)
        {

        }

        public Rocket(string n, string r, string naz, int v)
        {
            Name = n;
            Razrabot = r;
            Naznach = naz;
            Ves = v;
        }

    }
}
