# Windows PowerShell Supports Paging 01 Sample
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
* 2013-10-17 01:17:31
## Description

<div id="mainSection">
<p>This sample shows how to implement a cmdlet called <code>Get-Numbers</code> that supports paging operations. The
<code>Get-Numbers</code> cmdlet generates up to 100 consecutive numbers starting from 0. The
<i>IncludeTotalCount</i>, <i>Skip</i>, and <i>First</i> parameters enable the user to perform paging operations on the set of numbers returned by the cmdlet.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ul>
<li>Usage of the SupportsPaging attribute to implement paging functionality. </li></ul>
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
<p>The library will be built in the default \bin or \bin\Debug directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<p class="proch"><b>Running the C# Sample</b></p>
<ol>
<li>Store the assembly in the following module folder: <b>[user]/Documents/WindowsPowerShell/Modules/SupportsPaging01</b>
</li><li>Start Windows PowerShell. </li><li>Run the following command: <code>Import-Module SupportsPaging01</code> (This command loads the assembly into Windows PowerShell.)
</li><li>Run the <code>Get-Numbers</code> cmdlet. </li></ol>
<p class="proch"><b>Running the Windows PowerShell Script Sample</b></p>
<ol>
<li>Open Windows PowerShell. </li><li>Navigate to the directory where the SupportsPaging01.ps1 script is stored.
<p>By default, the script is located in the <b>.../PowerShell/SupportsPaging/SupportsPaging_Script/CS</b> directory.</p>
</li><li>Dot source the script by running the following command: <code>. .\SupportsPaging01.ps1</code>
</li></ol>
<p></p>
</div>
