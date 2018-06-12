# Background Transfer sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:06:03
## Description

<div id="mainSection">
<p>This sample demonstrates the power-friendly, cost-aware, and flexible behavior of the Background Transfer API for Windows Runtime applications. Provided sample scenarios cover file downloads and uploads. This sample is currently provided in the JavaScript,
 C#, and C&#43;&#43; programming languages.</p>
<p>Capabilities required by the Background Transfer sample:</p>
<ul>
<li><b>Internet:</b> Background Transfer is only enabled if at least one of the networking capabilities is set:
<b>Client</b>, <b>Client and Server</b>, or <b>Home or Work Networking</b>. </li><li><b>Pictures Library:</b> The sample downloads files to the Pictures library. </li></ul>
<p></p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample communicates with another process on the same machine (IIS server on loopback) for demonstrative purposes only.apps that communicate over loopback to other processes are
<b>not permitted</b>, and will not pass Store validation.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;IIS is not available on ARM builds. Instead, setup the server on a separate amd64/x86 machine and follow the steps for using the sample against non-localhost machine.</p>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700370">Quickstart: Downloading a file</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700372">Quickstart: Uploading a file</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761434">Transferring a file from a network resource</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207242"><b>Windows.Networking.BackgroundTransfer</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br207242"><b>Windows.Networking.BackgroundTransfer</b></a> ,
<a href="http://msdn.microsoft.com/library/windows/apps/br227346"><b>Windows.Storage</b></a>
<h3>Operating system requirements</h3>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012 </dt></td>
</tr>
</tbody>
</table>
<h3>Build the sample</h3>
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<h3><a id="Setting_up_the_localhost_server_"></a><a id="setting_up_the_localhost_server_"></a><a id="SETTING_UP_THE_LOCALHOST_SERVER_"></a>Setting up the localhost server:</h3>
<p>To use the provided server, navigate to the Server folder in your sample and do one of the following:</p>
<ul>
<li>Start PowerShell and Run <b>\SetupScript.ps1</b> </li><li>From the Command Prompt, run <b>PowerShell.exe -ExecutionPolicy Unrestricted -File SetupServer.ps1</b>.
</li></ul>
<p>To shutdown the server when it is no longer needed, navigate to the Server folder in your sample folder and do one of the following:</p>
<ul>
<li>Start PowerShell and run <b>\RemoveScript.ps1</b>. </li><li>From the Command Prompt, run <b>PowerShell.exe -ExecutionPolicy Unrestricted -File RemoveScript.ps1</b>.
</li></ul>
<h3><a id="Running_the_sample_against_custom_or_non-localhost_servers_"></a><a id="running_the_sample_against_custom_or_non-localhost_servers_"></a><a id="RUNNING_THE_SAMPLE_AGAINST_CUSTOM_OR_NON-LOCALHOST_SERVERS_"></a>Running the sample against custom
 or non-localhost servers:</h3>
<p>This sample can run against any server, not only the one we have provided with this sample. In this case, running one of the provided scripts as described in earlier steps is not required. However, the following should be taken into consideration when updating
 the sample to run against a custom or non-localhost server:</p>
<ul>
<li>Additional Network Capabilities may need to be added to the sample project (i.e. &quot;<b>Home or Work Networking</b>&quot; if the server is located on the intranet).
</li><li>The target URI field can be enabled by editing the existing xaml/html sample files. This will allow the target URI to be changed via the user interface.
</li></ul>
</div>
