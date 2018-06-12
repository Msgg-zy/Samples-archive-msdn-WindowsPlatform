# Association launching sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* App model
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:05:48
## Description

<div id="mainSection">
<p>This sample shows you how to launch the user's default app for file type or a protocol. You can also learn how to enable your app to be the default app for a file type or a protocol.
</p>
<p>A Windows Store app can't set, change, or query the default apps for file types and protocols. Windows asks the user to select which app to use as the default for each file type and protocol.</p>
<p>The sample covers these key tasks:</p>
<ul>
<li>launching the default app for a file using <a href="http://msdn.microsoft.com/library/windows/apps/hh701461">
<b>LaunchFileAsync</b></a> </li><li>handling file activation through the <b>Activated</b> event </li><li>launching the default app for a protocol using <a href="http://msdn.microsoft.com/library/windows/apps/hh701476">
<b>LaunchUriAsync</b></a> </li><li>handling protocol activation through the <b>Activated</b> event </li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452684">How to handle file activation (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779669">How to handle file activation (C#/VB/C&#43;&#43;)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452686">How to handle protocol activation (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779670">How to handle protocol activation (C#/VB/C&#43;&#43;)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452687">How to launch the default app for a file (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779671">How to launch the default app for a file (C#/VB/C&#43;&#43;)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452690">How to launch the default app for a protocol (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779672">How to launch the default app for a protocol (C#/VB/C&#43;&#43;)</a>
</dt><dt><b>Guidelines</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700321">Guidelines and checklist for file types and protocols</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224716"><b>Windows.ApplicationModel.Activation.FileActivatedEventArgs</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224742"><b>Windows.ApplicationModel.Activation.ProtocolActivatedEventArgs</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701461"><b>Windows.System.Launcher.LaunchFileAsync</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701476"><b>Windows.System.Launcher.LaunchUriAsync</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701781"><b>Windows.UI.WebUI.WebUIFileActivatedEventArgs</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701885"><b>Windows.UI.WebUI.WebUIProtocolActivatedEventArgs</b></a>
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
<p></p>
<ol>
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
