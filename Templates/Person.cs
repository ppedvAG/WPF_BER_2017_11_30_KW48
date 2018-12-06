using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templates
{
    class Person : INotifyPropertyChanged
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public int alter;
        public int Alter
        {
            get
            {
                return alter;
            }
            set
            {
                alter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Alter"));

                //if (PropertyChanged != null)
                //{
                //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Alter"));
                //}
            }
        }

        public Person() { }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
