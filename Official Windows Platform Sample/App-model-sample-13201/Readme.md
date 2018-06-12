# App model sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
## Topics
* App model
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:20:03
## Description

<div id="mainSection">
<p>This sample shows how to use the Windows Runtime <a href="http://msdn.microsoft.com/library/windows/apps/br224691">
<b>Windows.ApplicationModel</b></a> API in aWindows Store app using JavaScript and the WinJS Toolkit.
</p>
<p>Some things to note about the <a href="http://msdn.microsoft.com/library/windows/apps/br224691">
<b>Windows.ApplicationModel</b></a> API:</p>
<ul>
<li>The Windows Runtime provides applications three buckets to store unstructured state (files):
<ul>
<li>a local container which is unique to a single user on a single machine inside of a single application
</li><li>a roaming container which is unique to a single user from a single application but roams across multiple machines
</li><li>a temporary container which has the same limitations as the local container, but may be automatically be purged by the system
</li></ul>
The <a href="http://msdn.microsoft.com/library/windows/apps/br224691"><b>Windows.ApplicationModel</b></a> API provides rich access to the full Windows Runtime file I/O functionality, such as creating sub directories, multiple file formats, and full async programming
 at multiple layers. For apps that store significant data in their local or roaming container, use the base Windows Runtime APIs.
</li><li>The job of the WinJS library is to mesh the various Windows Runtime application events (such as process lifetime management (PLM) and app object or type activation) with HTML5 DOM events (like DOMContentLoaded) in your app's code. To understand the technical
 implementation (as opposed to the end developer model), you need to understand two concepts: event queuing and event dispatching. An event is queued to the application object based on some external activity, such as a screen touch or a mouse click. Events
 are dispatched after any previous events have been dispatched (first in, first out rules). No event is dispatched until &quot;run&quot; is called on the app. By queuing events until the app code is ready to receive them,your app is in control of when it will start receiving
 these various events. </li><li>A simple checkpoint event, <a href="http://msdn.microsoft.com/library/windows/apps/br229839">
<b>oncheckpoint</b></a>, is offered for Windows Store app using JavaScript developers. The
<b>oncheckpoint</b> event is raised by the system automatically as a preparation for suspension. In addition, the
<b>oncheckpoint</b> event can be raised manually if needed. </li></ul>
<p>This sample is written in HTML5 and JavaScript. </p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465102">How to activate an app (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465138">How to suspend an app (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465114">How to resume an app (JavaScript)</a>
</dt><dt><b>Guidelines</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465088">Guidelines for app suspend and resume</a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh464925">Application lifecycle</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224691"><b>Windows.ApplicationModel</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224766"><b>Windows.ApplicationModel.Activation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br205865"><b>Windows.ApplicationModel.Core</b></a>
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
<p></p>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
