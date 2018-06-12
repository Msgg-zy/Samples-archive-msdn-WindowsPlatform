# Input: Manipulations and gestures (JavaScript) sample
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
* 2013-04-09 02:38:32
## Description

<div id="mainSection">
<p>This sample demonstrates how to handle pointer input and process manipulations and gestures through the
<a href="http://msdn.microsoft.com/library/windows/apps/BR241937"><b>GestureRecognizer</b>
</a>&nbsp;APIs in a Windows Store app using JavaScript and Scalable Vector Graphics (SVG) elements. For a sample that shows how to use the
<b>GestureRecognizer</b>&nbsp;APIs in a Windows Store apps using C&#43;&#43; and DirectX, see the
<a href="http://go.microsoft.com/fwlink/p/?linkid=258347">Input: Manipulations and gestures (C&#43;&#43;) sample</a>.
</p>
<p>Specifically, this sample covers the following:</p>
<ul>
<li>Handling Document Object Model (DOM) pointer events, such as <a href="http://msdn.microsoft.com/library/windows/apps/Hh465891">
<b>onmspointerdown</b> </a>, <a href="http://msdn.microsoft.com/library/windows/apps/Hh465899">
<b>onmspointermove</b> </a>, and <a href="http://msdn.microsoft.com/library/windows/apps/Hh465912">
<b>onmspointerup</b> </a>. </li><li>Creating and attaching a gesture recognizer to each UI object that can be manipulated.
</li><li>Using <a href="http://msdn.microsoft.com/en-us/library/windows/apps/BR241971">
<b>GestureSettings</b> </a>to configure the gesture recognizer to process manipulationRotate, manipulationTranslateX, manipulationTranslateY, manipulationScale, manipulationRotateInertia, manipulationScaleInertia, manipulationTranslateInertia, and tap data.
</li><li>Handling manipulation events, such as <a href="http://msdn.microsoft.com/library/windows/apps/BR241957">
<b>ManipulationStarted</b> </a>, <a href="http://msdn.microsoft.com/library/windows/apps/BR241958">
<b>ManipulationUpdated</b> </a>, and <a href="http://msdn.microsoft.com/library/windows/apps/BR241955">
<b>ManipulationCompleted</b> </a>. </li><li>Using transformation matrices to calculate rotation, translation, and scale manipulations.
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;</p>
<p class="note">This sample does not cover creating a gesture recognizer pool and dynamically sharing recognizers between UI objects.</p>
<p></p>
<p></p>
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/apps/BR211386">Getting started with Windows Store apps</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/Hh673557">Pointer and gesture events</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/Hh700412">Responding to user interaction</a>
</dt><dt><b>Controls</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/Hh453747"><b>SVGElement</b>
</a></dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/Hh767307">Document Object Model (DOM) Events</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/BR242084"><b>Windows.UI.Input</b>
</a></dt></dl>
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
