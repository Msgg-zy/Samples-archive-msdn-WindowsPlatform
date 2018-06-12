# Windows PowerShell PowerShell01 Sample
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
* 2013-10-17 01:16:02
## Description

<div id="mainSection">
<p>This sample uses <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182569">
<b>InitialSessionState</b></a> to constrain a runspace and add commands and providers.
</p>
<p>This sample will concentrate on the SDK mechanisms to restrict the runspace. Script alternatives to the SDK include $ExecutionContext.SessionState.LanguageMode and the PSSessionConfiguration cmdlets.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Restricting the language by setting the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144218">
<b>InitialSessionState.LanguageMode</b></a> property. </li><li>Adding aliases to the environment using <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144216">
<b>InitialSessionState.Commands</b></a> property. </li><li>Marking commands as private. </li><li>Removing providers using <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144219">
<b>InitialSessionState.Providers</b></a> property. </li><li>Removing commands using <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144216">
<b>InitialSessionState.Commands</b></a> property. </li><li>Adding commands and providers. </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182569"><b>InitialSessionState</b></a>
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
<p>The executable will be built in the default<b> \bin</b> or <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Start command prompt. </li><li>Navigate to the folder containing the sample executable. </li><li>Run the executable. </li><li>See the output results and the corresponding code. </li></ol>
<p></p>
</div>
