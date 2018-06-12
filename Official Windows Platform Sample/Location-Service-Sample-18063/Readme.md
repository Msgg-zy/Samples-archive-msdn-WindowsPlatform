# Location Service Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* Location
## IsPublished
* True
## ModifiedDate
* 2013-05-03 06:34:01
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This is a simple app that receives data from the Windows&nbsp;Phone Location Service and displays the geographic coordinates of the device.</p>
<p>You need to install the Windows&nbsp;Phone&nbsp;SDK to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkId=259204">Windows Phone Dev Center</a>.</p>
<p>For more information about developing location-aware Windows&nbsp;Phone apps see <a href="http://go.microsoft.com/fwlink/?LinkID=185887">
How to: Get Data from the Location Service</a> in the MSDN Library.</p>
<p>You can test the location sensor with live or recorded input. </p>
<h3 class="procedureSubHeading">To test an app with live input</h3>
<div class="subSection">
<ol>
<li>
<p>In Visual Studio, run the app you want to test in the emulator.</p>
</li><li>
<p>Open the <span class="ui">Additional Tools</span> window and click the <span class="ui">
Location</span> tab.</p>
</li><li>
<p>Make sure the live input mode is on by toggling the <span class="ui">Live</span> button.
</p>
<p>If the <span class="ui">Live</span> button is grayed out, live input mode is off.</p>
</li><li>
<p>In the <span class="ui">Search</span> box, type the location you want to display in the map.</p>
</li><li>
<p>Click the <span class="ui">Search</span> button or press Enter. </p>
<p>The following image shows the location sensor simulator with a location specified and the
<span class="ui">Live</span> button on.</p>
</li><li>
<p>Use the zoom controls to zoom in or out from the mapped location.</p>
</li><li>
<p>Reposition the map by dragging the map with the mouse.</p>
</li><li>
<p>Toggle the push pin button on.</p>
</li><li>
<p>Click the map to add points to the map. </p>
<p>Each time you add a point to the map, the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/system.device.location.geocoordinatewatcher.positionchanged(v=vs.105).aspx">
PositionChanged</a> event will be raised in your app.</p>
</li><li>
<p>Stop your app when you have completed testing.</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">To test an app with recorded location data</h3>
<div class="subSection">
<ol>
<li>
<p>In Visual Studio, open the project you want to test and start Windows Phone Emulator. The portion of your app that uses the Location service must not be running.</p>
</li><li>
<p>Open the <span class="ui">Additional Tools</span> window.</p>
</li><li>
<p>Make sure the live input mode is off by toggling the <span class="ui">Live</span> button.
</p>
<p>If the <span class="ui">Live</span> button is grayed out, live input mode is off.</p>
</li><li>
<p>Use the <span class="ui">Search</span> box to find a location you want to display in the map.</p>
</li><li>
<p>Toggle the push pin button on.</p>
</li><li>
<p>Click the map to add points to the map. </p>
<p>Each time you add a point, an entry is added to the list at the lower left of the simulator. The following image shows the location sensor simulator with a location specified, live mode turned off, and several points added to the map.</p>
</li><li>
<p>To delete a point added in error, locate the point in the list at the lower left of the simulator and then click the
<span class="ui">Delete point</span> button to the right of the point. </p>
<p>You can delete all of the points by clicking the <span class="ui">Clear all points</span> button.</p>
</li><li>
<p>To enter the time interval that should elapse between points on the map, specify the number of seconds in the
<span class="ui">Fire every</span> box.</p>
<p>This number indicates the time interval (in seconds) between each occurrence of the
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/system.device.location.geocoordinatewatcher.positionchanged(v=vs.105).aspx">
PositionChanged</a> event in your app. </p>
</li><li>
<p>Optionally, you can save your data to a file by clicking the <span class="ui">
Save map points</span> button. If you save the data, you can use it in subsequent test passes.</p>
<p>When the Save As dialog box appears, specify a file name and click <span class="ui">
Save</span>. The file is saved as an XML file in the \Documents\WindowsPhoneEmulator\Location folder.</p>
</li><li>
<p>Run your app in the emulator or start the portion of your app that uses the location service</p>
</li><li>
<p>On the right side of the toolbar, click the <span class="ui">Play all points</span> button to start playback of the recorded location data.</p>
<p>You can play back the location data as many times as necessary to test your app.</p>
</li><li>
<p>Stop your app when you have completed testing.</p>
</li></ol>
</div>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>This sample is packaged as a Windows&nbsp;Phone&nbsp;7.5 project. It can be converted to a Windows&nbsp;Phone&nbsp;8 project, by changing the target Windows Phone OS version of the project. To create a Windows&nbsp;Phone&nbsp;8 project, you must be running the Windows&nbsp;Phone&nbsp;SDK&nbsp;8.0 on
 Visual Studio 2012. You can download the latest version of the SDK from <a href="http://dev.windowsphone.com/downloadsdk">
http://dev.windowsphone.com/downloadsdk</a>.</p>
<p>To convert the sample to a Windows&nbsp;Phone&nbsp;8 project:</p>
<ol>
<li>
<p>Double-click the <span class="ui">.sln</span> file to open the solution in Visual Studio.</p>
</li><li>
<p>Right-click the project in the <span class="ui">Solution Explorer</span> and select
<span class="ui">Properties</span>. This opens the <span class="ui">Project Properties</span> window.</p>
</li><li>
<p>In the <span class="ui">Application</span> tab of the Project Properties window, select
<span class="ui">Windows Phone OS 8.0</span> from the <span class="ui">Target Windows Phone OS Version</span> dropdown. A dialog will appear asking if you want to upgrade this project to Windows Phone OS 8.0.</p>
</li><li>
<p>Select <span class="ui">Yes</span> to upgrade the project.</p>
</li></ol>
</td>
</tr>
</tbody>
</table>
</div>
</div>
</div>
