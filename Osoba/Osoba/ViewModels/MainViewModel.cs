using Osoba.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Osoba.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private PersonContainer Data= new PersonContainer();

        private string _enteredYear;
        public string EnteredYear
        {
            get
            {
                return _enteredYear;
            }
            set
            {
                _enteredYear = value;
                RaisePropertyChangedEvent("EnteredYear");
            }
        }

        private string _enteredName;
        public string EnteredName
        {
            get
            {
                return _enteredName;
            }
            set
            {
                _enteredName = value;
                RaisePropertyChangedEvent("EnteredName");
            }
        }

        public ICommand FindPersonCommand 
        {
            get { return new DelegateCommand(FindPerson); }
        }
        private void FindPerson()
        {
            EnteredYear = Data.People.Where(x => x.FullName == EnteredName).First().BirthYear.ToString();
        }

        public ICommand SavePersonCommand 
        {
            get { return new DelegateCommand(SavePerson); }
        }
        private void SavePerson()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
