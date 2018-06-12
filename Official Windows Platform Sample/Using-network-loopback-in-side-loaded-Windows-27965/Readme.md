# Using network loopback in side-loaded Windows Store apps - Client app
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
* 2014-04-03 11:52:59
## Description

<h1><span style="font-size:small">This sample demonstrate the use of a network loopback technique to allow side-loaded Windows Store apps running on Windows 8.1 Update to access Desktop server components. This sample uses ASP.NET Web API and SignalR.
</span></h1>
<h1><span style="font-size:small">This is the Client app; you can download the related Host sample from&nbsp;<a href="http://code.msdn.microsoft.com/windowsapps/Using-network-loopback-in-07b8b377">http://code.msdn.microsoft.com/windowsapps/Using-network-loopback-in-07b8b377</a></span></h1>
<p><span style="font-size:small">These samples show you how to:</span></p>
<p>&nbsp;</p>
<ul>
<li><span style="font-size:small">Create a Web API controller using both ASP.NET and SignalR.</span>
</li><li><span style="font-size:small">Create a Web API client using ASP.NET and SignalR.</span>
</li><li><span style="font-size:small">Call components in the server from the client.</span>
</li></ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<ol>
<li><span style="font-size:small">Select Start to build and run the RestServiceHost project.&nbsp; (Nuget may install extra components during the initial build process).</span>
</li><li><span style="font-size:small">In a separate instance of Visual Studio, select Start build and run the RestServiceClient project.</span>
</li><li><span style="font-size:small">The Client app will connect to the Host server, and display a user interface for testing purposes.</span>
</li></ol>
<p>&nbsp;</p>
<p><span style="font-size:small"><strong>Related Samples</strong></span></p>
<p>&nbsp;</p>
<ul>
<li><span style="font-size:small"><a title="Host sample" href="http://code.msdn.microsoft.com/Using-network-loopback-in-0de2344a">Using network loopback in side-loaded Windows Store apps with WCF - Host app</a>&nbsp;</span>
</li><li><span style="font-size:small"><a title="Network loopback sample using ASP.net" href="http://code.msdn.microsoft.com/windowsapps/Using-network-loopback-in-07b8b377">Using network loopback in side-loaded Windows Store apps using ASP.NET and SignalR</a></span>
</li></ul>
