# Hyper-V dynamic memory sample
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
* 2013-10-17 02:20:06
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Hyper-V WMI APIs to obtain information about, and modify, dynamic memory in a virtual machine. The sample demonstrates how to perform each of the following operations:</p>
<ul>
<li>Obtain dynamic memory usage information for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850062">
<b>GetSummaryInformation</b></a> method. </li><li>Obtain the swap file data root for a virtual machine from the related <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850257">
<b>Msvm_VirtualSystemSettingData</b></a> class. </li><li>Modify the swap file data root for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850104">
<b>ModifySystemSettings</b></a> method. </li></ul>
<p></p>
<p>This sample is written in C# and requires some experience with WMI programming.</p>
<p>The Windows Samples Gallery contains a variety of code samples that demonstrate the use of various new programming features for managing Hyper-V that are available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples are provided as compressed
 ZIP files that contain a Microsoft Visual Studio&nbsp;2010 solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming models,
 platforms, languages, and APIs demonstrated in this sample, please refer to the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850319">
Hyper-V WMI provider (V2)</a> documentation.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850319">Hyper-V WMI provider (V2)</a>
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
<p>Start Visual Studio&nbsp;2010 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled DynMem.sln.</p>
</li><li>
<p>Press F7 (or F6 for Microsoft Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>
Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample must be run as an administrator.</p>
<p></p>
<p>This sample can be run in three different modes.</p>
<h4><a id="Obtain_dynamic_memory_usage_information_for_a_virtual_machine"></a><a id="obtain_dynamic_memory_usage_information_for_a_virtual_machine"></a><a id="OBTAIN_DYNAMIC_MEMORY_USAGE_INFORMATION_FOR_A_VIRTUAL_MACHINE"></a>Obtain dynamic memory usage
 information for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>DynMem.exe mem-status </b><i>hostMachine</i><b> </b><i>vmName</i></p>
<p>where <i>hostMachine</i> is the name of the computer that is hosting the virtual machine and
<i>vmName</i> is the name of the virtual machine.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Obtain_the_swap_file_data_root_for_a_virtual_machine"></a><a id="obtain_the_swap_file_data_root_for_a_virtual_machine"></a><a id="OBTAIN_THE_SWAP_FILE_DATA_ROOT_FOR_A_VIRTUAL_MACHINE"></a>Obtain the swap file data root for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>DynMem.exe get-swap-root </b><i>hostMachine</i><b> </b><i>vmName</i></p>
<p>where <i>hostMachine</i> is the name of the computer that is hosting the virtual machine and
<i>vmName</i> is the name of the virtual machine.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Modify_the_swap_file_data_root_for_a_virtual_machine"></a><a id="modify_the_swap_file_data_root_for_a_virtual_machine"></a><a id="MODIFY_THE_SWAP_FILE_DATA_ROOT_FOR_A_VIRTUAL_MACHINE"></a>Modify the swap file data root for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>DynMem.exe modify-swap-root </b><i>hostMachine</i><b> </b><i>vmName</i><b> </b>
<i>new-location</i></p>
<p>where <i>hostMachine</i> is the name of the computer that is hosting the virtual machine,
<i>vmName</i> is the name of the virtual machine, and <i>new-location</i> is the path to the new swap file data root directory.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
</div>
