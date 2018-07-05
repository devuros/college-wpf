using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMoj
{
    public class Gender
    {
        public static readonly Gender Male = new Gender("Male");
        public static readonly Gender Female = new Gender("Female");
        public static readonly Gender[] Genders = new Gender[] { Gender.Male, Gender.Female };

        public string Name { get; private set; }

        protected Gender(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
