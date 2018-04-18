using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Pessoa : IComparable
    {
        public string Gender { get; set; }
        public string GivenName { get; set; }
        public string MiddleInitial { get; set; }
        public string SurName { get; set; }
        public string Age { get; set; }

        public Pessoa (string gender , string givenName, string middleInitial, string sunName, string age)
        {
            this.Gender = gender;
            this.GivenName = givenName;
            this.MiddleInitial = middleInitial;
            this.SurName = sunName;
            this.Age = age;
        }

        public override string ToString()
        {
            return Gender.PadRight(20)
                + ""
                + GivenName.PadRight(20)
                + ""
                + MiddleInitial.PadRight(20)
                + ""
                + SurName.PadRight(20)
                + ""
                + Age;

        }

        public int CompareTo(object obj) {
            Pessoa outro = (Pessoa)obj;
            int resultado = GivenName.CompareTo(outro.GivenName);
            if(resultado != 0) {
                return resultado;
            }
            else {
                int resultado2 = SurName.CompareTo(outro.SurName);
                if(resultado2 != 0) {
                    return resultado2;
                }
                else {
                    return Age.CompareTo(outro.Age);
                }
            }


        }
    }
}
