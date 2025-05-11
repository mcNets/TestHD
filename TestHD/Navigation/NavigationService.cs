using System;

namespace TestHD.Navigation;

public partial class NavigationService : ObservableObject
{
    public NavigationService()
    {
    }

    [ObservableProperty]
    public MenuItems _currentItem;

    [ObservableProperty]
    public object? _currentParametre;

    public void NavigateTo(MenuItems item, object? parametre = null)
    {
        if (CurrentItem == item)
        {
            return;
        }
            
        if (Menu.Items.Any(x => x.ItemId == item) == false)
        {
            throw new ArgumentException($"Item {item} no existeix.");
        }

        item = CanNavigate(item, parametre);

        CurrentParametre = parametre;
        CurrentItem = item;
    }

    [RelayCommand]
    public void Navigate(MenuItems item)
    {
        NavigateTo(item);
    }

    private MenuItems CanNavigate(MenuItems item, object? parametre = null)
    {
        return item;
    }
}
