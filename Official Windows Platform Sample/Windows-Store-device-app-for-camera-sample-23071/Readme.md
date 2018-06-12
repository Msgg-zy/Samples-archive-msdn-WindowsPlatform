# Windows Store device app for camera sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
## Topics
* Devices and sensors
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:11:47
## Description

<div id="mainSection">
<p>This sample demonstrates how to create a Windows Store device app for a camera. A Windows Store device app is provided by an IHV or OEM to differentiate the capture experience for a particular camera. It can be used to adjust camera settings or to provide
 additional functionality or effects. </p>
<p>The Windows Store device app in this sample provides custom UI for adjusting camera settings when a specific camera associated with the app is being used to capture a photo or video. Device metadata is used to associate the app with a camera.</p>
<p>If the user launches this sample from the app tile in <b>Start</b>, rather than when the camera is capturing video, this sample simply displays a message.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This UI in this sample works together with the custom effect provided by the
<a href="http://go.microsoft.com/fwlink/p/?linkid=251566">Driver MFT Sample</a>. Build and install the Driver MFT Sample before running this sample, so that you can use the UI implemented in thisdevice app to control the custom effect provided in the Driver
 MFT Sample.</p>
<p></p>
<p>This sample shows that adevice app for camera can be activated in two different contexts. The context can be determined by examining the activation parameters.
</p>
<ul>
<li>
<p>The app can be activated from an attempt to adjust settings. This happens when an app calls
<a href="http://msdn.microsoft.com/library/windows/apps/br241060_show"><b>Windows.Media.Capture.CameraOptionsUI.Show</b></a>, or when the user taps the
<b>Camera options</b> control followed by <b>More options</b> in the Camera Capture UI (<a href="http://msdn.microsoft.com/library/windows/apps/br241030"><b>Windows.Media.Capture.CameraCaptureUI</b></a>). In this case, the activation parameter's
<b>kind</b> property is <b>Windows.ApplicationModel.Activation.ActivationKind.CameraSettings</b>.
</p>
<p>When this sample app is activated from the <b>CameraSettings</b> context, it provides a custom
<b>More options</b> UI that contains slider and button controls to adjust camera settings. The camera settings are accessed using the VideoDeviceController object obtained from the activation event's CameraSettingsActivatedEventArgs argument. A Windows Store
 device app for a camera can also provide other additional settings not shown in this sample. For more information, see
<a href="http://go.microsoft.com/fwlink/p/?LinkId=226802">Developing Windows Store device apps for Cameras</a> and the
<a href="http://go.microsoft.com/fwlink/p/?linkid=251566">Driver MFT Sample</a> sample.</p>
</li><li>
<p>The app can also be activated because the user chose the app tile in <b>Start</b>. In this case, the
<b>kind</b> property is <b>Windows.ApplicationModel.Activation.ActivationKind.Launched</b>.
</p>
<p>When a Windows Store device app for a camera is launched from the app tile in <b>
Start</b>, it should provide an interesting and engaging experience. This experience can be used to highlight related products, provide customer support and other services. This sample simply shows an informational message in place of this experience.</p>
</li></ul>
<p></p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Camera Settings declaration must be included in package.appxmanifest. You can see how this is done by double-clicking on
<b>package.appxmanifest</b> in Solution Explorer and opening the <b>Declarations</b> tab.</p>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Concepts</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=226802">Developing Windows Store device apps for Cameras</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=221801">Device Metadata Authoring Wizard</a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=251566">Driver MFT Sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=228589">Camera Capture UI sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=228588">Camera Options UI sample</a>
</dt><dt><b>Tutorials</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465152">Quickstart: Capturing a photo or video using the camera dialog</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241030"><b>Windows.Media.Capture.CameraCaptureUI</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241060"><b>Windows.Media.Capture.CameraOptionsUI</b></a>
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
<td><dt>None supported </dt></td>
</tr>
</tbody>
</table>
<h3>Build the sample</h3>
<h3><a id="Prerequisites"></a><a id="prerequisites"></a><a id="PREREQUISITES"></a>Prerequisites</h3>
<p>The Windows Store device app that this sample demonstrates must be linked to your camera using device metadata.</p>
<ul>
<li>You need a copy of the device metadata package for your camera, to add thedevice app info to it. If you don’t have device metadata, you can build it using the
<b>Device Metadata Authoring Wizard</b> that is integrated with Visual Studio and available in the in the
<a href="http://go.microsoft.com/fwlink/p/?linkid=251841">Windows Driver Kit (WDK)</a>. See the
<a href="http://go.microsoft.com/fwlink/p/?linkid=221801">Device Metadata Authoring Wizard</a> documentation for more information.
</li><li>You need to have the WDK installed so that you have the <b>Device Metadata Authoring Wizard</b> to use and edit the metadata. This tool is then available from the
<b>Driver</b> menu in Visual Studio Ultimate&nbsp;2012. </li><li>If you have an internally embedded camera, rather than an externally connected one, follow the requirements that apply to your camera, described in “Appendix A: Requirements for identifying internal cameras” in the paper
<a href="http://go.microsoft.com/fwlink/p/?LinkId=226802">Developing Windows Store device apps for Cameras</a>.
</li></ul>
<h3><a id="Install_the_sample"></a><a id="install_the_sample"></a><a id="INSTALL_THE_SAMPLE"></a>Install the sample</h3>
<p>The following steps build the sample and install device metadata.</p>
<ol>
<li>In an administrator command prompt, run this command:
<p><code>bcdedit -set testsigning on</code></p>
</li><li>Reboot the computer </li><li>
<p>Build the solution by opening the solution (.sln) file titled DeviceAppForWebcam.sln. Press F7 or go to
<b>Build-&gt;Build Solution</b> from the top menu after the sample has loaded. </p>
</li><li>Open <b>package.appxmanifest</b> and take note of the following fields. You will use them to edit the metadata in the next step:
<ul>
<li>Package Name </li><li>Publisher </li><li>App ID (View the code in package.appmanifest to get the app ID value from the &lt;Application&gt; element's Id attribute.)
</li></ul>
</li><li>Disconnect and uninstall the camera. This step is required so that Windows will read the updated device metadata the next time the device is detected.
<ul>
<li>If you have an externally connected camera, disconnect and uninstall your camera.
</li><li>If you have an internal camera, use <b>Device Manager</b> to uninstall the camera.
</li></ul>
</li><li>Edit and save device metadata.
<ol>
<li>Click the <b>Driver</b> menu in Visual Studio, select <b>Device Metadata</b>, and then select
<b>Authoring</b>.
<p>If you do not have the <b>Driver</b> menu, check that you have installed the WDK and that you are using Visual Studio Ultimate&nbsp;2012. Other versions of Microsoft Visual Studio do not have support for device metadata.</p>
</li><li>Open your device metadata file, and go to the <b>Applications</b> tab. Fill in
<b>Package Name</b>, <b>Publisher Name</b>, and <b>App ID</b> from step 4. </li><li>Go to the <b>Finish</b> tab and save your metadata file by following these steps under
<b>Save As</b>:
<ol>
<li>Confirm the package name in the <b>Save As</b> box. </li><li>Next to <b>Folder location</b>, confirm the location on your computer where you want the package to be saved, or click
<b>Change</b> to select a different location. </li><li>Select <b>Copy packages to your system's local metadata store</b> to install the metadata.
</li><li>Click <b>Finish</b>. </li></ol>
</li></ol>
</li><li>Reconnect your camera so that Windows reads the updated device metadata when the device is connected.
<ul>
<li>If you have an external camera, simply connect the camera. </li><li>If you have an internal camera, do one of the following:
<ul>
<li>Refresh the PC in the <b>Devices and Printers</b> folder. </li><li>Use<b> Device Manager</b> to scan for hardware changes. Windows should read the updated metadata when the device is detected.
</li></ul>
</li></ul>
</li></ol>
<h3>Run the sample</h3>
<p>To run the sample as if it were launched by the user choosing the app tile in Start, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled), or select the corresponding options from the Debug menu.
</p>
<p></p>
<p>To run the custom user interface for <b>More options</b>, do the following: </p>
<ol>
<li>Build and install the <a href="http://go.microsoft.com/fwlink/p/?linkid=251566">
Driver MFT Sample</a>, to install a custom effect that the <b>More options</b> flyout can control. You may skip this step, but then the
<b>Effect On/Off</b> and <b>Effect</b> controls in the custom flyout will not work.
</li><li>Run an app that invokes the <b>More options</b> flyout. Here are two ways to do that:
<ul>
<li>Run an app that displays the Camera Capture UI using <a href="http://msdn.microsoft.com/library/windows/apps/br241030">
<b>Windows.Media.Capture.CameraCaptureUI</b></a>. The <a href="http://go.microsoft.com/fwlink/p/?linkid=228589">
Camera Capture UI sample</a> is an example of such an app. <a href="http://msdn.microsoft.com/library/windows/apps/hh465152">
Quickstart: Capturing a photo or video using the camera dialog</a> provides a tutorial on using the Camera Capture UI.
<p>When the Camera Capture UI is displayed, tap the options button and then choose
<b>More options</b> in the dialog box that appears.</p>
</li><li>Run an app that calls <a href="http://msdn.microsoft.com/library/windows/apps/br241060_show">
<b>CameraOptionsUI.Show</b></a>. The <a href="http://go.microsoft.com/fwlink/p/?linkid=228588">
Camera Options UI sample</a> is an example of such an app. </li></ul>
</li><li>Check if the custom <b>More options</b> UI is correctly installed. It should contain
<b>Effect On/Off</b> and <b>Effect</b> controls. If you don't see these controls, check the troubleshooting steps.
</li><li>If you installed the <a href="http://go.microsoft.com/fwlink/p/?linkid=251566">
Driver MFT Sample</a> in step 1, the <b>Effect On/Off</b> control toggles an effect that covers the lower part of the video with a green box. The
<b>Effect</b> control adjusts the amount of the video that is covered. </li></ol>
<p></p>
<h3><a id="Troubleshooting"></a><a id="troubleshooting"></a><a id="TROUBLESHOOTING"></a>Troubleshooting</h3>
<p>If the <b>More options</b> flyout doesn't contain <b>Effect On/Off</b> and <b>
Effect</b> controls, check the following:</p>
<ul>
<li>Make sure you enabled test signing before installing the <a href="http://go.microsoft.com/fwlink/p/?linkid=249442">
Device app for camera sample</a>. Enable test signing by running <code>bcdedit -set testsigning on</code> in a command prompt.
</li><li>Make sure Package Name, Publisher Name, and App ID in the device metadata match the fields defined in the package.appxmanifest file of this sample.
</li><li>Use the <a href="http://go.microsoft.com/fwlink/p/?linkid=249441 ">Camera Capture UI sample</a> to test.
</li><li>If you have an internal camera (rather than an externally connected one), follow the requirements for your camera described in &quot;Appendix A: Requirements for identifying internal cameras&quot; in the
<a href="http://go.microsoft.com/fwlink/p/?linkid=249184">Developingdevice apps for Cameras</a> white paper. Note that you don’t have to provide the PLD information described in the paper, if your camera does not expose PLD info in its ACPI tables.
</li><li>If you have an internal camera, after installing the <a href="http://go.microsoft.com/fwlink/p/?linkid=249441">
Device app for camera sample</a>, refresh the PC using the <b>Devices and Printers</b> folder. Select the PC in the folder, and click the Refresh button as shown in the following image. The camera itself should not be visible in the
<b>Devices and Printers</b> folder. This is because internal cameras are enumerated as part of the PC device container.
</li></ul>
<p>If you have installed the <a href="http://go.microsoft.com/fwlink/p/?linkid=251566">
Driver MFT Sample</a> but don't see the video effect that covers the lower part of the video with a green box, check the following:</p>
<ul>
<li>Check that the <b>Effect On/Off</b> switch in the <b>More Options</b> flyout is set to
<b>On</b>. </li><li>Check that the SampleMFT0.DLL is registered and that you have entered the CLSID of the Driver MFT under the device registry key for the camera you are using to capture video, as described in
<b>Building the sample</b>. </li><li>Check that SampleMFT0.DLL is in a subdirectory of Program Files. </li></ul>
</div>
