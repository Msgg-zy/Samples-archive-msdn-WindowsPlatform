# LoggingSession Sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Diagnostics
* in-memory message log
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:28:13
## Description

<div id="mainSection">
<p>This sample shows how to log messages to an in-memory log as your app runs, and it shows how to save the in-memory message log to a file, on a condition of interest. You can view the log files by using the Windows Performance Toolkit (WPT) and other utilities
 like tracerpt.exe. </p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<p>The sample demonstrates these tasks:</p>
<ol>
<li>
<p><b>Send messages to an in-memory log</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn264208"><b>LogMessage</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dn264211"><b>LogValuePair</b></a> methods to send messages and data to a
<a href="http://msdn.microsoft.com/library/windows/apps/dn264217"><b>LoggingSession</b></a>.</p>
</li><li>
<p><b>Save a logging session to a file</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn264227"><b>SaveToFileAsync</b></a> method to save an in-memory log to a file.</p>
</li><li>
<p><b>Manage generated logs in an app's log repository folder</b></p>
<p>Queries for log files and generates names for new log files.</p>
</li><li>
<p><b>Track logging state during suspend and resume</b></p>
<p>Handles the <a href="http://msdn.microsoft.com/library/windows/apps/br205860">
<b>Suspending</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br205859">
<b>Resuming</b></a> events and enables logging accordingly.</p>
</li></ol>
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
