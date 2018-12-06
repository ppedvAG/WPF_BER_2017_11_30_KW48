using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuePersonenDialog
{
    public enum Geschlechter { Männlich, Weiblich, Divers}
    public enum Farben { Rot, Blau, Grün, Gelb}

    public class Person : IDataErrorInfo, INotifyPropertyChanged
    {
        public string vorname;
        public string Vorname
        {
            get { return vorname; }
            set
            {
                vorname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vorname"));
            }
        }

        public string Nachname { get; set; }

        public DateTime Geburtsdatum { get; set; }

        public bool Verheiratet { get; set; }

        public Geschlechter Geschlecht { get; set; }

        public Farben Lieblingsfarbe { get; set; }

        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Vorname):
                        if (Vorname.Length <= 0 || Vorname.Length > 50) return "Gib den Namen ein";
                        if (!Vorname.All(char.IsLetter)) return "Der Name darf nur aus Buchstaben bestehen";
                            break;
                    case nameof(Nachname):
                        if (Nachname.Length <= 0 || Nachname.Length > 50) return "Gib den Namen ein";
                        if (!Nachname.All(char.IsLetter)) return "Der Name darf nur aus Buchstaben bestehen";
                        break;
                    case nameof(Geburtsdatum):
                        if (Geburtsdatum > DateTime.Now) return "Der Geburtstag darf nicht in der Zukunft liegen";
                        if (DateTime.Now.Year - Geburtsdatum.Year > 150) return "Der Geburtstag darf nicht mehr als 150 Jahre in der Vergangenheit liegen";
                        break;
                }
                return "";
            }
        }

        public Person()
        {
            this.Geburtsdatum = DateTime.Now;
            this.Vorname = "";
            this.Nachname = "";
        }

        public Person(Person altePerson)
        {
            this.Vorname = altePerson.Vorname;
            this.Nachname = altePerson.Nachname;
            this.Geschlecht = altePerson.Geschlecht;
            this.Lieblingsfarbe = altePerson.Lieblingsfarbe;
            this.Verheiratet = altePerson.Verheiratet;

            this.Geburtsdatum = new DateTime(altePerson.Geburtsdatum.Year, altePerson.Geburtsdatum.Month, altePerson.Geburtsdatum.Day);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
