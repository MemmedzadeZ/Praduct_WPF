using Praduct_WPF.Models;
using System.Collections.ObjectModel;

namespace Praduct_WPF.Models;

public  class AllViewModel
{

    public ObservableCollection<Praduct>? Praducts { get; set; }

    public AllViewModel(ObservableCollection<Praduct> products)
    {
        Praducts = products;
    }


    public AllViewModel()
    {
        Praducts = new();

    }
}
