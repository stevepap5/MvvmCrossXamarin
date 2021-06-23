using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Behaviors;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MyMvvmCrossApp1.Core.Model;
using MyMvvmCrossApp1.Core.Services;
using Xamarin.Forms;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {

        private readonly  IMvxNavigationService _navigationService;

        public ObservableCollection<Employee> EmployeesList { get; set; }
        public MvxCommand NavigateCommand { get; private set; }

        public HomeViewModel(IMvxNavigationService navigationService) {

            _navigationService = navigationService;

            EmployeesList = new ObservableCollection<Employee>(App.DataService.GetEmployees());

            NavigateCommand = new MvxCommand(() => _navigationService.
            Navigate<NextViewModel,Employee>(new Employee()));
        }
        public EventToCommandBehavior eventNameProperty=new EventToCommandBehavior();
     
    }
}
