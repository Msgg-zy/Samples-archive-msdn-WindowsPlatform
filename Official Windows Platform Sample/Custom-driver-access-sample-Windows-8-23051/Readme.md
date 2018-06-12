# Custom driver access sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Devices and sensors
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:10:17
## Description

<div id="mainSection">
<p>This sample shows how to use <a href="http://msdn.microsoft.com/library/windows/apps/hh404237">
<b>CreateDeviceAccessInstance</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/hh404258">
<b>IDeviceIoControl</b></a> to access a specialized device. </p>
<p><b>Building and Using the FX2 Samples</b></p>
<p>The Custom Driver Access (MoFX2) sample application demonstrates how adevice app can interact with a USB device using a Windows Driver Framework (WDF) driver.</p>
<p>This sample is written for OSRUSB-FX2 Learning Kit device. Full functionality of the sample application requires an actual FX2 device. You can order the device
<a href="http://go.microsoft.com/fwlink/p/?linkid=227221">here</a>.</p>
<p>For more info about this device, see the device specification for the <a href="http://go.microsoft.com/fwlink/p/?linkid=227224">
OSR USB-FX2 Learning Kit</a>.</p>
<p>This document presumes you want to initially build and run the sample application.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;</p>
<p class="note">To run this sample with hardware, you must download an additional sample that provides the driver and metadata for the FX2 device. Depending on whether you would like to use a Kernel-Mode Driver Framework (KMDF) driver or a User-Mode Driver
 Framework (UMDF) driver, you can download either the <a href="http://msdn.microsoft.com/library/windows/apps/">
kmdf_fx2</a> sample, or the <a href="http://msdn.microsoft.com/library/windows/apps/">
umdf_fx2</a> sample.</p>
<p></p>
<p><b>Installing Your Development Environment</b></p>
<p>Before you can build and run this sample application, you'll need to complete the following steps:</p>
<ul>
<li>Install Windows&nbsp;8 </li><li>Install Microsoft Visual Studio Ultimate&nbsp;2012 </li><li>Install <a href="http://go.microsoft.com/fwlink/p/?linkid=246559">Windows Driver Kit 8 Consumer Preview</a>
</li><li>Download and install the WDFCoInstaller MSI from <a href="http://go.microsoft.com/fwlink/p/?linkid=226396">
MSDN</a> </li><li>Download either the <a href="http://msdn.microsoft.com/library/windows/apps/">
kmdf_fx2</a> sample, or the <a href="http://msdn.microsoft.com/library/windows/apps/">
umdf_fx2</a> sample from the <a href="http://go.microsoft.com/fwlink/p/?linkid=246562">
sample gallery</a> </li><li>Download this Custom driver access sample from the <a href="http://go.microsoft.com/fwlink/p/?linkid=246562">
sample gallery</a> </li></ul>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Samples</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/">kmdf_fx2</a> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/">umdf_fx2</a> </dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh404244">Device Access API</a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241442">Device Experience in Windows 8:Device Apps</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241447">Windows 8 Device App Design Guide for Specialized Devices</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241443">Device Metadata in Windows 8</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=246571">Windows 8 Device App Lifecycle</a>
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
<p>To deploy the Custom driver access sample solution on a single computer, you must first install the
<a href="http://msdn.microsoft.com/library/windows/apps/">kmdf_fx2</a> sample or the
<a href="http://msdn.microsoft.com/library/windows/apps/">umdf_fx2</a> sample, and then update and deploy the device metadata that is supplied with that sample.
</p>
<h4><a id="Build_and_install_the_Fx2_driver_sample"></a><a id="build_and_install_the_fx2_driver_sample"></a><a id="BUILD_AND_INSTALL_THE_FX2_DRIVER_SAMPLE"></a>Build and install the Fx2 driver sample</h4>
<ol>
<li>To enable test signing:
<ol>
<li>Open a command prompt as administrator. </li><li>Type the following command: <b>&quot;bcdedit /set testsigning on&quot;</b>. </li><li>Restart your computer. </li></ol>
</li><li>Follow the build instructions for <a href="http://msdn.microsoft.com/library/windows/apps/">
kmdf_fx2</a> or <a href="http://msdn.microsoft.com/library/windows/apps/">umdf_fx2</a>.
</li></ol>
<h4><a id="Update_and_deploy_device_metadata"></a><a id="update_and_deploy_device_metadata"></a><a id="UPDATE_AND_DEPLOY_DEVICE_METADATA"></a>Update and deploy device metadata</h4>
<p>The device metadata in this step is included in <a href="http://msdn.microsoft.com/library/windows/apps/">
kmdf_fx2</a> or <a href="http://msdn.microsoft.com/library/windows/apps/">umdf_fx2</a>.</p>
<ol>
<li>Open an instance of Visual Studio Ultimate&nbsp;2012. </li><li>Open the <b>Device Metadata Authoring Wizard</b> (Driver &gt; Device Metadata &gt; Authoring).
</li><li>Select <b>Update Existing Device Metadata Package</b>. </li><li>Click <b>Browse</b> to select a device metadata package from the driver project. Choose a metadata package for your locale from a subdirectory of the devicemetadatapackage directory. The device metadata packages have the extension
<b>devicemetadata.ms</b>. </li><li>Click <b>Next</b>. </li><li>In the <b>Application</b> tab, add <b>Device Companion Application</b> information to the relevant fields. To ensure the accuracy of this information, open the CustomDriverAccess.sln file using Visual Studio, and refer to the following fields in the MoFx2
 project's package.appxmanifest file from Solution Explorer.
<ul>
<li>Package name </li><li>Publisher name </li><li>App ID </li></ul>
</li><li>Add Privileged Application information to the relevant fields. Check that the package name and publisher name match the package and publisher names in the MoFx2 project's package.appxmanifest file.
<ul>
<li>Package name </li><li>Publisher name </li><li>Access Custom Driver (check this box) </li></ul>
<p class="note"><b>Note</b>&nbsp;&nbsp;These build instructions are only for building this sample so it can be tested locally with the Fx2 board. If you are authoring device metadata for your own device rather than the Fx2 board, you must also ensure that the Package
 name, Publisher name, and App ID are in sync with those that you registered with the Windows Store.
</p>
</li><li>Open the <b>Finish</b> tab. </li><li>Select the <b>Copy packages to your system's local metadata store</b> check box.
</li><li>Click <b>Finish</b>. </li><li>Restart your computer </li></ol>
<h3><a id="Building_the_solution"></a><a id="building_the_solution"></a><a id="BUILDING_THE_SOLUTION"></a>Building the solution</h3>
<ol>
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<h3><a id="Usage_Notes"></a><a id="usage_notes"></a><a id="USAGE_NOTES"></a>Usage Notes</h3>
<ul>
<li>The initial launch of the MoFX2 app will show an error message if you select <b>
1) Getting and setting Seven Segment Display</b>, then select <b>Get Seven Segment Display</b>. The error message reads: &quot;The parameter is incorrect. The segment display value is undefined.&quot;
<p>If you select <b>Set Seven Segment Display</b>, it works thereafter. This is because the device initializes the segment display to a non-numeric value. The sample does this to show how to handle error conditions.</p>
</li><li>If you select <b>Show the bar state</b>, the output shown doesn't (literally) match what is displayed on the screen. There are that number of bars lit, it just is that the table displayed by app doesn't visually correspond to bar locations on the device.
 For example, the screen shows bars 0-4 as lit, there are five lit bars on device; however, the top two and bottom two are not lit. The bar graph display seems odd, but is intentional. It's how the driver and the hardware maps actual the bar line to a number.
 This is what the functional spec for the hardware says. </li><li>In the <b>Get the switch state</b> menu option in the sample application the switch number values on the screen don't match what is silk-screened onto the Revision 2 device. The switches on the Revision 2 device start at 1 instead of 0.
</li></ul>
</div>
