# Windows PowerShell Runspace 11 Sample
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
* 2013-10-17 01:16:51
## Description

<div id="mainSection">
<p>This sample shows how to use the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144506">
<b>CommandMetadata</b></a> class to create a proxy command that calls an existing cmdlet, but restricts the set of available parameters. The proxy command (a function) is then added to an initial session state that is used to create a constrained runspace.
 The user can call the function, but cannot call not the initial cmdlet. </p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Creating a <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144506">
<b>CommandMetadata</b></a> object that describes the metadata of an existing cmdlet.
</li><li>Modifying the cmdlet metadata to remove a parameter from the cmdlet. </li><li>Adding the cmdlet to an initial session state and making it private. </li><li>Creating a proxy function that calls the existing cmdlet, but exposes only a restricted set of parameters.
</li><li>Adding the proxy function to the initial session state. </li><li>Calling the private cmdlet and the proxy function to demonstrate the constrained runspace.
</li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd144506"><b>CommandMetadata</b></a>
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
