# JavaScript Web Workers app multithreading sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* Networking
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:34:53
## Description

<div id="mainSection">
<p>This sample demonstrates how to use multithreading with Web Workers in your Windows Store app using JavaScript.
</p>
<p>Windows Store apps using JavaScript support standards-based Web Workers for multithreaded JavaScript. Web Workers can improve the responsiveness of your app by removing tasks from the UI thread. Web Workers use the
<a href="http://msdn.microsoft.com/library/windows/apps/hh772821"><b>postMessage</b></a> function to communicate with the UI thread.
</p>
<p>This sample covers the following scenarios:</p>
<ul>
<li>Using two Web Workers to calculate prime numbers. Even though this task is CPU intensive, the UI remains responsive because the calculations run inside the Web Workers.
</li><li>Importing WinJS into a Web Worker to use <b>XmlHttpRequest</b> to request a document.
</li><li>supporting Channel Messaging. Channel Messaging is used to enable direct communication between Web Workers. In this specific scenario, the UI thread creates two workers and a set of ports through which the Web Workers can directly communicate. The UI thread
 then passes the string &quot;Hello World&quot; to the first Web Worker, which passes it on to the second Web Worker via the specified port, which then passes it back to the UI thread.
</li><li>accessing the <a href="http://msdn.microsoft.com/library/windows/apps/hh453406">
<b>setTimeout</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/hh453402">
<b>setInterval</b></a> methods defined on a Web Worker. These methods can be used to throttle long running scripts or for other general timing purposes. Click the buttons to instruct the Worker to set a timeout or interval timer. At each callback of the timer,
 the Web Worker posts messages which are then displayed by the example. </li></ul>
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
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
