# Background Audio Player Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* background audio
## IsPublished
* True
## ModifiedDate
* 2013-06-26 02:10:19
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates how to implement an <a href="http://go.microsoft.com/fwlink/?LinkId=219687">
AudioPlayerAgent</a> that allows audio to play even when the app is not in the foreground. This background agent will run under the lock screen where the user can control the audio using the universal volume control (UVC). Also see
<a href="http://go.microsoft.com/fwlink/?LinkId=219686">How to: Play Background Audio for Windows Phone</a>.</p>
<p>You need to install the Windows&nbsp;Phone&nbsp;SDK to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkId=259204">Windows Phone Dev Center</a>.</p>
<p>For more information about developing background audio apps, see <a href="http://go.microsoft.com/fwlink/?LinkId=306180">
Background audio overview</a>.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>After unzipping the sample, double-click the <span value=".sln"><span class="keyword">.sln</span></span> file to open the solution. Run the app by selecting the
<span class="ui">Debug | Start Debugging</span> menu command.</p>
</li><li>
<p>The app launches, and the MainPage.xaml page is displayed. This page implements a simple media player interface using buttons that resemble typical playback icons, but are implemented with simple characters.</p>
</li><li>
<p>Tap the <span class="ui">&gt;</span> button to start playing a track.</p>
</li><li>
<p>Tap the <span class="ui">&gt;|</span> button to skip to the next track.</p>
</li><li>
<p>Tap the <span class="ui">|&lt;</span> button to skip to the previous track.</p>
</li><li>
<p>With a track playing, tap the Windows&nbsp;Phone <span class="ui">Start</span> button to go to the Start screen. You should continue to hear the audio track playing in the background.</p>
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
