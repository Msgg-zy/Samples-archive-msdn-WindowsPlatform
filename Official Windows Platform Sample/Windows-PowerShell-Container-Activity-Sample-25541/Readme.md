# Windows PowerShell Container Activity Sample
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
* 2013-10-17 01:14:44
## Description

<div id="mainSection">
<p>This sample shows how to write a Windows Workflow Activity that can accept a PowerShell script block as an argument.
</p>
<p>The context of this sample is an activity that lets you invoke actions very cautiously: after invoking the action, the workflow suspends and asks for manual verification. If you are satisfied that the action was accomplished correctly, then you can delete
 the log file and resume the workflow. </p>
<p>If you want the action to be attempted again, you can resume the workflow without deleting the log file. The activity implements support for script block arguments by defining a property of type 'Activity'. When the user supplies a script block to this parameter,
 PowerShell automatically converts the script block into an activity graph. The script uses the same mechanism that PowerShell already relies on to convert your workflow scripts into workflows that Windows Workflow Foundation can understand.
</p>
<p>Once you have compiled the ContainerActivity project, you can use the #requires statement to reference that DLL from a regular PowerShell Workflow.</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ul>
<li>How to write a Workflow activity that can accept a PowerShell script block as an argument, when called from a PowerShell Workflow.
</li></ul>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://technet.microsoft.com/en-us/library/jj134242.aspx">Getting Started with Windows PowerShell Workflow</a>
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
<li>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Solution (.sln) file.
</li><li>Make sure the project references the <code>Microsoft.Powershell.Activities.dll</code> assembly.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li><li>The library file will be built in the default <b>\bin</b> or <b>\bin\Debug</b> directory.
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Start <b>PowerShell</b>. </li><li>Navigate to the solution directory. </li><li>Follow the steps demonstrated in the <code>Invoke-ContainerActivity.ps1</code> sample script.
</li></ol>
<p></p>
</div>
