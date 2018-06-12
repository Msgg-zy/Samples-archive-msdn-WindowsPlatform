# NorthwindRT Brokered WinRT Component Sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Store app
* WinRTC
## Topics
* Sideloading
* Using legacy code
## IsPublished
* True
## ModifiedDate
* 2014-04-03 02:04:42
## Description

<p><span>This is a complete end-to-end sample, used at Build 2014, which demonstrates using Brokered WinRT Components to allow a Windows Store app to interact with a desktop server component.</span></p>
<p>&nbsp;</p>
<p><strong><span>What this sample does</span></strong></p>
<p>This sample:</p>
<p>&nbsp;</p>
<ul>
<li>
<p>Creates a desktop service</p>
</li><li>
<p>Creates a Windows Store app client</p>
</li><li>
<p>Runs a script which configures the security settings for the proxy/stub&nbsp;</p>
</li><li>
<p>Allows the client to access the desktop service.</p>
</li></ul>
<p><strong><span>Instructions</span></strong></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<ol>
<li>
<p>Open the downloaded solution, and locate the archive &quot;NorthwindRT.zip&quot;.</p>
</li><li>
<p>Unzip this solution, and open it.</p>
</li><li>
<p>Build and run the solution - it will fail at this point.</p>
</li><li>
<p>Run the script &quot;register_component.ps1&quot; in order to copy the files into the correct locations and configure security settings for the proxy/stub.</p>
</li><li>
<p>Re-run the solution with the Windows Store App client as the start project.</p>
</li></ol>
<p><strong><span>&nbsp;</span></strong></p>
<p><strong>Related Samples</strong></p>
<p>&nbsp;</p>
<ul>
<li>
<p><a title="Host sample" href="http://code.msdn.microsoft.com/Using-network-loopback-in-0de2344a">Using network loopback in side-loaded Windows Store apps with WCF</a>&nbsp;</p>
</li><li>
<p><a title="Network loopback sample using ASP.net" href="http://code.msdn.microsoft.com/windowsapps/Using-network-loopback-in-f1cbc32a">Using network loopback in side-loaded Windows Store apps using ASP.NET and SignalR</a></p>
</li></ul>
