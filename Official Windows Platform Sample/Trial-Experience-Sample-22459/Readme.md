# Trial Experience Sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Licensing
* trial mode
## IsPublished
* True
## ModifiedDate
* 2013-06-05 04:49:21
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>When you submit an app to the Windows Phone Store, you have the option to offer a free trial of your app. There will be only one version of your app in the Store, but you can design your app to adapt its functionality based on the installed license. A user
 can tap <span class="ui">Try</span> to install your app free of charge. Along with the app, a trial license will be installed. The user can tap
<span class="ui">Buy</span> to install a Full mode license. This sample shows you how to design your app to detect its license state when the app launches, and to detect changes to the license state while running. It can adapt features and functions accordingly.
 You could, for example, decide to limit functionality in trial mode, or you could turn off ads in full mode.</p>
<p>Follow the steps below to take the sample on a test drive.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.</p>
</li><li>
<p>Confirm that the solution configuration drop-down list is set to <span class="ui">
Debug</span> and then, on the <span class="ui">Build</span> menu, click <span class="ui">
Build Solution</span>. (Ctrl&#43;Shift&#43;B)</p>
</li><li>
<p>On the <span class="ui">Debug</span> menu, click <span class="ui">Start Without Debugging</span>. (Ctrl&#43;F5)</p>
<p>The first panorama page (<span class="ui">Instructions</span>) reports that you are running a debug build of the sample. There also are instructions on customizing the way that your app responds when the user taps
<span class="ui">Buy</span>, and a report of the current settings. The second page (<span class="ui">About</span>) contains a label that indicates the current license mode (Trial mode) along with a
<span class="ui">Buy</span> button. An <span class="ui">About</span> page is a good place to put a
<span class="ui">Buy</span> button, but you also could put one on your main page if you like. The sample has a
<span class="ui">Buy</span> button and a menu item on the app bar.</p>
</li><li>
<p>Tap either one of the <span class="ui">Buy</span> buttons, or the menu item. This launches the Store details page for the sample. However, the sample doesn't exist in the Store (and neither will your app until it is published) so in the sample a dialog
 is expected, which displays “Error code: 805a0194”.</p>
</li><li>
<p>Tap <span class="ui">Close</span> or <span class="ui">Back</span> to simulate completing the app purchase. The label on the
<span class="ui">About</span> page now indicates a Full mode license. The <span class="ui">
Buy</span> buttons and the menu item are disabled. In your app you could choose to remove them completely; perhaps you’d replace them with a message that thanks the user for purchasing your app.</p>
<p>Building and running the sample in release configuration doesn’t simulate the purchase experience, and it will not help you test the logic to check for a license in your own app. However, you will eventually publish a release build to the Store.</p>
</li></ol>
</div>
<p><b>What’s in the project?</b> </p>
<p>The sample has two parts. The first and most important piece is the <span value="TrialExperienceHelper">
<span class="keyword">TrialExperienceHelper</span></span> class (<span value="SdkHelper"><span class="keyword">SdkHelper</span></span> namespace), which you'll find in the SdkHelper folder. You can use that class without modification in your own projects.
 The following sections describe this class, how it works, and how you can use it in your own app.</p>
<p>The second part of this sample is the example UI and view model that makes up the rest of the sample. The view model is in the ViewModel folder and it shows you how you can customize your use of the general-purpose
<span value="TrialExperienceHelper"><span class="keyword">TrialExperienceHelper</span></span> class for a particular app. The view model in this sample has string properties, in addition to
<span value="BuyCommand"><span class="keyword">BuyCommand</span></span>, to which the UI binds. Your app won't need those string properties, but you might find
<span value="BuyCommand"><span class="keyword">BuyCommand</span></span> useful. We’ve also included (in the SdkHelper folder) standard, generally useful, helper implementations of
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/system.componentmodel.inotifypropertychanged(v=vs.105).aspx">
INotifyPropertyChanged</a> and <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/system.windows.input.icommand(v=vs.105).aspx">
ICommand</a>.</p>
<p><b>Which licensing APIs are used?</b> </p>
<p>The <span value="TrialExperienceHelper"><span class="keyword">TrialExperienceHelper</span></span> class determines license state by querying the
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.licenseinformation.isactive.aspx">
IsActive</a> and <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.licenseinformation.istrial.aspx">
IsTrial</a> properties of the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.licenseinformation.aspx">
LicenseInformation</a> class. It does this only when necessary – once when the app launches, and then each time the app resumes. It caches the results, so your app code can query the
<span value="TrialExperienceHelper.LicenseMode"><span class="keyword">TrialExperienceHelper.LicenseMode</span></span> property as often as you like without the app paying a performance penalty. The
<span value="LicenseMode"><span class="keyword">LicenseMode</span></span> property returns a value from the
<span value="LicenseModes"><span class="keyword">LicenseModes</span></span> enum (Full, MissingOrRevoked, or Trial) so that your app code needs to check only a single value. There’s also a convenient Boolean
<span value="IsFull"><span class="keyword">IsFull</span></span> property. Whenever the license mode has changed, or it is likely to have changed,
<span value="TrialExperienceHelper"><span class="keyword">TrialExperienceHelper</span></span> raises its
<span value="LicenseChanged"><span class="keyword">LicenseChanged</span></span> event and your app code can handle that event to query
<span value="LicenseMode"><span class="keyword">LicenseMode</span></span> or <span value="IsFull">
<span class="keyword">IsFull</span></span> again. Then, your app can control the availability of features, ads, and your
<span class="ui">Buy</span> UI as needed.</p>
<p><b>Using TrialExperienceHelper in debug and release configurations</b> </p>
<p>When you develop your app, you can write your own view model to consume <span value="TrialExperienceHelper">
<span class="keyword">TrialExperienceHelper</span></span>, or you can consume the helper using the code-behind. The code you use to consume the helper will be the same in debug configuration and in release configuration. In debug configuration, the helper
 simulates a purchase so you can verify that your code responds to its <span value="LicenseChanged">
<span class="keyword">LicenseChanged</span></span> event and property values correctly. The app you eventually publish to the Store will be a release build. In that build, the helper's simulation is removed by conditional compilation, but the helper functions
 the same in relation to your code. The difference is that the helper will access the app’s actual license info at that time.</p>
<p><b>See also</b> </p>
<ul>
<li>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/hh286402(v=vs.105).aspx">How to implement a trial experience in a Windows Phone app</a>
</p>
</li></ul>
</div>
</div>
