# Device Status Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* device status
## IsPublished
* True
## ModifiedDate
* 2013-06-26 02:10:36
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates how to use the DeviceStatus class, including accessing the properties of the class, determining if the power source of the device has changed, and determining if a physical keyboard has been deployed. For more info, see
<a href="http://go.microsoft.com/fwlink/?LinkId=226732">How to: Use the DeviceStatus Class</a>.</p>
<p>You need to install the Windows&nbsp;Phone&nbsp;SDK to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkId=259204">Windows Phone Dev Center</a>.</p>
<h3 class="procedureSubHeading">To run the sample on the device</h3>
<div class="subSection">
<ol>
<li>
<p>Double-click the <span class="ui">.sln</span> file to open the solution.</p>
</li><li>
<p>Press F5 to start debugging the app.</p>
</li><li>
<p>When the app launches on the device, the initial page will show all initial DeviceStatus values.</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">To test if a physical keyboard has been deployed in the Windows Phone Emulator</h3>
<div class="subSection">
<ul>
<li>
<p>When the app launches, enable the keyboard by following the steps at <a href="http://go.microsoft.com/fwlink/?LinkID=226733">
Keyboard Mapping for Windows Phone Emulator</a>.</p>
</li></ul>
</div>
<h3 class="procedureSubHeading">To test if the power source of the device has changed</h3>
<div class="subSection">
<ol>
<li>
<p>Deploy the app to the device.</p>
</li><li>
<p>Run the app from the device by clicking <span class="ui">sdkDeviceStatusCS</span> from the
<span class="ui">app list</span>.</p>
</li><li>
<p>Connect and disconnect an external power source from the device.</p>
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
