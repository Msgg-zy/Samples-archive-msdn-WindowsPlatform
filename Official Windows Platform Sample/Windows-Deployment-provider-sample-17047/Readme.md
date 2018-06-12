# Windows Deployment Services provider sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Services
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:27:28
## Description

<div id="mainSection">
<p>Demonstrates how to create a custom PXE provider DLL that can replace or run in conjunction with the standard WDSDCPXE PXE provider on a Windows Deployment Services (WDS) server.
</p>
<p></p>
<p><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd379586">Windows Deployment Services</a> (WDS) enables the deployment of Windows operating systems. You can use WDS to set up new clients with a network-based installation without requiring
 that administrators visit each computer or install directly from CD or DVD media. The PXE Server contains the core networking capability of the server solution. The PXE Server supports a plug-in interface. Plug-ins are also known as “PXE Providers”. This provider
 model allows for custom PXE solutions to be developed while leveraging the same core PXE Server networking code base.</p>
<ul>
<li>Plug-ins known as &quot;PXE Providers&quot; enable you to develop custom solutions that leverage the core networking code base of the WDS PXE Server implementation. This sample provider allows you to create a DLL that may replace or run in conjunction with the existing
 PXE Provider, BINL, on a Windows Deployment Services server. </li><li>This provider sample stores data in a text file rather than Active Directory.
</li><li>This provider sample adds a Boot option for a BCD file to the DHCP reply packet sent out by the server.
</li></ul>
<p></p>
<p>A simple walkthrough for using the sample filter provider consists of the following. First, compile the sample code into a DLL. Second, create an .ini file. Third, register the sample provider in the ordered provider list. Fourth, boot a sample client using
 PXE. Any requests not filtered by a preceding provider will then be passed to the next registered provider in the ordered list.</p>
<p>When you download this sample you will also receive a README.txt file.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb530732">Using the Windows Deployment Services Server API</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254936">Windows Deployment Services provider sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254937">Windows Deployment Services image enumeration sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254942">Windows Deployment Services transport manager sample</a>
</dt></dl>
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
<p></p>
<ol>
<li>Start Visual Studio and select <b>File &gt; Open &gt; Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled SampProv.sln.
</li><li>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build &gt; Build Solution</b> to build the sample.
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<p>For detailed information on how to run the Windows Deployment Services PXE provider sample see the Readme.txt file provided with this sample.
</p>
<p>Windows Deployment Services (WDS) enables the deployment of Windows operating systems using a network-based installation. You also need the following to complete this sample.</p>
<ul>
<li>Install the Windows Deployment Services server role on Windows Server&nbsp;2012&nbsp;R2.
</li><li>Initialize the Windows Deployment Services server. </li><li>Add a boot image (Boot.wim) to the server. This is a Windows PE image that a client computer can boot into to install the operating system. The boot image (Boot.wim) can be found on the Windows product DVD.
</li></ul>
<p></p>
</div>
