# Backstack Navigation Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* app navigation
## IsPublished
* True
## ModifiedDate
* 2013-06-26 01:58:33
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates how to visualize, inspect, and modify the navigation history, or back stack, of an app. This is useful for apps that want to modify the default navigation experience of their app to provide the optimal user experience for their customers.
 It also demonstrates how navigation from a pinned page affects the navigation history. This sample uses the new
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/microsoft.phone.controls.phoneapplicationframe.backstack(v=vs.105).aspx">
BackStack</a> property and the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/microsoft.phone.controls.phoneapplicationframe.removebackentry(v=vs.105).aspx">
RemoveBackEntry</a> method available in Windows&nbsp;Phone OS&nbsp;7.1. To develop this app step-by-step, see
<a href="http://msdn.microsoft.com/library/windowsphone/develop/hh394012(v=vs.105).aspx">
How to navigate using the back stack for Windows Phone</a>.</p>
<p>You will need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>After unzipping the sample, double-click the <span value=".sln"><span class="keyword">.sln</span></span> file to open the solution. Run the app by selecting the
<span class="ui">Debug | Start Debugging</span> menu command.</p>
</li><li>
<p>The app launches, and the MainPage.xaml page is displayed. The bottom half of the screen displays the back stack visualization. There is nothing in the navigation history at this point, so the list is empty. The current page is shown as
<span class="ui">[/MainPage.xaml]</span>.</p>
</li><li>
<p>Tap the <span class="ui">Next Page</span> button. Observe that the page changes to
<span class="ui">page 1</span> and the back stack list now contains <span class="ui">
/MainPage.xaml</span>. </p>
</li><li>
<p>Tap the <span class="ui">Next Page</span> button again. The current page is <span class="ui">
page 2</span>. The back stack now contains two entries: <span class="ui">/Page1.xaml</span> and
<span class="ui">/MainPage.xaml</span>. As a stack, it shows the newest entry at the top and the oldest entry at the bottom.
</p>
</li><li>
<p>Tap the <span class="ui">Pop Last</span> button. The <span class="ui">/Page1.xaml</span> entry is removed from the back stack list.
</p>
</li><li>
<p>Tap the hardware <span class="ui">Back</span> button on your device. The page
<span class="ui">main page</span> is displayed and the back stack is empty. This happened because we removed
<span class="ui">/Page1.xaml</span> from the back stack in the previous step, thus changing the back navigation from
<span class="ui">Page 2 -&gt; Page1 -&gt; MainPage</span> to <span class="ui">
Page2 -&gt; MainPage</span>.</p>
</li><li>
<p>Tap the <span class="ui">Next Page</span> button on <span class="ui">main page</span>. The page
<span class="ui">page 1</span> is displayed. The back stack has one entry, <span class="ui">
/MainPage.xaml</span>.</p>
</li><li>
<p>Tap the <span class="ui">Next Page</span> button on <span class="ui">page 1</span>. The page
<span class="ui">page 2</span> is now displayed. The back stack has two entries,
<span class="ui">/Page1.xaml</span> and <span class="ui">/MainPage.xaml</span>.</p>
</li><li>
<p>Tap <span class="ui">Pin To Start</span> on <span class="ui">page 2</span>.</p>
</li><li>
<p>A Tile named <span class="ui">page 2</span> is created on the Start screen of the device.
</p>
</li><li>
<p>Tap the Tile you created in the preceding step. The app is launched, and <span class="ui">
page 2</span> is displayed. Notice also that the back stack is empty. If you tap the
<span class="ui">Back</span> button on the device, the app terminates. Observe that
<span class="ui">page 2</span> was pinned to the Start screen on the device. The Tile was then tapped, the app launched, and Page2 is displayed. The back stack is now empty.
</p>
</li></ol>
</div>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>This sample is packaged as a Windows&nbsp;Phone&nbsp;7.5 project. It can be converted to a Windows&nbsp;Phone&nbsp;8 project, by changing the target Windows Phone OS version of the project. To create a Windows&nbsp;Phone&nbsp;8 project, you must be running the Windows&nbsp;Phone&nbsp;SDK&nbsp;8.0 on
 Visual Studio 2012. You can download the latest version of the SDK from <a href="http://dev.windowsphone.com/downloadsdk">
http://dev.windowsphone.com/downloadsdk</a>.</p>
<p>To convert the sample to a Windows&nbsp;Phone&nbsp;8 project:</p>
<ol>
<li>
<p>Double-click the <span class="ui">.sln</span> file to open the solution in Visual Studio.</p>
</li><li>
<p>Right-click the project in the <span class="ui">Solution Explorer</span> and select
<span class="ui">Properties</span>. This opens the <span class="ui">Project Properties</span> window.</p>
</li><li>
<p>In the <span class="ui">Application</span> tab of the Project Properties window, select
<span class="ui">Windows Phone OS 8.0</span> from the <span class="ui">Target Windows Phone OS Version</span> dropdown. A dialog will appear asking if you want to upgrade this project to Windows Phone OS 8.0.</p>
</li><li>
<p>Select <span class="ui">Yes</span> to upgrade the project.</p>
</li></ol>
</td>
</tr>
</tbody>
</table>
</div>
</div>
</div>
