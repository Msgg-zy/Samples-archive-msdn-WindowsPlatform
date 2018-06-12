# Background task sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* App model
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:05:59
## Description

<div id="mainSection">
<p>This sample shows you how to create and register background tasks using the Windows Runtime background task API.
</p>
<p>A background task is triggered by a system or time event and can be constrained by one or more conditions. When a background task is triggered, its associated handler runs and performs the work of the background task. A background task can run even when
 the app that registered the background task is suspended.</p>
<p>This sample demonstrates the following:</p>
<ul>
<li>Creating and registering background tasks written in C&#43;&#43;, C#, JavaScript, or Visual Basic.
</li><li>Creating a background task that is triggered by a system event. </li><li>Requesting the user's permission to add the app to the lock screen. </li><li>Creating a background task that is triggered by a time trigger. </li><li>Adding a condition that constrains the background task to run only when the condition is in effect.
</li><li>Reporting background task progress and completion to the app. </li><li>Using a deferral object to include asynchronous code in your background task.
</li><li>Handling the cancellation of a background task. </li><li>Initializing background task progress and completion handlers when the app is launched.
</li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b></b></dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh868260">Displaying tiles on the lock screen</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770837">Launching, resuming, and multitasking</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh977053">Managing background tasks</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh977056">Supporting your app with background tasks</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>API reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224847"><b>Windows.ApplicationModel.Background (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701740"><b>Windows.UI.WebUI.WebUIBackgroundTaskInstance (Windows Store apps using JavaScript and HTML)</b></a>
</dt></dl>
<h3>Operating system requirements</h3>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012 </dt></td>
</tr>
</tbody>
</table>
<h3>Build the sample</h3>
<p>This sample provides four solutions: one for background tasks written in C&#43;&#43;, one for background tasks written in C#, one for background tasks written in JavaScript, and one for background tasks written in Visual Basic. Each solution consists of two projects:
 a foreground application that creates and registers the background task, and a background component containing the code that runs when the background task is triggered.
</p>
<ol>
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>To trigger the background tasks associated with the <code>TimeZoneChange</code> event:</p>
<ol>
<li>Change date and time settings. </li><li>Click <b>Change time zone...</b> </li><li>Select a time zone that has a UTC offset different from the currently selected time zone.
</li><li>Click <b>OK</b>. </li></ol>
<p>Background tasks associated with the <code>TimeTrigger</code> event will only fire if the app is currently on the lock screen. There are two ways to accomplish this.</p>
<p>Accept the initial request to add the BackgroundTaskSample app to the lock screen:</p>
<ol>
<li>Launch the BackgroundTaskSample app for the first time. </li><li>Register the TimeTrigger event. </li><li>Accept the request to add the BackgroundTaskSample app to the lock screen. </li></ol>
<p>Add the BackgroundTaskSample app to the lock screen manually:</p>
<ol>
<li>From the Start screen, go to <b>Settings</b> &gt; <b>Customize your lock screen</b>.
</li><li>Choose the BackgroundTaskSample app for the lock screen. </li><li>Launch the BackgroundTaskSample app and register the TimeTrigger event. </li></ol>
<p class="note"><b>Note</b>&nbsp;&nbsp;The minimum delay for creating TimeTrigger events is 15 minutes. The first timer event, however, might not occur until 15 minutes after it is expected to expire (30 minutes after the app registers the event).</p>
<h3><a id="Read_more"></a><a id="read_more"></a><a id="READ_MORE"></a>Read more</h3>
<p>See the following topics for step-by-step information about using background tasks:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/hh977055">Quickstart: Create and register a background task</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh977058">How to respond to system events with background tasks</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh977057">How to set conditions for running a background task</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh977052">How to handle a cancelled background task</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh977054">How to monitor background task progress and completion</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh977059">How to run a background task on a timer</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/jj883699">How to use maintenance triggers</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh977049">How to declare background tasks in the application manifest</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh977051">Guidelines and checklists for background tasks</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/jj542416"><b>How to debug a background task</b></a>
</li></ul>
</div>
