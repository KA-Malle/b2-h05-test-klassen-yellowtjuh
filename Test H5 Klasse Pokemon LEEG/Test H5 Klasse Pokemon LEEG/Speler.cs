using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_H5_Klasse_Pokemon_LEEG
{


    internal class Speler
    {
        private string _Naam;
        private int _Gezondheid;
        private int _PositieX;
        private int _PositieY;
        private bool _Isleven;

        public string Naam
        {
            get { return _Naam; }
            set { _Naam = value; }
        }


        public int Gezondheid
        {
            get { return _Gezondheid; }
            set { _Gezondheid = value; }
        }



        public int PosX
        {
            get { return _PositieX; }
            set { _PositieX = value; }
        }



        public int PosY
        {
            get { return _PositieY; }
            set { _PositieY = value; }
        }



        public bool Levend
        {
            get { return _Isleven; }
            set { _Isleven = value; }
        }

        //Constructors

        public Speler()
        {
            Naam = "";
            Gezondheid = 100;
            PosX = 0;
            PosY = 0;
            Levend = true;
        }

        public Speler(string naam, int Gezond, int px, int py, bool levendig)
        {
            Naam = naam;
            Gezondheid = Gezond;
            PosX = px;
            PosY = py;
            Levend = levendig;

        }

        public int Verplaats(int parX, int parY)
        {
            PosX += parX;
            PosY += parY;

            return
        }

        public int OntvangSchade(int schade)
        {
            if (Gezondheid > 0)
            {
                if (Gezondheid > schade)
                {
                    Gezondheid -= schade;
                }
                else
                {
                    Levend = false;
                }

            }
            else
            {
                Levend = false;
            }

            return Gezondheid;
        }

        public int Genees(int gen)
        {
            Gezondheid += gen;
            if (Gezondheid > 100)
            {
                Gezondheid = 100;
            }
            return Gezondheid;
        }





    }

}
