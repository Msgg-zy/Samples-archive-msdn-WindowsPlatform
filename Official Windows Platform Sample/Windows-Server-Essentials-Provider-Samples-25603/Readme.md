# Windows Server Essentials Provider Samples
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Windows Server Essentials
## IsPublished
* True
## ModifiedDate
* 2013-10-17 01:17:52
## Description

<div id="mainSection">
<p>The Provider Framework is a communication framework in Windows Server Essentials that allows a developer to develop server management components. This sample shows how to create a provider to create a chat room and how to interact between the UI and the
 provider. </p>
<p>For more information about running the ChatProvider sample, see <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/gg513899">
Creating a Provider</a>. This topic is a mult-step walkthrough, based on this sample, for building a Windows Server Essentials provider.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href=" http://go.microsoft.com/fwlink/?LinkId=302084">Windows Dev Center</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/gg513958">Windows Server Essentials</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/gg513899">Creating a Provider</a>
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
<ol>
<li>Confirm that you have a Windows 2012 R2 Server with the Essentials Experience role enabled.
</li><li>
<p>Use Windows Explorer to navigate to the <b>%WinDir%\Microsoft.NET\assembly\GAC_MSIL</b> directory, and locate the following files:</p>
<ul>
<li>ProviderFramework.dll </li></ul>
<p></p>
</li><li>Copy these files into the <b>\Library</b> directory of the unzipped sample. </li><li>Start Microsoft Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>
Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>After you have created the provider files, you must install the provider files by copying the assemblies to folders on the target server.
</p>
<ol>
<li>Copy the .exe file for the ChatWindow project from the <b>bin\Debug</b> folder to
<b>%Program Files%\Windows Server\Bin</b>. </li><li>Copy the .dll files for the ChatSample.ObjectModel project from the <b>bin\Debug</b> folder to
<b>%Program Files%\Windows Server\Bin</b>. </li><li>Copy the .exe for the ChatSample project from the <b>bin\Debug</b> folder to <b>
%Program Files%\Windows Server\Bin</b>. </li><li>Run the ChatSample.exe file and then run one or more copies of the ChatWindow.exe file.
</li></ol>
<p></p>
</div>
