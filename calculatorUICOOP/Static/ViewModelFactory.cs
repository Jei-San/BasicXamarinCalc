﻿using calculatorUICOOP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace calculatorUICOOP.Static
{
    /// <summary>
    /// Factory that provides the Views with their ViewModels.
    /// This allows for constructor-based dependency injection if needed.
    /// </summary>
    public static class ViewModelFactory
    {
        public static MainPageViewModel GetMainPageViewModel() =>
            new MainPageViewModel();

        public static TViewModel GetViewModel<TViewModel>() where TViewModel : INotifyPropertyChanged, new() =>
            new TViewModel();
    }
}
