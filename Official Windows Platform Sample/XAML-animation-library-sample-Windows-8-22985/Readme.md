# XAML animation library sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
* Windows Runtime
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:05:13
## Description

<div id="mainSection">
<p>This sample demonstrates how to animate elements and apply easing functions to the animations to achieve various effects.
</p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Performing basic animations using the <a href="http://msdn.microsoft.com/library/windows/apps/br210490">
<b>Storyboard</b></a> class. This scenario uses a <a href="http://msdn.microsoft.com/library/windows/apps/br243136">
<b>DoubleAnimation</b></a> to animate the <a href="http://msdn.microsoft.com/library/windows/apps/hh759771">
<b>Canvas.Left</b></a> property of an element. </li><li>Performing more complex animations. This scenario adds a <a href="http://msdn.microsoft.com/library/windows/apps/br243066">
<b>ColorAnimation</b></a> to the previous animation so that the <a href="http://msdn.microsoft.com/library/windows/apps/br243378">
<b>Fill</b></a> property of a <a href="http://msdn.microsoft.com/library/windows/apps/br243377">
<b>Shape</b></a> changes while it moves. This scenario also demonstrates the use of
<a href="http://msdn.microsoft.com/library/windows/apps/br243066usingkeyframes"><b>ColorAnimationUsingKeyFrames</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br243136usingkeyframes"><b>DoubleAnimationUsingKeyFrames</b></a> to achieve the same effect but with discrete values in the animations.
</li><li>Creating realistic motion effects by setting the <b>EasingFunction</b> and <b>
EasingMode</b> properties of the various animation classes. </li></ul>
<p></p>
<p>This sample is written in XAML. For the HTML version, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=242402">
Using the Animation Library animations sample (HTML)</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Roadmaps</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for C# and Visual Basic</a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243232"><b>Windows.UI.Xaml.Media.Animation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br210490"><b>Storyboard</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243136"><b>DoubleAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243066"><b>ColorAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243066usingkeyframes"><b>ColorAnimationUsingKeyFrames</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243136usingkeyframes"><b>DoubleAnimationUsingKeyFrames</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br210277"><b>EasingMode</b></a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452703">QuickStart: Animating your UI</a>
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
