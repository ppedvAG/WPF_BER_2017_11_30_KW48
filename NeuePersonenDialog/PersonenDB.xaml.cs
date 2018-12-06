using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NeuePersonenDialog
{
    /// <summary>
    /// Interaction logic for PersonenDB.xaml
    /// </summary>
    public partial class PersonenDB : Window
    {
        internal ObservableCollection<Person> PersonenListe { get; set; }

        public PersonenDB()
        {
            InitializeComponent();

            this.PersonenListe = new ObservableCollection<Person>();
            this.DataContext = this;
            this.dgdPersonen.ItemsSource = this.PersonenListe;

            this.PersonenListe.Add(new Person() { Vorname = "Otto", Nachname = "Meyer", Geschlecht = Geschlechter.Männlich, Geburtsdatum = new DateTime(1989, 5, 12), Verheiratet = true, Lieblingsfarbe = Farben.Grün });
        }

        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            PersonenDialog neuePersonDialog = new PersonenDialog();

            if (neuePersonDialog.ShowDialog() == true) PersonenListe.Add(neuePersonDialog.neuePerson);
        }

        private void btnÄndern_Click(object sender, RoutedEventArgs e)
        {
            if (dgdPersonen.SelectedValue is Person)
            {
                PersonenDialog änderePersonDialog = new PersonenDialog(new Person(dgdPersonen.SelectedValue as Person));

                if (änderePersonDialog.ShowDialog() == true)
                    PersonenListe[PersonenListe.IndexOf(dgdPersonen.SelectedValue as Person)] = änderePersonDialog.neuePerson;
            }
        }

        private void btnLöschen_Click(object sender, RoutedEventArgs e)
        {
            if (dgdPersonen.SelectedValue is Person)
            {
                this.PersonenListe.Remove(dgdPersonen.SelectedValue as Person);
            }
        }
    }
}
