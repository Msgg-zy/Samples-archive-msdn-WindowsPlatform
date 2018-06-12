# Input: Manipulations and gestures (C++) sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Devices and sensors
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:13:55
## Description

<div id="mainSection">
<p>This sample demonstrates how to handle pointer input and process manipulations and gestures with the
<a href="http://msdn.microsoft.com/library/windows/apps/br241937"><b>GestureRecognizer</b></a>&nbsp;APIs in a Windows Store app using C&#43;&#43; and DirectX. For a sample that shows how to use the
<b>GestureRecognizer</b>&nbsp;APIs in a Windows Store app using JavaScript, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=231638">
Input: Manipulations and gestures (JavaScript) sample</a>. </p>
<p>Specifically, this sample covers the following:</p>
<ul>
<li>Creating and attaching a gesture recognizer to each UI object that can be manipulated.
</li><li>Handling window events, such as <a href="http://msdn.microsoft.com/library/windows/apps/br208225_activated">
<b>Activated</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208225_sizechanged">
<b>SizeChanged</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208225_closed">
<b>Closed</b></a>. </li><li>Handling pointer events, such as <a href="http://msdn.microsoft.com/library/windows/apps/br208225_pointerpressed">
<b>PointerPressed</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208225_pointermoved">
<b>PointerMoved</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208225_pointerreleased">
<b>PointerReleased</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208225_pointerwheelchanged">
<b>PointerWheelChanged.</b></a> </li><li>Handle display property events, such as <a href="http://msdn.microsoft.com/library/windows/apps/br226143_logicaldpichanged">
<b>LogicalDpiChanged</b></a>. </li><li>Hit testing. </li><li>Processing manipulation data for each UI object.
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
</dt><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/">Getting started with apps</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465370">Guidelines for user interaction</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700412">Responding to user interaction (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465397">Responding to user interaction (VB/C#/C&#43;&#43;)</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br242084"><b>Windows.UI.Input</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208383"><b>Windows.UI.Core</b></a>
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
