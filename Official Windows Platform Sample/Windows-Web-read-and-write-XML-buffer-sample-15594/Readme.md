# Windows Web Services read and write XML buffer sample
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
* 2013-10-17 02:26:17
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430435">
Windows Web Services API</a> to write XML to an XML buffer and then read it back out.
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
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430497"><b>WsCreateError</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430499"><b>WsCreateHeap</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430504"><b>WsCreateReader</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430509"><b>WsCreateWriter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430510"><b>WsCreateXmlBuffer</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430524"><b>WsFlushWriter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430526"><b>WsFreeError</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430527"><b>WsFreeHeap</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430531"><b>WsFreeReader</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430535"><b>WsFreeWriter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430539"><b>WsGetErrorProperty</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430540"><b>WsGetErrorString</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430585"><b>WsReadChars</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430587"><b>WsReadElement</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430589"><b>WsReadEndElement</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430599"><b>WsReadStartElement</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430600"><b>WsReadToStartElement</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430602"><b>WsReadValue</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430615"><b>WsResetHeap</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430632"><b>WsSetInputToBuffer</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430636"><b>WsSetOutputToBuffer</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430650"><b>WsWriteChars</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430655"><b>WsWriteEndElement</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430665"><b>WsWriteStartElement</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430652"><b>WsWriteElement</b></a>
</dt><dt><b>WsWriteEndElement</b> </dt><dt><b>WsWriteStartElement</b> </dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430669"><b>WsWriteValue</b></a>
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
<p>To build this sample, open the CPP project solution (.sln) file within Microsoft Visual Studio Express&nbsp;2013 for Windows for Windows&nbsp;8.1 (any SKU). Press F7 (or F6 for Visual Studio&nbsp;2013) or go to Build-&gt;Build Solution from the top menu after the sample
 has loaded. The sample will be built in the default \Debug or Release directory.</p>
<h3>Run the sample</h3>
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl-F5 (run without debugging enabled) from Visual Studio Express&nbsp;2013 for Windows for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the Debug menu.)
</p>
</div>
