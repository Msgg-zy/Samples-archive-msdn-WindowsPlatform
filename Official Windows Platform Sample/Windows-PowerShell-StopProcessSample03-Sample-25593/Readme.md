# Windows PowerShell StopProcessSample03 Sample
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
* 2013-10-17 01:17:20
## Description

<div id="mainSection">
<p>This sample shows how to write a cmdlet that declares aliases for parameters and supports wildcards.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Declaring a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms582518">
<b>cmdlet</b></a> class. </li><li>Declaring cmdlet parameters. </li><li>Specifying positions for parameters. </li><li>Specifying that the parameters can accept an object from the pipeline or accept a value from a property of an object that has the same name as the parameter.
</li><li>Handling errors and exceptions. </li><li>Using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms570256">
<b>ShouldProcess</b></a> and <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms570255">
<b>ShouldContinue</b></a> methods. </li><li>Implementing the <i>Force</i> and <i>PassThru</i> parameters. </li><li>Declaring aliases and wildcard support. </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms582518"><b>cmdlet</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms570256"><b>ShouldProcess</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms570255"><b>ShouldContinue</b></a>
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
<li>Store the assembly in the following module folder: <b>[user]/Documents/WindowsPowerShell/Modules/StopProcessSample03</b>
</li><li>Start Windows PowerShell. </li><li>Run the following command: <code>Import-Module StopProcessSample03</code> (This command loads the assembly into Windows PowerShell.)
</li><li>Type the following command to run the cmdlet: <code>Stop-Proc &lt;process name&gt;</code>
</li></ol>
<p></p>
</div>
