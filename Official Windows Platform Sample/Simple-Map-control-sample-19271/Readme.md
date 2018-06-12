# Simple Map control sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Maps
* Location
* map control
* landmarks
## IsPublished
* True
## ModifiedDate
* 2013-05-03 06:34:24
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>When the sample loads, the default map is displayed. The icon buttons and menu items on the app bar provide the following options:</p>
<ul>
<li>
<p><span class="label">Toggle your location on and off</span>. This command finds your current location and then centers the map on the location. It displays a small filled blue circle to mark the location. If the location is already displayed, then choosing
 this option again removes the circle marking the location.</p>
</li><li>
<p><span class="label">Toggle landmarks on and off</span>. This command enables the display of landmarks by setting the
<a href="http://msdn.microsoft.com/en-US/library/windowsphone/develop/microsoft.phone.maps.controls.map.landmarksenabled(v=vs.105).aspx">
LandmarksEnabledProperty</a> property to <span value="true"><span class="keyword">true</span></span>. If the zoom level of the map is less than the zoom level required for the display of landmarks, this command increases the zoom level. If landmarks are already
 displayed, then choosing this option again sets the <span value="LandmarksEnabled">
<span class="keyword">LandmarksEnabled</span></span> property to <span value="false">
<span class="keyword">false</span></span>.</p>
</li><li>
<p><span class="label">Zoom in</span>. Increases the zoom level by 1.</p>
</li><li>
<p><span class="label">Zoom out</span>. Decreases the zoom level by 1.</p>
</li></ul>
<p>This sample uses APIs from the following namespaces.</p>
<ul>
<li>
<p>From the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/microsoft.phone.maps(v=vs.105).aspx">
Maps</a> and <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/microsoft.phone.maps.controls(v=vs.105).aspx">
Maps.Controls</a> namespaces to display and configure the Map control.</p>
</li><li>
<p>From the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.devices.geolocation.aspx">
Devices.Geolocation</a> and <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/system.device.location(v=vs.105).aspx">
Device.Location</a> namespaces to find and set the current location.</p>
</li><li>
<p>From the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/system.windows.shapes(v=vs.105).aspx">
Shapes</a> and <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/system.windows.media(v=vs.105).aspx">
Media</a> namespaces to mark the location with a colored circle.</p>
</li></ul>
<h3 class="procedureSubHeading">Build the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Start Visual Studio and select <span class="ui">File</span> &gt; <span class="ui">
Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Browse to the directory in which you unzipped the sample. Double-click the solution (<span class="label">.sln</span>) file.</p>
<p>The solution opens in Visual Studio.</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">Run the sample</h3>
<div class="subSection">
<ul>
<li>
<p>To run the app with debugging, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. </p>
<p>- or -</p>
</li><li>
<p>To run the app without debugging, press Ctrl&#43;F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Without Debugging</span>.</p>
</li></ul>
</div>
</div>
<h1 class="heading"><span><a name="seeAlsoToggle">See Also</span> </h1>
<div id="seeAlsoSection" class="section" name="collapseableSection" style="">
<h4 class="subHeading">Other Resources</h4>
<div class="seeAlsoStyle"></a><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207045(v=vs.105).aspx">Maps and navigation for Windows Phone 8</a>
</div>
<div class="seeAlsoStyle"><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207033(v=vs.105).aspx">How to add a Map control to a page in Windows Phone 8</a>
</div>
<div class="seeAlsoStyle"><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj735578(v=vs.105).aspx">How to show your current location on a map in Windows Phone 8</a>
</div>
</div>
</div>
