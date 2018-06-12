# Mobile broadband account and device management sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:19:47
## Description

<div id="mainSection">
<p>This sample shows how to use the Windows&nbsp;8 Mobile Broadband API (<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>) employed by Mobile Network Operators (MNO).
</p>
<p>It demonstrates how to:</p>
<ul>
<li>use the <a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a> APIs to retrieve and display available Mobile Broadband device and network information.
</li><li>use the <a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br207353watcher"><b>MobileBroadbandAccountWatcher</b></a> APIs to watch for Mobile Broadband device and network change notifications and display the changes.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207353watcher"><b>MobileBroadbandAccountWatcher</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207353watcherstatus"><b>MobileBroadbandAccountWatcherStatus</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207361"><b>MobileBroadbandDeviceInformation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770616"><b>MobileBroadbandNetwork</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>
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
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>The Mobile Broadband account and device management sample accesses privileged APIs and requires a custom signed Mobile Broadband account metadata package that references this application or the application accessing the device in order to run. The application
 will display an <b>Access is Denied</b> error message if the metadata package doesn't explicitly grant permission to this application. For more info about how to create device metadata packages, see the
<a href="http://go.microsoft.com/fwlink/p/?LinkId=242581">Windows 8 Device Apps for Mobile Network Operators</a> white paper.</p>
</div>
