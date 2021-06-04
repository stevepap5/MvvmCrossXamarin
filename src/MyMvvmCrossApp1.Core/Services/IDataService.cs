using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MyMvvmCrossApp1.Core.Model;

namespace MyMvvmCrossApp1.Core.Services
{
    public interface IDataService
    {
        public ObservableCollection<Employee> GetEmployees();
    }
}
