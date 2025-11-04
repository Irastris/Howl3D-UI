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
        DragDropZoneBtn.Click += DragDropZone_Click;
        
        // Modal interactions
        CloseModalButton.Click += CloseModalButton_Click;
    }
    
    private void DragDropZone_Click(object sender, RoutedEventArgs e)
    {
        ModalContainer.IsVisible = true;
    }
    
    private void CloseModalButton_Click(object sender, RoutedEventArgs e)
    {
        ModalContainer.IsVisible = false;
    }
}