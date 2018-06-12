# Mobile broadband account provisioning sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
* Mobile Broadband
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:31:21
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Windows&nbsp;8.1 Mobile Broadband provisioning agent API (<a href="http://msdn.microsoft.com/library/windows/apps/br207397"><b>Windows.Networking.NetworkOperators.ProvisioningAgent</b></a>) in order to configure Windows&nbsp;8.1
 with required connectivity information and access provisioning specific data. It demonstrates how to:
</p>
<ul>
<li>configure Windows&nbsp;8.1 with connection profiles described in an XML document. </li><li>configure Windows&nbsp;8.1 with the cost associated with a Mobile Broadband profile.
</li><li>access details of the usage data associated with a provisioned Mobile Broadband profile.
</li><li>access details of a Mobile Broadband provisioning attempt on a per-provisioning-element basis.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207384"><b>ProfileUsage</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212046"><b>ProvisionFromXmlDocumentResults</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207397"><b>ProvisioningAgent</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Related technologies</h2>
<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>
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
</tbody>
</table>
<h2>Build the sample</h2>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>The Provisioning agent SDK sample has the following requirements: </p>
<ul>
<li>Scenarios 1, 2, and 3 within the sample access privileged APIs and require a custom signed Mobile Broadband account metadata package that references this application or the application accessing the device in order to run. The application will display an
 “Access is Denied” error message if the metadata package does not explicitly grant permission to this application. For info about Mobile Broadband, see the
<a href="http://go.microsoft.com/fwlink/p/?LinkID=301754">Windows Hardware Dev Center</a>.
</li><li>Scenario 4 requires signed provisioning XML using XML-DSIG with a digital signing EV certificate.
</li></ul>
<p></p>
</div>
