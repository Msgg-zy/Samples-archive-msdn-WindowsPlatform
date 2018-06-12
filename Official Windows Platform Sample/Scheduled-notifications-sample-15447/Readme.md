# Scheduled notifications sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
* Windows 8.1
* Windows Phone 8.1
## Topics
* User Interface
* universal app
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:28:37
## Description

<div id="mainSection">
<p><img src="/windowsapps/site/view/file/111748/1/image.png" alt="" align="middle">
</p>
<p>This sample shows how to use scheduled and recurring tile updates and toast notifications for an app. This ability enables you to specify a precise time to deliver the notification, even if the app is not running.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p>The sample demonstrates the following scenarios: </p>
<ul>
<li>Sending a scheduled tile or toast notification, that has optional repeat notifications at a certain interval
</li><li>Querying for a tile or toast notification that is scheduled to display, and then removing the notification
</li></ul>
<p></p>
<p>For an app to send a toast notification, the developer must have declared that the app is toast-capable in its app manifest file (package.appxmanifest) as they have for this sample app. Normally, you do this using the Microsoft Visual Studio&nbsp;2013 manifest
 editor, where you find the setting in the <b>Application UI</b> tab, under the <b>
Notifications</b> section. For more info, see <a href="http://msdn.microsoft.com/library/windows/apps/hh781238">
How to opt in for toast notifications</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761464">Guidelines and checklist for scheduled notifications</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761473">How to schedule a tile notification</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465417">How to schedule a toast notification</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 Windows Store app samples</a>
</dt></dl>
<h2>Operating system requirements</h2>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8.1 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012&nbsp;R2 </dt></td>
</tr>
<tr>
<th>Phone</th>
<td><dt>Windows Phone 8.1 </dt></td>
</tr>
</tbody>
</table>
<h2>Run the sample</h2>
<p>The next steps depend on whether you just want to deploy the sample or you want to both deploy and run it.</p>
<p><b>Deploying the sample</b></p>
<ul>
<li>
<p>To deploy the built Windows version of the sample:</p>
<ol>
<li>Select <b>ScheduledNotifications.Windows</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy ScheduledNotifications.Windows</b>.
</li></ol>
</li><li>
<p>To deploy the built Windows Phone version of the sample:</p>
<ol>
<li>Select <b>ScheduledNotifications.WindowsPhone</b> in <b>Solution Explorer</b>.
</li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy ScheduledNotifications.WindowsPhone</b>.
</li></ol>
</li></ul>
<p><b>Deploying and running the sample</b></p>
<ul>
<li>
<p>To deploy and run the Windows version of the sample:</p>
<ol>
<li>Right-click <b>ScheduledNotifications.Windows</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li><li>
<p>To deploy and run the Windows Phone version of the sample:</p>
<ol>
<li>Right-click <b>ScheduledNotifications.WindowsPhone</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li><li>Give it several seconds to launch in the emulator (it takes over the full screen, so if you're still seeing your Start screen tiles, the sample hasn't launched yet), after which you can find the sample in the Apps list. Add the tile's sample to the Start
 screen so that you can see the result of the action that you've taken in the sample. A tile must be pinned to the Start screen to receive notifications.
</li></ol>
</li></ul>
<h2><a id="How_to_use_the_sample"></a><a id="how_to_use_the_sample"></a><a id="HOW_TO_USE_THE_SAMPLE"></a>How to use the sample</h2>
<p>After you schedule a tile or toast notification in the sample, switch to your Start screen to see the notification appear. Click the sample's tile to return to the sample.</p>
<p>When removing a notification in scenario 2, be sure to select the notification before you click
<b>Remove selected notifications from schedule</b>.</p>
</div>
