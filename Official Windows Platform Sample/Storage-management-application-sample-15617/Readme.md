# Storage management application sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Storage
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:28:47
## Description

<div id="mainSection">
<p>This sample is an end-to-end application that uses the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh830613">
Windows Storage Management API</a> to create a formatted volume on a storage subsystem.
</p>
<p>This sample performs the following steps:</p>
<ol>
<li>Gets the subsystem object from the subsystem name that a user specified. </li><li>Creates a storage pool in the storage subsystem using one physical disk. </li><li>Creates a virtual disk in the storage pool. </li><li>Creates a partition on the virtual disk. </li><li>Creates an NTFS volume on the partition. </li><li>Formats the volume. </li></ol>
<p></p>
<p>This sample is written in C&#43;&#43; and requires some experience with WMIv2 programming.
</p>
<p>It is intended to be used by storage application programmers and assumes familiarity with storage hardware programming and storage industry standards such as the
<a href=" http://go.microsoft.com/fwlink/p/?linkid=161225">SMI-S v1.5 specification</a>, which can be downloaded from the
<a href="http://go.microsoft.com/fwlink/p/?linkid=161226">SNIA website</a>.</p>
<p>This sample contains the following files:</p>
<ul>
<li>StorageManagementApplication.cpp </li><li>StorageManagementApplication.h </li><li>StorageManagementApplication.sln </li><li>StorageManagementApplication.vcxproj </li><li>StorageManagementApplication.vcxproj.filters </li></ul>
<p></p>
<p class="note"><b>Warning</b>&nbsp;&nbsp;This sample requires Microsoft Visual Studio&nbsp;2013 and will not compile in Microsoft Visual Studio Express&nbsp;2013 for Windows.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh830613">Windows Storage Management API</a>
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
<p>To build this sample, open the solution (.sln) file titled StorageManagementApplication.sln from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). Press F7 (or F6 for Visual Studio&nbsp;2013) or go to
<b>Build-&gt;Build Solution</b> from the top menu after the sample has loaded.</p>
<h3>Run the sample</h3>
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl-F5 (run without debugging enabled) from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the
<b>Debug</b> menu.)</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The user needs to specify the name of the subsystem that the system has.</p>
</div>
