# Hyper-V resource pool management sample
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
* 2013-10-17 02:27:02
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Hyper-V WMI APIs to manage Hyper-V resource pools. The sample demonstrates how to perform each of the following operations:</p>
<ul>
<li>Enumerate and display the resources supported by this sample. </li><li>Create a resource pool using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203725">
<b>CreatePool</b></a> method. </li><li>Display resources for a resource pool using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850200">
<b>Msvm_ResourceAllocationSettingData</b></a> class. </li><li>Modify the host resources in a resource pool using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203727">
<b>ModifyPoolResources</b></a> method. </li><li>Display the setting data for a resource pool using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203732">
<b>Msvm_ResourcePoolSettingData</b></a> class. </li><li>Modify the setting data for a resource pool using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203728">
<b>ModifyPoolSettings</b></a> method. </li><li>Delete a resource pool using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203726">
<b>DeletePool</b></a> method. </li><li>Display the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850201">
<b>Msvm_ResourcePool</b></a>, <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj203732">
<b>Msvm_ResourcePoolSettingData</b></a> and <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850200">
<b>Msvm_ResourceAllocationSettingData</b></a> properties for a resource pool. </li><li>Display the pool identifiers of the child pools for a resource pool. </li><li>Display the pool identifiers of the parent pools for a resource pool. </li><li>Display the allocation capabilities for a resource pool. </li></ul>
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
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled ResourcePools.sln.</p>
</li><li>
<p>Press F7 (or F6 for Microsoft Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>
Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample must be run as an administrator.</p>
<p></p>
<p>This sample can be run in 12 different modes.</p>
<h4><a id="Enumerate_and_display_the_resources_supported_by_this_sample"></a><a id="enumerate_and_display_the_resources_supported_by_this_sample"></a><a id="ENUMERATE_AND_DISPLAY_THE_RESOURCES_SUPPORTED_BY_THIS_SAMPLE"></a>Enumerate and display the resources
 supported by this sample</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe EnumerateSupportedResources</b></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Create_a_resource_pool"></a><a id="create_a_resource_pool"></a><a id="CREATE_A_RESOURCE_POOL"></a>Create a resource pool</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe CreatePool </b><i>ResourceName</i><b> </b><i>PoolId</i><b>
</b><i>PoolName</i><b> </b><i>NewParentPoolIds</i><b> </b><i>ParentPoolHostResources</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li><li><i>PoolName</i> is the name of the new pool. </li><li><i>NewParentPoolIds</i> is a delimited string containing the parent pool identifiers. Each identifier is contained in the &quot;[p]&quot; delimiter. For example, &quot;[p]Pool A[p][p]Pool B[p]&quot;.
</li><li><i>ParentPoolHostResources</i> is a delimited string containing the host resources for each parent pool. This is a string representation of a two-dimensional array, where each host resource is contained in an &quot;[h]&quot; delimiter and each pool is contained in
 a &quot;[p]&quot; delimiter. For example, &quot;[p][h]Child A, Resource 1[h][h]Child A, Resource 2[h][p][p][h]Child B, Resource 1[h][p]&quot;.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Display_resources_for_a_resource_pool"></a><a id="display_resources_for_a_resource_pool"></a><a id="DISPLAY_RESOURCES_FOR_A_RESOURCE_POOL"></a>Display resources for a resource pool</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe DisplayPoolResources </b><i>ResourceName</i><b> </b>
<i>PoolId</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Modify_the_host_resources_in_a_resource_pool"></a><a id="modify_the_host_resources_in_a_resource_pool"></a><a id="MODIFY_THE_HOST_RESOURCES_IN_A_RESOURCE_POOL"></a>Modify the host resources in a resource pool</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe ModifyPoolResources </b><i>ResourceName</i><b> </b>
<i>PoolId</i><b> </b><i>NewParentPoolIds</i><b> </b><i>ParentPoolHostResources</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li><li><i>PoolName</i> is the name of the new pool. </li><li><i>NewParentPoolIds</i> is a delimited string containing the parent pool identifiers. Each identifier is contained in the &quot;[p]&quot; delimiter. For example, &quot;[p]Pool A[p][p]Pool B[p]&quot;.
</li><li><i>ParentPoolHostResources</i> is a delimited string containing the host resources for each parent pool. This is a string representation of a two-dimensional array, where each host resource is contained in an &quot;[h]&quot; delimiter and each pool is contained in
 a &quot;[p]&quot; delimiter. For example, &quot;[p][h]Child A, Resource 1[h][h]Child A, Resource 2[h][p][p][h]Child B, Resource 1[h][p]&quot;.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Display_the_setting_data_for_a_resource_pool"></a><a id="display_the_setting_data_for_a_resource_pool"></a><a id="DISPLAY_THE_SETTING_DATA_FOR_A_RESOURCE_POOL"></a>Display the setting data for a resource pool</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe DisplayPoolSettings </b><i>ResourceName</i><b> </b>
<i>PoolId</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Modify_the_setting_data_for_a_resource_pool"></a><a id="modify_the_setting_data_for_a_resource_pool"></a><a id="MODIFY_THE_SETTING_DATA_FOR_A_RESOURCE_POOL"></a>Modify the setting data for a resource pool</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe ModifyPoolSettings </b><i>ResourceName</i><b> </b><i>PoolId</i><b>
</b><i>NewPoolId</i><b> </b><i>NewPoolName</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li><li><i>NewPoolId</i> is the new pool identifier. </li><li><i>NewPoolName</i> is the new pool name. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Delete_a_resource_pool"></a><a id="delete_a_resource_pool"></a><a id="DELETE_A_RESOURCE_POOL"></a>Delete a resource pool</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe DeletePool </b><i>ResourceName</i><b> </b><i>PoolId</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Display_verbose_information_for_a_resource_pool"></a><a id="display_verbose_information_for_a_resource_pool"></a><a id="DISPLAY_VERBOSE_INFORMATION_FOR_A_RESOURCE_POOL"></a>Display verbose information for a resource pool</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe DisplayPool </b><i>ResourceName</i><b> </b><i>PoolId</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Display_child_pools"></a><a id="display_child_pools"></a><a id="DISPLAY_CHILD_POOLS"></a>Display child pools</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe DisplayChildPools </b><i>ResourceName</i><b> </b><i>PoolId</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Display_parent_pools"></a><a id="display_parent_pools"></a><a id="DISPLAY_PARENT_POOLS"></a>Display parent pools</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe DisplayParentPools </b><i>ResourceName</i><b> </b><i>PoolId</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Display_the_allocation_capabilities_for_a_resource_pool."></a><a id="display_the_allocation_capabilities_for_a_resource_pool."></a><a id="DISPLAY_THE_ALLOCATION_CAPABILITIES_FOR_A_RESOURCE_POOL."></a>Display the allocation capabilities for
 a resource pool.</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ResourcePoolSamples.exe DisplayAllocationCapabilities </b><i>ResourceName</i><b>
</b><i>PoolId</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>ResourceName</i> is the friendly name of the resource type. The friendly names of the resources can be obtained by running this sample with the &quot;EnumerateSupportedResources&quot; option.
</li><li><i>PoolId</i> is the pool identifier for the new pool. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
</div>
