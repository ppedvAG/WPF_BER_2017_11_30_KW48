using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_PersonenDB.ViewModels
{
    public class StartViewModel : INotifyPropertyChanged
    {
        public int AnzahlPersonen { get { return Models.Person.PersonenListe.Count; } }

        public StartViewModel()
        {
            this.LadeDB = new UserCommand
                (
                    parameter =>
                    {
                        return this.AnzahlPersonen == 0;
                    },
                    parameter =>
                    {
                        Models.Person.LadePersonenAusDB();
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AnzahlPersonen"));
                    }
                );

            this.ÖffneDB = new UserCommand
                (
                    parameter =>
                    {
                        return this.AnzahlPersonen > 0;
                    },
                    parameter =>
                    {
                        Views.ListView newListView = new Views.ListView();
                        newListView.DataContext = new ListViewModel();

                        newListView.Show();
                        ((Views.StartView)parameter).Close();
                    }
                );
        }

        public UserCommand LadeDB { get; set; }
        public UserCommand ÖffneDB { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
