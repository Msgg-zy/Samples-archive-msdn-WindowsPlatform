# Hyper-V recovery snapshot sample
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
* 2013-10-17 02:18:07
## Description

<div id="mainSection">
<p>This sample demonstrates how to set up and use the Hyper-V backup WMI APIs. The sample demonstrates how to perform each of the following operations:</p>
<ul>
<li>Create a recovery snapshot using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850037">
<b>CreateSnapshot</b></a> method. </li><li>Modify the incremental backup options for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850104">
<b>ModifySystemSettings</b></a> method. </li><li>List the recovery snapshots for a virtual machine using the related <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850257">
<b>Msvm_VirtualSystemSettingData</b></a> class. </li></ul>
<p></p>
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
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled Backup.sln.</p>
</li><li>
<p>Press F7 (or F6 for Microsoft Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>
Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample must be run as an administrator.</p>
<p></p>
<p>This sample can be run in three different modes.</p>
<h4><a id="Create_a_recovery_snapshot"></a><a id="create_a_recovery_snapshot"></a><a id="CREATE_A_RECOVERY_SNAPSHOT"></a>Create a recovery snapshot</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>Backup.exe create-recovery-snapshot </b><i>hostMachine</i><b> </b><i>vmName</i></p>
<p>where <i>hostMachine</i> is the name of the computer that is hosting the virtual machine and
<i>vmName</i> is the name of the virtual machine to create a recovery snapshot of.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The progress and final result of the operation will be displayed in the console window.
</li></ol>
<h4><a id="Toggle_the_incremental_backup_setting_for_a_virtual_machine"></a><a id="toggle_the_incremental_backup_setting_for_a_virtual_machine"></a><a id="TOGGLE_THE_INCREMENTAL_BACKUP_SETTING_FOR_A_VIRTUAL_MACHINE"></a>Toggle the incremental backup setting
 for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>Backup.exe toggle-incremental </b><i>hostMachine</i><b> </b><i>vmName</i></p>
<p>where <i>hostMachine</i> is the name of the computer that is hosting the virtual machine and
<i>vmName</i> is the name of the virtual machine to toggle the incremental backup setting for.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The progress and final result of the operation will be displayed in the console window.
</li></ol>
<h4><a id="List_the_recovery_snapshots_for_a_virtual_machine"></a><a id="list_the_recovery_snapshots_for_a_virtual_machine"></a><a id="LIST_THE_RECOVERY_SNAPSHOTS_FOR_A_VIRTUAL_MACHINE"></a>List the recovery snapshots for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>Backup.exe list-recovery-snapshot </b><i>hostMachine</i><b> </b><i>vmName</i></p>
<p>where <i>hostMachine</i> is the name of the computer that is hosting the virtual machine and
<i>vmName</i> is the name of the virtual machine to list the recovery snapshots for.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The progress and final result of the operation will be displayed in the console window.
</li></ol>
</div>
