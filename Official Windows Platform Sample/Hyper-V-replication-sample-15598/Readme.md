# Hyper-V replication sample
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
* 2013-10-17 02:26:37
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Hyper-V WMI replication APIs to configure and control virtual machine replication. The sample demonstrates how to perform each of the following operations:</p>
<ul>
<li>Enable or disable the replication service using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850101">
<b>ModifyServiceSettings</b></a> method. </li><li>Start a replication using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850303">
<b>StartReplication</b></a> method. </li><li>Create a test replica virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850305">
<b>TestReplicaSystem</b></a> method. </li><li>Initiate a failover for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850083">
<b>InitiateFailover</b></a> method. </li><li>Reverse a replication relationship for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850289">
<b>ReverseReplicationRelationship</b></a> method. </li><li>Remove an authorization entry using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850271">
<b>RemoveAuthorizationEntry</b></a> method. </li><li>Remove a replication relationship for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280626">
<b>RemoveReplicationRelationshipEx</b></a> method. </li><li>Add an authorization entry using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850014">
<b>AddAuthorizationEntry</b></a> method. </li><li>Set an authorization entry for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850293">
<b>SetAuthorizationEntry</b></a> method. </li><li>Create a replication relationship for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850036">
<b>CreateReplicationRelationship</b></a> method. </li><li>Change the replication state for a virtual machine using the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280622">
<b>RequestReplicationStateChangeEx</b></a> method. </li></ul>
<p></p>
<p>This sample is written in C# and requires some experience with WMI programming.</p>
<p>The Windows Samples Gallery contains a variety of code samples that demonstrate the use of various new programming features for managing Hyper-V that are available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples are provided as compressed
 ZIP files that contain a Microsoft Visual Studio&nbsp;2010 solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming models,
 platforms, languages, and APIs demonstrated in this sample, please refer to the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850319">
Hyper-V WMI provider (V2)</a> documentation.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850076">Hyper-V replication API</a>
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
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled Replica.sln.</p>
</li><li>
<p>Press F7 (or F6 for Microsoft Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>
Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample must be run as an administrator.</p>
<p></p>
<p>This sample can be run in several different modes. To obtain a list of the operations, use the following command line:</p>
<p><b>ReplicaSamples.exe /?</b></p>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<h3><a id="Enable_or_disable_the_replication_service"></a><a id="enable_or_disable_the_replication_service"></a><a id="ENABLE_OR_DISABLE_THE_REPLICATION_SERVICE"></a>Enable or disable the replication service</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe ModifyReplicationService </b>{<b>0</b>|<b>1</b>}</p>
<p>Pass 0 for the last parameter to disable the replication service or 1 to enable the replication service.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Start_a_replication"></a><a id="start_a_replication"></a><a id="START_A_REPLICATION"></a>Start a replication</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe StartReplication </b><i>VirtualMachineName</i></p>
<p><i>VirtualMachineName</i> is the name of the virtual machine to start replicating.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Create_a_test_replica_virtual_machine"></a><a id="create_a_test_replica_virtual_machine"></a><a id="CREATE_A_TEST_REPLICA_VIRTUAL_MACHINE"></a>Create a test replica virtual machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe TestReplicaSystem </b><i>VirtualMachineName</i></p>
<p><i>VirtualMachineName</i> is the name of the virtual machine to create a test replica virtual machine for.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Initiate_a_failover_for_a_virtual_machine"></a><a id="initiate_a_failover_for_a_virtual_machine"></a><a id="INITIATE_A_FAILOVER_FOR_A_VIRTUAL_MACHINE"></a>Initiate a failover for a virtual machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe InitiateFailover </b><i>VirtualMachineName</i></p>
<p><i>VirtualMachineName</i> is the name of the virtual machine to initiate a failover for.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Reverse_a_replication_relationship_for_a_virtual_machine"></a><a id="reverse_a_replication_relationship_for_a_virtual_machine"></a><a id="REVERSE_A_REPLICATION_RELATIONSHIP_FOR_A_VIRTUAL_MACHINE"></a>Reverse a replication relationship for a
 virtual machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe ReverseReplicationRelationship </b><i>VirtualMachineName</i></p>
<p><i>VirtualMachineName</i> is the name of the virtual machine to reverse the replication relationship for.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Remove_an_authorization_entry"></a><a id="remove_an_authorization_entry"></a><a id="REMOVE_AN_AUTHORIZATION_ENTRY"></a>Remove an authorization entry</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe RemoveAuthorizationEntry </b><i>FQDN</i></p>
<p><i>FQDN</i> is the fully qualified domain name of the primary server to remove.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Remove_a_replication_relationship_for_a_virtual_machine"></a><a id="remove_a_replication_relationship_for_a_virtual_machine"></a><a id="REMOVE_A_REPLICATION_RELATIONSHIP_FOR_A_VIRTUAL_MACHINE"></a>Remove a replication relationship for a virtual
 machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe RemoveReplicationRelationshipEx </b><i>VirtualMachineName
</i><b></b><i>Relationship Type</i></p>
<p><i>VirtualMachineName</i> is the name of the virtual machine to remove the replication relationship for.</p>
<p><i>Relationship Type</i> is the relationship type which should be removed. It should be either 0 or 1.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Add_an_authorization_entry"></a><a id="add_an_authorization_entry"></a><a id="ADD_AN_AUTHORIZATION_ENTRY"></a>Add an authorization entry</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe AddAuthorizationEntry </b><i>FQDN</i><b> </b><i>TrustGroup</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>FQDN</i> is the fully qualified domain name of the primary server to add. </li><li><i>TrustGroup</i> identifies the group of trusted primary servers for the authorization entry.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Set_an_authorization_entry_for_a_virtual_machine"></a><a id="set_an_authorization_entry_for_a_virtual_machine"></a><a id="SET_AN_AUTHORIZATION_ENTRY_FOR_A_VIRTUAL_MACHINE"></a>Set an authorization entry for a virtual machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe SetAuthorizationEntry </b><i>VirtualMachineName</i><b> </b>
<i>FQDN</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>VirtualMachineName</i> is the name of the virtual machine to set the authorization entry for.
</li><li><i>FQDN</i> is the fully qualified domain name of the primary server. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Create_a_replication_relationship_for_a_virtual_machine"></a><a id="create_a_replication_relationship_for_a_virtual_machine"></a><a id="CREATE_A_REPLICATION_RELATIONSHIP_FOR_A_VIRTUAL_MACHINE"></a>Create a replication relationship for a virtual
 machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe CreateReplicationRelationship </b><i>VirtualMachineName</i><b>
</b><i>RecoveryServerName</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>VirtualMachineName</i> is the name of the virtual machine to create a replication relationship for.
</li><li><i>RecoveryServerName</i> is the name of the recovery server. </li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
<h3><a id="Change_the_replication_state_for_a_virtual_machine"></a><a id="change_the_replication_state_for_a_virtual_machine"></a><a id="CHANGE_THE_REPLICATION_STATE_FOR_A_VIRTUAL_MACHINE"></a>Change the replication state for a virtual machine</h3>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>ReplicaSamples.exe RequestReplicationStateChangeEx</b> &nbsp;<i>VirtualMachineName</i> &nbsp;<i>RequestedState RelationshipType</i></p>
<p>where the parameters are as follows:</p>
<ul>
<li><i>VirtualMachineName</i> is the name of the virtual machine to change the replication state for.
</li><li><i>RequestedState</i> is one of the values for the <i>RequestedState</i> parameter of the
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280622"><b>RequestReplicationStateChangeEx</b></a> method that specifies the new replication state.
</li><li><i>RelationshipType</i> is the relationship type whose replication state is to be changed. It should be either 0 or 1.
</li></ul>
<p></p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2010, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>The final result of the operation will be displayed in the console window. </li></ol>
</div>
