# Windows PowerShell Serialization 01 Sample
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
* 2013-10-17 01:17:02
## Description

<div id="mainSection">
<p>This sample looks at an existing .NET class and shows how to make sure that information from selected public properties of this class is preserved across serialization and deserialization. The sample uses a types.ps1xml file to declare which properties of
 the class should get serialized. </p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Setting serialization depth for a given .NET class. </li><li>Restricting which set of properties from a class are serialized. </li><li>Demonstrating the effects of using a types.ps1xml file and <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144399">
<b>DeserializingTypeConverter</b></a>. </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144399"><b>DeserializingTypeConverter</b></a>
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
<li>Start a Command Prompt. </li><li>Navigate to the folder containing the sample binaries. </li><li>Run Serialization01.exe. </li></ol>
<p></p>
</div>
