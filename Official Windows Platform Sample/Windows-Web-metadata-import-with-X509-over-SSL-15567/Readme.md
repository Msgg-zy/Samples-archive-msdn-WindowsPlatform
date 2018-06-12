# Windows Web Services metadata import with X509 over SSL sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Windows web services
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:24:49
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430435">
Windows Web Services API</a> to import metadata from an endpoint that supports using an X509 token using
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd323568"><b>WS_XML_TOKEN_MESSAGE_SECURITY_BINDING</b></a> with
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd323441"><b>WS_SSL_TRANSPORT_SECURITY_BINDING</b></a>.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd323568"><b>WS_XML_TOKEN_MESSAGE_SECURITY_BINDING</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd323441"><b>WS_SSL_TRANSPORT_SECURITY_BINDING</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430503"><b>WsCreateMetadata</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430631"><b>WsSetInput</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430595"><b>WsReadMetadata</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430551"><b>WsGetMissingMetadataDocumentAddress</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430549"><b>WsGetMetadataEndpoints</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430554"><b>WsGetPolicyAlternativeCount</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430570"><b>WsMatchPolicyAlternative</b></a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430435">Windows Web Services API</a>
<h3>Operating system requirements</h3>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;7 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2008&nbsp;R2 </dt></td>
</tr>
</tbody>
</table>
<h3>Build the sample</h3>
<p>To build this sample, open the CPP project solution (.sln) file within Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). Press F7 (or F6 for Visual Studio&nbsp;2013) or go to Build-&gt;Build Solution from the top menu after the sample has loaded. The sample will
 be built in the default \Debug or Release directory.</p>
<h3>Run the sample</h3>
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl-F5 (run without debugging enabled) from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the Debug menu.)
</p>
</div>
