# Hyper-V storage QoS sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Win32
## Topics
* desktop
## IsPublished
* True
## ModifiedDate
* 2013-10-17 01:17:28
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Hyper-V WMI storage APIs to configure and monitor Quality of Service for virtual disks. The sample demonstrates how to perform each of the following operations:</p>
<ul>
<li>Read current Quality of Service settings for a virtual disk. </li><li>Modify Quality of Service settings for a virtual disk. </li><li>Monitor whether the Quality of Service requirements for a virtual disk are being satisfied.
</li></ul>
<p></p>
<p>This sample is written in C# and requires some experience with WMI programming.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850319">Hyper-V WMI provider (V2)</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd323653">Virtual Storage</a>
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
<ol>
<li>
<p>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled StorageQoS.sln.</p>
</li><li>
<p>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample must be run as an administrator.</p>
<p></p>
<p>This sample can be run in several different modes. To obtain a list of the operations, use the following command line:
</p>
<p><b>StorageQoSSamples.exe /?</b> </p>
<p>To debug the app and then run it from Visual Studio&nbsp;2013, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<h4><a id="__Read_Quality_of_Service_settings_for_a_virtual_disk"></a><a id="__read_quality_of_service_settings_for_a_virtual_disk"></a><a id="__READ_QUALITY_OF_SERVICE_SETTINGS_FOR_A_VIRTUAL_DISK"></a>Read Quality of Service settings for a virtual disk</h4>
<p>To run this sample in this mode, follow these steps. </p>
<dl><dd>
<p>1. Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>StorageQoSSamples.exe get</b> &nbsp;<i>Host VirtualMachineName VhdPath</i></p>
<p>Where the parameters are as follows:</p>
<ul>
<li><i>Host</i> specifies the name of the Hyper-V server to connect to. </li><li><i>VirtualMachineName</i> specifies the name of the virtual machine. </li><li><i>VhdPath</i> specifies the full path of the VHD to query. </li></ul>
</dd><dd>
<p>2. To debug the app and then run it from Visual Studio&nbsp;2013, press F5 or use <b>
Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</dd><dd>
<p>3. The final result of the operation will be displayed in the console window.</p>
</dd></dl>
<h4><a id="Modify_Quality_of_Service_settings_for_a_virtual_disk"></a><a id="modify_quality_of_service_settings_for_a_virtual_disk"></a><a id="MODIFY_QUALITY_OF_SERVICE_SETTINGS_FOR_A_VIRTUAL_DISK"></a>Modify Quality of Service settings for a virtual
 disk</h4>
<p>To run this sample in this mode, follow these steps.</p>
<dl><dd>
<p>1. Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>StorageQoSSamples.exe set</b>&nbsp; <i>Host VirtualMachineName VhdPath (-max | -min) IOPS</i></p>
<p>Where the parameters are as follows:</p>
<ul>
<li><i>Host</i> specifies the name of the Hyper-V server to connect to. </li><li><i>VirtualMachineName</i> specifies the name of the virtual machine. </li><li><i>VhdPath</i> specifies the full path of the VHD to modify </li><li><i>IOPS</i> specifies the maximum throughput (if the -max switch is specified) or the minimum throughput (if the
<i>-min </i>switch is specified) for the virtual disk. </li></ul>
</dd><dd>
<p>2. To debug the app and then run it from Visual Studio&nbsp;2013, press F5 or use <b>
Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</dd><dd>
<p>3. The final result of the operation will be displayed in the console window.</p>
</dd></dl>
<h4><a id="Monitor_whether_Quality_of_Service_requirements_are_being_satisfied"></a><a id="monitor_whether_quality_of_service_requirements_are_being_satisfied"></a><a id="MONITOR_WHETHER_QUALITY_OF_SERVICE_REQUIREMENTS_ARE_BEING_SATISFIED"></a>Monitor
 whether Quality of Service requirements are being satisfied</h4>
<p>To run this sample in this mode, follow these steps.</p>
<dl><dd>
<p>1. Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>StorageQoSSamples.exe monitor</b> &nbsp;<i>Host</i> </p>
<p>where <i>Host</i> is the name of the Hyper-V server to connect to and monitor.</p>
</dd><dd>
<p>2. To debug the app and then run it from Visual Studio&nbsp;2013, press F5 or use <b>
Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</dd><dd>
<p>3. The final result of the operation will be displayed in the console window.</p>
</dd></dl>
</div>
