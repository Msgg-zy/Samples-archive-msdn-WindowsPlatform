# Windows PowerShell Runspace 06 Sample
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
* 2013-10-17 01:16:37
## Description

<div id="mainSection">
<p>This sample shows how to add a module to an initial session state, how to create a runspace that uses the initial session state, and how to run a cmdlet that is provided by the module. This sample assumes that the user has the
<code>GetProcessSample02.dll</code> that is produced by the GetProcessSample02 sample copied to the current directory.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following: </p>
<ol>
<li>Creating a default initial session state. </li><li>Creating a runspace that uses the initial session state. </li><li>Creating a PowerShell object that uses the runspace. </li><li>Adding a cmdlet of a module to the PowerShell object. </li><li>Using <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms572584">
<b>PSObject</b></a> objects to extract and display properties from the objects returned by the cmdlet.
</li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms572584"><b>PSObject</b></a>
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
<li>Start a Command Prompt. </li><li>Navigate to the folder containing the sample executable. </li><li>Run the executable. </li></ol>
<p></p>
</div>
