namespace TestHD.Core;

public record MenuItemModel(
    MenuItems ItemId, 
    string Icon, 
    ImageSource BackgroundImage,
    string Caption, 
    bool CaptionVisible);
