# Web service discovery (WS-Discovery) sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Networking
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:30:46
## Description

<div id="mainSection">
<p>This sample shows how to use the Web Service Discovery API to perform WS-Discovery routines by using the
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa386012"><b>IWSDiscoveryProvider</b></a>,
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa386013"><b>IWSDiscoveryProviderNotify</b></a>,
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa386025"><b>IWSDiscoveryPublisher</b></a> and
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa386026"><b>IWSDiscoveryPublisherNotify</b></a> interfaces.</p>
<p>This sample implements the following WS-Discovery message pattern:</p>
<p><b>Probe --&gt;ProbeMatches --&gt; Resolve --&gt; ResolveMatches</b>.</p>
<p class="note"><b>Warning</b>&nbsp;&nbsp;This sample requires Microsoft Visual Studio&nbsp;2013 and will not compile in Microsoft Visual Studio Express&nbsp;2013 for Windows</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt>&lt;MSHelp:link tabindex=&quot;0&quot; keywords=&quot;http://msdn.microsoft.com/en-us/library/windows/desktop/aa826001&quot; xmlns:MSHelp=&quot;http://msdn.microsoft.com/mshelp&quot;&gt;Web Services for Devices API&lt;/MSHelp:link&gt;
</dt></dl>
<h3>Related technologies</h3>
&lt;MSHelp:link tabindex=&quot;0&quot; keywords=&quot;http://msdn.microsoft.com/en-us/library/windows/desktop/aa826001&quot; xmlns:MSHelp=&quot;http://msdn.microsoft.com/mshelp&quot;&gt;Web Services for Devices API&lt;/MSHelp:link&gt;
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
<p>To build the sample using Visual Studio (preferred method):</p>
<ol>
<li>Open <b>Windows Explorer</b> and navigate to the sample <b>\cpp</b> directory.
</li><li>Double-click the icon for the <b>WSDiscovery.sln</b> (solution) file to open the file in Visual Studio.
</li><li>On the <b>Build</b> menu, click <b>Build Solution</b>. The application will be built in the default
<b>\Debug</b> or <b>\Release</b> directory. </li></ol>
<p>To build the sample using the command prompt:</p>
<ol>
<li>Open the <b>Command Prompt</b> window and navigate to the directory containing the sample for a specific language.
</li><li>Type <b>msbuild WSDiscovery.sln</b>. </li></ol>
<h3>Run the sample</h3>
<p>To run the sample:</p>
<ol>
<li>Navigate to the directory that contains the new executable, using the <b>command prompt</b> or
<b>Windows Explorer</b>. </li><li>To start the WS-Discovery Client, type <b>WSDiscoveryClient.exe /?</b> for a list of commands and usages.
</li><li>To start the WS-Discovery Target Service, type <b>WSDiscoveryService.exe /?</b> for a list of commands and usages.
</li></ol>
<p class="note"><b>Note</b>&nbsp;&nbsp;</p>
<p class="note">In order for the client and target service to run correctly, make sure that your firewall settings allow WS-Discovery traffic and that the firewall allows multicast traffic.
</p>
<p class="note">The client and target service can be run on the same or different machines, and they can be run it multiple instances simultaneously to mimic the effect of having multiple target services or clients in the network, provided that the machines
 hosting these applications have sufficient resources such as large enough memory.</p>
<p></p>
</div>
