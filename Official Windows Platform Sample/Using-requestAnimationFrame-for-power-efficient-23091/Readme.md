# Using requestAnimationFrame for power efficient animations sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:12:54
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/hh920765">
requestAnimationFrame</a> method in an HTML5 Canvas to build smooth and power efficient animations in your Windows Store app using JavaScript.
</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh920765">requestAnimationFrame</a> API is the best way to do non-declarative animations in a power-efficient and smooth way. This API is similar to the
<a href="http://msdn.microsoft.com/library/windows/apps/hh453490"><b>setTimeout</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/hh453487"><b>setInterval</b></a> APIs that developers use today, except that it notifies the application when it needs to update the screen, and only when it needs to update the screen. It keeps Windows
 Store app using JavaScript applications perfectly aligned with the painting of the window, and uses only the necessary amount of graphics resources (which is ideal for low power settings and Connected Standby devices). This API will take page visibility and
 the display refresh rate into account to determine how many frames per second to allocate to the animations.</p>
<p>Until now, HTML and JavaScript did not provide an efficient means for web developers to schedule graphics timers for animations. Animations are commonly overdrawing – causing choppier animations and increased power consumption. Further efficiency is lost
 as animations are drawn without knowledge of whether the page is visible to the user. For example, most animations use a timer period of less than 16.7ms to draw animations, even though most monitors can only display at 60Hz frequency or 16.7ms periods.
</p>
<p>For example, using <a href="http://msdn.microsoft.com/library/windows/apps/hh453490">
<b>setTimeout</b></a> with a 10ms period results in every third callback not being painted, as another callback occurs prior to the display refresh. This overdrawing results in not only choppy animations, as every third frame being lost, but an overall increased
 resource consumption. </p>
<p>In this example, the clock is animated using HTML5 Canvas and the <a href="http://msdn.microsoft.com/library/windows/apps/hh920765">
requestAnimationFrame</a> API. </p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh920765">requestAnimationFrame</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
