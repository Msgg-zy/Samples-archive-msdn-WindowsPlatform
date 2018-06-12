# Windows PowerShell Script Line Profiler Sample
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
* 2013-10-17 01:16:09
## Description

<div id="mainSection">
<p>This sample shows how to create a script line profiler using the new Windows PowerShell 3.0 AST (Abstract Syntax Tree) support.
</p>
<p>The sample defines the InstrumentAst class (derived from the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh485441">
<b>ICustomAstVisitor</b></a> interface) that builds an AST object. The AST object inserts a Profile object callback that measures the execution time of each script statement. The profiler can be run on script files using the provided
<code>Measure-Script</code> cmdlet.</p>
<p><b>Sample Objectives</b></p>
<p></p>
<ol>
<li>Creating a script line profiler using Windows PowerShell </li><li>AST support. </li><li>Running the provided <code>Measure-Script</code> cmdlet to profile a script file.
</li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh485441"><b>ICustomAstVisitor</b></a>
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
</li><li>Make sure the PSProfiler project references the System.Management.Automation.dll assembly.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.
<p>The executable will be built in the default<b> \bin</b> or <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Run <code>Import-Module</code> with the full path to the sample DLL. </li><li>Run the <code>Measure-Script</code> cmdlet on a script file. </li></ol>
<p></p>
</div>
