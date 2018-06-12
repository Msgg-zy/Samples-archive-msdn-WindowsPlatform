# Windows PowerShell Remote Runspace 01 Sample
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
* 2013-10-17 01:16:12
## Description

<div id="mainSection">
<p>This sample shows how to construct a remote runspace, set connection and operation timeouts, establish a remote connection, and close the connection.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Creating an instance of the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182592">
<b>WSManConnectionInfo</b></a> class. </li><li>Setting <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd536113">
<b>OperationTimeout</b></a> and <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd536112">
<b>OpenTimeOut</b></a> using this <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182592">
<b>WSManConnectionInfo</b></a> instance. </li><li>Using this <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182592">
<b>WSManConnectionInfo</b></a> instance to establish a remote connection. </li><li>Closing the remote connection. </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd182592"><b>WSManConnectionInfo</b></a>
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
<p>The executable will be built in the default<b> \bin</b> or <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Verify that Windows PowerShell remoting is enabled. You can run the following command for additional information about how to enable this feature:
<code>help about_remote</code>. </li><li>Start the Command Prompt as Administrator. </li><li>Navigate to the folder containing the sample executable. </li><li>Run the executable. </li><li>See the output results and the corresponding code. </li></ol>
<p></p>
</div>
