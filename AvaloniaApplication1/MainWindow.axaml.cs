using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (bar.Orientation == Orientation.Horizontal)
        {
            bar.Orientation = Orientation.Vertical;
        }
        else
        {
            bar.Orientation = Orientation.Horizontal;
        }
    }
}