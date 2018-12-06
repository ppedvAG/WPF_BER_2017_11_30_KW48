using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_PersonenDB.Models
{
    public class Person : INotifyPropertyChanged
    {
        //Statische Member
        public static ObservableCollection<Person> PersonenListe { get; set; }

        static Person()
        {
            Person.PersonenListe = new ObservableCollection<Person>();
        }

        public static void LadePersonenAusDB()
        {
            Person.PersonenListe.Add(new Person() { Vorname = "Otto", Nachname = "Mayer", Geburtsdatum = new DateTime(1991, 5, 22) });
            Person.PersonenListe.Add(new Person() { Vorname = "Anna", Nachname = "Schmidt", Geburtsdatum = new DateTime(1958, 2, 2) });
            Person.PersonenListe.Add(new Person() { Vorname = "Jürgen", Nachname = "Fischer", Geburtsdatum = new DateTime(1975, 12, 14) });
            Person.PersonenListe.Add(new Person() { Vorname = "Sophie", Nachname = "Müller", Geburtsdatum = new DateTime(2009, 10, 29) });
        }


        //Klassenmember
        public event PropertyChangedEventHandler PropertyChanged;

        private string vorname;
        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vorname")); }
        }

        private string nachname;
        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nachname")); }
        }

        private DateTime geburtsdatum;
        public DateTime Geburtsdatum
        {
            get { return geburtsdatum; }
            set { geburtsdatum = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Geburtsdatum")); }
        }

        public Person()
        {
            this.Vorname = "";
            this.Nachname = "";
            this.Geburtsdatum = DateTime.Now;
        }

        public Person(Person altePerson)
        {
            this.Vorname = altePerson.Vorname;
            this.Nachname = altePerson.Nachname;
            this.Geburtsdatum = new DateTime(altePerson.Geburtsdatum.Year, altePerson.Geburtsdatum.Month, altePerson.Geburtsdatum.Day);
        }

    }
}
