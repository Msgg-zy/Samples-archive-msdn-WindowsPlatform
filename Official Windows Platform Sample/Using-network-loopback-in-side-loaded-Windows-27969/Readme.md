# Using network loopback in side-loaded Windows Store apps with WCF - Host app
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* WCF
* Windows Runtime
* Windows Store app
## Topics
* Windows Communication Foundation
* Sideloading
* Using legacy code
## IsPublished
* True
## ModifiedDate
* 2014-04-03 09:26:46
## Description

<p><span style="font-size:small"><strong>This sample demonstrates the use of a network loopback technique to allow side-loaded Windows Store apps running on Windows 8.1 Update to access Desktop server components. This sample uses WCF. This is the Host app;
 there is a related Client component sample.</strong></span></p>
<p><span style="font-size:small"><strong>You can download the corresponding Client app here:&nbsp;<a href="http://code.msdn.microsoft.com/Using-network-loopback-in-10f434b2">http://code.msdn.microsoft.com/Using-network-loopback-in-10f434b2</a></strong></span></p>
<p><span style="font-size:small"><strong><span><br>
</span></strong></span></p>
<h1><span style="font-size:small"><strong>These samples show you how to:</strong></span></h1>
<ul>
<li>
<p><span style="font-size:small">Create a Web API controller using WCF.</span></p>
</li><li>
<p><span style="font-size:small">Create a Web API client using WCF.</span></p>
</li><li>
<p><span style="font-size:small">Call components in the server from the client.</span></p>
</li></ul>
<h1><span style="font-size:small">Instructions</span></h1>
<ul>
<li><span style="font-size:small">Select Start to build and run the <strong>WcfServiceHost</strong> project. &nbsp;(<strong>NuGet</strong> may install extra components during the initial build process).
</span></li><li><span style="font-size:small">In a separate instance of Visual Studio, select
<strong>Build</strong> &gt; <strong>Build Solution</strong> and rthen un the <strong>
WcfServiceClient</strong> project. </span></li><li><span style="font-size:small">The Client app will connect to the Host server, and display a user interface for testing purposes.</span>
</li></ul>
<p>&nbsp;</p>
<p><strong><span style="font-size:small">Related Samples</span></strong></p>
<ul>
<li><a title="Host sample" href="http://code.msdn.microsoft.com/Using-network-loopback-in-10f434b2" style="font-size:small">Using network loopback in side-loaded Windows Store apps with WCF - Client app&nbsp;</a>
</li><li><span style="font-size:small"><a title="ASP.NET sample" href="http://code.msdn.microsoft.com/windowsapps/Using-network-loopback-in-f1cbc32a">Using network loopback in side-loaded Windows Store apps with ASP.NET/SignalR&nbsp;</a></span>
</li></ul>
