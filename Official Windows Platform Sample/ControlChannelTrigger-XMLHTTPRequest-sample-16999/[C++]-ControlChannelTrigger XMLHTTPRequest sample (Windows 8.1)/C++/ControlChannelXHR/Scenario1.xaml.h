//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
//*********************************************************

//
// Scenario1.xaml.h
// Declaration of the Scenario1 class
//

#pragma once
#include "Scenario1.g.h"

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace XHRTransportHelper;
using namespace Windows::UI::Core;

namespace SDKSample
{
    namespace ControlChannelXHR
    {
        public enum class connectionStates
        {
            notConnected = 0,
            connecting = 1,
            connected = 2,
        };

        /// <summary>
        /// An empty page that can be used on its own or navigated to within a Frame.
        /// </summary>
        [Windows::Foundation::Metadata::WebHostHidden]
        public ref class Scenario1 sealed
        {
        public:
            Scenario1();
            String^ GetUrl();
            String^ GetPostData();
            void ClientInit();

        protected:
            virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;

        private:
            void CanaryButton_Click(Object^ sender, RoutedEventArgs^ e);
            void ConnectButton_Click(Object^ sender, RoutedEventArgs^ e);
            void RegisterNetworkChangeTask();
            static connectionStates connectionState;
        internal:
            bool lockScreenAdded;
            CommModule^ commModule;
        };
    }
}
