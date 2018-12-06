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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeuePersonenDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PersonenDialog : Window
    {
        public Person neuePerson { get; set; }

        public PersonenDialog()
        {
            InitializeComponent();

            this.neuePerson = new Person();
            this.DataContext = neuePerson;
        }

        public PersonenDialog(Person änderePerson)
        {
            InitializeComponent();

            this.neuePerson = änderePerson;
            this.DataContext = neuePerson;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
