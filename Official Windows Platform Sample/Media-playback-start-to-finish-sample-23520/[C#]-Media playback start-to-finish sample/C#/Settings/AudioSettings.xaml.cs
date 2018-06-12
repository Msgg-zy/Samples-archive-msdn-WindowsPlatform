//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
//*********************************************************
using MediaPlaybackStartToFinish.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.System.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MediaPlaybackStartToFinish
{
    public sealed partial class AudioSettings : SettingsFlyout
    {    
        public AudioSettings()
        {
            this.InitializeComponent();          
        }
    }
}
