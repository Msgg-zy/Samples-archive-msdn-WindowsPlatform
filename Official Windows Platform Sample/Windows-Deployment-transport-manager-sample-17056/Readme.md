# Windows Deployment Services transport manager sample
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
* 2013-10-17 02:30:26
## Description

<div id="mainSection">
<p>Demonstrates how to use the Windows Deployment Services (WDS) Transport Management API, sometimes referred to as &quot;WdsTptMgmt&quot;, to manage a WDS Transport Server. The API allows applications to manage and use the multicast features provided by a WDS Transport
 Server and enables download of any type of data by custom client applications.</p>
<ul>
<li>The &quot;WdsTptMgmt&quot; API enables applications to manage and use the multicast features provided by a WDS Transport Server.
</li><li>You can use the &quot;WdsTptMgmt&quot; to enable a custom client application to download any type of data.
</li><li>This sample application can enable or disable WDS transport services and add or remove a transport namespace.
</li></ul>
<p>The WDS Transport Management API is a part of the overall <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd379586">
Windows Deployment Services</a> Transport platform. It enables developers transmit any type of data using multicast transport and have complete control over server configuration, the data being for download, and the individual transport sessions and clients.
</p>
<p>WdsTptMgmt provides programmatic support for the management of a local or remote WDS Transport Server. Management features are provided over a set interfaces. Setup management interfaces provide server information and support the registration of custom content
 providers. Configuration management interfaces control WDS Transport services and configure transport settings. This enables applications to enable and start services and to configure IP address ranges, port ranges, and diagnostic settings. Namespace management
 interfaces enable applications to add, remove, or query a registered transport namespace and manage active sessions and clients under a given namespace.</p>
<p>When you download this sample you will also receive a README.txt file.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb394781">Windows Deployment Services Transport Functions</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254940">Windows Deployment Services multicast consumer sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254940">Windows Deployment Services multicast consumer sample</a>
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
<p></p>
<ol>
<li>Start Visual Studio and select <b>File &gt; Open &gt; Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled WdsTransportManager.sln.
</li><li>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build &gt; Build Solution</b> to build the sample.
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<p>See the Readme.txt file provided with this sample for more information on how to run the Windows Deployment Services (WDS) Transport Management API sample.</p>
<p>Windows Deployment Services (WDS) enables the deployment of Windows operating systems using a network-based installation. You will also require the following to complete this sample.</p>
<ul>
<li>Windows Server&nbsp;2012&nbsp;R2 with the Windows Deployment Services server role installed.
</li><li>In order to manage this server using the &quot;WdsTptMgmt&quot; API, you need to have this API and associated management binaries installed on system running the client application.
</li><li>The user running the application must be an administrator on the WDS server. </li></ul>
<p></p>
</div>
