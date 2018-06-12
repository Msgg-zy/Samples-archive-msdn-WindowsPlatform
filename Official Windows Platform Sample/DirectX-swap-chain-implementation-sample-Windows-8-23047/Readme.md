# DirectX swap chain implementation sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* DirectX
## Topics
* Audio and video
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:10:04
## Description

<div id="mainSection">
<p>This sample shows how to receive <a href="http://msdn.microsoft.com/library/windows/apps/br208225">
<b>CoreWindow</b></a> events in a native application and how to connect a DirectX swap chain to the application view.
</p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Creating a view provider that implements <a href="http://msdn.microsoft.com/library/windows/apps/hh700478">
<b>IFrameworkView</b></a> and then running it </li><li>Obtaining a <a href="http://msdn.microsoft.com/library/windows/apps/br208225">
<b>CoreWindow</b></a> with an attached DirectX swap chain from the view provider </li><li>Configuring the base input events for the <a href="http://msdn.microsoft.com/library/windows/apps/br208225">
<b>CoreWindow</b></a> </li></ul>
<p></p>
<p>For more info about the concepts and APIs demonstrated in this sample, see these topics:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br229580">Create an app using DirectX</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dd370987">Direct2D graphics</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ff476080">Direct3D 11 graphics</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/bb205169">DXGI reference</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225016"><b>Windows.ApplicationMode.Core.CoreApplication</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225016view"><b>Windows.ApplicationMode.Core.CoreApplicationView</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh700478"><b>Windows.ApplicationMode.Core.IFrameworkView</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh700478source"><b>Windows.ApplicationMode.Core.IFrameworkViewSource</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>Windows.UI.Core.CoreWindow</b></a>
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br208225">CoreWindow</a>
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
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
