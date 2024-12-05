using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloMVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _message;

        public MainViewModel()
        {
            _message = "Hello World :-)))";

            ChangeTextCommand = new RelayCommand(o => ChangeText(), o => true);
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand ChangeTextCommand { get; set; }

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                SetField(ref _message, value);
            }
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private void ChangeText()
        {
            Message = "Changed";
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
