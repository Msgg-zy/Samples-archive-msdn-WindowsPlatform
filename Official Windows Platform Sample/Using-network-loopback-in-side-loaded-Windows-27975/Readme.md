# Using network loopback in side-loaded Windows Store apps with REST - Host app
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* REST
* Windows Store app
## Topics
* Sideloading
* Using legacy code
## IsPublished
* True
## ModifiedDate
* 2014-04-03 11:53:25
## Description

<h1><span style="font-size:xx-small">This sample demonstrate the use of a network loopback technique to allow side-loaded Windows Store apps running on Windows 8.1 Update to access Desktop server components. This sample uses ASP.NET Web API and SignalR.&nbsp;</span></h1>
<p><span><strong>You can download the corresponding Client app here:&nbsp;</strong></span><a href="http://code.msdn.microsoft.com/windowsapps/Using-network-loopback-in-f1cbc32a">http://code.msdn.microsoft.com/windowsapps/Using-network-loopback-in-f1cbc32a</a></p>
<p>&nbsp;</p>
<p>These samples show you how to:</p>
<p>&nbsp;</p>
<ul>
<li>Create a Web API controller using both ASP.NET and SignalR. </li><li>Create a Web API client using ASP.NET and SignalR. </li><li>Call components in the server from the client. </li></ul>
<p>&nbsp;</p>
<p><br>
Instructions</p>
<ul>
<li>Open the solution, and find the file &quot;RestServiceHost.zip&quot;.&nbsp; </li><li>Extract this archive to create a new Visual Studio solution, and open it. </li><li>Select Start to build and run the RestServiceHost project. &nbsp;(Nuget may install extra components during the initial build process).
</li><li>In a separate instance of Visual Studio, select Start build and run the RestServiceClient project.
</li><li>The Client app will connect to the Host server, and display a user interface for testing purposes.
</li></ul>
<p>&nbsp;</p>
<p><span><strong>Related Samples</strong></span></p>
<p>&nbsp;</p>
<ul>
<li><span><a title="Host sample" href="http://code.msdn.microsoft.com/Using-network-loopback-in-0de2344a">Using network loopback in side-loaded Windows Store apps with WCF - Host app</a>&nbsp;</span>
</li><li><span><a title="Network loopback sample using ASP.net" href="http://code.msdn.microsoft.com/windowsapps/Using-network-loopback-in-f1cbc32a">Using network loopback in side-loaded Windows Store apps using ASP.NET and SignalR</a></span>
</li></ul>
