using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_PersonenDB.ViewModels
{
    public class ListViewModel
    {
        public ListViewModel()
        {
            this.NeuePersonCmd = new UserCommand
                (
                    para =>
                    {
                        return true;
                    },
                    para =>
                    {
                        Views.DetailView detailV = new Views.DetailView();
                        detailV.DataContext = new DetailViewModel();

                        if (detailV.ShowDialog() == true) Models.Person.PersonenListe.Add((detailV.DataContext as DetailViewModel).aktuellePerson);  
                    }
                );
            this.ÄnderePersonCmd = new UserCommand
                (
                    p => p is Models.Person,
                    p =>
                    {
                        Views.DetailView detailV = new Views.DetailView();
                        detailV.DataContext = new DetailViewModel();
                        (detailV.DataContext as DetailViewModel).aktuellePerson = new Models.Person(p as Models.Person);

                        if (detailV.ShowDialog() == true) Models.Person.PersonenListe[Models.Person.PersonenListe.IndexOf(p as Models.Person)] = (detailV.DataContext as DetailViewModel).aktuellePerson;
                    }
                );
            this.LöschePersonCmd = new UserCommand
                (
                    p => p is Models.Person,
                    p => Models.Person.PersonenListe.Remove(p as Models.Person)
                );
            this.SchließeAppCmd = new UserCommand
                (
                    p => true,
                    p => Application.Current.Shutdown()
                );
        }

        public ObservableCollection<Models.Person> PersonenListe
        {
            get { return Models.Person.PersonenListe; }
        }

        public UserCommand NeuePersonCmd { get; set; }
        public UserCommand ÄnderePersonCmd { get; set; }
        public UserCommand LöschePersonCmd { get; set; }
        public UserCommand SchließeAppCmd { get; set; }

    }
}
