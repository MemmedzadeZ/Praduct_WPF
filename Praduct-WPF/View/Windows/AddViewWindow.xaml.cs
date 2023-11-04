using System.Windows;
using System.Windows.Controls;

namespace Praduct_WPF.View.Windows;

public partial class AddViewWindow : Window
{
    public AddViewWindow()
    {
        InitializeComponent();


        Praduct praducts = new Praduct();


        praducts.ID = 1;
        praducts.Name= "Cola";
        praducts.Prise = 2.0;

        DataGrid.Items.Add(praducts);


        Praduct manypraducts = new Praduct();

        manypraducts.ID = 2;
        manypraducts.Name = "Fanta";
        manypraducts.Prise = 2.0;

        DataGrid.Items.Add(manypraducts);
    }
}
