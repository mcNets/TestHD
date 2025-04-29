namespace TestHD.Core;

public class OsmoButtonEventArgs : EventArgs
{
    public OsmoButtonEventArgs(OsmoButton button, RoutedEventArgs args)
    {
        Button = button;
        Args = args;
    }

    public OsmoButton Button { get; }
    public RoutedEventArgs Args { get; }
}
