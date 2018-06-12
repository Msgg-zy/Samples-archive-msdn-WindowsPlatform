# Input: Windows 8 gestures sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
* HTML5
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-04-09 02:50:52
## Description

<div id="mainSection">
<p>This sample demonstrates the native gestures supported by the user interaction platform in both Windows Store apps and the new Windows UI in Windows&nbsp;8.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;Touch interactions are emphasized in this sample. Mouse, pen, and keyboard input modes are supported to varying degrees as noted below. See
<a href="http://go.microsoft.com/fwlink/?LinkID=268457">Responding to mouse interactions
</a>and <a href="http://go.microsoft.com/fwlink/?LinkID=268459">Responding to keyboard interactions
</a>for more information on the interaction behaviors for those input modes.</p>
<p>Users pan or scroll through a series of pages, each of which showcases a particular gesture, its interaction behavior, and the standard functionality the gesture enables. See
<a href="http://go.microsoft.com/fwlink/?LinkID=268162">Touch interaction design</a> for more information on the native Windows&nbsp;8 gestures and their interaction behaviors.</p>
<p>Specifically, this sample covers how to incorporate the following gestures into an app:</p>
<ul>
<li>Slide to pan through the app.
<ul>
<li>Touch: Slide one or more fingers to the left or right. </li><li>Mouse: Use the scroll bar where available, rotate the scroll wheel, or click the UI commands to page left and right.
</li><li>Pen: Tap the UI commands to page left and right. </li><li>Keyboard: Tab and arrow keys to navigate. </li></ul>
</li><li>Swipe from the edges of the display to expose application commands in an app bar, application settings in the charms bar, suspend the app, or switch apps.
<ul>
<li>Touch: Slide one or more fingers from the top edge to suspend the app, from the bottom edge to display the app bar, and from the right edge to display the charms bar.
</li><li>Mouse: Click and slide from the top edge to suspend the app, right click to display the app bar, and hover over the bottom, right edge to display the charms bar.
</li><li>Pen: Slide from the top edge to suspend the app, from the bottom edge to display the app bar, and from the right edge to display the charms bar.
</li><li>Keyboard: ALT &#43; F4 to suspend the app, Windows Key &#43; Z to display the app bar, Windows Key &#43; C to display the charms bar.
</li></ul>
</li><li>Swipe to select.
<ul>
<li>Touch: Press down on an element with one or more fingers and slide in a direction perpendicular to the panning axis of the content area.
</li><li>Mouse: Right click an element. </li><li>Pen: N/A. </li><li>Keyboard: Tab into page and, using the tab order to set focus on an element, press the spacebar.
</li></ul>
</li><li>Pinch and stretch to activate semantic zoom.
<ul>
<li>Touch: Pinch, stretch, or double tap to zoom in when in the zoomed out mode. </li><li>Mouse: Hold the Ctrl key and rotate the mouse wheel or double click to zoom in when in the zoomed out mode.
</li><li>Pen: Double tap to zoom in when in the zoomed out mode. </li><li>Keyboard: Tab into page and, using the tab order to set focus on an element, hold the Ctrl key down (with the Shift key, if no numeric keypad is available) and press the plus (&#43;) or minus (-) key.
</li></ul>
</li><li>Pinch and stretch to activate optical zoom and resize.
<ul>
<li>Touch: Press down on an element with two or more fingers and pinch or stretch the element.
</li><li>Mouse: While hovering over the element, hold the Ctrl key and rotate the mouse wheel.
</li><li>Pen: N/A. </li><li>Keyboard: N/A. </li></ul>
</li><li>Tap to initiate a primary action (recommended target sizes for different interaction scenarios are also demonstrated).
<ul>
<li>Touch: Tap an element. </li><li>Mouse: Click an element. </li><li>Pen: Tap an element. </li><li>Keyboard: Tab into page and, using the tab order to set focus on an element, press the spacebar.
</li></ul>
</li><li>Press and hold to learn (both tooltips and info pop-ups are demonstrated, context menus are not).
<ul>
<li>Touch: One finger touches the element and stays in place. </li><li>Mouse: Click the element and hold. </li><li>Pen: Press on the element and hold. </li><li>Keyboard: N/A. </li></ul>
</li><li>Turn to rotate and slide to move.
<ul>
<li>Touch: Press down on an element with two or more fingers and move them in a clockwise or counter-clockwise arc. Both examples use the center of the element as the rotation point, neither use a touch point as the center of rotation.
</li><li>Mouse: While hovering over the element, hold the Ctrl and Shift keys and rotate the mouse wheel. The rotate-only example uses the center of the element as the rotation point while the rotate and move example uses the mouse pointer as the rotation point.
</li><li>Pen: Rotate is N/A, press down and slide to move. </li><li>Keyboard: N/A. </li></ul>
</li></ul>
<p></p>
<p class="note"><b>Important</b>&nbsp;&nbsp;We don't recommend customizing the behavior of the basic Windows gestures, as this can create an inconsistent and confusing user experience. Create custom gestures only if there is a clear, well-defined requirement and no
 basic gesture can support your scenario.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/?LinkId=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/?LinkId=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/apps/BR211386">Getting started with Windows Store apps</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/?LinkID=268162">Touch interaction design</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/Hh700412">Responding to user interaction</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/?LinkID=268599">Guidelines for common user interactions</a>
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
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
