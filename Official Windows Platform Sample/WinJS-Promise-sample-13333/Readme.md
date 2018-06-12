# WinJS Promise sample
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
* 2013-11-25 04:31:18
## Description

<div id="mainSection">
<p></p>
<p>This sample demonstrates the use of the Windows Library for JavaScript <a href="http://msdn.microsoft.com/library/windows/apps/br211867">
<b>Promise</b></a> object. Promises are a simple way to do asynchronous programming in JavaScript. They allow developers to perform operations on a value (or a set of values) that may only be available in the future, handle possible errors, and provide progress
 notification. </p>
<p>This sample includes the following scenarios:</p>
<ol>
<li>
<p>The creating async Promises scenario: A Promise is an object that represents a value that may not yet have been computed, an error which has not yet been found, or some work that has not yet been performed. Promises can be chained together using Promise.then
 to schedule work when a value from the previous chain is available, so you can synchronize a series of asynchronous tasks or events.</p>
</li><li>
<p>The WinJS.Promise.timeout scenario: Creates a Promise that is fulfilled after a specified delay. The parameter is an optional value determining the minimum number of milliseconds to wait before completing the promise. Providing zero or omitting the delay
 results in the Promise being completed as soon as possible. </p>
</li><li>
<p>The catching errors scenario: Promises support error handling. By passing a second callback function to the
<b>then()</b> method, you can specify an error handler that will be called if an exception occurs during the promise's execution.</p>
</li><li>
<p>The error event scenario: Exceptions that are generated during asynchronous operations are passed to the optional error handler defined in the
<b>then()</b> method. There is a class of errors in JavaScript (for example, referencing an undefined variable or method) that aren't something a developer would want to put in an error handler. The
<b>Promise.onerror</b> event is raised whenever an exception or error is caught inside a promise, regardless of the presence of an actual error handler or not. This provides a central point where a developer can do logging or put a breakpoint and catch exceptions
 that would otherwise have been handled silently by the Promise object. </p>
</li><li>
<p>The Promise.as scenario: You can wrap a value in a Promise. This is useful if you don't know whether or not the operation is asynchronous, and just want to treat the value as a Promise in order to schedule some work to be done using
<b>then()</b>.</p>
</li><li>
<p>The cancellation scenario: Request cancellation of any work that is being computed in order to fulfill this Promise. This may chain the cancellation request up through the Promise(s) that this Promise is waiting on.</p>
</li><li>
<p>The WinJS.Promise.join scenario: Creates a Promise that is not fulfilled until a collection of other Promises are all fulfilled.</p>
</li><li>
<p>The WinJS.Promise.any scenario: Creates a Promise that is fulfilled as soon as one of the input Promises is fulfilled.</p>
</li></ol>
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
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465037">Roadmap for apps using JavaScript</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700339">Quickstart: using promises</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700337">How to handle errors with promises</a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700330">Asynchronous programming in JavaScript</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211867">WinJS.Promise</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701079">WinJS.Promise.done</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229728">WinJS.Promise.then</a>
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
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
