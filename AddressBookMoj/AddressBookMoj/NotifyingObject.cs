using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMoj
{
    // Klasa NotifyingObject predstavlja osnovu za sve objekte koji treba da obaveštavaju o promenama
    // svojih svojstava. Može se koristiti kao bazna klasa za klase u aktivnom modelu. Ova klasa implementira
    // interfejs INotifyPropertyChanged čime se naglašava da ona obaveštava.
    // INotifyPropertyChaned interfejs očekuju WPF kontrole koje koriste Binding.
    [Serializable]
    public class NotifyingObject : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        // Ova metoda postavlja zadatu vrednost fieldValue zadatom polju field i obaveštava o promeni odgovarajućeg
        // svojstva. Prvo se proverava da li je zadata vrednost fieldValue različita od trenutne vrednosti
        // zadatog polja, jer u slučaju da nije, ne treba ništa raditi.
        protected void SetAndNotify<T>(ref T field, T fieldValue, [CallerMemberName]string propertyName = "")
        {
            if (!EqualityComparer<T>.Default.Equals(field, fieldValue))
            {
                field = fieldValue;
                NotifyPropertyChanged(propertyName);
            }
        }

        // Obaveštavanje o promeni zadatog svojstva. Atribut CallerMemberName omogućava da se prilikom
        // poziva ove metode izostavi argument propertyName. To može da se radi ako se obaveštavanje
        // vrši iz set metode onog svojstva o čijoj promeni se obaveštava.
        protected void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
        {
            // Provera da li je neko pretplaćen na obaveštavanje
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion
    }
}
