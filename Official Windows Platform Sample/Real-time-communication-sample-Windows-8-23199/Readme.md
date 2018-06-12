# Real-time communication sample (Windows 8)
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
* 2013-06-27 02:23:31
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the low latency feature to enable real-time communication applications.
</p>
<p>Specifically, this sample contains: </p>
<ul>
<li>
<p>A simple end-to-end video call client that demonstrates the low latency mode (<a href="http://msdn.microsoft.com/library/windows/apps/hh767377"><b>msRealTime</b></a>) of the Windows Runtime capture engine and the
<a href="http://msdn.microsoft.com/library/windows/apps/hh767390"><b>video</b></a> tag. The sample uses a custom network source and a custom sink extension to send and receive captured audio and video data between two computers.
</p>
</li><li>
<p>A demonstration of the end-to-end latency of video captured using the <a href="http://msdn.microsoft.com/library/windows/apps/br226738">
<b>Media Capture</b></a> API and displayed using the <a href="http://msdn.microsoft.com/library/windows/apps/hh767390">
<b>video</b></a> tag with low latency mode enabled. Two output windows are displayed. The first shows a camera preview window of the raw output from your camera. The second is a local host client window that shows the video from the camera when compressed,
 streamed, and received over machine's loopback network interface. This window demonstrates the end-to-end latency of video captured, streamed to, and displayed by a remote client minus network latency.
</p>
</li></ul>
<p></p>
<p></p>
<p class="note"><b>Important</b>&nbsp;&nbsp; </p>
<p class="note">This sample uses the Media Extension feature of Windows&nbsp;8 to add functionality to the Microsoft Media Foundation pipeline. A Media Extension consists of a hybrid object that implements both Component Object Model (COM) and Windows Runtime
 interfaces. The COM interfaces interact with the Media Foundation pipeline. The Windows Runtime interfaces activate the component and interact with the Windows Store app.
</p>
<p class="note">In most situations, it is recommended that you use Visual C&#43;&#43; with Component Extensions (C&#43;&#43;/CX ) to interact with the Windows Runtime. But in the case of hybrid components that implement both COM and Windows Runtime interfaces, such as Media
 Extensions, this is not possible. C&#43;&#43;/CX can only create Windows Runtime objects. So, for hybrid objects it is recommended that you use
<a href="http://go.microsoft.com/fwlink/p/?linkid=243149">Windows Runtime C&#43;&#43; Template Library</a> to interact with the Windows Runtime. Be aware that Windows Runtime C&#43;&#43; Template Library has limited support for implementing COM interfaces.</p>
<p></p>
<p class="note"><b>Important</b>&nbsp;&nbsp;The binaries used by this sample have been included for proof of concept purposes only. They might have significant performance, reliability, and security issues and should not be used outside of a test environment. They
 are not licensed for use in a production environment or for use with sensitive data.</p>
<p></p>
<p></p>
<p class="note"><b>Important</b>&nbsp;&nbsp;The URL passed to the code is not validated or authenticated. The application must perform these actions.</p>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Roadmaps</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for apps using C# and Visual Basic</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700360">Roadmap for apps using C&#43;&#43;</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465037">Roadmap for apps using JavaScript</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh767284">Designing UX for apps</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465134">Adding multimedia</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452742">How to enable low-latency playback</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226738"><b>Windows.Media.Capture.MediaCapture</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241124"><b>MediaCapture</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh767377"><b>msRealTime</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br240987"><b>MediaExtensionManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701296"><b>Windows.Media.MediaProperties</b></a>
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
