# Mobile broadband account provisioning sample (Windows 8)
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
* 2013-06-27 02:21:52
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Windows&nbsp;8 Mobile Broadband provisioning agent API (<a href="http://msdn.microsoft.com/library/windows/apps/br207397"><b>Windows.Networking.NetworkOperators.ProvisioningAgent</b></a>) in order to configure Windows&nbsp;8
 with required connectivity information and access provisioning specific data. It demonstrates how to:
</p>
<ul>
<li>configure Windows&nbsp;8 with connection profiles described in an XML document. </li><li>configure Windows&nbsp;8 with the cost associated with a Mobile Broadband profile.
</li><li>access details of the usage data associated with a provisioned Mobile Broadband profile.
</li><li>access details of a Mobile Broadband provisioning attempt on a per-provisioning-element basis.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207384"><b>ProfileUsage</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212046"><b>ProvisionFromXmlDocumentResults</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207397"><b>ProvisioningAgent</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>
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
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>The Provisioning agent SDK sample has the following requirements: </p>
<ul>
<li>Scenarios 1, 2, and 3 within the sample access privileged APIs and require a custom signed Mobile Broadband account metadata package that references this application or the application accessing the device in order to run. The application will display an
 “Access is Denied” error message if the metadata package does not explicitly grant permission to this application. For information about how to create device metadata packages, see the &quot;<a href="http://go.microsoft.com/fwlink/p/?LinkId=242581">Windows 8 Device
 Apps for Mobile Network Operators</a>&quot; whitepaper. </li><li>Scenario 4 requires signed provisioning XML using XML-DSIG with a digital signing EV certificate.
</li></ul>
<p></p>
</div>
