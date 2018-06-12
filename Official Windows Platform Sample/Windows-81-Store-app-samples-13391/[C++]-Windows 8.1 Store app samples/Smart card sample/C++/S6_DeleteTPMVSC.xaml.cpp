//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
//*********************************************************

//
// Scenario3.xaml.cpp
// Implementation of the Scenario3 class
//

#include "pch.h"
#include "S6_DeleteTPMVSC.xaml.h"
#include "MainPage.xaml.h"
#include "ChallengeResponseAlgorithm.h"

using namespace SDKSample;
using namespace SDKSample::Common;
using namespace SDKSample::SmartCardSample;

using namespace concurrency; 
using namespace Platform; 

using namespace Windows::Devices::SmartCards;
using namespace Windows::Foundation;
using namespace Windows::Storage::Streams;
using namespace Windows::Security::Cryptography;
using namespace Windows::Security::Cryptography::Core;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;

Scenario6::Scenario6()
{
    InitializeComponent();
}

void Scenario6::Delete_Click(Platform::Object^ sender,
                             Windows::UI::Xaml::RoutedEventArgs^ e)
{
    if (MainPage::Current->SmartCardReaderDeviceId == nullptr)
    {
        MainPage::Current->NotifyUser(
            "Use Scenario One to create a TPM virtual smart card.",
            NotifyType::ErrorMessage);
        return;
    }

    Button^ b = dynamic_cast<Button^>(sender);
    b->IsEnabled = false;

    MainPage::Current->NotifyUser("Deleting TPM virtual smart card...",
                                  NotifyType::StatusMessage);

    create_task(MainPage::Current->GetSmartCard()).then(
    [=](task<SmartCard^> getSmartCardTask)
    {
        SmartCard^ card = getSmartCardTask.get();

        // The following block is not directly related to TPM virtual smart
        // card deletion, but rather demonstrates how to handle CardRemoved
        // events by registering an event handler with a SmartCardReader
        // object.  Since we are using a TPM virtual smart card in this
        // case, the card cannot actually be added to or removed from
        // the reader, but a CardRemoved event will fire when the reader
        // is deleted.
        {
            // Event handlers will only fire during the lifetime of the
            // particular SmartCardReader instance they are attached to;
            // thus, we must maintain a handle to the reader as an instance
            // member.
            this->reader = card->Reader;

            // Here we use the += operator to add our event handler to the
            // collection of CardRemoved handlers for the reader.  Note that
            // if you want to do any UI operations in the handler, or in
            // general use any non-agile objects, you must specify a
            // callback context of CallbackContext::Same in the
            // TypedEventHandler's constructor, as below.  Otherwise you
            // may receive exceptions due to RPC_E_WRONG_THREAD.
            this->reader->CardRemoved += ref new
                TypedEventHandler<SmartCardReader ^, CardRemovedEventArgs ^>(
                    this,
                    &Scenario6::HandleCardRemoved,
                    CallbackContext::Same);
        }

        return
            SmartCardProvisioning::RequestVirtualSmartCardDeletionAsync(card);
    }).then(
    [=](task<bool> deleteSmartCardTask)
    {
        try
        {
            bool result = deleteSmartCardTask.get();
            if(result)
            {
                MainPage::Current->NotifyUser(
                    "TPM virtual smart card deletion completed.",
                    NotifyType::StatusMessage);
                MainPage::Current->SmartCardReaderDeviceId = nullptr;
            }
            else
            {
                MainPage::Current->NotifyUser(
                    "TPM virtual smart card deletion was canceled by user.",
                    NotifyType::StatusMessage);
            }
        }
        catch(Exception^ ex)
        {
            MainPage::Current->NotifyUser(
                "TPM virtual smart card deletion failed with exception: " +
                ex->ToString(),
                NotifyType::ErrorMessage);
        }

        b->IsEnabled = true;
    });
}

void Scenario6::HandleCardRemoved(SmartCardReader ^evtReader,
                                  CardRemovedEventArgs^ args)
{
    MainPage::Current->NotifyUser(
        "Card removed from reader " + evtReader->Name + ".",
        NotifyType::StatusMessage);
}
