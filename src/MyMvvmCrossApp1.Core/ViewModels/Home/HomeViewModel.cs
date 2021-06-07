using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MyMvvmCrossApp1.Core.Model;
using Xamarin.Forms;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        public Command EmployeeCommand;
        public ObservableCollection<Employee> EmployeesList { get; set; }

        public HomeViewModel() {

            EmployeesList = new ObservableCollection<Employee>(App.DataService.GetEmployees());
            EmployeeCommand = new Command<Employee>(GetEmployeeCommand);
        }

        private void GetEmployeeCommand(Employee employee) => throw new NotImplementedException();
    }
}
