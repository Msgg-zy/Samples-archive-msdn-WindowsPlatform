# Windows PowerShell Event Registration Sample
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
* 2013-10-17 01:15:01
## Description

<div id="mainSection">
<p>This sample shows how to create a cmdlet for event registration by deriving from
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd432311"><b>ObjectEventRegistrationBase</b></a>.
</p>
<p>The sample creates the <code>Register-FileSystemEvent</code> cmdlet which subscribes to events raised by
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/x7t1d0ky"><b>System.IO.FileSystemWatcher</b></a>. With this cmdlet, users can register an action to execute when a specific event is raised, such as when a file is created under an specific directory.</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ul>
<li>How to how to derive from the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd432311">
<b>ObjectEventRegistrationBase</b></a> class to create a cmdlet for event registration.
</li></ul>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/x7t1d0ky"><b>System.IO.FileSystemWatcher</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd432311"><b>ObjectEventRegistrationBase</b></a>
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
<li>Start PowerShell and import the library file in order to make the <code>Register-FileSystemEvent</code> cmdlet available in PowerShell.
</li><li>Use the <code>Register-FileSystemEvent</code> cmdlet to register an action that will write a message when a file is created under the TEMP directory.
</li><li>Create a file under the TEMP directory and note that the action is executed (i.e. the message is displayed).
</li></ol>
<p></p>
<p>This is the sample output from executing these 3 steps: </p>
<div class="code"><span>
<table>
<tbody>
<tr>
<th>cmd</th>
</tr>
<tr>
<td>
<pre>
PS&gt; Import-Module .\bin\Debug\Events01.dll
PS&gt; Register-FileSystemEvent $env:temp Created -filter &quot;*.txt&quot; -action { Write-Host &quot;A file was created in the TEMP directory&quot; }

Id  Name            State      HasMoreData  Location  Command
--  ----            -----      -----------  --------  -------
1   26932870-d3b... NotStarted False                  Write-Host &quot;A f...

PS&gt; Set-Content $env:temp\test.txt &quot;This is a test file&quot;
A file was created in the TEMP directory
PS&gt;</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
</div>
