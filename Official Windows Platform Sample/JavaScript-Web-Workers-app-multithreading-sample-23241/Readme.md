# JavaScript Web Workers app multithreading sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* Networking
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:26:09
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
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
