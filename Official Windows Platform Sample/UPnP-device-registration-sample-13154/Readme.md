# UPnP device registration sample
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
* 2013-10-17 02:26:25
## Description

<div id="mainSection">
<p>This sample implements the <b>UPnP Dimmer device sample</b> functionality as a COM server object and demonstrates how to register and unregister the device with the Microsoft UPnP framework device host.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The actual device functionality is implemented in the
<a href="http://go.microsoft.com/fwlink/p/?linkid=245629">UPnP Dimmer device sample</a>. The UPnP device registration sample will not build if the Dimmer device sample has not been built first.</p>
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
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa382303">Universal Plug and Play API</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa382303">Universal Plug and Play API</a>
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
<p>To build the sample using Visual Studio&nbsp;2013 (preferred method):</p>
<ol>
<li>Build the <a href="http://go.microsoft.com/fwlink/p/?linkid=245629">UPnP Dimmer device sample</a> project and place it in the UPnP device registration sample folder.
</li><li>Navigate to the UPnP device registration sample <b>\cpp</b> directory. </li><li>Double-click the icon for the <b>RegDevice.sln</b> (solution) file to open the file in Visual Studio.
</li><li>In the <b>Build</b> menu, click <b>Build Solution</b>. The application will be built in the default
<b>\Debug</b> or <b>\Release</b> directory.
<p class="note"><b>Note</b>&nbsp;&nbsp;The built <a href="http://go.microsoft.com/fwlink/p/?linkid=245629">
UPnP Dimmer device sample</a> must be present in the UPnP device registration sample folder at build.</p>
</li></ol>
<p>To build the sample using the command prompt:</p>
<ol>
<li>Open the <b>Command Prompt</b> window and navigate to the sample directory. </li><li>Type <b>msbuild RegDevice.sln</b>.
<p class="note"><b>Note</b>&nbsp;&nbsp;The built <a href="http://go.microsoft.com/fwlink/p/?linkid=245629">
UPnP Dimmer device sample</a> must be present in the UPnP device registration sample folder at build.</p>
</li></ol>
<h3>Run the sample</h3>
<p>Running the Sample:</p>
<ol>
<li>Open a <b>Command Prompt</b> window and navigate to the <b>Release</b> or <b>
Debug</b> directory for the built Dimmer sample. </li><li>Run <b>regsvr32 UPNPSampleDimmerDevice.dll</b> to register the device specific COM object.
</li><li>Navigate to the <b>Release</b> or <b>Debug</b> directory for the built Register Device sample.
</li><li>Copy the <b>DimmerDevice-Desc.xml</b> and <b>DimmingService_SCPD</b>.xml files from the RegisterDevice directory to the current directory.
</li><li>Run <b>RegDevice.exe</b>. </li><li>After the device is hosted, go to <b>My Computer</b> on a computer that has Windows&nbsp;8.1 installed.
</li><li>Click <b>Network</b> in the left-side menu. </li><li>Turn on Network Discovery, if prompted. </li><li>The <b>UPNP SDK Dimmer Device Hosted by Windows</b> should appear under <b>Other Devices</b>.
</li><li>Double-click the device in <b>Network Explorer</b>. This should open a presentation web-page in a web browser.
</li><li>Accept the security warning in order to be able to control the device. You can now use the presentation web-page interface to control the device.
</li></ol>
</div>
