using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Howl3D;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CloseModalButton.Click += CloseModalButton_Click;
    }
    
    private void CloseModalButton_Click(object sender, RoutedEventArgs e)
    {
        ModalContainer.IsVisible = false;
    }
}