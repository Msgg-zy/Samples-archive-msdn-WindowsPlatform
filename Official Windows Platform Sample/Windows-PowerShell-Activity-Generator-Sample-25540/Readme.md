# Windows PowerShell Activity Generator Sample
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
* 2013-10-17 01:14:38
## Description

<div id="mainSection">
<p>This sample shows how to use the Windows PowerShell Activity Generation API to generate the source code for an activity that wraps a Windows PowerShell command from C# code. The sample then and then compiles the source code into an activity dll.
</p>
<p>The sample uses the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms569889">
<b>System.Management.Automation.PowerShell</b></a> API to get the definition of a command before calling the activity generation API. You can also accomplish this by calling the activity generator API from PowerShell directly, using the output of Get-Command
 as the command definition. </p>
<p>After you have generated the source code for an activity, compile it into a DLL and then reference that DLL from your Windows Workflow project.
</p>
<p>The sample contains the <code>New-PSActivity.ps1</code> script that can be used to generate the source code for one or more activities and to compile the source into a single activity dll.</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ul>
<li>How to use the Windows PowerShell Activity Generation API to generate the source code for an activity that wraps a Windows PowerShell command from C# code and then compile the source code into an activity dll.
</li></ul>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Overview</b> </dt><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms569889"><b>System.Management.Automation.PowerShell</b></a>
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
</li><li>Make sure the project references the System.Management.Automation.dll assembly.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.
<p>The library will be built in the default<b> \bin</b> or <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<p class="proch"><b>Running the sample</b></p>
<ol>
<li>Start PowerShell and run the ActivityGenerator.exe program. </li><li>If you wish to generate activities for a specific module, supply the module name as the first command-line parameter.
</li></ol>
<p></p>
<p></p>
<p class="proch"><b>Generating the Source Code and Activity DLL</b></p>
<ol>
<li>Start PowerShell. </li><li>Run the following command: .<code>\New-PSActivity.ps1 -Namespace ActivityGenerator.Test -ModulePath .\Math.cdxml -OutputPath .\ -AssemblyName ActivityGenerator.Test.Activities.dll -verbose</code>
</li><li>Reference <code>ActivityGenerator.Test.Activities.dll</code> DLL from your Windows Workflow project and create a workflow.
</li></ol>
<p></p>
</div>
