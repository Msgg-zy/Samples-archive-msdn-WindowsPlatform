# CoreDispatcher event processing for DirectX games sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* DirectX
* Windows Runtime
## Topics
* Graphics
* App model
## IsPublished
* True
## ModifiedDate
* 2013-12-12 11:38:04
## Description

<div id="mainSection">
<p>This sample demonstrates the best practices for dispatching <a href="http://msdn.microsoft.com/library/windows/apps/br208225">
<b>CoreWindow</b></a> events in different DirectX game loop scenarios. </p>
<p>Specifically, this game provides a simple jigsaw puzzle where the player is required to snap the puzzle pieces into the game board. Pieces can be selected and placed, or dragged and dropped onto the game board.</p>
<p>It covers the behaviors of the following <a href="http://msdn.microsoft.com/library/windows/apps/br208215">
<b>CoreDispatcher::ProcessEvents</b></a> flags when the API is called from inside a game loop:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br208217"><b>CoreProcessEventsOption.ProcessOneAndAllPending</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br208217"><b>CoreProcessEventsOption.ProcessAllIfPresent</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br208217"><b>CoreProcessEventsOption.ProcessUntilQuit</b></a>
</li></ul>
<p></p>
<p>Four projects are included in this sample which correspond to different ways in which a game can be categorized:
</p>
<ul>
<li>The game only needs to redraw the screen in response to user input (render on demand)
</li><li>The game mostly only needs to redraw the screen in response to user input, but occasionally wants to animate game content independent of input events (transient animations)
</li><li>The game is always animating and must redraw the screen as fast as the display allows (continuous animation)
</li><li>The game is always animating and must also have the fastest response to user input possible (multithreaded input and presentation)
</li></ul>
<p></p>
<p>This sample is written in C&#43;&#43; and requires basic experience with graphics programming concepts.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208215"><b>CoreDispatcher::ProcessEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>CoreWindow</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj554502">Get started with DirectX</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/ff476080">Direct3D 11 graphics</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
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
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<p>You can also open any of the individual .vcxproj files for each of the lessons, such as Lesson5.Components\Lesson5.Components.vcxproj, and build them separately from the solution.</p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
