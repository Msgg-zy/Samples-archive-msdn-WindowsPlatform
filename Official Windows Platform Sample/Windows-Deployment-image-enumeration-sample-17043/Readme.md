# Windows Deployment Services image enumeration sample
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
* 2013-10-17 02:24:13
## Description

<div id="mainSection">
<p>Demonstrates how to use the Windows Deployment Services (WDS) Client API to enumerate images that are stored on a WDS server.
</p>
<p></p>
<p><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd379586">Windows Deployment Services</a> (WDS) enables the deployment of Windows operating systems. You can use WDS to set up new clients with a network-based installation without requiring
 that administrators visit each computer or install directly from CD or DVD media. The Windows Deployment Services Client library can be leveraged as part of a custom client application that takes the place of the Windows Deployment Services Client. This allows
 for a customized client solution that still leverages a Windows Deployment Services server as the back-end.</p>
<ul>
<li>The application demonstrates how a custom client application can use the Windows Deployment Services Client library to take the place of the WDS client.
</li><li>You can use the WDS client library to develop custom client applications that use a WDS server. This allows for a customized client solution that still leverages a Windows Deployment Services server as the back-end.
</li><li>This sample takes credentials and the name of a WDS server and enumerates the available Windows Imaging (WIM) files stored on the server.
</li></ul>
<p></p>
<p>The functionality included in the Windows Deployment Services Client library is capable of enumerating images stored on a Windows Deployment Services server. The sample takes the credentials and the name of a valid Windows Deployment Services server and
 returns a list of available Windows Imaging (WIM) files stored on the Windows Deployment Services server. In the background, the sample application will establish a session with the specified Windows Deployment Services server, authenticate using the supplied
 credentials, retrieve a list of available images, extract the listed properties from the image, and print the output. This particular sample does not make use of the capability to send client installation events to report or monitor the start and finish of
 a client installation.</p>
<p>When you download this sample you will also receive a README.txt file.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb530731">Using the Windows Deployment Services Client API</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254935">Windows Deployment Services filter provider sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254940">Windows Deployment Services multicast consumer sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254941">Windows Deployment Services multicast provider sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254936">Windows Deployment Services provider sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254942">Windows Deployment Services transport manager sample</a>
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
<li>Start Visual Studio and select <b>File &gt; Open &gt; Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled ImgEnum.sln.
</li><li>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build &gt; Build Solution</b> to build the sample.
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<p>For detailed information on how to run the Windows Deployment Services image enumeration sample see the Readme.txt file provided with this sample.
</p>
<p>Windows Deployment Services (WDS) enables the deployment of Windows operating systems using a network-based installation. You will also require the following to complete this sample.</p>
<ul>
<li>Windows Server&nbsp;2012&nbsp;R2 with the Windows Deployment Services server role installed.
</li><li>A Windows Pre-Installation Environment (Windows PE) image in the Windows Imaging (WIM) format that contains the setup.exe and associated binaries.
</li><li>Wdsclientapi.dll, Wdsimage.dll, Wdscsl.dll and Wdstptc.dll copied into the sample directory.
</li></ul>
<p></p>
</div>
