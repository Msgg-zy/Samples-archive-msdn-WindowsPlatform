# Windows PowerShell Host01 Sample
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
* 2013-10-17 01:15:35
## Description

<div id="mainSection">
<p>This sample uses the RunspaceInvoke class to execute a script that calls exit. The host application looks at this and prints out the result.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Creating your own host interface class derived from <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms572439">
<b>PSHost</b></a>. This example host implementation is mostly stubs but does illustrate mapping the exit status and exit code from the engine back to the calling program.
</li><li>Creating a runspace using that host implementation. </li><li>Running a script then calling exit. </li><li>Verifying that the script returned the correct value and the exit process operated correctly.
</li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Conceptual</b> </dt><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms572439"><b>PSHost</b></a>
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
<li>Start command prompt. </li><li>Navigate to the folder containing the sample executable. </li><li>Run the executable. </li></ol>
<p></p>
</div>
