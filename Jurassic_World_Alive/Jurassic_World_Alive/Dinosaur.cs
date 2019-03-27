using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jurassic_World_Alive
{
    class Dinosaur
    {
        private string DinoName { get; set; }
        private string DinoSex { get; set; }
        private string DinoSize { get; set; }
        private string DinoClass { get; set; }
        private string DinoPeriod { get; set; }
        private int DinoAge { get; set; }

        

        public Dinosaur(String DinoName, String DinoSex, String DinoSize, String DinoClass, String DinoPeriod, int DinoAge)
        {
            this.DinoName = DinoName;
            this.DinoSex = DinoSex;
            this.DinoSize = DinoSize;
            this.DinoClass = DinoClass;
            this.DinoPeriod = DinoPeriod;
            this.DinoAge = DinoAge;

            
        }

        public static List<Dinosaur> dinolist = new List<Dinosaur>();

        public string getDinoName
        {
            get
            {
                return DinoName;
            }
            set
            {
                DinoName = value;
            }
        }

        public string getDinoSex
        {
            get
            {
                return DinoSex;
            }
            set
            {
                DinoSex = value;
            }
        }

        public string getDinoSize
        {
            get
            {
                return DinoSize;
            }
            set
            {
                DinoSize = value;
            }
        }

        public string getDinoClass
        {
            get
            {
                return DinoClass;
            }
            set
            {
                DinoClass = value;
            }
        }

        public string getDinoPeriod
        {
            get
            {
                return DinoPeriod;
            }
            set
            {
                DinoPeriod = value;
            }
        }

        public int getDinoAge
        {
            get
            {
                return DinoAge;
            }
            set
            {
                DinoAge = value;
            }
        }

        public override string ToString()
        {
            return (getDinoName + " " + getDinoSex +" "+ getDinoSize +" "+ getDinoClass + " " + getDinoPeriod + " " + getDinoAge );
            
        }
    }
}
