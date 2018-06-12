# Windows PowerShell Select-String Sample
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
* 2013-10-17 01:17:00
## Description

<div id="mainSection">
<p>This sample creates a cmdlet called <code>Select-Str</code> that searches files for specified patterns. The patterns can be case-sensitive or case-insensitive. The user can also specify a script block to use for performing the matching operation instead
 of relying on the cmdlet's own logic which uses regular expressions for matching.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Using PSPaths with cmdlet parameters. </li><li>Using script blocks with cmdlet parameters. </li><li>Using session state in a cmdlet implementation. </li></ol>
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
<li>Store the assembly in the following module folder: [user]/Documents/WindowsPowerShell/Modules/SelectStrCommandSample
</li><li>Start Windows PowerShell. </li><li>Run the following command: Import-Module SelectStrCommandSample (This command loads the assembly into Windows PowerShell.)
</li><li>Type Get-Command Select-Str -Syntax to see the syntax for the Select-Str cmdlet.
</li><li>Type Select-Str to run the cmdlet. </li></ol>
<p></p>
</div>
