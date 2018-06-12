# Raw notifications sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:22:09
## Description

<div id="mainSection">
<p>This sample shows how to use raw notification, which are push notifications with no associated UI that performs a background task for the app. For example, a magazine app can download the latest issue in the background so that it is ready when the user subsequently
 switches to the app. </p>
<p>The sample demonstrates the following actions: </p>
<ul>
<li>Requesting access from the user to be allowed to run in the background </li><li>Opening a channel URI through which the raw notifications will be sent </li><li>Registering a background task for the raw notification </li><li>Receiving a raw notification when your app is running and visible </li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231476">Push and periodic notifications sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 Windows Store app samples</a>
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
<ol>
<li>Start Visual Studio&nbsp;2012 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<h3><a id="How_to_use_the_sample"></a><a id="how_to_use_the_sample"></a><a id="HOW_TO_USE_THE_SAMPLE"></a>How to use the sample</h3>
<p>For an app to be capable of performing background tasks, it must declare those background tasks in its app manifest file (package.appxmanifest). For a raw notification, you must declare the &quot;Push Notification&quot; background task as this sample has done. In
 Visual Studio Express&nbsp;2012 for Windows&nbsp;8, this value is set in the <b>Declarations</b> page of the manifest editor, which sets the
<a href="http://msdn.microsoft.com/library/windows/apps/br211421"><b>BackgroundTasks</b></a> element in the package.appxmanifest file.</p>
<p>For raw notifications to work, your app tile must be able to receive notifications. Tile notifications can be disabled by a user for a single app or for all apps, or by a system administrator by using group policy. For more information, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh465439">How to check whether a tile can be updated</a>.</p>
<p>An app is allowed to ask a user to grant background task access only one time. When you first run this sample and select
<b>Open a channel and register background task</b>, a dialog box appears. Regardless of the answer you choose, because of the &quot;ask only one time&quot; rule, you will not see this dialog again unless you uninstall and reinstall the sample.</p>
<p>When you choose <b>Allow</b> from the dialog box, the sample app is added to the lock screen because the two capabilities are set as a pair. However, because a raw notification does not include UI, you will not see a badge or tile text associated with a
 raw notification on the lock screen. </p>
<p>The channel URI that is returned is sent to your web server as it would be with any push notification, and any subsequent actions taken by the server to send a raw notification using that channel URI, are also no different than other push notifications.
 For more information, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=231476">
Push and periodic notifications</a> sample.</p>
</div>
