// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

//
// Scenario4.xaml.h
// Declaration of the Scenario4 class
//

#pragma once
#include "Scenario4.g.h"

namespace SDKSample
{
	namespace Flyouts
	{
		/// <summary>
		/// An empty page that can be used on its own or navigated to within a Frame.
		/// </summary>
		public ref class Scenario4 sealed
		{
		public:
			Scenario4();

		private:
			void button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
			void flyout_Opening(Platform::Object^ sender, Platform::Object^ e);
			int viewCount;
		};
	}
}
