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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ObservableCollection<Person> PersonenListe { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.PersonenListe = new ObservableCollection<Person>();

            this.PersonenListe.Add(new Person() { Vorname = "Hannes", Nachname = "Meier", Alter = 39 });
            this.PersonenListe.Add(new Person() { Vorname = "Anna", Nachname = "Schmidt", Alter = 67 });

            //Setzen des DataContext des Windows auf sich selbst (d.h. der DataContext der Xaml-Elemente sind die Properties der Window-Klasse im CodeBehind)
            this.DataContext = this;
            this.lbxPersonen.ItemsSource = this.PersonenListe;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.PersonenListe.Add(new Person() { Vorname = "Johanna", Nachname = "Fischer", Alter = 21 });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.PersonenListe[0].Alter++;
        }
    }
}
