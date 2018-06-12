# Hyper-V virtual Fiber Channel sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Hyper-V
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:20:44
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Hyper-V WMI Fiber Channel APIs to create, configure, and remove storage area networks and virtual Fiber Channel ports. The sample demonstrates how to perform each of the following operations:</p>
<ul>
<li>Create a virtual storage area network (SAN) and assign resources to it using the
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203725"><b>CreatePool</b></a> method.
</li><li>Delete a virtual SAN using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203726">
<b>DeletePool</b></a> method. </li><li>Modify the settings of a virtual SAN using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203728">
<b>ModifyPoolSettings</b></a> method. </li><li>Modify the resources assigned to a virtual SAN using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203727">
<b>ModifyPoolResources</b></a> method. </li><li>Create a virtual Fiber Channel port for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850020">
<b>Msvm_VirtualSystemManagementService.AddResourceSettings</b></a> method. </li><li>Delete a virtual Fiber Channel port from a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850278">
<b>Msvm_VirtualSystemManagementService.RemoveResourceSettings</b></a> method. </li><li>Configure the world wide name generator to generate world wide names in a specified range using the
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850102"><b>Msvm_VirtualSystemManagementService.ModifyServiceSettings</b></a> method to modify the
<b>MinimumWWPNAddress</b>, <b>MaximumWWPNAddress</b>, and (optionally) <b>CurrentWWNNAddress</b> properties of the
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850254"><b>Msvm_VirtualSystemManagementServiceSettingData</b></a> class.
</li><li>Enumerate the virtual Fiber Channel ports for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh859772">
<b>Msvm_FcPortAllocationSettingData</b></a> and <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh859768">
<b>Msvm_ExternalFcPort</b></a> classes. </li></ul>
<p></p>
<p>This sample is written in C# and requires some experience with WMI programming.</p>
<p>The Windows Samples Gallery contains a variety of code samples that demonstrate the use of various new programming features for managing Hyper-V that are available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples are provided as compressed
 ZIP files that contain a Microsoft Visual Studio&nbsp;2010 solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming models,
 platforms, languages, and APIs demonstrated in this sample, please refer to the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850319">
Hyper-V WMI provider (V2)</a> documentation.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh859763">Hyper-V virtual Fiber Channels API</a>
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
<ol>
<li>
<p>Start Visual Studio&nbsp;2010 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled FibreChannel.sln.</p>
</li><li>
<p>Press F7 (or F6 for Microsoft Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>
Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample must be run as an administrator.</p>
<p></p>
<p>This sample can be run in several different modes. To obtain a list of the operations, use the following command line:</p>
<p><b>FibreChannelSamples.exe /?</b></p>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<h3><a id="Create_a_virtual_SAN"></a><a id="create_a_virtual_san"></a><a id="CREATE_A_VIRTUAL_SAN"></a>Create a virtual SAN</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>FibreChannelSamples.exe CreateSan </b><i>SanName</i><b> (</b><i>WWPN</i><b>
</b><i>WWNN</i><b> &#43;) </b>[<i>&quot;SAN Notes&quot;</i>]</p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>SanName</i> is the name to be applied to the SAN. </li><li><i>WWPN</i> is the port name and <i>WWNN</i> is the node name for the SAN. You can include one or more pairs of these arguments in sequence.
</li><li><i>SAN Notes</i> are the notes for the SAN. The notes must be contained inside of quotation marks. This parameter is optional and a standard note will be added if it is not specified.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Delete_a_virtual_SAN"></a><a id="delete_a_virtual_san"></a><a id="DELETE_A_VIRTUAL_SAN"></a>Delete a virtual SAN</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>FibreChannelSamples.exe DeleteSan </b><i>SanName</i></p>
<p>where <i>SanName</i> is the name of the SAN to delete.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Modify_the_settings_of_a_virtual_SAN"></a><a id="modify_the_settings_of_a_virtual_san"></a><a id="MODIFY_THE_SETTINGS_OF_A_VIRTUAL_SAN"></a>Modify the settings of a virtual SAN</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>FibreChannelSamples.exe ModifySanName </b><i>SanName</i><b> </b><i>NewSanName</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>SanName</i> is the current name of the SAN to be modified. </li><li><i>NewSanName</i> is the new name to be applied to the SAN. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Modify_the_resources_assigned_to_a_virtual_SAN"></a><a id="modify_the_resources_assigned_to_a_virtual_san"></a><a id="MODIFY_THE_RESOURCES_ASSIGNED_TO_A_VIRTUAL_SAN"></a>Modify the resources assigned to a virtual SAN</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>FibreChannelSamples.exe ModifySanPorts </b><i>SanName</i><b> (</b><i>WWPN</i><b>
</b><i>WWNN</i><b> &#43;)</b></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>SanName</i> is the name of the SAN to be modified. </li><li><i>WWPN</i> is the new port name and <i>WWNN</i> is the new node name to be applied to the SAN. You can include one or more pairs of these arguments in sequence.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Create_a_virtual_Fiber_Channel_port_for_a_virtual_machine"></a><a id="create_a_virtual_fiber_channel_port_for_a_virtual_machine"></a><a id="CREATE_A_VIRTUAL_FIBER_CHANNEL_PORT_FOR_A_VIRTUAL_MACHINE"></a>Create a virtual Fiber Channel port for
 a virtual machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>FibreChannelSamples.exe CreateVirtualFcPort </b><i>VmName</i><b> </b><i>SanName</i><b>
</b>[<i>WWPN-A</i>|<i>WWNN-A</i>|<i>WWPN-B</i>|<i>WWNN-B</i>]</p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>VmName</i> is the name of the virtual machine to create the virtual Fiber Channel port for.
</li><li><i>SanName</i> is the name of the SAN. </li><li><i>WWPN-A</i> <i>WWNN-A</i> <i>WWPN-B</i> <i>WWNN-B</i> are the port and node names for the virtual Fiber Channel port. These arguments are optional. If they are not included, these names will be auto-generated.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Delete_a_virtual_Fiber_Channel_port_from_a_virtual_machine"></a><a id="delete_a_virtual_fiber_channel_port_from_a_virtual_machine"></a><a id="DELETE_A_VIRTUAL_FIBER_CHANNEL_PORT_FROM_A_VIRTUAL_MACHINE"></a>Delete a virtual Fiber Channel port
 from a virtual machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>FibreChannelSamples.exe DeleteVirtualFcPort </b><i>VmName</i><b> </b><i>WWPN-A</i><b>
</b><i>WWNN-A</i><b> </b><i>WWPN-B</i><b> </b><i>WWNN-B</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>VmName</i> is the name of the virtual machine to delete the virtual Fiber Channel port from.
</li><li><i>WWPN-A</i> <i>WWNN-A</i> <i>WWPN-B</i> <i>WWNN-B</i> are the port and node names of the virtual Fiber Channel port to delete.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Configure_the_world_wide_name_generator"></a><a id="configure_the_world_wide_name_generator"></a><a id="CONFIGURE_THE_WORLD_WIDE_NAME_GENERATOR"></a>Configure the world wide name generator</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>FibreChannelSamples.exe ConfigureWwnGenerator </b><i>Min WWPN</i><b> </b><i>Max WWPN</i><b>
</b><i>New WWNN</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>Min WWPN</i> is the new minimum world wide port name to use for the <b>MinimumWWPNAddress</b> property.
</li><li><i>Max WWPN</i> is the new maximum world wide port name to use for the <b>MaximumWWPNAddress</b> property.
</li><li><i>New WWNN</i> is the world wide node name to use for the <b>CurrentWWNNAddress</b> property.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Enumerate_the_virtual_Fiber_Channel_ports_for_a_virtual_machine"></a><a id="enumerate_the_virtual_fiber_channel_ports_for_a_virtual_machine"></a><a id="ENUMERATE_THE_VIRTUAL_FIBER_CHANNEL_PORTS_FOR_A_VIRTUAL_MACHINE"></a>Enumerate the virtual
 Fiber Channel ports for a virtual machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>FibreChannelSamples.exe EnumerateFcPorts</b></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
</div>
