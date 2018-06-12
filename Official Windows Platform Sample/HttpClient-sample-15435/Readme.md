# HttpClient sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
* Windows 8.1
* Windows Phone 8.1
## Topics
* Networking
* universal app
## IsPublished
* True
## ModifiedDate
* 2014-05-13 12:09:19
## Description

<div id="mainSection">
<p>This sample shows you how to upload and download various types of content with an HTTP server using the
<a href="http://msdn.microsoft.com/library/windows/apps/dn298639"><b>HttpClient</b></a> and related classes in
<a href="http://msdn.microsoft.com/library/windows/apps/dn279692"><b>Windows.Web.Http</b></a> namespace in your Windows Runtime app.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p>This sample shows the use of asynchronous GET and POST requests using <a href="http://msdn.microsoft.com/library/windows/apps/dn298639">
<b>HttpClient</b></a>. The sample also shows the use of caching and filters. Example filters are provided to handle retries and metered network connections. Versions of this sample are provided in JavaScript, C#, VB, and C&#43;&#43;.
</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/dn298639"><b>HttpClient</b></a> class is used to send and receive basic requests over HTTP. It is the main class for sending HTTP requests and receiving HTTP responses from a resource identified
 by a URI. This class can be used to send a GET, PUT, POST, DELETE, and other requests to a web service. Each of these requests is sent as an asynchronous operation. The
<b>HttpClient</b> class can be used in scenarios that use text as well as scenarios that use arbitrary streams of data.
</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/dn279692"><b>Windows.Web.Http</b></a> namespace and the related
<a href="http://msdn.microsoft.com/library/windows/apps/dn252713"><b>Windows.Web.Http.Headers</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dn298623"><b>Windows.Web.Http.Filters</b></a> namespaces in Windows&nbsp;8.1, Windows Server&nbsp;2012&nbsp;R2, and later provide a programming interface for Windows Runtime apps that target HTTP services. The new HTTP
 API provides consistent support in JavaScript, C#, VB.NET, and C&#43;&#43; for developers. This new API replaces the use of three different APIs with differing features that previously were needed for each language projection in Windows&nbsp;8.</p>
<p>Classes in the <a href="http://msdn.microsoft.com/library/windows/apps/dn252713">
<b>Windows.Web.Http.Headers</b></a> namespace represent HTTP headers defined in <a href="http://go.microsoft.com/fwlink/?LinkID=241642">
RFC 2616</a> by the IETF. HTTP headers are associated with <a href="http://msdn.microsoft.com/library/windows/apps/dn279617">
<b>HttpRequestMessage</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/dn279631">
<b>HttpResponseMessage</b></a> objects as properties that are retrieved or set.</p>
<p>Classes in the <a href="http://msdn.microsoft.com/library/windows/apps/dn279692">
<b>Windows.Web.Http</b></a> namespace can use filters based on the classes in the
<a href="http://msdn.microsoft.com/library/windows/apps/dn298623"><b>Windows.Web.Http.Filters</b></a> namespace. Filters provide a handler to help with common HTTP web service issues. Filters can be chained together in a sequence to address more complex web
 service issues. Two filters are included in this sample to handle metered network connections and retry. The sample also shows how to use the
<a href="http://msdn.microsoft.com/library/windows/apps/dn298616"><b>HttpCacheControl</b></a> class in the
<b>Windows.Web.Http.Filters</b> namespace to control read or write cache behavior.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows version of this sample by default requires network access using the loopback interface.</p>
<p></p>
<p>For a sample that shows how to use <a href="http://msdn.microsoft.com/library/windows/apps/dn298639">
<b>HttpClient</b></a> so that the app is always connected and always reachable using background network notifications in a Windows Store app, download the
<a href="http://go.microsoft.com/fwlink/p/?linkid=258323">ControlChannelTrigger HttpClient sample</a> .
</p>
<p><b>Network capabilities</b></p>
<p>This sample requires that network capabilities be set in the <i>Package.appxmanifest</i> file to allow the app to access the network at runtime. These capabilities can be set in the app manifest using Microsoft Visual Studio.
</p>
<p>To build the Windows version of the sample, set the following network capabilities:</p>
<ul>
<li>
<p><b>Internet (Client)</b>: The sample can use the Internet for GET and POST operations (outbound-initiated access). This allows the app to download various types of content from an HTTP server and upload content to an HTTP server located on the Internet.
 This is represented by the <b>Capability name = &quot;internetClient&quot;</b> tag in the app manifest.
</p>
<p><b>Private Networks (Client &amp; Server)</b>: The sample has inbound and outbound network access on a home or work network (a local intranet). This allows the app to download various types of content from an HTTP server and upload content to an HTTP server
 located on a local intranet. The <b>Private Networks (Client &amp; Server)</b> capability is represented by the
<b>Capability name = &quot;privateNetworkClientServer&quot;</b> tag in the app manifest. </p>
</li></ul>
<p>To build the Windows Phone version of the sample, set the following network capabilities:</p>
<ul>
<li>
<p><b>Internet (Client &amp; Server):</b> This sample has complete access to the network for both client operations (outbound-initiated access) and server operations (inbound-initiated access). This allows the app to download various types of content from an
 HTTP server and upload content to an HTTP server located on the Internet or on a local intranet. This is represented by the
<b>Capability name = &quot;internetClientServer&quot;</b> tag in the app manifest. </p>
<p class="note"><b>Note</b>&nbsp;&nbsp;On Windows Phone, there is only one network capability which enables all network access for the app.</p>
<p></p>
</li></ul>
<p></p>
<p>For more information on network capabilities, see <a href="http://msdn.microsoft.com/library/windows/apps/hh770532">
How to set network capabilities</a>.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;Network communications using an IP loopback address cannot normally be used for interprocess communication between a Windows Runtime app and a different process (a different Windows Runtime app or a desktop app) because this is
 restricted by network isolation. Network communication using a loopback address to a different process is allowed when the app is run under the debugger. For more information, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh780593">How to enable loopback and troubleshoot network isolation</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013 Update&nbsp;2, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Microsoft Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Other - C#/VB/C&#43;&#43; and XAML</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452751">Adding support for networking (XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452976">Connecting to network services (XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh994396">&gt;Connecting with WebSockets (XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn440594">How to connect to an HTTP server using Windows.Web.Http Windows.Web.Http.HttpClient (XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj835817">How to set network capabilities (XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj662741">Staying connected in the background (XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770534">Troubleshooting and debugging network connections</a>
</dt><dt><b>Other - JavaScript and HTML</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452752">Adding support for networking (HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452977">Connecting to network services (HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761442">Connecting with WebSockets (HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn469430">How to connect to an HTTP server using Windows.Web.Http (HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh771189">How to set background connectivity options (HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770532">How to set network capabilities (HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770534">Troubleshooting and debugging network connections</a>
</dt><dt><b>Other resources</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452752">Adding support for networking</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761442">Connecting to a WebSocket service</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770532">How to configure network isolation capabilities</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh781240">How to secure HttpClient connections</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh781239">Quickstart: Connecting using HttpClient</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn298639"><b>HttpClient</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn279692"><b>Windows.Web.Http</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn252713"><b>Windows.Web.Http.Headers</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn298623"><b>Windows.Web.Http.Filters</b></a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=258323">ControlChannelTrigger HttpClient sample</a>
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
<tr>
<th>Phone</th>
<td><dt>Windows Phone 8.1 </dt></td>
</tr>
</tbody>
</table>
<h2>Build the sample</h2>
<ol>
<li>Start Visual Studio&nbsp;2013 Update&nbsp;2 and select <b>File</b> &gt; <b>Open</b> &gt;
<b>Project/Solution</b>. </li><li>Go to the directory to which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Update&nbsp;2 Solution (.sln) file.
</li><li>Follow the steps for the version of the sample you want:
<ul>
<li>
<p>To build the Windows version of the sample:</p>
<ol>
<li>Select <b>HttpClient.Windows</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B, or use <b>Build</b> &gt; <b>Build Solution</b>, or use <b>
Build</b> &gt; <b>Build HttpClient.Windows</b>. </li></ol>
</li><li>
<p>To build the Windows Phone version of the sample:</p>
<ol>
<li>Select <b>HttpClient.WindowsPhone</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B or use <b>Build</b> &gt; <b>Build Solution</b> or use <b>Build</b> &gt;
<b>Build HttpClient.WindowsPhone</b>. </li></ol>
</li></ul>
</li></ol>
<h2>Run the sample</h2>
<p>The next steps depend on whether you just want to deploy the sample or you want to both deploy and run it.</p>
<p><b>Deploying the sample</b></p>
<ul>
<li>
<p>To deploy the built Windows version of the sample:</p>
<ol>
<li>Select <b>HttpClient.Windows</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy HttpClient.Windows</b>.
</li></ol>
</li><li>
<p>To deploy the built Windows Phone version of the sample:</p>
<ol>
<li>Select <b>HttpClient.WindowsPhone</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy HttpClient.WindowsPhone</b>.
</li></ol>
</li></ul>
<p><b>Deploying and running the Windows version of the sample</b></p>
<p>This sample requires that a web server is available for the app to access for uploading and downloading files. The web server must be started before the app is run. The web server must also have an
<i>HttpClientSample</i> path available for uploads and downloads. The sample includes a PowerShell script that will install IIS on the local computer, create the
<i>HttpClientSample</i> folder on the server, copy files to this folder, and enable IIS.
</p>
<p>The easiest way to run the sample is to use the provided web server scripts. Browse to the
<i>Server</i> folder in your sample folder to setup and start the web server. There are two options possible.</p>
<p></p>
<ul>
<li>Start PowerShell elevated (Run as administrator) and run the following command:
<p><b>.\SetupServer.ps1</b></p>
<p>Note that you may also need to change script execution policy. </p>
</li><li>Start an elevated Command Prompt (Run as administrator) and run following command:
<p><b>PowerShell.exe -ExecutionPolicy Unrestricted -File SetupServer.ps1</b></p>
</li></ul>
<p></p>
<p>When the web server is not needed anymore, please browse to the <i>Server</i> folder in you sample folder and run one of the following:</p>
<p></p>
<ul>
<li>Start PowerShell elevated (Run as administrator) and run the following command:
<p><b>.\RemoveServer.ps1</b></p>
<p>Note that you may also need to change script execution policy. </p>
</li><li>Start an elevated Command Prompt (Run as administrator) and run following command:
<p><b>PowerShell.exe -ExecutionPolicy Unrestricted -File RemoveServer.ps1</b></p>
</li></ul>
<p></p>
<p>The sample can run using other web servers, not only the one provided with the sample. However for scenarios in the sample, the web server may need to be configured to interpret the query string and cookies similar to IIS so it can send the expected responses.
</p>
<p>If IIS is used on a different computer, then the previous scripts can be used with minor changes.
</p>
<ul>
<li>Copy the <i>Server</i> folder to the device where IIS will be run. </li><li>Run the above scripts to install IIS, create the <i>HttpClientSample</i> folder on the server, copy files to this folder, and enable IIS.
</li></ul>
<p></p>
<p>The sample must also be updated when run against a non-localhost web server. To configure the sample for use with IIS on a different device:
</p>
<ul>
<li>The hostname of the server to connect to needs to be updated. This can be handled in two ways. The
<b>AddressField</b> element in the HTML or XAML files can be edited so that &quot;localhost&quot; is replaced by the hostname or IP address of the web server. Alternately when the app is run, enter the hostname or IP address of the web server instead of the &quot;localhost&quot;
 value in the Address textbox. </li></ul>
<p></p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;IIS is not available on ARM builds nor on Windows Phone. Instead, set up the web server on a separate 64-bit or 32-bit computer and follow the steps for using the sample against non-localhost web server.
</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;When used with the supplied scripts, this Windows Runtime app sample communicates with another process (IIS server which is a desktop app) on the same machine over loopback for demonstration purposes only. A Windows Runtime app
 that communicates over loopback to another process that represents a Windows Runtime app or a desktop app is not allowed and such apps will not pass Store validation. For more information, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh780593">How to enable loopback and troubleshoot network isolation</a>.
</p>
<p>However if a server different than IIS is used, then this requires some special configuration of the server to create the
<i>HttpClientSample</i> folder. </p>
<dl><dd>Copy the <i>Server\webSite</i> directory to the <i>HttpClientSample</i> folder on the web server and configure the server to allow GET and POST requests.
</dd></dl>
<p></p>
<p>To configure the sample for use with a web server different than IIS not using localhost:</p>
<dl><dd>The target URI field should be updated. This can be handled in two ways. The
<b>AddressField</b> element in the HTML or XAML files can be edited so that the URI is replaced by a URI for the non-IIS server. Alternately when the app is run, enter the URI to access on the web server instead of the default value in the Address textbox.
</dd></dl>
<p></p>
<ul>
<li>
<p>To deploy and run the Windows version of the sample:</p>
<ol>
<li>Right-click <b>HttpClient.Windows</b> in <b>Solution Explorer</b> and select <b>
Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li></ul>
<p><b>Deploying and running the Windows Phone version of the sample</b></p>
<p>IIS is not available on Windows Phone. For the app to access a web server, there are two options:</p>
<ul>
<li>The easiest way to run the sample is to use the provided web server scripts on a separate 64-bit or 32-bit device that can run IIS. Follow the instructions for deploying and running the Windows version of the sample using IIS on a different device.
</li><li>Use a web server different than IIS on a separate device. Follow the instructions for deploying and running the Windows version of the sample using a non-IIS web server.
</li></ul>
<p></p>
<ul>
<li>
<p>To deploy and run the Windows Phone version of the sample:</p>
<ol>
<li>Right-click <b>HttpClient.WindowsPhone</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li></ul>
</div>
