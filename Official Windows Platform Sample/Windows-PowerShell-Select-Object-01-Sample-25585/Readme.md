# Windows PowerShell Select-Object 01 Sample
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
* 2013-10-17 01:16:57
## Description

<div id="mainSection">
<p>This sample creates a cmdlet called <code>Select-Obj</code> which acts as a filter to select only certain objects to process or pass down the pipeline. It is most effectively used as a pipeline receiver from other cmdlets such as
<code>Get-Service</code> or <code>Get-Process</code>. The <i>First</i>, <i>Last</i>, and
<i>Unique</i> parameters select which objects to process. The cmdlet works with files, modules, registry keys, and other objects.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following: </p>
<ul>
<li>Creating an advanced cmdlet. </li></ul>
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
<li>Store the assembly in the following module folder: <b>[user]/Documents/WindowsPowerShell/Modules/SelectObjSample01</b>
</li><li>Start Windows PowerShell. </li><li>Run the following command: Import-Module SelectObjSample01 (This command loads the assembly into Windows PowerShell.)
</li><li>Type the following command to run the cmdlet: Select-Obj </li></ol>
<p></p>
</div>
