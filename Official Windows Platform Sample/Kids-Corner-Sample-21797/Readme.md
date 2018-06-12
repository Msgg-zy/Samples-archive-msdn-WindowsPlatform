# Kid's Corner Sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* settings
* Windows Phone 8
* kid's corner
## IsPublished
* True
## ModifiedDate
* 2013-04-22 10:46:24
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>The sample illustrates the use of the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.phone.applicationmodel.applicationprofile.modes(v=vs.105).aspx">
ApplicationProfile.Modes</a> property. When the app runs, it checks this property and if the value is
<span value="ApplicationProfileModes.Alternate"><span class="keyword">ApplicationProfileModes.Alternate</span></span>, then the app is running in Kid’s Corner mode. Depending on the content of your app, you may want to change its appearance or behavior when
 it is running in Kid’s Corner. Some features that you should consider disabling when running in Kid’s Corner include in-app purchases, launching the web browser, and the ad control.</p>
<p>To illustrate this feature, this sample app makes changes to the following UI elements.</p>
<ul>
<li>
<p>TextBlock – The text is updated to indicate whether the app is currently in Kid’s Corner mode.</p>
</li><li>
<p>Checkbox – This checkbox is data bound to a value in isolated storage settings. It allows you to specify whether the Button control in the UI should be disabled in Kid’s Corner. The checkbox itself is hidden when running in Kid’s Corner.</p>
</li><li>
<p>Button – This button, when enabled, simply launches a message box. If the checkbox was checked while the app was running in normal mode, the button is disabled when running in Kid’s Corner.</p>
</li></ul>
<p>For more info about this feature, see <a href="http://go.microsoft.com/fwlink/?LinkId=290922">
Kids Corner for Windows Phone</a>.</p>
<p><b>Build the sample</b> </p>
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.
</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.
</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.
</p>
</li></ol>
<h3 class="procedureSubHeading">Run the sample in normal mode</h3>
<div class="subSection">
<ul>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</li></ul>
</div>
<h3 class="procedureSubHeading">Test the sample in Kid’s Corner mode</h3>
<div class="subSection">
<ol>
<li>
<p>On the device or emulator, go to <span class="ui">Settings</span> and select
<span class="ui">Kid’s Corner</span>.</p>
</li><li>
<p>Make sure the <span class="ui">Kid’s Corne</span>r slider is set to <span class="ui">
On</span>.</p>
</li><li>
<p>Tap <span class="ui">Apps</span> and select your app from the list to allow it to be launched in Kid’s Corner. You can tap launch kid’s corner from this screen to go immediately into Kid’s Corner mode.</p>
</li><li>
<p>To enter Kid’s Corner mode without going to the settings page, engage your lock screen by pressing the power button on your phone twice or, on the emulator, press the F12 key twice. When the lock screen appears, swipe to the left to enter Kid’s Corner mode.</p>
</li><li>
<p>You can launch your app by tapping its tile or you can debug your app using Visual Studio.</p>
</li><li>
<p>To return to normal phone mode, bring up the lock screen by tapping the power button or F12 twice and then swipe up.</p>
</li></ol>
</div>
<p><b>See also</b> </p>
<ul>
<li>
<p><a href="http://go.microsoft.com/fwlink/?LinkId=290922">Kid’s Corner for Windows Phone</a>
</p>
</li></ul>
</div>
</div>
