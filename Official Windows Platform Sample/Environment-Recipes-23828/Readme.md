# Environment Recipes
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Theme
* memory
* Resolution
* Version
* Sensors
* emulator
## IsPublished
* True
## ModifiedDate
* 2013-07-11 05:29:41
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates how you can use various APIs to discover information about the environment in which your app is running. The sample consists of a pivot page, on which each pivot item represents a recipe. The pivot item shows the name of the recipe,
 a brief description of the recipe, and the important code snippet you use in the recipe. You can tap the
<b>run recipe</b> button and see the result of the action just below this button. Each page also contains
<b>copy snippet</b> and <b>email snippet</b> buttons with which you can copy the code snippet to the clipboard or email the code snippet.</p>
<p>This sample uses the following API:</p>
<div class="caption"></div>
<div class="tableSection">
<table width="50%" cellspacing="2" cellpadding="5" frame="lhs">
<tbody>
<tr>
<th>
<p>API</p>
</th>
<th>
<p>Use</p>
</th>
</tr>
<tr>
<td>
<p><b>App.Current.Host.Content.ScaleFactor</b> </p>
</td>
<td>
<p>To determine the screen resolution of the phone on which the app is running.</p>
</td>
</tr>
<tr>
<td>
<p><b>Application.Current.Resources</b> </p>
</td>
<td>
<p>To find out whether the user has the phone set to use the light or dark theme.</p>
</td>
</tr>
<tr>
<td>
<p><b>Microsoft.Devices.Environment.DeviceType</b> </p>
</td>
<td>
<p>To check whether the app is running in an emulator.</p>
</td>
</tr>
<tr>
<td>
<p><b>Microsoft.Devices.Sensors</b> </p>
</td>
<td>
<p>To find out what sensors are available on the phone.</p>
</td>
</tr>
<tr>
<td>
<p><b>Windows.Phone.ApplicationModel.ApplicationProfile.Modes</b> </p>
</td>
<td>
<p>To check whether the app is running in Kid’s Corner mode.</p>
</td>
</tr>
<tr>
<td>
<p><b>Microsoft.Phone.Info.DeviceStatus.ApplicationMemoryUsageLimit</b> </p>
</td>
<td>
<p>To check whether the app is running on a low-memory device.</p>
</td>
</tr>
<tr>
<td>
<p><b>System. Environment.OSVersion.Version</b> </p>
</td>
<td>
<p>To determine the OS version of the phone on which the app is running.</p>
</td>
</tr>
</tbody>
</table>
</div>
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
<p><b>Run the sample</b> </p>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</div>
<h1 class="heading"><span><a name="seeAlsoToggle">See Also</span> </h1>
<div id="seeAlsoSection" class="section" name="collapseableSection" style="">
<h4 class="subHeading">Other Resources</h4>
<div class="seeAlsoStyle"></a><a href="http://msdn.microsoft.com/library/windowsphone/develop/ff402563(v=vs.105).aspx">Windows Phone Emulator</a>
</div>
<div class="seeAlsoStyle"><a href="http://msdn.microsoft.com/library/windowsphone/develop/hh855081(v=vs.105).aspx">Developing apps for lower-memory phones</a>
</div>
<div class="seeAlsoStyle"><a href="http://msdn.microsoft.com/library/windowsphone/develop/hh202968(v=vs.105).aspx">Sensors for Windows Phone</a>
</div>
<div class="seeAlsoStyle"><a href="http://msdn.microsoft.com/library/windowsphone/develop/dn168931(v=vs.105).aspx">Kid's Corner for Windows Phone 8</a>
</div>
<div class="seeAlsoStyle"><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206974(v=vs.105).aspx">Multi-resolution apps for Windows Phone 8</a>
</div>
<div class="seeAlsoStyle"><a href="http://msdn.microsoft.com/library/windowsphone/develop/ff769552(v=vs.105).aspx#BKMK_ThemeVisibilityAndOpacity">Theme Visibility and opacity</a>
</div>
</div>
</div>
