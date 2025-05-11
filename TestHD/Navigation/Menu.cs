using System;

namespace TestHD.Navigation;

public static class Menu
{
    public static List<MenuItemModel> Items { get; } = new()
    {
        new MenuItemModel(
            MenuItems.Page1,
            "\uE80F",
            (ImageSource)Application.Current.Resources["ImgBckg1"],
            "Caption Page 1",
            true),
        new MenuItemModel(
            MenuItems.Page2,
            "\uE713",
            (ImageSource)Application.Current.Resources["ImgBckg2"],
            string.Empty,
            false),
    };
}
