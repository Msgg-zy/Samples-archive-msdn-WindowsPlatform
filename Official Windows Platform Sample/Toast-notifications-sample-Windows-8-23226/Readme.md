# Toast notifications sample (Windows 8)
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
* 2013-06-27 02:25:09
## Description

<div id="mainSection">
<p>This sample shows how to use toast notifications, which are notifications sent from an app to the user that appear as pop-up notifications in the upper right corner of the screen. A user can select the toast (touch or click) to launch the associated app.
 Toast notifications can be sent locally or through a web service. This sample demonstrates the functionality and features of local toast notifications and gives you a chance to preview all the toast template types.</p>
<p>The sample demonstrates the following scenarios: </p>
<ul>
<li>Sending a text-only toast notification </li><li>Sending a toast notification that uses an image included in the app's package
</li><li>Sending a toast notification that uses an image from the web </li><li>Changing the sound that plays when a toast notification is displayed </li><li>Responding to events that arise from the user's interaction with the toast notification: a selection, a dismissal, or a time-out
</li><li>Using long-duration toast notifications </li></ul>
<p></p>
<p>For an app to send a toast notification, the developer must have declared that the app is toast-capable in its app manifest file (package.appxmanifest) as they have for this sample app. Normally, you do this through the Microsoft Visual Studio Express&nbsp;2012
 for Windows&nbsp;8 manifest editor, where you find the setting in the <b>Application UI</b> tab, under the
<b>Notifications</b> section. For more information, see <a href="http://msdn.microsoft.com/library/windows/apps/hh781238">
How to opt in for toast notifications</a>.</p>
<p>For any functionality that involves non-local content, the developer must have declared the &quot;Internet (Client)&quot; capability in the app's manifest. In the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 manifest editor, this option is under the
<b>Capabilities</b> tab.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761494">The toast notification template catalog</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465448">Quickstart: Sending a toast notification</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh781238">How to opt in for toast notifications</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761493">Sending toast notifications (tutorials)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779727">Toast notifications (concepts)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208661"><b>Windows.UI.Notifications namespace</b></a>
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
<p>As you send the toast notifications from the different scenarios, watch for them to appear in the upper-right corner of the screen. Each toast will be dismissed by the system after a few seconds, but you can also manually dismiss them with a swipe or a click.</p>
</div>
