using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HelloMVVM;

namespace DynamicCheckboxList.ViewModels
{
    internal class DynamicCheckboxListVM
    {
        public DynamicCheckboxListVM()
        {
            Items = new ObservableCollection<CheckBoxItemVM>
            {
                new CheckBoxItemVM {Name = "Option 1", IsChecked = false},
                new CheckBoxItemVM {Name = "Option 2", IsChecked = true},
                new CheckBoxItemVM {Name = "Option 3", IsChecked = false}
            };

            MainCheckBox = new CheckBoxItemVM() {Name = "Main", IsChecked = false};

            AddCommand = new RelayCommand(o => AddNewItem(), o => true);
        }

        public ObservableCollection<CheckBoxItemVM> Items { get; }

        public CheckBoxItemVM MainCheckBox { get; }

        public ICommand AddCommand { get; set; }

        private void AddNewItem()
        {
            int itemsCount = Items.Count;
            Items.Add(new CheckBoxItemVM() {Name = $"Option {itemsCount + 1}", IsChecked = itemsCount % 2 == 0});
        }
    }
}
