# Basic Lens sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Extensibility
* uri mapping
* lenses
* lens app
* advanced capture
* mediaviewer
## IsPublished
* True
## ModifiedDate
* 2013-09-27 02:54:37
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample is a development template that you can extend to create your own lens app. It demonstrates key points from the
<a href="http://msdn.microsoft.com/library/windowsphone/design/jj662922(v=vs.105).aspx">
Lens design guidelines</a> and provides a media viewer and customizable helper classes that control the camera. The helper classes use the advanced capture APIs, from the
<a href="http://msdn.microsoft.com/library/windowsphone/develop/windows.phone.media.capture(v=vs.105).aspx">
Windows.Phone.Media.Capture</a> namespace, to provide optimal performance and a greater selection of camera settings. For more info, see
<a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206990(v=vs.105).aspx">
Lenses for Windows Phone 8</a> and <a href="http://msdn.microsoft.com/library/windowsphone/develop/jj662940(v=vs.105).aspx">
Advanced photo capture</a>.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Important Note:</b> </th>
</tr>
<tr>
<td>
<p>We recommend using a Windows&nbsp;Phone&nbsp;8 device to run this sample and develop camera apps. Some API calls may not work as expected on the emulator. Review the Windows&nbsp;Phone&nbsp;SDK release notes for the latest details.</p>
</td>
</tr>
</tbody>
</table>
</div>
<p>This sample demonstrates the following points from the <a href="http://msdn.microsoft.com/library/windowsphone/design/jj662922(v=vs.105).aspx">
Lens design guidelines</a>:</p>
<ul>
<li>
<p>Lens icon support for the WXGA, WVGA, and 720P resolutions.</p>
</li><li>
<p>Swipe from the left to view previously captured photos.</p>
</li><li>
<p>Support for portrait and landscape orientations.</p>
</li><li>
<p>Support for the hardware camera shutter button.</p>
</li><li>
<p>Provides icon to control the flash.</p>
</li><li>
<p>Support for the front camera when it’s available.</p>
</li><li>
<p>Displays focus brackets while focusing.</p>
</li><li>
<p>Only one photo is saved to the camera roll per capture.</p>
</li><li>
<p>Provides a delete button for photos saved exclusively in the local folder.</p>
</li></ul>
<p>A major feature of lenses is the ability to provide a rich media experience. However, rich media is beyond the scope of this sample. For more info about rich media, see the
<a href="http://msdn.microsoft.com/library/windowsphone/design/jj662922(v=vs.105).aspx">
Lens design guidelines</a> and <a href="http://msdn.microsoft.com/library/windowsphone/develop/jj662942(v=vs.105).aspx">
Rich media extensibility</a>.</p>
<p><b>Build the sample</b> </p>
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.
</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.
</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.
</p>
</li></ol>
<p></p>
<p><b>Run the sample</b> </p>
<ul>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. </p>
</li><li>
<p>To run the app without debugging, press Ctrl&#43;F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Without Debugging</span>. </p>
</li></ul>
<p></p>
<p><b>Launch the sample from the lens picker</b> </p>
<ol>
<li>
<p>Run the sample, as described in the previous procedure. </p>
</li><li>
<p>Launch the built-in camera app: press the hardware camera shutter button or in the App list, tap
<span class="ui">Camera</span>. </p>
</li><li>
<p>Tap the <span class="ui">lenses</span> button in the app bar. This launches the lens picker.
</p>
</li><li>
<p>In the lens picker, tap the icon for the sample. This launches the sample into a viewfinder experience.
</p>
</li></ol>
<p></p>
<p><b>Use the sample</b> </p>
<p>This sample allows you to capture photos, save photos to the camera roll, view previously captured photos, and delete photos that are only stored in the local folder. Follow these steps to use the sample.</p>
<ol>
<li>
<p>Run the sample, as described in the previous procedures.</p>
</li><li>
<p>In the app bar, tap the <span class="ui">front</span> button to toggle between the front camera (when available) and back camera.</p>
</li><li>
<p>In the app bar, tap the <span class="ui">flash</span> button to toggle between flash states: on, auto, and off.</p>
</li><li>
<p>Tap anywhere on the viewfinder to initiate a photo capture. Note that this will only work if your phone supports focusing on a specific region in the viewfinder. See the
<span class="code">BeginPointFocusAndCapture</span> method for more info.</p>
</li><li>
<p>Press the hardware camera shutter button half way to initiate a focus operation. Press it all the way to capture a photo.</p>
</li><li>
<p>After capturing a photo, swipe from the left, across the viewfinder to slide out the media viewer.</p>
</li><li>
<p>Continue swiping from the left to view photos that are saved in the app’s local folder (and not saved in the media library).</p>
</li><li>
<p>Observe that a <span class="ui">delete</span> button appears in the app bar of the media viewer for photos that are stored exclusively in the local folder. Apps can’t delete photos from the media library, so the media viewer doesn’t display a delete button
 for those photos.</p>
</li><li>
<p>To view the captured photos in the camera roll, tap <span class="ui">Start</span>, then tap
<span class="ui">photos</span>, and finally, tap <span class="ui">camera roll</span>.</p>
</li></ol>
<p><b>Extend the sample</b> </p>
<p>There are a few different ways that you can make use of this sample template:</p>
<ul>
<li>
<p><span class="label">Incorporate a rich media viewing/editing experience:</span> Save additional info about the capture in your app’s local folder to provide a unique in-app experience. Rich media apps that implement
<a href="http://msdn.microsoft.com/library/windowsphone/develop/jj662942(v=vs.105).aspx">
rich media extensibility</a> can be launched from the <span class="ui">Open</span> link of the built-in picture viewer when viewing photos they’ve saved to the library.</p>
</li><li>
<p><span class="label">Build on top of the sample:</span> Take the sample as it is and build the functionality that makes your lens unique directly on top of it.</p>
</li><li>
<p><span class="label">Replace the capture experience:</span> If your app offers a significantly different capture experience, remove the capture experience from the sample (in the MainPage.xaml and MainPage.xaml.cs files) and replace it with your own UI.
 If your capture experience is complex, consider creating a user control that implements your capture experience. Then put an instance of that control in the
<span class="code">MediaViewer.FooterTemplate</span> of MainPage.xaml.</p>
</li></ul>
<p><b>Reconfigure the camera sensor</b> </p>
<p>This procedure describes how you can modify the sample to use different camera settings. For more info about the available camera settings, see
<a href="http://msdn.microsoft.com/library/windowsphone/develop/jj662939(v=vs.105).aspx">
Advanced capture properties</a>.</p>
<ol>
<li>
<p>Add a setting to the <span class="code">CameraSettings</span> class in CameraSettings.cs so that it can be persisted between camera load/unload cycles. Note that the camera is unloaded when the user scrolls two photos away from the viewfinder for performance
 and battery reasons. The user will expect the settings that they selected to still be in effect when they scroll back to the viewfinder.</p>
</li><li>
<p>Add a property to the <span class="code">LensViewModel</span> class that exposes the property you want to be able to configure. See the
<span class="code">FlashState</span> property as an example.</p>
</li><li>
<p>Add a property to the <span class="code">CameraController</span> class to allow callers to
<span class="code">get</span>/<span class="code">set</span> the property. See
<span class="code">CameraController.FlashState</span> as an example.</p>
</li><li>
<p>Add a property to the <span class="code">CameraEngine</span> class to allow callers to
<span class="code">get</span>/<span class="code">set</span> the property. See
<span class="code">CameraEngine.FlashState</span> as an example.</p>
</li><li>
<p>Update <span class="code">LensViewModel.GetDefaultCameraSettings</span> to pick a default value for the setting.</p>
</li><li>
<p>Update <span class="code">LensViewModel.ApplyCameraSettings</span> to set the property.</p>
</li><li>
<p>Update MainPage.xaml and/or MainPage.xaml.cs to set the new property you added on
<span class="code">LensViewModel</span> as you see fit.</p>
</li></ol>
<p><b>Edit the photo before saving it</b> </p>
<p>Some lenses edit photos before saving them. If your app does that, keep in mind the following points:</p>
<ul>
<li>
<p>Add a call to your image modification code in the <span class="code">LensViewModel.OnStillCaptureComplete</span> method.</p>
</li><li>
<p>The <span class="code">OnStillCaptureComplete</span> method provides two JPEG-encoded streams that you can edit before saving them to the camera roll:
<span class="code">thumbnailStream</span> and <span class="code">imageStream</span> (the full resolution photo).</p>
</li><li>
<p><span class="code">OnStillCaptureComplete</span> runs on a background thread. This is why the
<span class="code">Dispatcher</span> invokes some of the work on the UI thread.</p>
</li></ul>
<p></p>
<p><b>Solution overview</b> </p>
<p>This solution is comprised of two projects: <span class="ui">MediaViewer</span> and
<span class="ui">sdkBasicLensWP8CS</span>. The <span class="ui">MediaViewer</span> project contains all of the code for the media viewer control. The media viewer displays photos from the camera roll and local folder. The
<span class="ui">sdkBasicLensWP8CS</span> project contains the code for the Basic Lens Sample. The primary helper classes in this sample are named
<span class="code">CameraEngine</span>, <span class="code">CameraControl</span>, and
<span class="code">WorkflowBase</span>. See the following sections for more info about this solution and how you can extend it.</p>
<p></p>
<p><b>MediaViewer project</b> </p>
<p></p>
<p>Here are a few items to note about this project:</p>
<ul>
<li>
<p><span class="code">MediaViewer</span> class: A control which displays content in a page-by-page fashion similar to the built-in picture viewer. It supports an optional header and footer, and in between it renders items supplied by your app. This control
 also has the ability to allow users to pinch zoom when viewing items. The <span class="code">
MediaViewer</span> is a virtualizing control, so it loads only the data it needs, and scales to very large sets of data.</p>
</li><li>
<p><span class="code">ThumbnailedImageViewer</span> class: This is the default <span class="code">
ItemTemplate</span> for the <span class="code">MediaViewer</span> control, and displays images that have an associated thumbnail. Add objects to the
<span class="code">MediaViewer.Items</span> collection that implement the <span class="code">
IThumbnailedImage</span> interface so that the <span class="code">ThumbnailedImageViewer</span> can display them. For examples that implement this interface, see
<span class="code">LocalFolderThumbnailedImage</span> and <span class="code">
MediaLibraryThumbnailedImage</span>.</p>
</li></ul>
<p></p>
<p><b>sdkBasicLensWP8CS project</b> </p>
<p></p>
<p>Here are a few items to note about this project:</p>
<ul>
<li>
<p><span class="code">MainPage</span> class: This page contains a <span class="code">
MediaViewer</span> control with a <span class="code">FooterTemplate</span> that implements a photo capture experience. All presentation layer concerns are handled in the code-behind file, MainPage.xaml.cs, and the business logic is implemented in the
<span class="code">LensViewModel</span> class.</p>
</li><li>
<p><span class="code">LensViewModel</span> class: This viewmodel holds the list of items to be bound to the
<span class="code">MediaViewer.Item</span> collection, as well as the business logic to implement the lens. It communicates with the
<span class="code">CameraEngine</span> model class.</p>
</li><li>
<p><span class="code">CameraEngine</span> class: This class handles all of the interaction with the capture API. Most importantly, it serializes most operations to reduce corner cases that would otherwise have to be handled manually. It processes a single
 workflow at a time, and most of the methods on this class simply queue up a new workflow. Workflows always execute in the order they were queued (FIFO), and are strictly serialized. The
<span class="code">CameraEngine</span> holds a reference to the <span class="code">
CameraController</span> class which directly wraps the capture API. It does not expose the
<span class="code">CameraController</span> to its callers, reducing the chance of accidental unserialized access to the capture API.</p>
</li><li>
<p><span class="code">WorkflowBase</span> class: The base class for all workflows. It implements some common logic needed by all workflows.</p>
</li><li>
<p><span class="code">CameraController</span> class: This class encapsulates the capture API and is used by the workflows.</p>
</li></ul>
<p></p>
</div>
</div>
