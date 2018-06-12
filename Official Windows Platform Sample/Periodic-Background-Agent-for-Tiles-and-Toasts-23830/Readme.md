# Periodic Background Agent for Tiles and Toasts
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Background Agent
* Live Tile
* toast notifications
## IsPublished
* True
## ModifiedDate
* 2013-07-11 05:29:47
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample shows you how to create and schedule a periodic background agent for a Windows&nbsp;Phone app. You use the background agent to set up code to execute in the background based on an interval even when the associated app is not running in the foreground.
 This sample demonstrates how to perform a periodic task to update a Tile, or a periodic task to display a Toast notification. The Tile update action and the Toast notification action are independent. You can modify the code to perform either action separately.
 Also, this sample demonstrates how to use only the periodic background agent. For more resource-intense actions, consider using a resource-intensive background agent. For more info about running code in the background, see
<a href="http://go.microsoft.com/fwlink/?LinkId=219414">Background agents for Windows Phone</a>.</p>
<p>Use the <b>LaunchForTest</b> method to invoke background agents after a specified interval, rather than on the schedule on which they would run in the app on an actual device. This way you can test your agents without waiting for them to run. It’s important
 to use this method only during development; any calls to <b>LaunchForTest</b> should be removed before publishing your app. This sample defines a constant,
<b>DEBUG_AGENT</b>, at the top of MainPage.xaml.cs and ScheduledAgent.cs that the code uses to detect whether the
<b>LaunchForTest</b> method is called. Removing the definition of this constant removes all calls to
<b>LaunchForTest</b>.</p>
<p>This sample app features the following types:</p>
<ul>
<li>
<p><span><span class="selflink">PeriodicTask</span> </span></p>
</li><li>
<p><span><span class="selflink">ScheduledActionService</span> </span></p>
</li></ul>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;8.0 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Double-click the .sln file to open the solution.</p>
</li><li>
<p>Press F5 to start debugging the app.</p>
</li><li>
<p>Use the radio buttons to select a Tile or toast periodic background agent. Then, press
<span class="ui">Start Agent</span> to run the periodic background agent. The instructions, displayed as part of the app, provide additional details.</p>
</li></ol>
</div>
</div>
</div>
