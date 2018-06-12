# Windows PowerShell Serialization 02 Sample
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
* 2013-10-17 01:17:05
## Description

<div id="mainSection">
<p>By default, serialization preserves all public properties of an object. This sample looks at an existing .NET class and shows how to make sure that information from an instance of this class is preserved across serialization and deserialization when the
 information is not available in public properties of the class. </p>
<p><b>Sample Objectives</b></p>
<p>The sample demonstrates the following:</p>
<ol>
<li>Setting serialization depth for a given .NET class. </li><li>Adding an extended property that carries information not available in public properties of the .NET class.
</li><li>Hiding the extended property (an implementation detail needed for serialization) from users.
</li></ol>
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
<li>Start a Command Prompt. </li><li>Navigate to the folder containing the sample binaries. </li><li>Run Serialization02.exe. </li></ol>
<p></p>
</div>
