# Windows Deployment Services multicast provider sample
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
* 2013-10-17 02:30:23
## Description

<div id="mainSection">
<p>Demonstrates how to use the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd379586">
Windows Deployment Services</a> (WDS) Multicast Client library to implement a multicast provider.
</p>
<p></p>
<ul>
<li>A multicast provider can be used with a multicast consumer to transport user-defined data over multicast.
</li><li>This multicast provider sample encodes a file on the server into a series of data blocks in a format that can be understood by the
<a href="http://go.microsoft.com/fwlink/p/?linkid=254940">Windows Deployment Services multicast consumer sample</a>.
</li><li>You can re-implement the <b>ReceiveContentsCallback</b> function of the multicast consumer sample to connect to a multicast session, receive data from the multicast provider sample, and interpret the transmitted data.
</li></ul>
<p></p>
<p>A content provider is just one part of a pair of components that must be implemented in order to transmit custom data over multicast. The other piece that is required is a content consumer that decodes the sequence of data blocks that it receives over multicast,
 such as the <a href="http://go.microsoft.com/fwlink/p/?linkid=254940">Windows Deployment Services multicast consumer sample</a>. It is the content provider's responsibility to encode the data the user is transmitting into a series of blocks that the content
 consumer can decode.</p>
<p>A simple walkthrough for using the multicast provider sample consists of the following. First, build the content provider DLL. Second, install the content provider DLL on the WDS Transport Server and register it. Third, use the Windows Deployment Services
 Transport Management (WdsTptMgmt) API to create a WDS Transport namespace on the server that specifies the sample content provider and the folder containing the files to be transferred over multicast. Finally, use a consumer application to download files exposed
 by the namespace.</p>
<p>When you download this sample you will also receive a README.txt file.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb394781">Windows Deployment Services Transport Functions</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=254940">Windows Deployment Services multicast consumer sample</a>
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
<li>Start Visual Studio and select <b>File &gt; Open &gt; Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled provider.sln.
</li><li>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build &gt; Build Solution</b> to build the sample.
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<p>See the Readme.txt file provided with this sample for more information on how to run the multicast provider sample.</p>
<p>A multicast provider is only one of the two parts required to transmit custom data over multicast. The multicast provider encodes the data being transmitted into a sequence of data blocks. A content consumer application is required to receive and interpret
 this data. The multicast provider DLL must encode the data in a format that can be understood by the consumer application. You can use the
<a href="http://go.microsoft.com/fwlink/p/?linkid=254940">Windows Deployment Services multicast consumer sample</a> to receive data encoded by this multicast provider sample.</p>
</div>
