# ControlChannelTrigger StreamSocket sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:22:13
## Description

<div id="mainSection">
<p>The sample shows how to use the <a href="http://msdn.microsoft.com/library/windows/apps/hh701032">
<b>ControlChannelTrigger</b></a> class to enable a Windows Store app using a TCP <a href="http://msdn.microsoft.com/library/windows/apps/br226882">
<b>StreamSocket</b></a> so that the app is always connected and always reachable. This sample demonstrates the use of background network notifications in a Windows Store app.
</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> class and related interfaces are used to enable real-time network status and triggers for class elements in the
<a href="http://msdn.microsoft.com/library/windows/apps/br226960"><b>Windows.Networking.Sockets</b></a> and related namespaces. These features allow an app to receive notifications while the app is suspended. These notifications can be set to occur when network
 packets are received or to maintain keep-alive packets. This sample uses notifications to receive incoming network packets. This allows the app to minimize power usage for improved battery life and wake up to respond to incoming packets and other conditions
 only when needed. </p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> class is commonly used by long-running network apps to minimize network and system resource usage (an email application that is left running, for example).
 Network triggers allow an app to drop to a low-power mode for periods of time while still keeping established network connections intact and operating in a low-power state. An app can set a server keep-alive interval used by the system for when the app should
 wake up. An app can also set a trigger to wake up when network data is received by the system for the app.
</p>
<p>A Windows Store app for Windows&nbsp;8.1 is normally suspended when it's no longer the foreground app and moved to the background. There are some exceptions to suspending an app (actively printing, accessing an audio stream, and transferring files in the background,
 for example). The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032">
<b>ControlChannelTrigger</b></a> class allows a network app that has established a TCP connection to notify the system that an established network connection should be kept operational. Additionally, the system should wake up the suspended app when network
 data is received for the app or the server keep-alive timer interval expires. </p>
<p>In this sample, the <a href="http://msdn.microsoft.com/library/windows/apps/hh701032">
<b>ControlChannelTrigger</b></a> class is used with the <a href="http://msdn.microsoft.com/library/windows/apps/br226882">
<b>StreamSocket</b></a> class to connect to network service (another app listening for TCP connections). However, the
<b>ControlChannelTrigger</b> class can also be used with other network transports that establish a TCP connection.</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> class can be used with instances of the following classes in the
<a href="http://msdn.microsoft.com/library/windows/apps/br226960"><b>Windows.Networking.Sockets</b></a> that establish a TCP connection.
</p>
<p></p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br226882"><b>StreamSocket</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br226842"><b>MessageWebSocket</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br226923"><b>StreamWebSocket</b></a>
</li></ul>
<p></p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> class can also be used by instances of the following that establish a TCP connection:</p>
<p></p>
<ul>
<li>The <a href="http://msdn.microsoft.com/library/windows/apps/dn298639"><b>HttpClient</b></a> class in the
<a href="http://msdn.microsoft.com/library/windows/apps/dn279692"><b>Windows.Web.Http</b></a> namespace.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh831151"><b>IXMLHTTPRequest2</b></a> interface that extends the
<b>IXmlHttpRequest</b> interface defined in several working drafts published by the World Wide Web Consortium (W3C) .
</li></ul>
<p></p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032">
<b>ControlChannelTrigger</b></a> class is not supported in a Windows Store app built for Windows using JavaScript.
</p>
<p></p>
<p>Versions of this sample are provided in both C# and C&#43;&#43;. This sample requires some experience with network programming.
</p>
<p>This sample requires the following capabilities:</p>
<ul>
<li><b>Home or work networking</b> - Needed when requests are sent over TCP on a home or work intranet.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Other resources</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452752">Adding support for networking</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452976">Connecting to network services (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770532">How to configure network isolation capabilities</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh771189">How to set background connectivity options</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452977">Making network connections with sockets</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh977056">Supporting your app with background tasks</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226882"><b>StreamSocket</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226960"><b>Windows.Networking.Sockets</b></a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=258323">ControlChannelTrigger HttpClient sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=258538">ControlChannelTrigger IXMLHTTPRequest2 sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=251232">ControlChannelTrigger StreamWebSocket sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=243037">StreamSocket sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Operating system requirements</h2>
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
<h2>Build the sample</h2>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<p>This sample requires two computers that can connect to each other using networking. Both computers need to be running Windows&nbsp;8.1. One computer will play the role of the client, while the other computer will play the role of the server.
</p>
<p>To deploy this sample after building it, select Deploy Solution from the Build menu. A tile for the sample will be available on the Start Screen. To both deploy and run the sample, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled)
 from Visual Studio&nbsp;2013 (any SKU). (Or select the corresponding options from the Debug menu.)
</p>
<p>The sample must be deployed to both the client and server computers.</p>
<p>To run the sample, first the start the app on the server computer. </p>
<dl><dd>1. Select the function as the server. </dd><dd>2. Enter a TCP port number (port 12345, for example) to start listening for a client connection.
</dd><dd></dd></dl>
<p></p>
<p>After the server computer has started, start the app on the client computer. </p>
<dl><dd>1. Select the function as the client. </dd><dd>2. Enter the hostname and TCP port on the server computer for the client to connect to (TCP port 12345, for example) and click
<b>Connect.</b> </dd></dl>
<p></p>
<p>The server computer should show the client as connected. After the client is connected, the server can send a message to the client. The message is received on the client and displayed as a toast notification.
</p>
<p>You should be able to let the client app get suspended and it can still receive an incoming network message from the server and display a toast when a message is received.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;When the app is run under a debugger, it will not be suspended.</p>
<p></p>
</div>
