# App package information sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* App model
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:20:18
## Description

<div id="mainSection">
<p>This sample shows you how to get package information using the Windows Runtime packaging API.
</p>
<p>Users acquire your Windows Store app as an app package. Windows uses the information in an app package to install the app on a per-user basis, and ensure that all traces of the app are gone from the device after all users who installed the app uninstall
 it. Each package consists of the files that constitute the app, along with a package manifest file that describes the app to Windows.</p>
<p>Each package is defined by a globally unique identifier known as the package identity. Each package is described through package properties such as the display name, description, and logo.</p>
<p>The sample covers these key tasks:</p>
<ul>
<li>Getting the package identity using <a href="http://msdn.microsoft.com/library/windows/apps/br224680">
<b>Package.Id</b></a> </li><li>Getting the package directory using <a href="http://msdn.microsoft.com/library/windows/apps/br224681">
<b>Package.InstalledLocation</b></a> </li><li>Getting package dependencies using <a href="http://msdn.microsoft.com/library/windows/apps/br224679">
<b>Package.Dependencies</b></a> </li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh464929">App packages and deployment</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224667"><b>Windows.ApplicationModel.Package</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224667id"><b>Windows.ApplicationModel.PackageId</b></a>
</dt></dl>
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
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
