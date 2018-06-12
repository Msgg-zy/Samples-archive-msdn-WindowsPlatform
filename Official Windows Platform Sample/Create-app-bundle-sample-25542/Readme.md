# Create app bundle sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Packaging
## IsPublished
* True
## ModifiedDate
* 2013-10-17 01:14:47
## Description

<div id="mainSection">
<p>This sample shows you how to create an app bundle using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446766">
Packaging API</a>. </p>
<p>The sample covers these tasks:</p>
<ul>
<li>Use <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280280">
<b>IAppxBundleFactory::CreateBundleWriter</b></a> to create a bundle writer </li><li>Use <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280303">
<b>IAppxBundleWriter::AddPayloadPackage</b></a> to add the payload packages to the bundle
</li><li>Create an input stream and use <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280304">
<b>IAppxBundleWriter::Close</b></a> to flush the stream </li></ul>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280280"><b>IAppxBundleFactory::CreateBundleWriter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280302"><b>IAppxBundleWriter</b></a>
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
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
