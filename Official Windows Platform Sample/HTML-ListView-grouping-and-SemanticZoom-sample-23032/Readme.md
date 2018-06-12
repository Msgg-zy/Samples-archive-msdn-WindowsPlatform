# HTML ListView grouping and SemanticZoom sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
## Topics
* Controls
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:08:19
## Description

<div id="mainSection">
<p>This sample demonstrates how to group items in a <a href="http://msdn.microsoft.com/library/windows/apps/br211837">
<b>ListView</b></a> and how to use it with the <a href="http://msdn.microsoft.com/library/windows/apps/br229690">
<b>SemanticZoom</b></a> control. </p>
<p>It uses the <a href="http://msdn.microsoft.com/library/windows/apps/hh700742">
<b>List.createGrouped</b></a> method to create a grouped version of a <a href="http://msdn.microsoft.com/library/windows/apps/hh700774">
<b>WinJS.Binding.List</b></a>. Then it uses two <a href="http://msdn.microsoft.com/library/windows/apps/br211837">
<b>ListView</b></a> controls and a <a href="http://msdn.microsoft.com/library/windows/apps/br229690">
<b>SemanticZoom</b></a> to create separate zoomed-out and zoomed-in views of the data.
</p>
<p>For more info about the concepts and APIs demonstrated in this sample, see these topics:
</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/hh465464">How to group items in a ListView</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465492">Quickstart: adding a SemanticZoom</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465319">Guidelines and checklist for SemanticZoom</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh770118">SemanticZoom templates</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465493">Quickstart: adding Windows Library for JavaScript controls and styles</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465496">Quickstart: adding a ListView</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465463">Item templates for grid layouts</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465478">Item templates for list layouts</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br211837"><b>ListView reference</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br229690"><b>SemanticZoom reference</b></a>
</li></ul>
<p></p>
<p>This sample is written in HTML, CSS, and JavaScript. For the XAML version, see the
<a href="http://go.microsoft.com/fwlink/p/?linkid=242399">XAML grouped data controls sample</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465464">How to group items in a ListView</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465492">Quickstart: adding a SemanticZoom</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465319">Guidelines and checklist for SemanticZoom</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465496">Quickstart: adding a ListView</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465493">Quickstart: adding Windows Library for JavaScript controls and styles</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465463">Item templates for grid layouts</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465478">Item templates for list layouts</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211837"><b>ListView reference</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229690"><b>SemanticZoom reference</b></a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br211385">Windows 8 apps using JavaScript</a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br211837"><b>ListView</b></a> ,
<a href="http://msdn.microsoft.com/library/windows/apps/br229690"><b>SemanticZoom</b></a>
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
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>To switch between the different <a href="http://msdn.microsoft.com/library/windows/apps/br229690">
<b>SemanticZoom</b></a> views: </p>
<table>
<tbody>
<tr>
<th>Input mechanism</th>
<th>Zoom out</th>
<th>Zoom in</th>
</tr>
<tr>
<td>Touch</td>
<td>Pinch out</td>
<td>Pinch in, tap</td>
</tr>
<tr>
<td>Keyboard</td>
<td>Ctrl &#43; Minus sign, Enter, Space</td>
<td>Ctrl &#43; Plus sign, Enter, Space</td>
</tr>
<tr>
<td>Mouse</td>
<td>Ctrl &#43; Rotate the mouse wheel backward </td>
<td>Ctrl &#43; Rotate the mouse wheel forward </td>
</tr>
</tbody>
</table>
</div>
