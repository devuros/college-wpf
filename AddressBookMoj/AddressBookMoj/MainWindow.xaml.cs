using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddressBookMoj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddressBook adresar = new AddressBook();

        public AddressBook Adresar
        {
            get { return adresar; }
            private set { }
        }

        public RelayCommand ExitCommand { get; set; }
        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeCommands();

            FillAdressBook();

            this.DataContext = this;
        }

        private void InitializeCommands()
        {
            this.ExitCommand = new RelayCommand
            (
                delegate(object o)
                {
                    this.Close();
                }, o => true
            );

            this.AddCommand = new RelayCommand
            (
                delegate(object o)
                {
                    PersonDialog pd = new PersonDialog();
                    if (pd.ShowDialog() ?? false)
                    {
                        this.adresar.Persons.Add(pd.Person);
                    }

                }, o => true
            );

            this.RemoveCommand = new RelayCommand
            (
                delegate(object o)
                {
                    ICollectionView cv = CollectionViewSource.GetDefaultView(adresar.Persons);
                    Person current = cv.CurrentItem as Person;
                    adresar.Persons.Remove(current);

                }, o => true
            );
        }

        private void FillAdressBook()
        {
            adresar.Persons.Add(new Person()
            {
                Name = "Dusan Kosovac",
                Height = 2.4,
                Birthdate = new DateTime(1994, 4, 7),
                Gender = Gender.Male
            });
            adresar.Persons.Add(new Person()
            {
                Name = "Petar Lukic",
                Height = 2.0,
                Birthdate = new DateTime(1992, 12, 25),
                Gender = Gender.Male
            });
            adresar.Persons.Add(new Person()
            {
                Name = "Dusica Petrovic",
                Height = 1.8,
                Birthdate = new DateTime(1997, 2, 5),
                Gender = Gender.Female
            });
            adresar.Persons[1].Adrese.Add(new Address()
            {
                StrName = "Admirala Geprata",
                StrNumber = "15"
            });
            adresar.Persons[1].Adrese.Add(new Address()
            {
                StrName = "Filipa Visnjica",
                StrNumber = "4"
            });
            adresar.Persons[2].Adrese.Add(new Address()
            {
                StrName = "Milosa Velikog",
                StrNumber = "44"
            });
        }

    }
}
