using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_PersonenDB.ViewModels
{
    public class DetailViewModel
    {
        public DetailViewModel()
        {
            this.OkCmd = new UserCommand
                (
                    p => true,
                    p =>
                    {
                        (p as Views.DetailView).DialogResult = true;
                        (p as Views.DetailView).Close();
                    }
                );
            this.aktuellePerson = new Models.Person();
        }

        public Models.Person aktuellePerson { get; set; }

        public UserCommand OkCmd { get; set; }

    }
}
