using System;
using System.Collections.ObjectModel;

namespace Praduct_WPF.Models
{
    public class ObservableCollection
    {
        public static implicit operator ObservableCollection<object>(ObservableCollection v)
        {
            throw new NotImplementedException();
        }
    }
}