using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.Microcharts.Example
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            this.DataContext = new MainWindowViewModel();
        }
    }
}