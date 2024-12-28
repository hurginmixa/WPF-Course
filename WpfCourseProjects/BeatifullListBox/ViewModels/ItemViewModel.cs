namespace BeatifullListBox.ViewModels;

public class ItemViewModel
{
    private readonly string _name;
    private readonly int _price;

    public ItemViewModel(string name, int price)
    {
        _name = name;
        _price = price;
    }

    public string Name => _name;

    public int Price => _price;
}