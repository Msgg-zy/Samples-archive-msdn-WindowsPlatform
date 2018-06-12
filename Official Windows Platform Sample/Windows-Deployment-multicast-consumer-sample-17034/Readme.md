# Windows Deployment Services multicast consumer sample
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
* 2013-10-17 02:18:32
## Description

<div id="mainSection">
<p>Demonstrates how to use the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd379586">
Windows Deployment Services</a> (WDS) Multicast Client library to implement a multicast consumer.
</p>
<p></p>
<ul>
<li>A multicast consumer can be used with a multicast provider to transport user-defined data over multicast.
</li><li>This multicast consumer sample demonstrates connecting to a multicast session, receiving a file from a multicast provider, and writing the file to disk.
</li><li>An actual application would need to re-implement the <b>ReceiveContentsCallback</b> function of this sample to interpret the transmitted data.
</li><li>You can use the <a href="http://go.microsoft.com/fwlink/p/?linkid=258652">Windows Deployment Services multicast provider sample</a> to provide data in a format that can be understood by this sample consumer.
</li></ul>
<p></p>
<p>A content consumer is just one part of a pair of components that must be implemented in order to transmit custom data over multicast. The other piece that is required is a content provider that encodes the data to be transmitted into a sequence of data blocks.
 It is the content consumer's responsibility to interpret these blocks of data.</p>
<p>A simple walkthrough for using the multicast consumer sample consists of the following. First, choose a content provider DLL that encodes the data in a format this consumer application will understand, such as the
<a href="http://go.microsoft.com/fwlink/p/?linkid=258652">Windows Deployment Services multicast provider sample</a>. Second, install the content provider DLL on the WDS Transport Server and register it. Third, use the Windows Deployment Services Transport Management
 (WdsTptMgmt) API to create a WDS Transport namespace on the server that specifies the sample content provider and the folder containing the files to be transferred over multicast. Finally, use the consumer application to download files exposed by the namespace.</p>
<p>When you download this sample you will also receive a README.txt file.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/bb394781">Windows Deployment Services Transport Functions</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=258652">Windows Deployment Services multicast provider sample</a>
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
<li>Start Visual Studio and select <b>File &gt; Open &gt; Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled consumer.sln.
</li><li>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build &gt; Build Solution</b> to build the sample.
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<p>See the Readme.txt file provided with this sample for more information on how to run the multicast consumer sample.</p>
<p>A consumer is only one of the two parts required to transmit custom data over multicast. The other piece is a multicast provider that encodes the data into a sequence of data blocks into a format that can be received and understood by the consumer application.
 To implement a full solution, you can use the multicast consumer sample together with the
<a href="http://go.microsoft.com/fwlink/p/?linkid=258652">Windows Deployment Services multicast provider sample</a>.</p>
</div>
