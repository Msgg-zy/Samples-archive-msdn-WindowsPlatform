// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using System.Runtime.Serialization;
using System.IO;
using Windows.ApplicationModel;

class SuspensionManager
{
    static private Dictionary<string, object> sessionState_ = new Dictionary<string, object>();
    private const string filename = "_sessionState.xml";

    static public Dictionary<string, object> SessionState
    {
        get { return sessionState_; }
        
    }

    // Worker to workaround deadlocks.
    static async public Task SaveAsync()
    {
        
        await Windows.System.Threading.ThreadPool.RunAsync((wiSender) =>
        {
            SuspensionManager.SaveImplAsync().Wait();
        }, Windows.System.Threading.WorkItemPriority.Normal);
    }

    static async private Task SaveImplAsync()
    {
        // Get the output stream for the SessionState file.
        StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
        IRandomAccessStream raStream = await file.OpenAsync(FileAccessMode.ReadWrite);
        IOutputStream outStream = raStream.GetOutputStreamAt(0);

        // Serialize the Session State.
        DataContractSerializer serializer = new DataContractSerializer(typeof(Dictionary<string, object>));
        serializer.WriteObject(outStream.AsStream(), sessionState_);
        await outStream.FlushAsync();
    }

    // Worker to workaround deadlocks.
    static async public Task RestoreAsync()
    {
        await Windows.System.Threading.ThreadPool.RunAsync((wiSender) =>
        {
            SuspensionManager.RestoreImplAsync().Wait();
        }, Windows.System.Threading.WorkItemPriority.Normal);
    }

    static async private Task RestoreImplAsync()
    {
        // Get the input stream for the SessionState file.
        StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync(filename, CreationCollisionOption.OpenIfExists);
        if (file == null) return;
        IInputStream inStream = await file.OpenForReadAsync();

        // Deserialize the Session State.
        DataContractSerializer serializer = new DataContractSerializer(typeof(Dictionary<string, object>));
        sessionState_ = (Dictionary<string, object>)serializer.ReadObject(inStream.AsStream());
    }
}
