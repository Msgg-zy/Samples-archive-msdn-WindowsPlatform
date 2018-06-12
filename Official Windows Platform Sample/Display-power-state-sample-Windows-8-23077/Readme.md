# Display power state sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Devices and sensors
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:12:09
## Description

<div id="mainSection">
<p>This sample shows you how to use the Windows Runtime display request API to keep the display on during extended periods without user activity.
</p>
<p>To conserve power and extend battery life, Windows reduces power to the computer if it does not detect any user activity for a period of time. Depending on power settings the user chooses, the display might first be dimmed, then turned off as the computer
 enters a low-power sleep state. The display request API enables a Windows Store app to keep the display on after it would otherwise be dimmed or turned off.
</p>
<p>This sample demonstrates the following tasks:</p>
<ul>
<li>Creating a display request </li><li>Activating a display request </li><li>Deactivating a display request </li><li>Tracking the number of active display requests </li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241816"><b>Windows.System.Display.DisplayRequest</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>To see the effect of this sample on the display, you might want to modify your system's power settings so it enters standby-connected or sleep in a shorter amount of time. Run the sample and activate the request. The display should remain on even after the
 standby-connected/sleep timeout elapses.</p>
</div>
