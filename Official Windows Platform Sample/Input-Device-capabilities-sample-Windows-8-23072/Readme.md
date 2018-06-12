# Input: Device capabilities sample (Windows 8)
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
* 2013-06-27 02:11:51
## Description

<div id="mainSection">
<p>This sample demonstrates how to query the input devices that are connected to the user's device and support the input modes (pointer, touch, pen/stylus, mouse, keyboard) of Windows Store apps. Once the input devices have been identified, their capabilities
 and attributes are then retrieved. </p>
<p>This sample is provided as a Windows Store app using JavaScript, Windows Store app using C#, Windows Store app using Visual Basic, and Windows Store app using C&#43;&#43;.</p>
<p>Specifically, this sample covers using the Windows Runtime&nbsp;<a href="http://msdn.microsoft.com/library/windows/apps/br225648"><b>Windows.Devices.Input</b></a>&nbsp;APIs to:</p>
<ul>
<li>Detect all connected touch digitizers, pen/stylus digitizers, mouse devices, and keyboard devices.
</li><li>Identify which devices report pointer data by retrieving a collection of <a href="http://msdn.microsoft.com/library/windows/apps/br225633">
<b>PointerDevice</b></a> objects through <a href="http://msdn.microsoft.com/library/windows/apps/br225633_getpointerdevices">
<b>GetPointerDevices</b></a>. </li><li>Get the capabilities and attributes reported by each <a href="http://msdn.microsoft.com/library/windows/apps/br225633">
<b>PointerDevice</b></a>. </li><li>Get the capabilities and attributes reported by each device for a specific input mode:
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br225623"><b>KeyboardCapabilities</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225626"><b>MouseCapabilities</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225644"><b>TouchCapabilities</b></a>
</li></ul>
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/">Getting started with apps</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465379">Quickstart: Identifying input devices (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh868250">Quickstart: Identifying input devices (VB/C#/C&#43;&#43;)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700412">Responding to user interaction (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465397">Responding to user interaction (VB/C#/C&#43;&#43;)</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br225648"><b>Windows.Devices.Input</b></a>
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
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
