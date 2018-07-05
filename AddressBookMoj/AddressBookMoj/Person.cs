using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMoj
{
    public class Person : NotifyingObject
    {
        private ObservableCollection<Address> adrese = new ObservableCollection<Address>();

        private string name;
        private DateTime birthdate;
        private double height;
        private Gender gender;

        public string Name
        {
            get { return name; }
            set { SetAndNotify(ref name, value); }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set
            {
                if(this.birthdate != value)
                {
                    this.birthdate = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Age");
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                SetAndNotify(ref height, value);
            }
        }

        public Gender Gender
        {
            get { return gender; }
            set
            {
                SetAndNotify(ref gender, value);
            }
        }

        public int Age 
        {
            get
            {
                return DateTime.Now.Year - Birthdate.Year;
            }
        }

        public ObservableCollection<Address> Adrese
        {
            get { return adrese; }
            private set
            {
                this.adrese = value;
            }
        }

    }
}
