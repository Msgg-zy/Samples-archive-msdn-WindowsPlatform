# Background Agent Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.1
## Topics
* multitasking
* background agents
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:12:56
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample shows how to create and schedule a background agent for a Windows&nbsp;Phone app. The background agent enables the execution of code in the background even when the associated app is not running in the foreground. For more info about running code
 in the background, see <a href="http://go.microsoft.com/fwlink/?LinkId=219414">Scheduled Tasks Overview for Windows Phone</a>.</p>
<p>The <b>LaunchForTest</b> method is used to invoke background agents after a specified interval, rather than on the schedule on which they would run on an actual device. This allows you to test your agents without having to wait for them to run. This method
 should only be used during development. Any calls to <b>LaunchForTest</b> should be removed before publishing your app. This sample defines a constant,
<b>DEBUG_AGENT</b>, at the top of MainPage.xaml.cs and ScheduledAgent.cs that the code uses to decide if the
<b>LaunchForTest</b> method is called. Removing the definition of this constant will remove all calls to<b> LaunchForTest</b>.</p>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Double-click the .sln file to open the solution.</p>
</li><li>
<p>Press F5 to start debugging the app.</p>
</li><li>
<p>Use the check boxes to enable the periodic and/or resource-intensive background agents.
</p>
</li></ol>
</div>
</div>
</div>
