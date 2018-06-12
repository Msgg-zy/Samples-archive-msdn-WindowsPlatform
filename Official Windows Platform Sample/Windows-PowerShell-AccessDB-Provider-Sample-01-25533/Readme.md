# Windows PowerShell AccessDB Provider Sample 01
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
* 2013-10-17 01:14:19
## Description

<div id="mainSection">
<p>This sample shows how to implement a basic Windows PowerShell provider. </p>
<p>Subsequent provider samples show how to implement additional provider functionality. Windows PowerShell providers enable users to access data in a consistent format that resembles a file system drive.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ul>
<li>Creating a basic Windows PowerShell provider. </li></ul>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ee126192(v=vs.85).aspx">Writing a Windows PowerShell Provider</a>
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
<li>Start Windows PowerShell. </li><li>Navigate to the folder containing the sample DLL. </li><li>Run <code>Import-Module .\AccessDBProviderSample01.dll</code>. This will add the AccessDB provider to the current environment.
</li><li>Run <code>Get-PSProvider</code> to see the new AccessDB provider. </li></ol>
<p></p>
</div>
