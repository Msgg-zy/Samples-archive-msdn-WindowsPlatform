# Network Access Protection SHA-SHV-QEC sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* COM
## Topics
* Security
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:25:16
## Description

<div id="mainSection">
<p>This sample shows how to create a Quarantine Enforcement Client (QEC), System Health Agent (SHA), and System Health Validator (SHV), for the Network Access Protection (NAP) system.
</p>
<p class="note"><b>Warning</b>&nbsp;&nbsp;This sample requires Microsoft Visual Studio&nbsp;2013 and doesn't compile in Microsoft Visual Studio Express&nbsp;2013 for Windows.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa369143">About NAP</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa369706">NAP Reference</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms694197">Microsoft Media Foundation</a>
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
<p>To build the sample using Visual Studio&nbsp;2013:</p>
<ol>
<li>
<p>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled SdkSamples.sln from Visual Studio&nbsp;2013.</p>
</li><li>
<p>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<p>To build the sample in a Command Prompt window:</p>
<ol>
<li>Open a Command Prompt window and navigate to the sample directory. </li><li>Enter <b>msbuild SdkSamples.sln</b>. </li></ol>
<h3>Run the sample</h3>
<p>To run this sample, follow these steps:</p>
<ol>
<li>Run <b>Regsvr32 /s </b><i>PathToSdkShv.dll</i><b>\SdkShv.dll</b> on the NAP server.
</li><li>Run <b>SdkSha.exe /?</b> on the NAP client for further instructions. </li><li>Run <b>SdkQec.exe /?</b> on the NAP client for further instructions. </li></ol>
<p>To run SdkShaInfo.dll, follow these steps:</p>
<ol>
<li>Run SdkSha.exe at a command prompt on the NAP client. </li><li>In another Command Prompt window on the NAP client, enter <b>regsvr32 /s SdkShaInfo.dll</b>.
</li><li>Run <b>netsh nap client show state</b> on the NAP client and note that the parameters displayed for the SDK SHA sample differ from the parameters displayed when SdkShaInfo.dll is not registered. The SHA\DLL\Messages.mc file can be edited to change the parameters
 displayed for the SDK SHA sample. </li></ol>
<p>To install or uninstall the SHV configuration UI, follow these steps:</p>
<ol>
<li>Run <b>Regsvr32 /s </b><i>PathToSdkShv.dll</i><b>\SdkShv.dll</b> on the NAP server.
</li><li>Run <b>Sampleshvui.exe /regserver</b> to install the sample SHV configuration UI on the NAP server.
</li><li>Run <b>Sampleshvui.exe /unregserver</b> to uninstall the sample SHV configuration UI from the NAP server.
</li></ol>
<p>To debug the app and then run it from Visual Studio&nbsp;2013, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
