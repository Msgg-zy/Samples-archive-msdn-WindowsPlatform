# ControlChannelTrigger HTTP client sample (Windows 8)
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
* 2013-06-27 02:07:44
## Description

<div id="mainSection">
<p>The sample shows how to use the <a href="http://msdn.microsoft.com/library/windows/apps/hh701032">
<b>ControlChannelTrigger</b></a> class to enable a Windows Store app using <a href="http://go.microsoft.com/fwlink/p/?linkid=241637">
HttpClient</a> to be always connected and always reachable. This sample demonstrates the use of background network notifications in a Windows Store app.
</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> class and related interfaces are used to enable real-time network status and triggers for class elements in the
<a href="http://msdn.microsoft.com/library/windows/apps/br226960"><b>Windows.Networking.Sockets</b></a> and related namespaces. These features allow an app to receive notifications while the app is suspended. These notifications can be set to occur when network
 packets are received or to maintain keep-alive packets. This sample uses notifications to receive incoming network packets. This allows the app to minimize power usage for improved battery life and wake up to respond to incoming packets and other conditions
 only when needed. </p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> class is commonly used by long-running network apps to minimize network and system resource usage (an email application that is left running, for example).
 Network triggers allow an app to drop to a low-power mode for periods of time while still keeping established network connections intact and operating in a low-power state. An app can set a server keep-alive interval used by the system for when the app should
 wake up. An app can also set a trigger to wake up when network data is received by the system for the app.
</p>
<p>A Windows Store app for Windows&nbsp;8 is normally suspended when it is no longer in the foreground app and moved to the background. There are some exceptions to suspending an app (actively printing, accessing an audio stream, and transferring files in the background,
 for example). The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032">
<b>ControlChannelTrigger</b></a> class allows a network app that has established a TCP connection to notify the system that an established network connection should be kept operational and the system should wake up the suspended app when network data is received
 for the app or the server keep-alive timer interval expires. </p>
<p>In this sample, the <a href="http://msdn.microsoft.com/library/windows/apps/hh701032">
<b>ControlChannelTrigger</b></a> class is used with the <a href="http://go.microsoft.com/fwlink/p/?linkid=241637">
HttpClient</a> class to connect to a web service. However, the <b>ControlChannelTrigger</b> class can also be used with other network transports that establish a TCP connection.</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> class can be used by instances of the following that establish a TCP connection:</p>
<p></p>
<ul>
<li>The <a href="http://go.microsoft.com/fwlink/p/?linkid=241637">HttpClient</a>,
<a href="http://go.microsoft.com/fwlink/p/?linkid=241638">HttpClientHandler</a>, and related classes in the
<a href="http://go.microsoft.com/fwlink/p/?linkid=227894">System.Net.Http</a> namespace in the .NET Framework&nbsp;4.5.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh831151"><b>IXMLHTTPRequest2</b></a> interface that extends the
<b>IXmlHttpRequest</b> interface defined in several working drafts published by the World Wide Web Consortium (W3C)
</li></ul>
<p></p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> class can also be used with instances of the following classes in the
<a href="http://msdn.microsoft.com/library/windows/apps/br226960"><b>Windows.Networking.Sockets</b></a> that establish a TCP connection.
</p>
<p></p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br226842"><b>MessageWebSocket</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br226882"><b>StreamSocket</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br226923"><b>StreamWebSocket</b></a>
</li></ul>
<p></p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The <a href="http://msdn.microsoft.com/library/windows/apps/hh701032">
<b>ControlChannelTrigger</b></a> class is not supported in a Windows Store app built for Windows using JavaScript.
</p>
<p></p>
<p>This sample is written in C# and requires some experience with network programming.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Other resources</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452752">Adding support for networking</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770532">How to configure network isolation capabilities</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh771189">How to set background connectivity options</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh977056">Supporting your app with background tasks</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770534">Troubleshoot and debug network connections</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=227894">System.Net.Http</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241637">HttpClient</a> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241638">HttpClientHandler</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224847"><b>Windows.ApplicationModel.Background</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226960"><b>Windows.Networking.Sockets</b></a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=258538">ControlChannelTrigger IXMLHTTPRequest2 sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=243039">ControlChannelTrigger StreamSocket sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=251232">ControlChannelTrigger StreamWebSocket sample</a>
</dt><dt><a href=" http://go.microsoft.com/fwlink/p/?linkid=242550">HttpClient Sample</a>
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
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>This sample requires that a web server is available on a separate computer for the app to access for sending requests and receiving responses. The web server must be started before the app is run. The web server must also have a
<i>CCTHttpServerSample</i> path available for the <i>default.aspx</i> file. The sample includes a PowerShell script that will install IIS on a computer, create the
<i>CCTHttpServerSample</i> folder on the server, and copy files to this folder. </p>
<p>The easiest way to run the sample is to use the provided web server scripts. Browse to the
<i>HttpServer</i> folder in your sample folder to setup and start the web server. Copy this folder and its subfolder to another computer and run the server scripts. There are two options possible.</p>
<p></p>
<ul>
<li>Start PowerShell elevated (Run as administrator) and run the following command:
<p><b>.\SetupServer.ps1</b></p>
<p>Note that you may also need to change script execution policy. </p>
</li><li>Start an elevated Command Prompt (Run as administrator) and run following command:
<p><b>PowerShell.exe -ExecutionPolicy Unrestricted -File SetupServer.ps1</b></p>
</li></ul>
<p></p>
<p>When the web server is not needed anymore, please browse to the copy of the <i>
HttpServer</i> folder on the computer and run one of the following:</p>
<p></p>
<ul>
<li>Start PowerShell elevated (Run as administrator) and run the following command:
<p><b>.\RemoveServer.ps1</b></p>
<p>Note that you may also need to change script execution policy. </p>
</li><li>Start an elevated Command Prompt (Run as administrator) and run following command:
<p><b>PowerShell.exe -ExecutionPolicy Unrestricted -File RemoveServer.ps1</b></p>
</li></ul>
<p></p>
<p>To configure the app for use with the web server:</p>
<ul>
<li>Additional capabilities may need to be added. For example, &quot;Internet (Client)&quot; if the web server is located on the Internet and not on a local home or work network.
</li><li>The target ServerUri field should be updated. This is changed by editing the XAML files so that the Server-HostName TextBox contains the URI to the web server.
</li></ul>
<p></p>
<p>The sample can run using any web server, not only the one provided with the sample. In this case, running the previous scripts is not required. However, this requires some special configuration of the server to create the
<i>CCTHttpServerSample</i> folder and copy files to this folder. </p>
<p>To configure for use with a different web server:</p>
<dl><dd>Copy the <i>HttpServer\webSite</i> directory to the <i>CCTHttpServerSample</i> folder on the web server and configure the server to allow GET and POST requests. Also configure the web server so it delays responses by about 25 seconds. This delay is
 to ensure the client app can have enough time to enter suspended state and then receive the incoming response from the server.
</dd><dd>Revise or replace the <i>default.aspx</i> file as need so it works with the web server.
</dd></dl>
<p class="note"><b>Note</b>&nbsp;&nbsp;IIS is not available on ARM builds. Instead, set up the web server on a separate 64-bit or x86 32-bit computer.
</p>
<p></p>
<p>To deploy this app after building it, select <b>Deploy Solution</b> from the <b>
Build</b> menu. A tile for the sample will be available on the Start Screen. To both deploy and run the sample, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Visual Studio&nbsp;2012 (any SKU). (Or select the corresponding
 options from the Debug menu.) </p>
<p>After the server computer has started, start the app on the local computer. </p>
<dl><dd>A tile to start the app will be available on the Start Screen. </dd></dl>
<p></p>
<p>Once the client starts, the <b>Connect</b> button will send the initial HTTP request to the web server. The default server will delay sending the HTTP response by 25 seconds. This allows the client app to be suspended and then receive the push notification.
</p>
<p>The <b>Send</b> button can be used to send subsequent HTTP requests using the same
<a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> object instance but with separate
<a href="http://go.microsoft.com/fwlink/p/?linkid=241637">HttpClient</a> transport instances.
</p>
<p>The response from the web server will delayed so the app will have time to be suspended. The resulting delayed http response will be received by the
<a href="http://msdn.microsoft.com/library/windows/apps/hh701032"><b>ControlChannelTrigger</b></a> and a toast will be displayed.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;When the app is run under a debugger, it will not be suspended.</p>
<p></p>
</div>
