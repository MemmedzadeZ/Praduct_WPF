using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Praduct_WPF.View.Pages;


public partial class MainViewPagee : Page
{

    private int count;

    public int Count
    {
        get { return count; }
        set
        {
            count = value;
            OnPropertyChanged();


        }
    }
    public MainViewPagee()
    {
        InitializeComponent();
        Count = 0;

        DataContext = this;
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        
        Count++;

    }

    public void OnPropertyChanged([CallerMemberName] string? parametrName = null)
                   => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(parametrName));

    private void Add_Click(object sender, RoutedEventArgs e)
    {

    }
}
