# DatagramSocket sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:11:23
## Description

<div id="mainSection">
<p>This sample demonstrates the basics of the <a href="http://msdn.microsoft.com/library/windows/apps/br241319">
<b>DatagramSocket</b></a> class using the networking features provided by the Windows Runtime. The client component of the sample creates a UDP socket, uses the socket to send and receive data, and closes the socket. The server component of the sample creates
 a UDP socket to listen for incoming network packets, receives incoming UDP packets from the client, sends data to the client, and closes the socket.
</p>
<p>The client component of the sample demonstrates the following features:</p>
<p></p>
<ul>
<li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/br241319"><b>DatagramSocket</b></a> class to create a UDP socket for the client to send and receive data.
</li><li>Add a listener for a <a href="http://msdn.microsoft.com/library/windows/apps/br241319_messagereceived">
<b>DatagramSocket.MessageReceived</b></a> event that indicates that a UDP datagram was received on the
<a href="http://msdn.microsoft.com/library/windows/apps/br241319"><b>DatagramSocket</b></a> object.
</li><li>Set the remote endpoint for a UDP network server where packets should be sent using one of the
<a href="http://msdn.microsoft.com/library/windows/apps/br241319_connectasync"><b>DatagramSocket.ConnectAsync</b></a> methods.
</li><li>Send data to the server using the <a href="http://msdn.microsoft.com/library/windows/apps/br208154">
<b>Streams.DataWriter</b></a> object which allows a programmer to write common types (integers and strings, for example) on any stream.
</li></ul>
<p></p>
<p>The server component of the sample demonstrates the following features:</p>
<p></p>
<ul>
<li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/br241319"><b>DatagramSocket</b></a> class to create a UDP socket to listen for and receive incoming datagram packets and for sending packets.
</li><li>Add a listener for a <a href="http://msdn.microsoft.com/library/windows/apps/br241319_messagereceived">
<b>DatagramSocket.MessageReceived</b></a> event that indicates that a UDP datagram was received on the
<a href="http://msdn.microsoft.com/library/windows/apps/br241319"><b>DatagramSocket</b></a> object.
</li><li>Bind the socket to a local service name to listen for incoming UDP packets using the
<a href="http://msdn.microsoft.com/library/windows/apps/br241319_bindservicenameasync">
<b>DatagramSocket.BindServiceNameAsync</b></a> method. </li><li>Receive a <a href="http://msdn.microsoft.com/library/windows/apps/br241319_messagereceived">
<b>DatagramSocket.MessageReceived</b></a> event that indicates that a UDP datagram was received on the
<a href="http://msdn.microsoft.com/library/windows/apps/br241319"><b>DatagramSocket</b></a> object.
</li><li>Receive data from the client using the <a href="http://msdn.microsoft.com/library/windows/apps/br241319_getoutputstreamasync_1619245957">
<b>DatagramSocket.GetOutputStreamAsync(HostName, String)</b></a> object which allows an app to also determine the remote address and port that sent the data.
</li></ul>
<p></p>
<p>This sample requires the following capabilities:</p>
<ul>
<li>Home or Work Networking - Even though this sample by default runs on loopback, it needs either the &quot;Home or Work Networking&quot; or &quot;Internet (Client &amp; Server)&quot; capability in order to accept connections using
<a href="http://msdn.microsoft.com/library/windows/apps/br241319"><b>DatagramSocket</b></a>. For more information, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh770532">How to configure network isolation capabilities</a>.
</li></ul>
<p></p>
<p>Versions of this sample are provided in JavaScript, C#, and C&#43;&#43; and require some experience with network programming.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Procedural</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452752">Adding support for networking</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452977">Connecting to network services (Windows Store apps using JavaScript and HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452976">Connecting to network services (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770532">How to configure network isolation capabilities</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780596">How to use advanced socket controls (Windows Store apps using JavaScript and HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj150598">How to use advanced socket controls (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</dt><dt>How to configure network isolation capabilities </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452986">Quickstart: Connecting to a network resource with a datagram socket (Windows Store apps using JavaScript and HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770534">Troubleshoot and debug network connections</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226882"><b>DatagramSocket</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241319messagereceivedeventargs"><b>DatagramSocketMessageReceivedEventArgs</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207124"><b>Windows.Networking</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226960"><b>Windows.Networking.Sockets</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208119"><b>Windows.Storage.Streams.DataReader</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208154"><b>Windows.Storage.Streams.DataWriter</b></a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=243037">StreamSocket sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Operating system requirements</h3>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012 </dt></td>
</tr>
</tbody>
</table>
<h3>Build the sample</h3>
<ol>
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
</div>
