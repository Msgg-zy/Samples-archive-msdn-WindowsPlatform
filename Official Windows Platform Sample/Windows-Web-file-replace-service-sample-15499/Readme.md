# Windows Web Services file replace service sample
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
* 2013-10-17 02:20:47
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430435">
Windows Web Services API</a> to retrieve files from a server and copy them to a client. It employs three components - the server service running on the machine with the source file, the client service running on the machine where the destination file will be
 copied, and a command line tool to control the copying. The client and server services are constantly running web services while the command line tool is started by the user and exits after one request. This sample implements the client and server services,
 and the command line tool is implemented by the <b>Windows Web Services file replace client sample</b>.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430495"><b>WsCreateChannel</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd430502"><b>WsCreateMessageForChannel</b></a>
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
<li>Open <b>Windows Explorer</b> and navigate to the directory. </li><li>Double-click the icon for the <b>FileRepService.sln</b> (solution) file to open the file in Visual Studio.
</li><li>Change the active solution platform to the platform you want in the <b>Configuration Manager</b> found in the
<b>Build</b> menu. </li><li>In the <b>Build</b> menu, click <b>Build Solution</b>. The app is built in the default
<b>\Debug</b> or <b>\Release</b> directory. </li></ol>
<p>To build the sample using the command prompt:</p>
<ol>
<li>Open the <b>Command Prompt</b> window and navigate to the directory. </li><li>Type <b>msbuild FileRepService.sln</b>. </li></ol>
<h3>Run the sample</h3>
<p>To run this sample after building it, press <b>F5</b> (run with debugging enabled) or
<b>Ctrl-F5</b> (run without debugging enabled) from Microsoft Visual Studio Express&nbsp;2013 for Windows for Windows&nbsp;8.1 (any SKU).</p>
</div>
