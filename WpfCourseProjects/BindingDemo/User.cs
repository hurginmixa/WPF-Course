using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingDemo
{
    internal class User : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set => SetField(ref _lastName, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            
            OnPropertyChanged(propertyName);
            
            return true;
        }
    }
}
