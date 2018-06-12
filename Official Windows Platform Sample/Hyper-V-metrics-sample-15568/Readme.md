# Hyper-V metrics sample
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
* 2013-10-17 02:24:51
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Hyper-V metrics WMI APIs to manage metrics for a virtual machine. The sample demonstrates how to perform each of the following operations:</p>
<ul>
<li>Enable metrics gathering for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850034">
<b>ControlMetrics</b></a> method. </li><li>Disable metrics gathering for a network adapter using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850034">
<b>ControlMetrics</b></a> method. </li><li>Set the metrics flush interval for all virtual machines using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850100">
<b>ModifyServiceSettings</b></a> method and the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850183">
<b>Msvm_MetricServiceSettingData</b></a> class. </li><li>Determine if metrics collection is enabled for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850178">
<b>Msvm_MetricDefForME</b></a> class. </li><li>Enumerate the discrete metrics for a virtual machine using the related <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850109">
<b>Msvm_AggregationMetricValue</b></a> classes. </li><li>Enumerate the metrics for a resource pool using the related <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850108">
<b>Msvm_AggregationMetricDefinition</b></a> and <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850109">
<b>Msvm_AggregationMetricValue</b></a> classes. </li></ul>
<p></p>
<p>This sample is written in C# and requires some experience with WMI programming.</p>
<p>The Windows Samples Gallery contains a variety of code samples that demonstrate the use of various new programming features for managing Hyper-V that are available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples are provided as compressed
 ZIP files that contain a Microsoft Visual Studio&nbsp;2010 solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming models,
 platforms, languages, and APIs demonstrated in this sample, please refer to the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850319">
Hyper-V WMI provider (V2)</a> documentation.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850072">Hyper-V metrics API</a>
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
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled Metrics.sln.</p>
</li><li>
<p>Press F7 (or F6 for Microsoft Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>
Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample must be run as an administrator.</p>
<p></p>
<p>This sample can be run in six different modes.</p>
<h4><a id="Enable_metrics_gathering_for_a_virtual_machine"></a><a id="enable_metrics_gathering_for_a_virtual_machine"></a><a id="ENABLE_METRICS_GATHERING_FOR_A_VIRTUAL_MACHINE"></a>Enable metrics gathering for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>MetricsSample.exe EnableMetricsForVm </b><i>vmName</i></p>
<p>where <i>vmName</i> is the name of the virtual machine.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Disable_metrics_gathering_for_a_network_adapter"></a><a id="disable_metrics_gathering_for_a_network_adapter"></a><a id="DISABLE_METRICS_GATHERING_FOR_A_NETWORK_ADAPTER"></a>Disable metrics gathering for a network adapter</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>MetricsSample.exe DisableMetricsForNetworkAdapter </b><i>MacAddress</i><b> </b>
<i>IpAddress</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>MacAddress</i> is the MAC address of the network adapter. </li><li><i>IpAddress</i> is the IP address of the port ACL to disable metrics for. This network port ACL must have been previously added to the virtual machine.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010., press F5 or use <b>
Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Set_the_metrics_flush_interval_for_a_virtual_machine"></a><a id="set_the_metrics_flush_interval_for_a_virtual_machine"></a><a id="SET_THE_METRICS_FLUSH_INTERVAL_FOR_A_VIRTUAL_MACHINE"></a>Set the metrics flush interval for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>MetricsSample.exe ConfigureMetricsFlushInterval </b><i>flush-interval-hours</i></p>
<p>where <i>flush-interval-hours</i> is the new metrics flush interval, in hours.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Determine_if_metrics_collection_is_enabled_for_a_virtual_machine"></a><a id="determine_if_metrics_collection_is_enabled_for_a_virtual_machine"></a><a id="DETERMINE_IF_METRICS_COLLECTION_IS_ENABLED_FOR_A_VIRTUAL_MACHINE"></a>Determine if metrics
 collection is enabled for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>MetricsSample.exe QueryMetricCollectionEnabledForVm </b><i>vmName</i></p>
<p>where <i>vmName</i> is the name of the virtual machine.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Enumerate_the_discrete_metrics_for_a_virtual_machine"></a><a id="enumerate_the_discrete_metrics_for_a_virtual_machine"></a><a id="ENUMERATE_THE_DISCRETE_METRICS_FOR_A_VIRTUAL_MACHINE"></a>Enumerate the discrete metrics for a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>MetricsSample.exe EnumerateDiscreteMetricsForVm </b><i>vmName</i></p>
<p>where <i>vmName</i> is the name of the virtual machine.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h4><a id="Enumerate_the_metrics_for_a_resource_pool"></a><a id="enumerate_the_metrics_for_a_resource_pool"></a><a id="ENUMERATE_THE_METRICS_FOR_A_RESOURCE_POOL"></a>Enumerate the metrics for a resource pool</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>MetricsSample.exe EnumerateMetricsForResourcePool </b><i>ResourceType</i><b>
</b><i>ResourceSubType</i><b> [</b><i>PoolId</i><b>]</b></p>
<p>where <i>ResourceType</i> is the numeric resource type, <i>ResourceSubType</i> is the resource sub type, and
<i>PoolId</i> is the resource pool identifier. The <i>PoolId</i> is optional.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
</div>
