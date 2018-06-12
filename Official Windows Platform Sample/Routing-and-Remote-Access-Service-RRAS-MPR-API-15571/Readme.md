# Routing and Remote Access Service (RRAS) MPR API sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Networking
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:25:04
## Description

<div id="mainSection">
<p>Demonstrates how to use Windows&nbsp;8.1 MPR APIs to set and retrieve configuration info from Routing and Remote Access Service (RRAS).
</p>
<p>The sample demonstrates how to: </p>
<ul>
<li>configure custom IPSec policies on a demand dial interface. </li><li>remove a custom IPSec configuration from a demand dial interface. </li><li>configure custom IPSec policies (to be applied on all the VPN connections) on a RRAS server.
</li><li>remove custom a IPSec configuration from a RRAS server. </li><li>enumerate the VPN connections on a RRAS server. </li></ul>
<p></p>
<p>The APIs demonstrated in this sample are: </p>
<ul>
<li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375840"><b>MprAdminServerConnect</b></a> - to establish a connection to a RRAS server for the purpose of administering the RRAS.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375843"><b>MprAdminServerDisconnect</b></a> - to disconnect the connection made using
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375840"><b>MprAdminServerConnect</b></a>.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa374573"><b>MprAdminInterfaceCreate</b></a> - to create a demand dial interface on a specified RRAS server.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa374575"><b>MprAdminInterfaceDeviceGetInfo</b></a> - to retrieve info for a specified interface on a server.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa374581"><b>MprAdminInterfaceGetHandle</b></a> - to retrieve a handle to a specified interface for administering that interface.
</li><li>MprAdminInterfaceSetCustomInfoEx - to set tunnel-specific custom configuration info for a specified demand dial interface on a server.
</li><li>MprAdminInterfaceGetCustomInfoEx - to retrieve tunnel-specific custom configuration info for a specified demand dial interface on a server.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa374557"><b>MprAdminBufferFree</b></a> - to release the memory buffers returned by the MprAdmin* APIs.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd408070"><b>MprAdminServerGetInfoEx</b></a> - to retrieve the tunnel-specific configuration of the RRAS server.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd408071"><b>MprAdminServerSetInfoEx</b></a> - to set the tunnel-specific configuration on a specified RRAS server.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa374559"><b>MprAdminConnectionEnum</b></a> - to enumerate all active VPN connections on a specified RRAS server.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375874"><b>MprConfigServerConnect</b></a> - to connect to a RRAS server to be configured.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375875"><b>MprConfigServerDisconnect</b></a> - to disconnect a connection made using
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375874"><b>MprConfigServerConnect</b></a>.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375860"><b>MprConfigInterfaceCreate</b></a> - to create a router interface in the specified router configuration.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375864"><b>MprConfigInterfaceGetHandle</b></a> - to retrieve a handle to the specified interface's configuration in a router configuration.
</li><li>MprConfigInterfaceSetCustomInfoEx - to set the custom IKEv2 policy configuration for a specified interface in a router configuration.
</li><li>MprConfigInterfaceGetCustomInfoEx - to retrieve the custom IKEv2 policy configuration for a specified interface in a router configuration.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa375855"><b>MprConfigBufferFree</b></a> - to free the buffers allocated by calls to the MprConfig* APIs.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd408076"><b>MprConfigServerGetInfoEx</b></a> - to retrieve tunnel-specific custom configuration information for a specified demand dial interface on a server.
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd408077"><b>MprConfigServerSetInfoEx</b></a> - to set tunnel-specific custom configuration for a specified demand dial interface on a server.
</li></ul>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb545679">Routing and Remote Access Service</a>
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
<p>To build this sample, open the CPP project solution (.sln) file within Visual Studio Express&nbsp;2013 for Windows for Windows&nbsp;8.1 (any SKU). Press F7 (or F6 for Visual Studio&nbsp;2013) or go to Build-&gt;Build Solution from the top menu after the sample has loaded.
 The sample will be built in the default \Debug or Release directory.</p>
<h3>Run the sample</h3>
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl-F5 (run without debugging enabled) from Visual Studio Express&nbsp;2013 for Windows for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the Debug menu.)</p>
<p>In order to see the enumerated VPN connections using this sample, you must have VPN clients connected to the RRAS server. Otherwise, this sample would always show &quot;No VPN connections are available&quot;.
</p>
</div>
