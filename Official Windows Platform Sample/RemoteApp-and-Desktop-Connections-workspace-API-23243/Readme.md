# RemoteApp and Desktop Connections workspace API sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* Networking
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:26:14
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="js_rds_metro.workspacebrokerax">
<b>WorkspaceBrokerAx</b></a> object in a Windows&nbsp;8 app. Specifically, this sample demonstrates how to perform the following operations:</p>
<ul>
<li>Create the <a href="js_rds_metro.workspacebrokerax"><b>WorkspaceBrokerAx</b></a> object.
</li><li>Initialize the <a href="js_rds_metro.workspacebrokerax"><b>WorkspaceBrokerAx</b></a> object using the
<a href="js_rds_metro.workspacebrokerax_initializeworkspaceconfiguration"><b>InitializeWorkspaceConfiguration</b></a> method.
</li><li>Subscribe to a RemoteApp and Desktop Connections workspace using the <a href="js_rds_metro.workspacebrokerax_setupworkspace">
<b>SetupWorkspace</b></a> method. This also shows how to support the <a href="js_rds_metro.onworkspacesetupcompleted_event">
<b>OnWorkspaceSetupCompleted</b></a> event. </li><li>Display workspace folders and items using the following properties:
<ul>
<li><a href="js_rds_metro.workspacebrokerax_workspacescount"><b>WorkspacesCount</b></a>
</li><li><a href="js_rds_metro.workspacebrokerax_workspaceid"><b>WorkspaceId</b></a> </li><li><a href="js_rds_metro.workspacebrokerax_workspacename"><b>WorkspaceName</b></a>
</li><li><a href="js_rds_metro.workspacebrokerax_workspacefolderscount"><b>WorkspaceFoldersCount</b></a>
</li><li><a href="js_rds_metro.workspacebrokerax_workspacefoldername"><b>WorkspaceFolderName</b></a>
</li><li><a href="js_rds_metro.workspacebrokerax_workspacefoldercontentscount"><b>WorkspaceFolderContentsCount</b></a>
</li><li><a href="js_rds_metro.workspacebrokerax_workspacefolderitemname"><b>WorkspaceFolderItemName</b></a>
</li><li><a href="js_rds_metro.workspacebrokerax_workspacefolderimagedata"><b>WorkspaceFolderImageData</b></a>
</li><li><a href="js_rds_metro.workspacebrokerax_workspacefolderitemfileextension"><b>WorkspaceFolderItemFileExtension</b></a>
</li><li><a href="js_rds_metro.workspacebrokerax_isworkspacefolderitemremotedesktop"><b>IsWorkspaceFolderItemRemoteDesktop</b></a>
</li></ul>
</li><li>Launch a workspace item using the <a href="js_rds_metro.workspacebrokerax_launchworkspaceitem">
<b>LaunchWorkspaceItem</b></a> method. </li></ul>
<p></p>
<p>This sample is written in JavaScript and requires some experience with JavaScript and HTML programming.</p>
<p>The Windows Samples Gallery contains a variety of code samples that demonstrate the use of various new programming features for Remote Desktop that are available to apps in Windows&nbsp;8 and/or Windows Server&nbsp;2012. These downloadable samples are provided as
 compressed ZIP files that contain a Microsoft Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="js_rds_metro.remoteapp_and_desktop_connections_workspaces_api">RemoteApp and Desktop Connections workspaces API</a>
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
<li>Start Visual Studio&nbsp;2012 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2012 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To run the app in the debugger, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
