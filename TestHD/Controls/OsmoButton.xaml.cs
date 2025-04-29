namespace TestHD.Controls;

public sealed partial class OsmoButton : UserControl
{
    private readonly static Brush _brushBoto = (Brush)Application.Current.Resources["OsmoGradientBlau"];

    public OsmoButton()
    {
        InitializeComponent();
    }

    public event EventHandler<OsmoButtonEventArgs>? OnClick;

    public Symbol Symbol
    {
        get { return (Symbol)GetValue(SimbolProperty); }
        set { SetValue(SimbolProperty, value); }
    }

    public static readonly DependencyProperty SimbolProperty =
        DependencyProperty.Register(nameof(Symbol), typeof(Symbol), typeof(OsmoButton), new PropertyMetadata(Symbol.Emoji2));

    public bool SymbolVisible
    {
        get { return (bool)GetValue(SimbolVisibleProperty); }
        set { SetValue(SimbolVisibleProperty, value); }
    }

    public static readonly DependencyProperty SimbolVisibleProperty =
        DependencyProperty.Register(nameof(SymbolVisible), typeof(bool), typeof(OsmoButton), new PropertyMetadata(true));

    public string Text
    {
        get { return (string)GetValue(TexteProperty); }
        set { SetValue(TexteProperty, value); }
    }

    public static readonly DependencyProperty TexteProperty =
        DependencyProperty.Register(nameof(Text), typeof(string), typeof(OsmoButton), new PropertyMetadata(string.Empty));

    public bool TextVisible
    {
        get { return (bool)GetValue(TexteVisibleProperty); }
        set { SetValue(TexteVisibleProperty, value); }
    }

    public static readonly DependencyProperty TexteVisibleProperty =
        DependencyProperty.Register(nameof(TextVisible), typeof(bool), typeof(OsmoButton), new PropertyMetadata(true));

    public ICommand? Command
    {
        get { return (ICommand)GetValue(CommandProperty); }
        set { SetValue(CommandProperty, value); }
    }

    public static readonly DependencyProperty CommandProperty =
        DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(OsmoButton), new PropertyMetadata(null));

    public object? CommandParameter
    {
        get { return (object)GetValue(CommandParameterProperty); }
        set { SetValue(CommandParameterProperty, value); }
    }

    public static readonly DependencyProperty CommandParameterProperty =
        DependencyProperty.Register(nameof(CommandParameter), typeof(object), typeof(OsmoButton), new PropertyMetadata(null));

    private void OsmoButtonClick(object sender, RoutedEventArgs args)
    {
        OnClick?.Invoke(sender, new OsmoButtonEventArgs(this, args));

        if (Command != null && Command.CanExecute(CommandParameter))
        {
            Command.Execute(CommandParameter);
        }
    }
}
