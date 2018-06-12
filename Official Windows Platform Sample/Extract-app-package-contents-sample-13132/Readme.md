# Extract app package contents sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Packaging
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:20:40
## Description

<div id="mainSection">
<p>This sample demonstrates how to read an app package and extract its contents to disk by using the app
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446766">Packaging API</a>.
</p>
<p>Users acquire your app as an app package. Windows uses the information in an app package to install the app on a per-user basis, and ensure that all traces of the app are gone from the device after all users who installed the app uninstall it. Each package
 consists of the files that constitute the app, along with a package manifest file that describes the app to Windows.</p>
<p>The sample covers the following tasks:</p>
<ul>
<li>Use <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446677">
<b>IAppxFactory::CreatePackageReader</b></a> to create a package reader </li><li>Use <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446758">
<b>IAppxPackageReader::GetFootprintFile</b></a> to get each footprint file </li><li>Use <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446761">
<b>IAppxPackageReader::GetPayloadFiles</b></a> to enumerate the payload files </li></ul>
<p class="note"><b>Warning</b>&nbsp;&nbsp;This sample requires Microsoft Visual Studio&nbsp;2013; it doesn't compile with Microsoft Visual Studio Express&nbsp;2013 for Windows.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=236965">Create app package sample</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446618">Quickstart: Extract app package contents</a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh464929">App packages and deployment</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446677"><b>IAppxFactory::CreatePackageReader</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446756"><b>IAppxPackageReader</b></a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh446593">App packaging and deployment</a>
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
<h4><a id="From_the_Command_window"></a><a id="from_the_command_window"></a><a id="FROM_THE_COMMAND_WINDOW"></a>From the Command window</h4>
<ol>
<li>
<p>Open a Command Prompt window.</p>
</li><li>
<p>Go to the directory where you downloaded the ExtractAppx sample.</p>
</li><li>
<p>Run the following command:</p>
<p><b>msbuild ExtractAppx.sln</b></p>
</li></ol>
<h4><a id="From_Visual_Studio"></a><a id="from_visual_studio"></a><a id="FROM_VISUAL_STUDIO"></a>From Visual Studio</h4>
<ol>
<li>
<p>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory where you downloaded the ExtractAppx sample and double-click its Microsoft Visual Studio Solution (.sln) file.</p>
</li><li>
<p>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>Build Solution</b>.</p>
</li></ol>
<h3>Run the sample</h3>
<ol>
<li>
<p>Open a Command Prompt window.</p>
</li><li>
<p>Go to the directory that contains ExtractAppx.exe.</p>
</li><li>
<p>Run the following command:</p>
<p><b>ExtractAppx </b><i>appPackage</i><b>.appx </b><i>outputFolder</i></p>
<p>For testing purposes, you can specify Data\HelloWorld.appx as the package. The contents of this package are written to the
<i>outputFolder</i> directory.</p>
</li></ol>
</div>
