# Windows Web Services HTTP calculator with XML token over SSL client sample
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
* 2013-10-17 02:23:13
## Description

<div id="mainSection">
<div class="clsServerSDKContent">
<h1><a id="gallery_samples.httpcalculatorwithusernamexmltokenoversslclient_gallery"></a>Windows Web Services HTTP calculator with XML token over SSL client sample</h1>
</div>
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430435">
Windows Web Services API</a> to implement an HTTP client that uses the service proxy to talk to a calculator service with an XML security token over SSL mixed-mode security. In this setup, the transport connection is protected (signed, encrypted) by SSL which
 also provides server authentication. Client authentication is provided by a WS-Security username/password pair that is used as an XML security token by the example.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This client side example uses the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd323568">
<b>WS_XML_TOKEN_MESSAGE_SECURITY_BINDING</b></a>. An equivalent way of doing the same client side security using the
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd323497"><b>WS_USERNAME_MESSAGE_SECURITY_BINDING</b></a> is illustrated by the example
<b>Windows Web Services HTTP calculator with username over SSL client sample</b>. A matching server side for both of these client side examples is provided by the example
<b>Windows Web Services HTTP calculator with username over SSL service</b>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430490"><b>WsCloseServiceProxy</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430499"><b>WsCreateHeap</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430504"><b>WsCreateReader</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430507"><b>WsCreateServiceProxy</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430511"><b>WsCreateXmlSecurityToken</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430527"><b>WsFreeHeap</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430531"><b>WsFreeReader</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430534"><b>WsFreeServiceProxy</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430532"><b>WsFreeSecurityToken</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430539"><b>WsGetErrorProperty</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430540"><b>WsGetErrorString</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430577"><b>WsOpenServiceProxy</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430601"><b>WsReadType</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430631"><b>WsSetInput</b></a>
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
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl-F5 (run without debugging enabled) from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the Debug menu.)</p>
</div>
