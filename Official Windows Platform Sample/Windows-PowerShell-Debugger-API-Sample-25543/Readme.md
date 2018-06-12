# Windows PowerShell Debugger API Sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Powershell
## IsPublished
* True
## ModifiedDate
* 2013-10-17 01:14:50
## Description

<div id="mainSection">
<p>This sample shows how to use the PowerShell Debugger API. </p>
<p>This sample shows how to use the PowerShell debugging API to handle debugger events and process debug commands. It also demonstrates Workflow debugging. Workflow debugging is new for PowerShell version 4 and is an opt-in feature. In order to debug Workflow
 script functions the debugger DebugMode must include the DebugModes.LocalScript flag. Note that Workflow is not supported for WOW (Windows on Windows) and so this sample should be built using x64 CPU if building on an x64 platform.
</p>
<p>The DebuggerSample class contains a single public Run method that creates a sample script file, sets a single breakpoint in the script Workflow function, and runs the script. There are two event handlers that handle the debugger
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182204"><b>Debugger.BreakpointUpdated</b></a> and
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182205"><b>Debugger.DebuggerStop</b></a> events. There is also a simple Read, Evaluate, Print Loop (REPL) that handles user debugger commands.</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Creating a sample script file to debug that includes a Workflow function. </li><li>How to handle a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182204">
<b>Debugger.BreakpointUpdated</b></a> event. </li><li>How to handle a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182205">
<b>Debugger.DebuggerStop</b></a> event. </li><li>How to process user debugger commands in a simple REPL. </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182204"><b>Debugger.BreakpointUpdated</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182205"><b>Debugger.DebuggerStop</b></a>
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
<li>If you are building on an x64 platform make sure your are building to an x64 CPU.
</li><li>Start Microsoft Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>
Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Solution (.sln) file.
</li><li>Make sure the DebuggerSample project references the System.Management.Automation.dll assembly.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.
<p>The library will be built in the default<b> \bin</b> or <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Build the project as described above and run it. </li><li>A console will appear that runs the sample script file and stops at the breakpoint on line 10.
</li><li>Type <code>'h'</code> to get the debugger help list. </li><li>Type <code>'k</code>' to see the call stack. </li><li>Type <code>'list'</code> to see the script and the current line of execution.
</li><li>Type <code>'v'</code> to step through the Workflow script. </li><li>Type <code>'$Title'</code> to see the Title variable. </li><li>Type <code>'$JobId'</code> to see the Workflow job id. </li><li>Type <code>'Get-PSBreakpoint'</code> to see the breakpoints. You can also add a new breakpoint with Set-PSBreakpoint.
</li><li>Type <code>'o'</code> to step out of the Workflow function. </li><li>Type <code>'c'</code> to finish running the script. </li></ol>
<p></p>
</div>
