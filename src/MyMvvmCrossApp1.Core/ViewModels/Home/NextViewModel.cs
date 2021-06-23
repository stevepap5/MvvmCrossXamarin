using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MyMvvmCrossApp1.Core.Model;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class NextViewModel : BaseViewModel<Employee>
    {
        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                RaisePropertyChanged(() => Name);
                // take any additional actions here which are required when MyProperty is updated
            }
        }

        private string _Surname;
        public string Surname
        {
            get => _Surname;
            set
            {
                _Surname = value;
                RaisePropertyChanged(() => Surname);
                // take any additional actions here which are required when MyProperty is updated
            }
        }

        public override void Prepare(Employee args) {

            Name = args.Name;
            Surname = args.Surname;
           
        }
      




    }
}
