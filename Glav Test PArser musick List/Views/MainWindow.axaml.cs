using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Glav_Test_PArser_musick_List.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
