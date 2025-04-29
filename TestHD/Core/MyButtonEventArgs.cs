namespace TestHD.Core;

public class MyButtonEventArgs : EventArgs
{
    public MyButtonEventArgs(MyButton button, RoutedEventArgs args)
    {
        Button = button;
        Args = args;
    }

    public MyButton Button { get; }
    public RoutedEventArgs Args { get; }
}
