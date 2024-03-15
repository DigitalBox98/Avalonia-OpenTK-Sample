using Avalonia_Sample.Views;
using Avalonia;
using Avalonia.Media;
using System;
using ReactiveUI;

namespace Avalonia_Sample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private Color _selectedColor = new Color(255, 128, 128, 0);

    public Color SelectedColor
    {
        get => _selectedColor;
        set => this.RaiseAndSetIfChanged(ref _selectedColor, value);
    }

}
