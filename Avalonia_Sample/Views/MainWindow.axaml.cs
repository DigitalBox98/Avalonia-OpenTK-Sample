
using Avalonia.Controls;
using Avalonia_Sample.ViewModels;

namespace Avalonia_Sample.Views;

public partial class MainWindow : Window
{

    public MainWindowViewModel ViewModel { get; } = new MainWindowViewModel();

    public MainWindow()
    {
        InitializeComponent();
        DataContext = ViewModel;
    }


}