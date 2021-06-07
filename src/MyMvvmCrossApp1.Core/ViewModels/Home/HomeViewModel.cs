using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MyMvvmCrossApp1.Core.Model;
using Xamarin.Forms;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {

        private readonly IMvxNavigationService _navigationService;

        public Command EmployeeCommand;
        public Command GoCommand;
        public ObservableCollection<Employee> EmployeesList { get; set; }
        public MvxAsyncCommand NavigateCommand { get; private set; }

        public HomeViewModel(IMvxNavigationService navigationService) {

            _navigationService = navigationService;

            EmployeesList = new ObservableCollection<Employee>(App.DataService.GetEmployees());
            //    GoCommand = new Command<Employee>(GoNextCommand);
            NavigateCommand = new MvxAsyncCommand(
                () => _navigationService.Navigate<NextViewModel>());
        }

        private async void GoNextCommandAsync(Employee obj) {

            await _navigationService.Navigate<NextViewModel>();
        }

        public async void GetEmployeeCommandAsync(Employee employee) {

            await _navigationService.Navigate<NextViewModel, Employee>(new Employee());
        }
    }
}
