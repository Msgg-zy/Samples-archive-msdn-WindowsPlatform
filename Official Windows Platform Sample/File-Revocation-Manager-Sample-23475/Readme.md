# File Revocation Manager Sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* XAML
* Windows Runtime
## Topics
* Security
* Data
* Files
## IsPublished
* True
## ModifiedDate
* 2013-12-12 11:33:22
## Description

<div id="mainSection">
<p>This sample demonstrates how to use File Revocation Manager API to protect files or folders using Selective Wipe.
</p>
<p>Selective Wipe enables you to identify specify folders and files on a user’s PC as protected. This means that your app can revoke access to all files and folders for a particular enterprise identity when it receives a command from a server. This is especially
 relevant for businesses and enterprises in the case when an employee has company files on a personal device and then leaves the company.</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/dn279148"><b>FileRevocationManager</b></a> class provides the following methods to perform Selective Wipe operations.</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/dn279151"><b>ProtectAsync</b></a> - protect a file or folder for an enterprise id using Selective Wipe.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dn279149"><b>CopyProtectionAsync</b></a> - copy the protection from one file or folder to another. This is important when saving a new copy of a file as in a &quot;Save As...&quot; scenario. When copying an
 item, the Selective Wipe protection is copied with it. When saving a new copy of a file, you need to also copy the Selective Wipe protection status to the new file.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dn279152"><b>Revoke</b></a> - revoke all protected files and folders for an enterprise id.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dn279150"><b>GetStatusAsync</b></a> - get the Selective Wipe protection status for a file or folder.
</li></ul>
<p></p>
<p>The File Revocation Manager sample shows how to perform the following Selective Wipe operations.
</p>
<ul>
<li>Use Selective Wipe to protect a file or folder for a specified enterprise id.
</li><li>Copy the Selective Wipe protection of a file or folder to another file or folder.
</li><li>Get the Selective Wipe protection status of a file. </li><li>Revoke all files and folders protected by Selective Wipe for a specified enterprise id.
</li><li>Delete files and folders that have been revoked by Selective Wipe. </li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn279153"><b>Windows.Security.EnterpriseData</b></a>
</dt></dl>
<h2>Operating system requirements</h2>
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
<h2>Build the sample</h2>
<p></p>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
