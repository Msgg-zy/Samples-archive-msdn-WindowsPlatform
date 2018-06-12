# Mobile broadband account and device management sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
* Mobile Broadband
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:29:10
## Description

<div id="mainSection">
<p>This sample shows how to use the Windows&nbsp;8.1 Mobile Broadband API (<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>) employed by Mobile Network Operators (MNO).
</p>
<p>It demonstrates how to:</p>
<ul>
<li>use the <a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a> APIs to retrieve and display available Mobile Broadband device and network information.
</li><li>use the <a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/hh770597"><b>MobileBroadbandAccountWatcher</b></a> APIs to watch for Mobile Broadband device and network change notifications and display the changes.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=301754">Mobile Broadband on the Windows Hardware Dev Center</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770597"><b>MobileBroadbandAccountWatcher</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770598"><b>MobileBroadbandAccountWatcherStatus</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207361"><b>MobileBroadbandDeviceInformation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770616"><b>MobileBroadbandNetwork</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Related technologies</h2>
<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>
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
</tbody>
</table>
<h2>Build the sample</h2>
<p></p>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>The Mobile Broadband account and device management sample accesses privileged APIs and requires a custom signed Mobile Broadband account metadata package that references this application or the application accessing the device in order to run. The application
 will display an <b>Access is Denied</b> error message if the metadata package doesn't explicitly grant permission to this application. For info about Mobile Broadband, see the
<a href="http://go.microsoft.com/fwlink/p/?LinkID=301754">Windows Hardware Dev Center</a>.</p>
</div>
