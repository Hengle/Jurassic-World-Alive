using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jurassic_World_Alive
{
    class Player
    {
        private string name { get; set; }
        private int age { get; set; }
        private string gender { get; set; }
        private string description { get; set; }

        public Player(String name, int Age, String Gender, String Description)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.description = description;

        }

        
        
        public String getName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int getAge
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public String getGender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public String getDescription
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        




    }
}
