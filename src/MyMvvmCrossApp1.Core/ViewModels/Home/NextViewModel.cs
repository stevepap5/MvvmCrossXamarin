using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using MyMvvmCrossApp1.Core.Model;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class NextViewModel : BaseViewModel<Employee>
    {
        public override void Prepare(Employee parameter) => throw new NotImplementedException();
    }
}
