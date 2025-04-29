using Microsoft.UI.Xaml.Media.Animation;

namespace TestHD;

public sealed partial class SplashScreenControl : UserControl
{
    public SplashScreenControl(Action onTerminated)
    {
        InitializeComponent();

        _onTerminated = onTerminated;
        
        OsmoTextBlock.Text = "OSMO";
        Loaded += SplashPageControl_Loaded;
    }

    private Action? _onTerminated;

    private void SplashPageControl_Loaded(object sender, RoutedEventArgs e)
    {
        StartAnimation();
        Loaded -= SplashPageControl_Loaded;
    }

    private void StartAnimation()
    {
        OsmoTextBlock.Text = "UNO";

        var scaleXAnimation = new DoubleAnimation
        {
            From = 1,
            To = 4, // Adjust the maximum size as needed
            Duration = new Duration(TimeSpan.FromSeconds(1.5)) // Adjust the duration as needed
        };

        var scaleYAnimation = new DoubleAnimation
        {
            From = 1,
            To = 4, // Adjust the maximum size as needed
            Duration = new Duration(TimeSpan.FromSeconds(1.5)) // Adjust the duration as needed
        };

        var storyboard = new Storyboard();
        storyboard.Children.Add(scaleXAnimation);
        storyboard.Children.Add(scaleYAnimation);

        Storyboard.SetTarget(scaleXAnimation, ScaleTransform);
        Storyboard.SetTargetProperty(scaleXAnimation, "ScaleX");

        Storyboard.SetTarget(scaleYAnimation, ScaleTransform);
        Storyboard.SetTargetProperty(scaleYAnimation, "ScaleY");

        storyboard.Completed += (_, _) => _onTerminated?.Invoke();

        storyboard.Begin();
    }
}

