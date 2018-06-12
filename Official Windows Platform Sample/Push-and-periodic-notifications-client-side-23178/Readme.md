# Push and periodic notifications client-side sample (Windows 8)
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
* 2013-06-27 02:22:06
## Description

<div id="mainSection">
<p>This sample shows how a client app can register and listen for push notifications that are sent from a web server. Push notifications can be used to update a badge or a tile, raise a toast notification, or launch a background task. Periodic notifications
 act in the other direction, polling a web server for tile or badge content at a fixed time interval.
</p>
<p>The sample demonstrates the following actions: </p>
<ul>
<li>Requesting a channel URI through which the push notifications will be sent </li><li>Renewing a channel </li><li>Listening for push notifications from the web server </li><li>Polling a web server for updated tile content </li><li>Polling a web server for updated badge content </li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465407">How to authenticate with the Windows Push Notification Service (WNS)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465412">How to request, create, and save a notification channel</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761476">How to set up periodic notifications for tiles</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761476">How to set up periodic notifications for badges</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465450">How to update a badge through push notifications</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465450">Quickstart: Sending a tile push notification</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761487">Quickstart: Sending a toast push notification</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241553">Raw notifications sample</a>
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
<p>For any functionality that involves non-local content, the developer must have declared the &quot;Internet (Client)&quot; capability in the app's manifest. In the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 manifest editor, this option is under the
<b>Capabilities</b> tab.</p>
<p>To run this sample, you need access to a web server that can store your notification channel, send push notifications to your client, and provide tile and badge update content when polled.</p>
<p>For tile and badge push notifications to work, your app tile must be able to receive notifications. Tile notifications can be disabled by a user for a single app or for all apps, or by a system administrator through group policy.</p>
</div>
