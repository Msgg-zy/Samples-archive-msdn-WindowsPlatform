# Windows Web Services asynchronous streaming server example
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
* 2013-10-17 02:18:02
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430435">
Windows Web Services API</a> to implement a basic TCP server that sends one-way messages in an asynchronous streaming fashion. This sample performs streaming only on the application layer. On the transport layer, data is buffered before returning to the client.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;Streaming mode is supported only on HTTP channels.
</p>
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
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430500"><b>WsCreateListener</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430575"><b>WsOpenListener</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd401948"><b>WS_LISTENER</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd401953"><b>WS_MESSAGE</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd401759"><b>WS_ASYNC_OPERATION</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd401757"><b>WS_ASYNC_CONTEXT</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd401768"><b>WS_CALLBACK_MODEL</b></a>
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
<p>To build the sample using Visual Studio (preferred method):</p>
<ol>
<li>Open <b>Windows Explorer</b> and navigate to the directory. </li><li>Double-click the icon for the <b>AsyncStreamingTcpServer.sln</b> (solution) file to open the file in Visual Studio.
</li><li>Change the active solution platform to the platform you want in the <b>Configuration Manager</b> found on the
<b>Build</b> menu. </li><li>In the <b>Build</b> menu, select <b>Build Solution</b>. The app is built in the default
<b>\Debug</b> or <b>\Release</b> directory. </li></ol>
<p>To build the sample using the command line:</p>
<ol>
<li>Open the <b>Command Prompt</b> window and navigate to the directory. </li><li>Type <b>msbuild AsyncStreamingTcpServer.sln</b>. </li></ol>
<h3>Run the sample</h3>
<p>To run this sample after building it, press <b>F5</b> (run with debugging enabled) or
<b>Ctrl-F5</b> (run without debugging enabled) from Microsoft Visual Studio Express&nbsp;2013 for Windows for Windows&nbsp;8.1 (any SKU).</p>
</div>
