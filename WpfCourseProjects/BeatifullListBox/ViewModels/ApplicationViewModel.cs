using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using HelloMVVM;

namespace BeatifullListBox.ViewModels
{
    public class ApplicationViewModel
    {
        private readonly ObservableCollection<ItemViewModel> _items;

        public ApplicationViewModel()
        {
            _items = new ObservableCollection<ItemViewModel>();

            AddItemCoomCommand = new RelayCommand(s => AddItem(), s => true);
        }

        private void AddItem()
        {
            var itemViewModel = new ItemViewModel($"Name_{_items.Count + 1}", (_items.Count + 1) * 10);
            _items.Add(itemViewModel);
        }

        public ICommand AddItemCoomCommand { get; set; }

        public ObservableCollection<ItemViewModel> Items => _items;
    }
}
