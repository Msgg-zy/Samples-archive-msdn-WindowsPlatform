# User domain name sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Security
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:25:46
## Description

<div id="mainSection">
<p>This sample demonstrates the domain-related functionality provided by the <a href="http://msdn.microsoft.com/library/windows/apps/br241871">
<b>UserInformation</b></a> class of the <a href="http://msdn.microsoft.com/library/windows/apps/br241881">
<b>Windows.System.UserProfile</b></a> namespace. The <a href="http://msdn.microsoft.com/library/windows/apps/br241871">
<b>UserInformation</b></a> class enables an app to get and set information about the user, including the account picture, domain name, the principal name, and the Uniform Resource Identifier (URI) of the Session Initiation Protocol (SIP).</p>
<p>This sample covers the following scenarios:</p>
<ul>
<li>How to get the Domain Name System (DNS) domain name for the user. </li><li>How to get the principal name for the user. This user's principle name is typically the user's email address, although this is not always true.
</li><li>How to get the SIP URI for the user. </li></ul>
<p></p>
<p>This sample uses the following API elements from the <a href="http://msdn.microsoft.com/library/windows/apps/br241871">
<b>UserInformation</b></a> class:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br241871_nameaccessallowed"><b>NameAccessAllowed</b></a> property
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br241871_getprincipalnameasync"><b>GetPrincipalNameAsync</b></a> method
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br241871_getdomainnameasync"><b>GetDomainNameAsync</b></a> method
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br241871_getsessioninitiationprotocoluriasync"><b>GetSessionInitiationProtocolUriAsync</b></a> method
</li></ul>
<p></p>
<p>For a sample app that demonstrates how to get and set the image used for the user's tile, see the
<a href="http://go.microsoft.com/fwlink/p/?linkid=231579">Account picture name sample</a>. That sample also demonstrates the different ways of getting the name of the user that is currently logged in.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241871"><b>Windows.System.UserProfile.UserInformation</b></a>
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
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
</div>
