# Setting central access control and resource attributes sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Security
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:27:00
## Description

<div id="mainSection">
<p>Demonstrates setting both central access policies and resource attributes to a security descriptor and displaying the access granted by
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375788"><b>AuthzAccessCheck</b></a>.
</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was previously entitled as the Resource attributes sample.</p>
<p></p>
<p>The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples are provided as compressed
 ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming models, platforms, languages,
 and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to indicate or demonstrate the functionality
 of the programming models and feature APIs for Windows&nbsp;8.1 and Windows Server&nbsp;2012&nbsp;R2.
</p>
<p>Please provide feedback on this sample! </p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375788"><b>AuthzAccessCheck</b></a>
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
<p>To build this sample, open the ResourceAttributesSample.sln solution file in Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). Press F7 (or F6 for Visual Studio&nbsp;2013) or go to Build-&gt;Build Solution from the top menu after the sample has loaded.</p>
<h3>Run the sample</h3>
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl-F5 (run without debugging enabled) from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the Debug menu.) When executed without any
 command line options, the output contains a description of the usage of the tool. To be able to exercise the options involving Central Access Policy IDs or resource claims, you need to run this sample in an environment where claim types and Central Access
 Policies have been defined for the forest and the Central Access Policy being used is applied to the machine the tool is running on.</p>
</div>
