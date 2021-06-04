using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MyMvvmCrossApp1.Core.Model;

namespace MyMvvmCrossApp1.Core.Repository
{
   public static class Repository
    {
        public static ObservableCollection<Employee> EmployeesList;

        static Repository() {
            if (EmployeesList==null){

                EmployeesList = new ObservableCollection<Employee>()
                { new Employee {Name="Stefanos",Surname="Papamichail" } };
            }
        }
    }
}
