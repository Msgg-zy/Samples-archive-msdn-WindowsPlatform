# Image Recipes
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* XAML
## IsPublished
* True
## ModifiedDate
* 2013-05-03 08:01:11
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>The sample illustrates how to use images in your app efficiently, while giving your users a great experience. The sample covers the following scenarios:</p>
<ul>
<li>
<p><span class="label">How to downsample an image using DecodePixelHeight and DecodePixelWidth.</span> This scenario shows you how to take advantage of the new
<span value="DecodePixelHeight"><span class="keyword">DecodePixelHeight</span></span> and
<span value="DecodePixelWidth"><span class="keyword">DecodePixelWidth</span></span> properties on
<span value="BitmapImage"><span class="keyword">BitmapImage</span></span> to save on memory when downscaling image assets. As the scenario demonstrates, reducing the size of the image this way saves memory, and in many cases, you can reduce the size of the
 image without affecting the quality of the image for the user. </p>
</li><li>
<p><span class="label">How to implement a smooth pinch and zoom experience for an image.</span> This scenario shows how to implement a smooth zooming experience using a
<span value="ViewPort"><span class="keyword">ViewPort</span></span> control and the
<span value="PinchManipulation"><span class="keyword">PinchManipulation</span></span> property of the
<span value="OnManipulationDelta"><span class="keyword">OnManipulationDelta</span></span> event on the ViewPort. It shows how to zoom the image around the central point of the pinch, an action that is familiar to users from when they pinch and zoom on a map
 on the phone.</p>
</li><li>
<p><span class="label">How to show progress while downloading an image.</span> This scenario uses the
<span value="DownloadProgress"><span class="keyword">DownloadProgress</span></span> event of the
<span value="BitmapImage"><span class="keyword">BitmapImage</span></span> object to show progress while an image is being downloaded.
</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>Because of the internal caching mechanism of the phone, progress is visible only the first time the scenario is run. After the image is downloaded, the image is cached on the phone, assuming that resources are available to cache the image. To see the
<span value="ProgressBar"><span class="keyword">ProgressBar</span></span> in action again, you need to either supply a URI of a different image, or reset the cache by restarting the emulator or by reinstalling the app. You can also slow down the network speed
 while running the app in the emulator by using the Simulation Dashboard in Visual Studio Express 2012 for Windows&nbsp;Phone.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p><span class="label">How to cancel an image download.</span> In the preceding scenario, you cannot cancel the download of the image once it has started. This scenario uses the
<span value="WebClient"><span class="keyword">WebClient</span></span> object to download the image and shows how to use the
<span value="CancelAsync()"><span class="keyword">CancelAsync()</span></span> method of WebClient to cancel an in-progress download.
</p>
</li></ul>
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
</li><li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</li></ol>
<p><b>See also</b> </p>
</div>
</div>
