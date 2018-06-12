# Input: XAML user input events sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:16:26
## Description

<div id="mainSection">
<p>This sample demonstrates how to handle the user input events of the <a href="http://msdn.microsoft.com/library/windows/apps/br208911">
<b>UIElement</b></a> class in order to implement touch, mouse, stylus, and keyboard support in your app.
</p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Handling the <a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerpressed">
<b>PointerPressed</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointermoved">
<b>PointerMoved</b></a>, and <a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerreleased">
<b>PointerReleased</b></a> events implement a drawing feature. </li><li>Handling the <a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerentered">
<b>PointerEntered</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerexited">
<b>PointerExited</b></a> events to change the visual state of an element. </li><li>Using the <a href="http://msdn.microsoft.com/library/windows/apps/br208911_capturepointer">
<b>CapturePointer</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br208911_releasepointercapture">
<b>ReleasePointerCapture</b></a> methods. </li><li>Handling the <a href="http://msdn.microsoft.com/library/windows/apps/br208911_tapped">
<b>Tapped</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208911_doubletapped">
<b>DoubleTapped</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br208911_righttapped">
<b>RightTapped</b></a>, and <a href="http://msdn.microsoft.com/library/windows/apps/br208911_holding">
<b>Holding</b></a> events. </li><li>Handling manipulation events to implement drag, zoom, and rotate gestures. </li><li>Handling the <a href="http://msdn.microsoft.com/library/windows/apps/br208911_keydown">
<b>KeyDown</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br208911_keyup">
<b>KeyUp</b></a> events. </li></ul>
<p class="note"><b>Important</b>&nbsp;&nbsp;Mouse input is associated with a single pointer assigned when mouse input is first detected. Clicking a mouse button (left, wheel, or right) creates a secondary association between the pointer and that button through the
<a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerpressed">
<b>PointerPressed</b></a> event. The <a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerreleased">
<b>PointerReleased</b></a> event is fired only when that same mouse button is released (no other button can be associated with the pointer until this event is complete). Because of this exclusive association, other mouse button clicks are routed through the
<a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointermoved"><b>PointerMoved</b></a> event.
</p>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911"><b>UIElement</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerpressed"><b>PointerPressed</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointermoved"><b>PointerMoved</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerreleased"><b>PointerReleased</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerentered"><b>PointerEntered</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_pointerexited"><b>PointerExited</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_capturepointer"><b>CapturePointer</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_releasepointercapture"><b>ReleasePointerCapture</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_tapped"><b>Tapped</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_doubletapped"><b>DoubleTapped</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_righttapped"><b>RightTapped</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_holding"><b>Holding</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_keydown"><b>KeyDown</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208911_keyup"><b>KeyUp</b></a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700412">Responding to user interaction</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465387">QuickStart: Touch input</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for C# and Visual Basic</a>
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
