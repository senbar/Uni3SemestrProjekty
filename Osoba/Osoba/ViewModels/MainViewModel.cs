using Osoba.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                SexString = "";
                _enteredName = value;
                RaisePropertyChangedEvent("EnteredName");
            }
        }

        private string _sexString;
        public string SexString
        {
            get
            {
                return _sexString;
            }
            set
            {
                _sexString = value;
                RaisePropertyChangedEvent("SexString");
            }
        }
        public ICommand FindPersonCommand 
        {
            get { return new DelegateCommand(FindPerson); }
        }
        private void FindPerson()
        {
            try
            {
                Person person = Data.People.Where(x => x.FullName == EnteredName).First();
                EnteredYear = person.BirthYear.ToString();
                SexString = person.Sex;

            }
            catch (Exception e)
            {
                MessageBox.Show("nie znaleziono osoby");
            }
        }

        public ICommand SavePersonCommand 
        {
            get { return new DelegateCommand(SavePerson); }
        }

        private void SavePerson()
        {
            if(Data.People.Find(x=> x.FullName== EnteredName)==null)
                Data.People.Add(new Person(EnteredName, EnteredYear));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
