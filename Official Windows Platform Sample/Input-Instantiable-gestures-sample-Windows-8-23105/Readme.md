# Input: Instantiable gestures sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* Devices and sensors
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:13:53
## Description

<div id="mainSection">
<p>This sample is a basic jigsaw puzzle app (four colored tiles on a rectangular background) that demonstrates three scenarios for Windows Store apps using JavaScript: static association of
<a href="http://msdn.microsoft.com/library/windows/apps/hh968249"><b>MSGesture</b></a> objects with UI elements, dynamic association of
<b>MSGesture</b> objects with UI elements, and mouse wheel input. </p>
<p>In the first scenario, a <a href="http://msdn.microsoft.com/library/windows/apps/hh968249">
<b>MSGesture</b></a> object is created for each UI element and enables independent interaction with any combination of tiles and container.
</p>
<p>The second scenario, while visually similar, adds two important levels of complexity. First, to improve scalability, the
<a href="http://msdn.microsoft.com/library/windows/apps/hh968249"><b>MSGesture</b></a> objects for the square tiles are created and freed dynamically. Second, support for two modes of interaction: one where only the container can be manipulated, and another
 where only a combination of the colored squares can be manipulated. </p>
<p>The third scenario shows how to handle mouse wheel input.</p>
<p>Specifically, this sample covers the following:</p>
<ul>
<li>Listening for <a href="http://msdn.microsoft.com/library/windows/apps/hh465891">
<b>onmspointerdown</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/hh465912">
<b>onmspointerup</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/hh868516">
<b>onmspointercancel</b></a> events. </li><li>Creating and statically assigning an <a href="http://msdn.microsoft.com/library/windows/apps/hh968249">
<b>MSGesture</b></a> object to each UI element. </li><li>Creating and dynamically assigning <a href="http://msdn.microsoft.com/library/windows/apps/hh968249">
<b>MSGesture</b></a> objects to UI elements, as needed. </li><li>Listening for and managing gestures and manipulations through <a href="http://msdn.microsoft.com/library/windows/apps/hh968249">
<b>MSGesture</b></a>&nbsp;Document Object Model (DOM) events. </li><li>Listening for <a href="http://msdn.microsoft.com/library/windows/apps/hh466023">
<b>onmousewheel</b></a> events and processing mouse wheel data as pointer input for gesture support.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700412">Responding to user interaction</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh673557">Pointer and gesture events</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/">Getting started with apps</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh767307">Document Object Model (DOM) Events</a>
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
</div>
