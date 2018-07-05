using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMoj
{
    public class AddressBook
    {
        public ObservableCollection<Person> Persons { get; set; }

        public AddressBook()
        {
            this.Persons = new ObservableCollection<Person>();
        }

    }
}
