/* 
    Copyright (c) 2011 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
  
*/
using System;
using System.Windows.Input;
using Microsoft.Phone.Controls;

namespace sdkKeyboardIndexCS
{
    public partial class Keyboard8 : PhoneApplicationPage
    {
        public Keyboard8()
        {
            InitializeComponent();

            //You can set the Keyboard Input Scope by using either XAML or code.
            //See the XAML file for the XAML version.
            //The code version is below.

            InputScope scope = new InputScope();
            InputScopeName name = new InputScopeName();

            name.NameValue = InputScopeNameValue.Digits;  //<--Here
            scope.Names.Add(name);

            txtK8.InputScope = scope;

            //To create keyboard 8, you can use any of the following Input Scopes.
            //--------------------------------------------------------------------
            // CurrencyAmount
            // DateDay
            // DateMonth
            // DateYear
            // Digits
            // Number
            // NumberFullWidth
            // NumericPassword
            // TimeHour
            // TimeMinorSec
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //This code opens up the keyboard when you navigate to the page.
            txtK8.UpdateLayout();
            txtK8.Focus();
        }
    }
}
