# Windows Server Essentials HostedEmail add-in samples
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
* 2013-10-17 01:17:46
## Description

<div id="mainSection">
<p>This sample describes the key components for a hosted email add-in, a mockup service, and a logging helper for Windows Server Essentials.
</p>
<p>Windows Server Essentials allows email service hosts to develop an add-in to integrate Essentials features via the Hosted Email Add-in Framework. This sample describes how to create and build a hosted email add-in provider, a log monitor, additions to the
 Dashboard UI, as well as a custom Windows Installer package. The sample also includes a simulated email service, which the provider links to in order to demonstrate simple email features.
</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href=" http://go.microsoft.com/fwlink/?LinkId=302084">Windows Dev Center</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/gg513958">Windows Server Essentials</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj991858">Working with a Hosted Email Service</a>
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
<li>Confirm that you have a Windows 2012 R2 Server with the Essentials Experience role enabled.
</li><li>
<p>Use Windows Explorer to navigate to the <b>%WinDir%\Microsoft.NET\assembly\GAC_MSIL</b> directory, and locate the following files:</p>
<ul>
<li>HomeAddinContract.dll </li><li>Microsoft.windowsserversolutions.administration.objectmodel.dll </li><li>Wssg.HostedEmailBase.dll </li><li>Wssg.HostedEmailObjectModel.dll </li><li>AdminCommon.dll </li><li>ProviderFrameworkExtended.dll </li><li>ProviderFramework.dll </li></ul>
<p></p>
</li><li>Copy these files into the <b>\Library</b> directory of the unzipped sample. </li><li>Confirm that you have the WIX toolset installed on your system. For more information, see
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/gg513936">How to: Install the Windows Installer XML (WiX) Tools</a>.
</li><li>Start Microsoft Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>
Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ul>
<li>For information on how to set up and run the sample, see <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj991886">
Quickstart: Creating a Hosted Email Adapter</a>. </li></ul>
<p></p>
</div>
