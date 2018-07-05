using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace AddressBookMoj
{
    /// <summary>
    /// Interaction logic for PersonDialog.xaml
    /// </summary>
    public partial class PersonDialog : Window
    {
        public Person Person { get; set; }

        public PersonDialog(Person per = null)
        {
            InitializeComponent();

            if(per == null)
                per = new Person();
            this.Person = per;
            this.DataContext = this;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
