# Remote Desktop app container client sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* Networking
## IsPublished
* True
## ModifiedDate
* 2014-01-29 12:32:06
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/hh994983">
Remote Desktop app container client</a> objects in a Windows Store app. Specifically, this sample demonstrates how to perform the following operations:</p>
<ul>
<li>Create the <a href="http://msdn.microsoft.com/library/windows/apps/hh994940">
<b>RemoteDesktopClient</b></a> object. </li><li>Connect to a remote machine using the <a href="http://msdn.microsoft.com/library/windows/apps/hh994953">
<b>SetRdpProperty</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/hh994955">
<b>Connect</b></a> methods. </li><li>Handle event notifications by implementing the following event handlers:
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/hh994963"><b>OnConnecting</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh994962"><b>OnConnected</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh994968"><b>OnLoginCompleted</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh994965"><b>OnDialogDisplaying</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh994964"><b>OnDialogDismissed</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh994966"><b>OnDisconnected</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh994969"><b>OnNetworkStatusChanged</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh994971"><b>OnStatusChanged</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh994970"><b>OnRemoteDesktopSizeChanged</b></a>
</li></ul>
</li><li>Send actions to a remote machine using the <a href="http://msdn.microsoft.com/library/windows/apps/hh994943">
<b>ExecuteRemoteAction</b></a> method. </li><li>Get a snapshot of a remote machine using the <a href="http://msdn.microsoft.com/library/windows/apps/hh994944">
<b>GetSnapshot</b></a> method. </li></ul>
<p></p>
<p>This sample is written in JavaScript and requires some experience with JavaScript and HTML programming.</p>
<p>The Windows Samples Gallery contains a variety of code samples that demonstrate the use of various new programming features for Remote Desktop that are available to apps in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples are provided
 as compressed ZIP files that contain a Microsoft Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Related technologies</h2>
<a href="http://msdn.microsoft.com/library/windows/apps/hh994983">Remote Desktop app container client</a>
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
<p>To run the app in the debugger, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
