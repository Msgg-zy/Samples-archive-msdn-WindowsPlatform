# Volume Shadow Copy Service hardware provider sample
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
* 2013-10-17 02:30:15
## Description

<div id="mainSection">
<p>This sample demonstrates the use of the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb968832">
Volume Shadow Copy Service</a> (VSS) COM interfaces to create a VSS hardware provider.
</p>
<p>This sample is written in C&#43;&#43; and requires some experience with COM.</p>
<p>This sample contains the following files:</p>
<ul>
<li>async.h </li><li>eventlogmsgs.mc </li><li>install-sampleprovider.cmd </li><li>readme.txt </li><li>resource.h </li><li>sampleprovider.cpp </li><li>sampleprovider.h </li><li>sampleprovider.rgs </li><li>setup.txt </li><li>stdafx.cpp </li><li>stdafx.h </li><li>uninstall-sampleprovider.cmd </li><li>utility.cpp </li><li>utility.h </li><li>vsssampleprovider.cpp </li><li>vsssampleprovider.def </li><li>vsssampleprovider.idl </li><li>vsssampleprovider.rc </li><li>vsssampleprovider.rgs </li><li>VssSampleProvider.sln </li><li>VssSampleProvider.vcxproj </li><li>VssSampleProvider.vcxproj.filters </li><li>vstorinterface.h </li></ul>
<p></p>
<p>This sample also requires the following files in the Windows SDK:</p>
<ul>
<li>register_app.vbs </li><li>virtualstoragevss.sys </li><li>vssampleprovider.dll </li><li>vstorcontrol.exe </li><li>vstorinterface.dll </li></ul>
<p></p>
<p>The following VSS API elements are used or implemented in the sample:</p>
<ul>
<li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa381923"><b>IVssAdmin::RegisterProvider</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384241"><b>IVssHardwareSnapshotProvider::AreLunsSupported</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384243"><b>IVssHardwareSnapshotProvider::BeginPrepareSnapshot</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384245"><b>IVssHardwareSnapshotProvider::FillInLunInfo</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384251"><b>IVssHardwareSnapshotProvider::GetTargetLuns</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384256"><b>IVssHardwareSnapshotProvider::LocateLuns</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384259"><b>IVssHardwareSnapshotProvider::OnLunEmpty</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384265"><b>IVssProviderCreateSnapshotSet::AbortSnapshots</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384269"><b>IVssProviderCreateSnapshotSet::CommitSnapshots</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384272"><b>IVssProviderCreateSnapshotSet::EndPrepareSnapshots</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384277"><b>IVssProviderCreateSnapshotSet::PostCommitSnapshots</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384278"><b>IVssProviderCreateSnapshotSet::PostFinalCommitSnapshots</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384279"><b>IVssProviderCreateSnapshotSet::PreCommitSnapshots</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384280"><b>IVssProviderCreateSnapshotSet::PreFinalCommitSnapshots</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384282"><b>IVssProviderNotifications::OnLoad</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa384283"><b>IVssProviderNotifications::OnUnload</b></a>
</li></ul>
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
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa381601">Developing VSS Hardware Providers</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb968832">Volume Shadow Copy Service</a>
<h3>Operating system requirements</h3>
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
<h3>Build the sample</h3>
<p>To build the sample using the command line:</p>
<ul>
<li>Open the <b>Command Prompt </b>window and navigate to the directory. </li><li>Type <b>msbuild VssSampleProvider.sln</b>. </li></ul>
<p>To build the sample using Visual Studio&nbsp;2013 (preferred method):</p>
<ul>
<li>Open File Explorer and navigate to the directory. </li><li>Double-click the icon for the .sln (solution) file to open the file in Visual Studio.
</li><li>In the <b>Build</b> menu, select <b>Build Solution</b>. The application will be built in the default \Debug or \Release directory.
</li></ul>
<h3>Run the sample</h3>
<p class="note"><b>Note</b>&nbsp;&nbsp;You must run this sample as an administrator.</p>
<p></p>
<ol>
<li>Install the virtual storage driver as follows:
<ol>
<li>Navigate to the Program Files (x86)\Windows Kits\8.0\bin\x86 directory in the Windows SDK. This directory contains virtualstoragevss.sys and vstorcontrol.exe.
</li><li>Type <b>vstorcontrol.exe install</b> at the command prompt. </li></ol>
</li><li>Install the VSS sample provider as follows:
<ol>
<li>Copy the following files from the Program Files (x86)\Windows Kits\8.0\bin\x86 directory into the VssSampleProvider directory in the downloaded sample.
<ul>
<li>VssSampleProvider.dll </li><li>VstorInterface.dll </li><li>install-sampleprovider.cmd </li><li>uninstall-sampleprovider.cmd </li><li>register_app.vbs </li></ul>
</li><li>In the VssSampleProvider directory, type <b>install-sampleprovider.cmd</b> at the command prompt.
</li></ol>
</li><li>Create one or more virtual LUNs as follows:
<ol>
<li>At the command prompt, type <b>vstorcontrol.exe create fixeddisk -newimage C:\disk1.image -size 20M -storid &quot;VSS Sample HW Provider&quot;</b>. This creates a virtual LUN whose storage identifier is &quot;VSS Sample HW Provider&quot;. To create additional virtual LUNs,
 repeat this step.
<p class="note"><b>Note</b>&nbsp;&nbsp;The VSS sample provider will recognize a LUN only if &quot;VSS Sample HW Provider&quot; is a part of the storage identifier. For more information about the storage identifier, see
<a href=" http://go.microsoft.com/fwlink/p/?linkid=251516">LUN-Resync with DiskShadow and Virtual Storage</a> on MSDN.</p>
</li><li>Use diskpart.exe or diskmgmt.msc to format the virtual disk and assign a drive letter to it.
</li></ol>
</li><li>Run the sample provider by typing the following at the command prompt:
<p><b>Run vshadow.exe -p -nw </b><i>DriveLetter</i></p>
<p>where <i>DriveLetter</i> is the drive letter of the virtual LUN.</p>
</li><li>To uninstall the VSS sample provider, do the following:
<ol>
<li>In the VssSampleProvider directory, type <b>uninstall-sampleprovider.cmd</b> at the command prompt.
</li><li>Uninstall the virtual storage driver by typing <b>vstorcontrol.exe uninstall</b> at the command prompt.
</li></ol>
</li></ol>
<p></p>
</div>
