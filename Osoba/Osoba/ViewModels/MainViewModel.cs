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
        private bool authorised = false;

        private Account account = new Account();

        public string Saldo {
            get
            {
                if (authorised)
                    return account.Saldo.ToString();
                return "Prosze wpisac poprawny pin";
            }
        }

        public string Owner { get => Account.Owner; }

        private string _enteredPin;
        public string EnteredPin
        {
            get
            {
                return _enteredPin;
            }
            set
            {
                _enteredPin = value;
                if (_enteredPin == Account.Pin.ToString())
                {
                    authorised = true;
                }
                else
                {
                    authorised = false;
                }
                RaisePropertyChangedEvent("Saldo");
            }
        }


        public string EnteredWithdrawAmount { get; set; }

        public ICommand WithdrawCommand
        {
            get { return new DelegateCommand(Withdraw); }
        }
        private void Withdraw()
        {
            if (!authorised)
                return;
            try
            {
                account.Saldo -= int.Parse(EnteredWithdrawAmount);
            }
            catch (Exception e) { }
            RaisePropertyChangedEvent("Saldo");
         
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
