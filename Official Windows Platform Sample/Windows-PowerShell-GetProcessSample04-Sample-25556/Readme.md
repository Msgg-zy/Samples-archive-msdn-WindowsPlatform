# Windows PowerShell GetProcessSample04 Sample
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
* 2013-10-17 01:15:29
## Description

<div id="mainSection">
<p>This sample shows how to create a cmdlet that handles non-terminating errors. </p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Declaring a cmdlet class. </li><li>Declaring a parameter. </li><li>Specifying the position of a parameter. </li><li>Specifying that the parameter can accept an object from the pipeline or accept a value from a property of an object that has the same name as the parameter.
</li><li>Trapping a non-terminating error and writing an error message to the error stream.
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
<li>Store the assembly in the following module folder: [<code>user]/Documents/WindowsPowerShell/Modules/GetProcessSample04</code>
</li><li>Start Windows PowerShell. </li><li>Run the following command: <code>Import-Module GetProcessSample04</code> (This command loads the assembly into Windows PowerShell.)
</li><li>Type the following command to run the cmdlet: <code>Get-Proc</code> </li></ol>
<p></p>
</div>
