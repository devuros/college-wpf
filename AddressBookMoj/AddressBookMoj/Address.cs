using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMoj
{
    public class Address : NotifyingObject
    {
        private string strName;
        private string strNumber;

        public string StrName
        {
            get { return strName; }
            set { SetAndNotify(ref strName, value); }
        }

        public string StrNumber
        {
            get { return strNumber; }
            set { SetAndNotify(ref strNumber, value); }
        }
    }
}
