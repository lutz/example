using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace example.ui
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}