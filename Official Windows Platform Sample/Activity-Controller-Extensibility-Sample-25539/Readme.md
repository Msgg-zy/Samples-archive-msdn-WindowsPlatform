# Activity Controller Extensibility Sample
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
* 2013-10-17 01:14:35
## Description

<div id="mainSection">
<p>This sample demonstrates how to extend the Windows PowerShell Workflow activity controller.
</p>
<p>The extended activity controller uses RunspacePool-based queuing on a local WinRM custom workflow endpoint. The sample includes the CustomWorkflowEndpointSetup.ps1 script that can be used to set up a custom workflow endpoint.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>How to extend the Windows PowerShell Workflow activity controller. </li><li>How to create a custom workflow endpoint </li></ol>
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
<p>The ActivityControllerExtensibilitySample.exe file will be built in the <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Start Windows PowerShell as Administrator. </li><li>Navigate to the folder containing the CustomWorkflowEndpointSetup.ps1 script.
</li><li>Run the CustomWorkflowEndpointSetup.ps1 script to create a custom endpoint. </li><li>Navigate to the folder containing the sample binaries. </li><li>Run ActivityControllerExtensibilitySample.exe </li></ol>
<p></p>
</div>
