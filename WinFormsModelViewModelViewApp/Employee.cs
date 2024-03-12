using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsModelViewModelViewApp
{
    internal class Employee : INotifyPropertyChanged
    {
        string name = "";
        int age;

        public string Name
        {
            set 
            { 
                if(name != value)
                {
                    name = value;
                    //OnPropertyChanged(nameof(Employee.Name));
                    //OnPropertyChanged("Name");
                    OnPropertyChanged();
                }
            }
            get => name;
        }

        public int Age 
        { 
            set
            {
                if(age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
            get => age;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
