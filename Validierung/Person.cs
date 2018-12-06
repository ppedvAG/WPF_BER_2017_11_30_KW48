using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validierung
{
    //Für ValidatesOnDataErrors muss z.B. das Interface IDataErrorInfo implementiert werden. Dieses erfordert die Einbindung von zwei zusätzlichen
    class Person : IDataErrorInfo
    {
        private string vorname;

        public string Vorname
        {
            get { return vorname; }
            set
            {
                if (!value.All(x => Char.IsLetter(x))) throw new Exception("Bitte gib nur Buchstaben ein");
                else vorname = value;
            }
        }

        private string nachname;

        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        private int alter;

        public int Alter
        {
            get { return alter; }
            set { alter = value; }
        }

        public Person()
        {

        }

        public string Error
        {
            get { return ""; }
        }

        //Diese Property wird zur Fehler- und Fehlermeldungsdefinition verwendet durch das Interface verwendet
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Alter):
                        if (Alter < 0) return "Du bist bestimmt älter als 0 Jahre.";
                        break;
                }

                return "";
            }
        }


    }
}
