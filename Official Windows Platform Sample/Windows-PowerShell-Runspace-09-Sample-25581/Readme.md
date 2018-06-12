# Windows PowerShell Runspace 09 Sample
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
* 2013-10-17 01:16:45
## Description

<div id="mainSection">
<p>This sample shows how to use a PowerShell object to run a script that generates the numbers from 1 to 10 with delays between each number. The pipeline of the PowerShell object is run asynchronously and events are used to handle the output.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Creating a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144526">
<b>PowerShell</b></a> object. </li><li>Adding a script to the pipeline of the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144526">
<b>PowerShell</b></a> object. </li><li>Using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd127743">
<b>BeginInvoke</b></a> method to run the pipeline asynchronosly. </li><li>Using the events of the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144526">
<b>PowerShell</b></a> object to process the output of the script. </li><li>Using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182457">
<b>PowerShell.Stop</b></a> method to interrupt an executing pipeline. </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144526"><b>PowerShell</b></a>
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
