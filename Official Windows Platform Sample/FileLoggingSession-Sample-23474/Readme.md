# FileLoggingSession Sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Diagnostics
* file logging
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:25:57
## Description

<div id="mainSection">
<p>This sample shows how to log messages and data to a file continuously as your app runs. You can view the log files by using the Windows Performance Toolkit (WPT) and other utilities like tracerpt.exe.
</p>
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
<p><b>Send messages and data to a log file</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn264208"><b>LogMessage</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dn264211"><b>LogValuePair</b></a> methods to send messages and data to a
<a href="http://msdn.microsoft.com/library/windows/apps/dn264138"><b>FileLoggingSession</b></a>.</p>
</li><li>
<p><b>Log file has reached the maximum size </b></p>
<p>Handles the <a href="http://msdn.microsoft.com/library/windows/apps/dn264161">
<b>LogFileGenerated</b></a> event, which indicates when a log file has reached the maximum size and is ready for analysis.</p>
</li><li>
<p><b>Move a logging session file to an app's log repository folder</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br241621"><b>LocalFolder</b></a> property and the
<a href="http://msdn.microsoft.com/library/windows/apps/br227216"><b>MoveAsync</b></a> method to move a log file to the app's log repository folder.</p>
</li><li>
<p><b>Manage generated logs in an app's log repository folder</b></p>
<p>Queries for log files and generates names for new log files.</p>
</li><li>
<p><b>Track logging state during suspend and resume</b></p>
<p>Handles the <a href="http://msdn.microsoft.com/library/windows/apps/br205860">
<b>Suspending</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br205859">
<b>Resuming</b></a> events and enables logging accordingly.</p>
</li></ol>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206677"><b>Windows.Foundation.Diagnostics</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
