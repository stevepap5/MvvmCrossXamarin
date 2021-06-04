using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MyMvvmCrossApp1.Core.Model;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {

        public ObservableCollection<Employee> EmployeesList { get; set; }

        public HomeViewModel() {

            EmployeesList = new ObservableCollection<Employee>(Repository.
                Repository.EmployeesList);
        }
    }
}
