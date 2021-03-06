﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ListsOfPersons.ViewModels;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ListsOfPersons.Views.ContentDailogs
{
    public sealed partial class PersonContentDialog : ContentDialog
    {
        public PersonContentDialog()
        {
            this.InitializeComponent();
            ViewModel = new PersonContentDialogViewModel();
            DataContext = ViewModel;
        }

        public PersonContentDialogViewModel ViewModel { get; set; }
    }
}
