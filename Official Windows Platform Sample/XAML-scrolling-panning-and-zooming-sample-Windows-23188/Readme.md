# XAML scrolling, panning, and zooming sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
* Windows Runtime
## Topics
* Controls
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:22:49
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br209527">
<b>ScrollViewer</b></a> control to pan and zoom. </p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Using panning and scrolling to enable users to reach content that won't otherwise fit within a view. You can use the
<a href="http://msdn.microsoft.com/library/windows/apps/br209527_horizontalscrollmode">
<b>HorizontalScrollMode</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br209527_verticalscrollmode">
<b>VerticalScrollMode</b></a> properties to restrict panning to the horizontal or vertical axis or enable panning in any direction. You can use the
<a href="http://msdn.microsoft.com/library/windows/apps/br209527_ishorizontalrailenabled">
<b>IsHorizontalRailEnabled</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br209527_isverticalrailenabled">
<b>IsVerticalRailEnabled</b></a> properties to lock the motion to the horizontal or vertical axis after panning has started. You can use the
<a href="http://msdn.microsoft.com/library/windows/apps/br209527_horizontalscrollbarvisibility">
<b>HorizontalScrollBarVisibility</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br209527_verticalscrollbarvisibility">
<b>VerticalScrollBarVisibility</b></a> to show, hide, or disable scroll bars. </li><li>Using snap points to help users reach key locations in your content. You can use mandatory snap points to automatically continue panning until a snap point is reached, or you can use proximity snap points to continue panning only when the current location
 is close to a snap point. You can specify the snap point type by setting the <a href="http://msdn.microsoft.com/library/windows/apps/br209527_horizontalsnappointstype">
<b>HorizontalSnapPointsType</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br209527_verticalsnappointstype">
<b>VerticalSnapPointsType</b></a> properties. </li><li>Enabling users to resize or zoom your content by setting the <a href="http://msdn.microsoft.com/library/windows/apps/br209527_zoommode">
<b>ZoomMode</b></a> property. You can also set the minimum and maximum zoom levels through the
<a href="http://msdn.microsoft.com/library/windows/apps/br209527_minzoomfactor"><b>MinZoomFactor</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br209527_maxzoomfactor"><b>MaxZoomFactor</b></a> properties.
</li></ul>
<p>This sample is written in XAML. For the HTML version, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=242394">
Scrolling, panning, and zooming sample (HTML)</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Roadmaps</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for C# and Visual Basic</a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527"><b>ScrollViewer</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_horizontalscrollmode"><b>HorizontalScrollMode</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_verticalscrollmode"><b>VerticalScrollMode</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_ishorizontalrailenabled"><b>IsHorizontalRailEnabled</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_isverticalrailenabled"><b>IsVerticalRailEnabled</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_horizontalscrollbarvisibility"><b>HorizontalScrollBarVisibility</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_verticalscrollbarvisibility"><b>VerticalScrollBarVisibility</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_horizontalsnappointstype"><b>HorizontalSnapPointsType</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_verticalsnappointstype"><b>VerticalSnapPointsType</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_zoommode"><b>ZoomMode</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_minzoomfactor"><b>MinZoomFactor</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209527_maxzoomfactor"><b>MaxZoomFactor</b></a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211380">Create an app using C# or Visual Basic</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465307">Guidelines for optical zoom and resizing</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465310">Guidelines for panning</a>
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
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
