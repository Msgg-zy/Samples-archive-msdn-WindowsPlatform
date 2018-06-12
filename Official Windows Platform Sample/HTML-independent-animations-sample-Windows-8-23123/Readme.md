# HTML independent animations sample (Windows 8)
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
* 2013-06-27 02:15:58
## Description

<div id="mainSection">
<p>This sample demonstrates how to use independent animation to animate elements in an app UI.
</p>
<p>Independent animation is a feature of Windows&nbsp;8 that composes animations on a thread that is separate from the thread used to draw the app's UI. Composing on a separate thread helps prevent glitches and keeps the UI thread from blocking the animations.</p>
<p>In Windows Store app using JavaScript, independent animation is used for animations and transitions of non-layout CSS properties, including 2D transforms, flat mode 3D transforms, and opacity. The system automatically targets these animations and composes
 them on a separate thread. You don't need to do any additional work or markup to get independent animation.</p>
<p></p>
<p>This sample demonstrates the following scenarios:</p>
<ul>
<li>Independent versus dependent animation </li><li>Transitioning 2D transforms and opacity </li><li>Transitioning 3D transforms and opacity </li><li>Transition events </li><li>Animation of 2D transforms and opacity </li><li>Animation of 3D transforms and opacity </li><li>Animation events </li></ul>
<p></p>
<p>You can learn more about the different Cascading Style Sheets (CSS) elements and how to use them in our reference topic on
<a href="http://msdn.microsoft.com/library/windows/apps/hh996828">Cascading Style Sheets</a>.</p>
<p>To learn more about independent animation, see <a href="http://msdn.microsoft.com/library/windows/apps/hh849087">
Animating</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh441191"><b>animations</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh996828">Cascading Style Sheets</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh453377"><b>transforms</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh453384"><b>transitions</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465037">Roadmap for apps using JavaScript</a>
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
