using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GV_Testing_Program_2
{
    public class Tester
    {
        public Gender gender { get; private set; }
        public int age { get; private set; }
        public char genderShort { get; private set; }

        private string lastName, firstName, middleName;
        
        public Tester(string lastName, string firstName, string middleName, Gender gender, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.gender = gender;
            this.age = age;

            genderShort = (gender == Gender.male) ? 'M' : 'F';
        }

        public string getName(string which)
        {
            return which switch
            {
                "last" => lastName,
                "first" => firstName,
                "middle" => middleName,
                _ => ""
            };
        }

    }
}
