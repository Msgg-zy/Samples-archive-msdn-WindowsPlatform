# Windows Powershell  role-based OData Web Service sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Network security
## IsPublished
* True
## ModifiedDate
* 2014-01-10 12:51:15
## Description

<div id="mainSection">
<p>Using the Management OData Web Service requires a third party to implement the Microsoft.Management.OData.CustomAuthorization and System.Management.Automation.Remoting.PSSessionConfiguration interfaces to expose Windows PowerShell cmdlets. These interfaces
 perform user authorization and provide PowerShell session configuration. This sample shows an implementation of the two interfaces using a role-based authorization model. This model can define multiple roles. Each role is associated with a group of users.
 Each role is also associated with a set of cmdlets, scripts, and modules. A user can be assigned to only one of these roles, and that user can run only the set of cmdlets, scripts, and modules associated with that role.
</p>
<p class="note"><b>Important</b>&nbsp;&nbsp;This sample requires Microsoft Visual Studio&nbsp;2013 or Microsoft Visual Studio&nbsp;2010. It doesn't compile in Microsoft Visual Studio Express&nbsp;2013 for Windows.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h2>Operating system requirements</h2>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>None supported </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012&nbsp;R2 </dt></td>
</tr>
</tbody>
</table>
<h2>Build the sample</h2>
<p>This sample must be built on a computer that is running Windows Server&nbsp;2012&nbsp;R2 with the
<b>Management OData IIS Extension</b> feature installed. To install this feature:</p>
<ol>
<li>Open an elevated PowerShell window. </li><li>Enter <b>Set-ExecutionPolicy -ExecutionPolicy Unrestricted</b>. </li><li>Enter <i>TargetDirectory</i><b> PswsRoleBasedPlugins\C#\setup\InstallModata.ps1</b>.
</li></ol>
<p>To build the sample using Visual Studio&nbsp;2013:</p>
<ol>
<li>
<p>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled RoleBasedPlugins.sln.</p>
</li><li>
<p>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<p>To build the sample from a Command Prompt window:</p>
<ol>
<li>Open a Command Prompt window and navigate to the sample directory. </li><li>Enter <b>msbuild RoleBasedPlugins.sln</b>. </li></ol>
<h2>Run the sample</h2>
<ol>
<li>Open an elevated PowerShell window. </li><li>Navigate to the solution \Debug or \Release directory. </li><li>Enter <b>.\setupEndPoint.ps1</b>. </li></ol>
</div>
