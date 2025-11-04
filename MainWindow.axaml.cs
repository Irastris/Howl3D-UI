using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Howl3D;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // Main window interactions
        DragDropZone.AddHandler(DragDrop.DropEvent, (sender, args) =>
        {
            ModalContainer.IsVisible = true;
        });
        
        // Modal interactions
        CloseModalButton.Click += CloseModalButton_Click;
    }
    
    private void CloseModalButton_Click(object sender, RoutedEventArgs e)
    {
        ModalContainer.IsVisible = false;
    }
}