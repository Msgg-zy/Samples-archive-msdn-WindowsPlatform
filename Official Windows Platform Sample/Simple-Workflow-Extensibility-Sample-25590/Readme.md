# Simple Workflow Extensibility Sample
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
* 2013-10-17 01:17:11
## Description

<div id="mainSection">
<p>This sample demonstrates how to host the Windows PowerShell Worflow runtime in an application.
</p>
<p>In the sample, the <b>OutOfProcessActivity</b>, <b>AllowedActivity</b>, and <b>
LanguageMode</b> members of the <b>PSWorkflowConfigurationProvider</b> class are overridden with custom implementations. The custom configuration is passed as the configuration provider when the PSWorkflowRuntime is created. Finally, the runtime is used to
 invoke a sample workflow. </p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ul>
<li>How to host the Windows PowerShell Workflow runtime in an application. </li></ul>
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
<p>The SimpleExtensibilitySample.exe file will be built in the <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Start a Command Prompt. </li><li>Navigate to the folder containing the sample executable. </li><li>Run the executable. </li></ol>
<p></p>
</div>
