//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Reflection;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace FileHandling
{
    public sealed partial class FileHandlingAppBar : UserControl
    {
        public FileHandlingAppBar()
        {
            this.InitializeComponent();
        }
        private void PageButton_Click(object sender, RoutedEventArgs e)
        {
            Button pageButton = sender as Button; 
            string pageName = pageButton.Tag.ToString();

            var frame = Window.Current.Content as Frame;
            frame.Navigate(Type.GetType("FileHandling." + pageName), null);
        }
    }
}
