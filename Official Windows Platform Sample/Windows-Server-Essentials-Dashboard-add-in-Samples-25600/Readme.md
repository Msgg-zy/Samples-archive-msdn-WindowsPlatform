# Windows Server Essentials Dashboard add-in Samples
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
* 2013-10-17 01:17:42
## Description

<div id="mainSection">
<p>This sample demonstrates how to develop various add-ins to the Windows Server Essentials Dashboard.
</p>
<p>The Windows Server Essentials Dashboard is a UI designed to help simplify complex administrative tasks, and provide a consistent experience for an administrator. The Dashboard also exposes an API that allows 3rd party developers to add in their own functionality.
 This extended sample describes a number of ways a developer can add or modify Dashboard features, as described in the list below. Note that many of these tasks are also described in the Windows Server Essentials SDK documentation.</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following:</p>
<ol>
<li>Adding a Common Task </li><li>Adding a Community Link </li><li>Adding a Quick Status </li><li>Adding a listview </li><li>Adding a WinForm Control </li><li>Adding a WPF Control </li><li>Extended a Tab </li><li>Adding a top-level Tab with Listview </li><li>Adding a top-level tab with multiple subtabs </li><li>Adding a top-level tab with WinForm control </li><li>Adding a top-level tab with WPF control and extended user tabs </li></ol>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href=" http://go.microsoft.com/fwlink/?LinkId=302084">Windows Dev Center</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/gg513958">Windows Server Essentials</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/gg513895">Creating a Dashboard Add-In</a>
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
<li>HomeAddinContract.dll </li><li>Microsoft.windowsserversolutions.administration.objectmodel.dll </li></ul>
<p></p>
</li><li>Copy these two files into the <b>\Library</b> directory of the unzipped sample.
</li><li>Start Microsoft Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>
Project/Solution</b>. </li><li>Go to the directory in which you unzipped sample. Go to the directory named for the sample, and double-click the Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>The dashboard sample contain a number of dashboard add-ins that you can run on your Windows Server Essentials system. Generally, you can run each sample by taking the generated add-in (.addin) file and placing the file in the
<b>%Program Files%\Windows Server\Bin\Addins\Users</b> directory. You may need to to re-start Server Manager to see the new additions. For more information, see the
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/gg513895">Creating a Dashboard Add-In</a> topic and sub-topics. The sample also contains readme files that describe how to access certain add-in features.</p>
</div>
