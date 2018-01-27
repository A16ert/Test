using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ViewModel : INotifyPropertyChanged
    {
        private double _value;

        public double Value {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

            
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string Name)
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs(Name) );
        }
        

    }
}
