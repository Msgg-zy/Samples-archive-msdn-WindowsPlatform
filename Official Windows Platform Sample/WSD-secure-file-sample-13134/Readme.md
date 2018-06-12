# WSD secure file services sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Devices and sensors
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:20:54
## Description

<div id="mainSection">
<p></p>
<p>This sample demonstrates how to use a selected set of security features in the &lt;MSHelp:link tabindex=&quot;0&quot; keywords=&quot;http://msdn.microsoft.com/en-us/library/windows/desktop/aa826001&quot; xmlns:MSHelp=&quot;http://msdn.microsoft.com/mshelp&quot;&gt;Web Services for Devices
 API&lt;/MSHelp:link&gt;.</p>
<p></p>
<p>This sample is a modification to the <b>WSD file services sample</b>, which introduces security features. The selected set of security features includes the following:
</p>
<ul>
<li>Server authentication over TLS using X509 certificates. The client authenticates the server using the server certificate thumb-print (certificate hash).
</li><li>Client authentication using either NTLM/Negotiate http authentication scheme or X509 client certificate present in the current user store.
</li></ul>
<p></p>
<p>This sample shows how to use a user token, which is a handle containing the credentials of the client. The service uses this token to impersonate the user and then execute any of the code paths through that user.</p>
<p class="note"><b>Warning</b>&nbsp;&nbsp;This sample requires Microsoft Visual Studio&nbsp;2013 and will not compile in Microsoft Visual Studio Express&nbsp;2013 for Windows.</p>
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
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa823078">Configuring WSDAPI Applications to Use a Secure Channel</a>
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
<ol>
<li>
<p>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>2. Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.</p>
</li><li>
<p>Press F6 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p>The client and service applications can run on the same computer or a different one. Be aware that secure channel configurations are required prior to using the client and service applications. For more information, see
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa823078">Configuring WSDAPI Applications to Use a Secure Channel</a>.</p>
<p>To run the service type:</p>
<ol>
<li>Navigate to the directory that contains the new executable, using the command prompt or Windows Explorer.
</li><li>Type <b>FileServiceSecureService.exe </b>at the command prompt, or double-click the icon for
<b>FileServiceSecureService</b> to launch it from Windows Explorer. </li></ol>
<p>To run the client type:</p>
<ol>
<li>Navigate to the directory that contains the new executable, using the command prompt or Windows Explorer.
</li><li>Type <b>FileClientSecureService.exe </b>at the command prompt, or double-click the icon for
<b>FileClientSecureService</b> to launch it from Windows Explorer. </li></ol>
</div>
