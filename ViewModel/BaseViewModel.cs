using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Retail_Operation_POS.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertiChanged(string nameProperty)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
        }
    }
}
