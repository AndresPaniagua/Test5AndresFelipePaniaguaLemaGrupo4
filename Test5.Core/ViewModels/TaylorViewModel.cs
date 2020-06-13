using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Test5.Core.Services;

namespace Test5.Core.ViewModels
{
    public class TaylorViewModel : MvxViewModel
    {
        private readonly ITaylorService _taylor;
        private double _n;
        private double _x;
        private double _result;
        private MvxCommand _calculateCommand;

        public TaylorViewModel(ITaylorService taylor)
        {
            _taylor = taylor;
        }

        public double N
        {
            get => _n;
            set => SetProperty(ref _n, value);
        }

        public double X
        {
            get => _x;
            set => SetProperty(ref _x, value);
        }

        public double Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        private void Calculate()
        {
            if (string.IsNullOrEmpty(N.ToString()))
            {
                return;
            }

            if (string.IsNullOrEmpty(X.ToString()))
            {
                return;
            }

            Result = _taylor.Calculate(N, X);
        }

    }
}
