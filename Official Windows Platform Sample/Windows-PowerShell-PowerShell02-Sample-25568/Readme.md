# Windows PowerShell PowerShell02 Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Powershell
## IsPublished
* True
## ModifiedDate
* 2013-10-17 01:16:05
## Description

<div id="mainSection">
<p>This sample uses a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182576">
<b>RunspacePool</b></a> to run multiple commands concurrently. Although commands can be run synchronously using runspace pools, typically runspace pools are used to run commands concurrently.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Creating a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182576">
<b>RunspacePool</b></a> with a minimum and maximum number of Runspaces. </li><li>Creating many PowerShell commands with the same <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182576">
<b>RunspacePool</b></a> </li><li>Running the commands concurrently. </li><li>Calling <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd127653">
<b>GetAvailableRunspaces</b></a> to see how many Runspaces are free. </li><li>Capturing the command output with <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182447">
<b>EndInvoke.</b></a> </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182576"><b>RunspacePool</b></a>
</dt></dl>
<h3>Operating system requirements</h3>
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
<h3>Build the sample</h3>
<p></p>
<ol>
<li>Start Microsoft Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>
Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.
<p>The library will be built in the default<b> \bin</b> or <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Start command prompt. </li><li>Navigate to the folder containing the sample executable. </li><li>Run the executable. </li><li>See the output results and the corresponding code. </li></ol>
<p></p>
</div>
