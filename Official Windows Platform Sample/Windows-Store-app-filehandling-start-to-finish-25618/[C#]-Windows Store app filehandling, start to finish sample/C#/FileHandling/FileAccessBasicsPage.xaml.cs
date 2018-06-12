//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using FileHandling.Common;
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

using Windows.Storage;
using System.Text;
using Windows.Storage.FileProperties;
using System.Threading.Tasks;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace FileHandling
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class FileAccessBasicsPage : Page
    {
        readonly string sampleFileName = "sample.dat";
        readonly string dateAccessedProperty = "System.DateAccessed";
        readonly string fileOwnerProperty = "System.FileOwner";

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public FileAccessBasicsPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

            AppBar bar = new AppBar();
            bar.Content = new FileHandlingAppBar();
            bar.IsOpen = true;
            bar.IsSticky = true;
            this.TopAppBar = bar;
            PageGrid.Margin = new Thickness(0, 60, 0, 0);
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        private void pageRoot_RightTapped(object sender, RightTappedRoutedEventArgs e) 
        { 
            if (this.TopAppBar.IsOpen)
                PageGrid.Margin = new Thickness(0);
            else PageGrid.Margin = 
                new Thickness(0,60,0,0); 
        }        
        
        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private async void EnumPicturesLibraryButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset output.
            Output.Children.Clear();

            // Enumerate all files in the Pictures library.
            var files = await FileHelper.GetLibraryFilesAsync(KnownFolders.PicturesLibrary);
            foreach (StorageFile file in files)
            {
                // Display each file's name.
                Output.Children.Add(UIHelper.CreateLineItemTextBlock(file.Name));
            }
        }

        private async void GetFileProperties_Click(object sender, RoutedEventArgs e)
        {
            // Reset output.
            Output.Children.Clear();

            // Enumerate all files in the Pictures library.
            var files = await FileHelper.GetLibraryFilesAsync(KnownFolders.PicturesLibrary);
            foreach (StorageFile file in files)
            {
                // Get top level file properties.
                StringBuilder fileProperties = new StringBuilder();
                fileProperties.AppendLine("File name: " + file.Name);
                fileProperties.AppendLine("File type: " + file.FileType);

                // Get basic properties.
                BasicProperties basicProperties = await file.GetBasicPropertiesAsync();
                string fileSize = string.Format("{0:n0}", basicProperties.Size);
                fileProperties.AppendLine("File size: " +  fileSize + " bytes");
                fileProperties.AppendLine("Date modified: " + basicProperties.DateModified);

                // Define property names to be retrieved.
                List<string> propertiesName = new List<string>();
                propertiesName.Add(dateAccessedProperty);
                propertiesName.Add(fileOwnerProperty);

                // Get extended properties.
                IDictionary<string, object> extraProperties = await file.Properties.RetrievePropertiesAsync(propertiesName);

                // Get LastDateAccessed property.
                var propValue = extraProperties[dateAccessedProperty];
                if (propValue != null)
                {
                    fileProperties.AppendLine("Date accessed: " + propValue);
                }

                // Get FileOwner property.
                propValue = extraProperties[fileOwnerProperty];
                if (propValue != null)
                {
                    fileProperties.AppendLine("File owner: " + propValue);
                }

                // Display file's properties.
                Output.Children.Add(UIHelper.CreateLineItemTextBlock(fileProperties.ToString()));
            }
        }

        private async Task<StorageFile> GetSampleFileAsync()
        {
            try
            {
                return await KnownFolders.PicturesLibrary.GetFileAsync(sampleFileName);
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        private async Task<StorageFile> CreateSampleFile()
        {
            return await KnownFolders.PicturesLibrary.CreateFileAsync(sampleFileName);
        }

        private async void WriteData_Click(object sender, RoutedEventArgs e)
        {
            // Reset output.
            Output.Children.Clear();

            try
            {
                // Get StorageFile object for sample file.
                StorageFile sampleFile = await GetSampleFileAsync();

                // If sample file does not exist, create it.
                if (sampleFile == null) sampleFile = await CreateSampleFile();

                // Write the current timestamp to the sample file.
                string sampleFileContents = DateTime.Now.ToString();
                await FileIO.WriteTextAsync(sampleFile, sampleFileContents);

                // Display results of write operation.
                StringBuilder output = new StringBuilder();
                output.AppendFormat("The following text was written to '" + sampleFile.Name + "': " + sampleFileContents);
                Output.Children.Add(UIHelper.CreateLineItemTextBlock(output.ToString()));
            }
            catch(Exception ex)
            {
                // If an exception is caught, display its text to the user.
                StringBuilder errorText = new StringBuilder();
                errorText.AppendFormat("Exception caught: {0}", ex.Message);
                Output.Children.Add(UIHelper.CreateLineItemTextBlock(errorText.ToString()));
            }
        }

        private async void ReadData_Click(object sender, RoutedEventArgs e)
        {
            // Reset output.
            Output.Children.Clear();

            try
            {
                // Get StorageFile object for sample file.
                StorageFile sampleFile = await GetSampleFileAsync();

                
                if (sampleFile != null)
                {
                    // Read and display sample file's contents.
                    string fileContent = await FileIO.ReadTextAsync(sampleFile);
                    StringBuilder output = new StringBuilder();
                    output.AppendFormat("The following text was read from '{0}': {1}", sampleFile.Name, fileContent);
                    Output.Children.Add(UIHelper.CreateLineItemTextBlock(output.ToString()));
                }
                else // If sample file does not exist...
                {
                    // ...let user know that it needs to be created.
                    StringBuilder output = new StringBuilder();
                    output.AppendFormat("The sample file ('{0}') does not exist. Click 'Write data to sample file' first.", sampleFileName);
                    Output.Children.Add(UIHelper.CreateLineItemTextBlock(output.ToString()));
                }
            }
            catch (Exception ex)
            {
                // If an exception is caught, display its text to the user.
                StringBuilder errorText = new StringBuilder();
                errorText.AppendFormat("Exception caught: {0}", ex.Message);
                Output.Children.Add(UIHelper.CreateLineItemTextBlock(errorText.ToString()));
            }
        }
    }
}
