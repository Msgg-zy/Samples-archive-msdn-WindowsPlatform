# Windows PowerShell Job Source Adapter Sample
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
* 2013-10-17 01:15:58
## Description

<div id="mainSection">
<p>This sample shows how to derive a <b>FileCopyJob</b> class from the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh485406">
<b>Job2</b></a> type and a <b>FileCopyJobSourceAdapter</b> class from the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh485414">
<b>JobSourceAdapter</b></a> type. </p>
<p>The <b>FileCopyJob</b> sample class is implemented to perform simple file system listening and file copying functions. The
<b>FileCopyJobSourceAdapter</b> implementation creates <b>FileCopyJob</b> objects and allows manipulation of these objects through Windows PowerShell's Get-Job, Suspend-Job, Resume-Job, Stop-Job, and Remove-Job cmdlets.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Creating a <b>FileCopyJob</b> job derived from a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh485406">
<b>Job2</b></a> type. </li><li>Creating a <b>FileCopyJobSourceAdapter</b> derived from a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh485414">
<b>JobSourceAdapter</b></a> type. </li><li>Importing the assembly and the <b>FileCopyJobSourceAdapter</b> into a PowerShell console so that existing PowerShell job cmdlets can be used to manipulate
<b>FileCopyJob</b> job objects. </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Conceptual</b> </dt><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh485406"><b>Job2</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh485414"><b>JobSourceAdapter</b></a>
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
</li><li>Make sure the JobSourceAdapter project references the System.Management.Automation.dll assembly.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.
<p>The executable will be built in the default<b> \bin</b> or <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Run <code>Import-Module</code> with the full path to the sample DLL. </li><li>Run the <code>Get-FileCopyJob</code> cmdlet that was imported from the assembly. Create one or more
<b>FileCopyJob</b> objects passing in the name, text source file, and text destination file paths.
</li><li>Use <code>Get-Job</code> to see the FileCopyJob jobs that were created. </li><li>Use <code>Suspend-Job</code> and <code>Resume-Job</code> to suspend and resume the jobs.
</li><li>Use <code>Stop-Job</code> and <code>Remove-Job</code> to stop and remove the jobs from the JobSourceAdapter repository.
</li></ol>
<p></p>
</div>
