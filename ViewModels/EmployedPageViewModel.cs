using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.ViewModels
{
    public partial class EmployedPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _empName;

        [ICommand]
        public void Save()
        {

        }


    }


}
