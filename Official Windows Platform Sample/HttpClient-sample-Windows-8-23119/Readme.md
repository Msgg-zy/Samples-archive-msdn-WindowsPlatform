# HttpClient sample (Windows 8)
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
* 2013-06-27 02:15:07
## Description

<div id="mainSection">
<p>This sample demonstrates the use of the <a href="http://go.microsoft.com/fwlink/p/?linkid=241637">
HttpClient</a> class and the <a href="http://msdn.microsoft.com/library/windows/apps/hh831151">
<b>IXMLHTTPRequest2</b></a> interface to upload and download various types of content from an HTTP server using the networking features provided by the Windows Runtime. The sample shows the use of asynchronous GET and POST requests. The sample also shows recommended
 ways of handling both trusted (hard coded) URI inputs and unvalidated (user-entered) URI inputs.
</p>
<p>For C# and VB, the <a href="http://go.microsoft.com/fwlink/p/?linkid=241637">HttpClient</a> class is used to send and receive basic requests over HTTP. It provides a base class for sending HTTP requests and receiving HTTP responses from a resource identified
 by a URI. This class can be used to send a GET, PUT, POST, DELETE, and other requests to a web service. Each of these requests is sent as an asynchronous operation. The
<a href="http://go.microsoft.com/fwlink/p/?linkid=241637">HttpClient</a> class can be used in scenarios that use text and other scenarios that use arbitrary streams of data.
</p>
<p>For C&#43;&#43;, the <a href="http://msdn.microsoft.com/library/windows/apps/hh831151">
<b>IXMLHTTPRequest2</b></a> interface is used to send and receive basic requests over HTTP. It provides an interface for sending HTTP requests and receiving HTTP responses from a resource identified by a URI. This interface can be used to send a GET, PUT, POST,
 DELETE, and other requests to a web service. Each of these requests is sent as an asynchronous operation. The
<b>IXMLHTTPRequest2</b> interface can be used in scenarios that use text and other scenarios that use arbitrary streams of data. However data is always returned as a stream by the
<a href="stg.isequentialstream"><b>ISequentialStream</b></a> interface.</p>
<p><a href="http://go.microsoft.com/fwlink/p/?linkid=241637">HttpClient</a> is part of the
<a href="http://go.microsoft.com/fwlink/p/?linkid=227894">System.Net.Http</a> namespace in .NET Framework&nbsp;4.5 that provides a programming interface for modern HTTP applications. The
<a href="http://go.microsoft.com/fwlink/p/?linkid=227894">System.Net.Http</a> namespace and the related
<a href="http://go.microsoft.com/fwlink/p/?linkid=241636">System.Net.Http.Headers</a> namespace provide HTTP client components that allow users to consume modern web services over HTTP.
</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/hh831151"><b>IXMLHTTPRequest2</b></a> interfaces allow an app to conduct HTTP request operations in multithreaded apartments (MTA) and use callbacks to receive notification of required information
 during response processing. </p>
<p>This sample requires the following capabilities:</p>
<ul>
<li>Internet client - Needed to send requests to HTTP servers on the Internet. </li><li>Home or work networking - Needed when requests are sent to HTTP servers on a home or work intranet.
</li></ul>
<p></p>
<p>Versions of this sample are provided in C#, VB, and C&#43;&#43;. This sample requires some experience with network programming.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Other resources</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452752">Adding support for networking</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761442">Connecting to a WebSocket service</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770532">How to configure network isolation capabilities</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh781240">How to secure HttpClient connections</a>
</dt><dt><a href="m_web_service_mca.use_httpclient_handlers">How to use HttpClient handlers</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh781239">Quickstart: Connecting using HttpClient</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770550">Quickstart: Connecting using XML HTTP Request (IXHR2)</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241637">HttpClient</a> </dt><dt><a href="stg.isequentialstream"><b>ISequentialStream</b></a> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh831151"><b>IXMLHTTPRequest2</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=227894">System.Net.Http</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241636">System.Net.Http.Headers</a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=258323">ControlChannelTrigger HttpClient sample</a>
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
<li>Start Visual Studio&nbsp;2012 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>This sample requires that a web server is available for the app to access for uploading and downloading files. The web server must be started before the app is run. The web server must also have an
<i>HttpClientSample</i> path available for uploads and downloads. The sample includes a PowerShell script that will install IIS on the local computer, create the
<i>HttpClientSample</i> folder on the server, and copy files to this folder. </p>
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
<p>The sample can run using any web server, not only the one provided with the sample. In this case, running the previous scripts is not required. However, this requires some special configuration of the server to create the
<i>HttpClientSample</i> folder and copy files to this folder. The sample must also be updated if run against a non-localhost web server:
</p>
<p>To configure the for use with a different web server:</p>
<dl><dd>Copy the <i>Server\webSite</i> directory to the <i>HttpClientSample</i> folder on the web server and configure the server to allow GET and POST requests.
</dd><dd>Additional capabilities may need to be added. For example, &quot;Home or Work Networking&quot; if the web server is located on local intranet.
</dd><dd>The target URI field should be updated. This is changed by editing the XAML files so that the AddressField TextBox is enabled (IsEnabled=&quot;true&quot;) and the AddressField TextBox that contains the URI to the web server has the hostname or IP address of the web
 server substituted for localhost. </dd></dl>
<p class="note"><b>Note</b>&nbsp;&nbsp;IIS is not available on ARM builds. Instead, set up the web server on a separate 64-bit or 32-bit computer and follow the steps for using the sample against non-localhost web server.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;When used with the supplied scripts, this sample communicates with another process on the same machine (IIS server on loopback) for demonstration purposes only. Communicating over loopback to other processes is not permitted in
 Windows Store apps and such apps would not pass Store validation. </p>
<p></p>
<p>To deploy this app after building it, select <b>Deploy Solution</b> from the <b>
Build</b> menu. A tile for the sample will be available on the Start Screen. To both deploy and run the sample, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Visual Studio&nbsp;2012 (any SKU). (Or select the corresponding
 options from the Debug menu.) </p>
<p>After the server computer has started, start the app on the local computer. </p>
<dl><dd>A tile to start the app will be available on the Start Screen. </dd></dl>
<p></p>
</div>
