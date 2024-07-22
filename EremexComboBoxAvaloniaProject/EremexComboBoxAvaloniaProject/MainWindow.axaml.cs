using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Eremex.AvaloniaUI.Controls.Common;

namespace EremexComboBoxAvaloniaProject;

public partial class MainWindow : MxWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }
}

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    [property: Required()]
    private string selectedSimpleObject;
    [ObservableProperty] private ObservableCollection<string> simpleObjects;
    [ObservableProperty] 
    [property: Required()]
    private string selectedComplexObject;
    [ObservableProperty] private ObservableCollection<ComplexObject> complexObjects;

    public MainViewModel()
    {
        SimpleObjects = new ObservableCollection<string>()
        {
            "One",
            "Two",
            "Three"
        };
        ComplexObjects = new ObservableCollection<ComplexObject>()
        {
            new() { Text = "One", Value = 1 },
            new() { Text = "Two", Value = 2 },
            new() { Text = "Three", Value = 3 },
        };
    }
}


public partial class ComplexObject : ViewModelBase
{
    [ObservableProperty] private string text;
    [ObservableProperty] private int value;
}