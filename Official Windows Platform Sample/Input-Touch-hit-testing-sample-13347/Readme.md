# Input: Touch hit testing sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* Devices and sensors
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:32:26
## Description

<div id="mainSection">
<p>This sample uses a polygon shapes puzzle to demonstrate how to handle pointer input, implement custom hit testing for touch input, and process manipulations in a Windows Store app using C&#43;&#43; and DirectX.
</p>
<p>For a sample that shows how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br241937">
<b>GestureRecognizer</b></a>&nbsp;APIs in a Windows Store app using JavaScript, check out the
<a href="http://go.microsoft.com/fwlink/p/?linkid=231638">Input: Manipulations and gestures (JavaScript) sample</a>.</p>
<p>Specifically, this sample covers the following:</p>
<ul>
<li>Managing touch interactions for UI objects of varying sizes and shapes. </li><li>Handling pointer events, such as <a href="http://msdn.microsoft.com/library/windows/apps/br208278">
<b>PointerPressed</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208276">
<b>PointerMoved</b></a>, and <a href="http://msdn.microsoft.com/library/windows/apps/br208279">
<b>PointerReleased</b></a>. </li><li>Handling display property events, such as <a href="http://msdn.microsoft.com/library/windows/apps/br226150">
<b>LogicalDpiChanged</b></a>. </li><li>Handling <a href="http://msdn.microsoft.com/library/windows/apps/br208284"><b>TouchHitTesting</b></a> events.
</li><li>Identifying the most likely touch input target based on proximity and z-order from the hit testing results provided by
<a href="http://msdn.microsoft.com/library/windows/apps/br208376"><b>ProximityEvaluation</b></a>.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700412">Responding to user interaction</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465326">Guidelines for targeting</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/">Getting started with apps</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208383"><b>Windows.UI.Core</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br242084"><b>Windows.UI.Input</b></a>
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
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
