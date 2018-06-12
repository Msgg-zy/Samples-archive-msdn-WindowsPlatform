# Windows PowerShell GetProcessSample01 Sample
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
* 2013-10-17 01:15:19
## Description

<div id="mainSection">
<p>This sample shows how to create a simple cmdlet. </p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Creating a basic sample cmdlet. </li><li>Creating a snap-in that works with Windows PowerShell version 1.0 or greater.
<p>Note that subsequent samples will use modules (a Windows PowerShell version 2.0 feature) instead of snap-ins.</p>
</li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
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
<li>Start an elevated Command Prompt window. </li><li>Navigate to the folder containing the sample DLL. </li><li>Run <code>installutil &quot;GetProcessSample01.dll&quot;</code>
<blockquote><b>Note</b>&nbsp;&nbsp;On a 64-bit operating system, you must run the 64-bit version of installutil.</blockquote>
. </li><li>Start Windows PowerShell. </li><li>Run the following command: <code>Add-PSSnapin GetProcPSSnapIn01</code> (This command adds the PowerShell snap-in to the shell.)
</li><li>Type the following command to run the cmdlet: <code>Get-Proc</code> </li></ol>
<p></p>
</div>
