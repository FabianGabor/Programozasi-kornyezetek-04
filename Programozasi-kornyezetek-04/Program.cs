using System;

namespace Programozasi_kornyezetek_04 {
    struct Bringa : IComparable{
        private string _nev;
        private int _ar;
        
        public int Ar {
            get => _ar;
            set => _ar = (_ar > 0) ? value : _ar;
        }

        public string Nev { get; set; }

        public override string ToString() {
            // return base.ToString();
            return "Nev: " + _nev + ", ar: " + _ar;
        }

        public int CompareTo(object obj) {
            throw new NotImplementedException();
        }
    }

    internal class Program {
        public static void Main(string[] args) {
            Bringa csepel = new Bringa();
            csepel.Ar = 135000;
            csepel.Ar = -10;
            Console.WriteLine(csepel.Ar);
            csepel.Nev = "Csepel";
            Console.WriteLine(csepel.Nev);
            Console.WriteLine(csepel);
            
        }
    }
}