# Tile Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* User Interface
* Tiles
* integration
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:14:15
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates how to update an Application Tile using the ShellTile APIs. It also demonstrates how to create, delete, and update secondary Tiles. For more information about using Tiles, see
<a href="http://go.microsoft.com/fwlink/?LinkID=219455">Tiles Overview for Windows Phone</a>. For a walkthrough of creating this sample app, see
<a href="http://go.microsoft.com/fwlink/?LinkID=219457">How to: Create, Delete, and Update Tiles for Windows Phone</a>.</p>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkId=259204">Windows Phone Dev Center</a>.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Double-click <span class="ui">.sln</span> to open the solution.</p>
</li><li>
<p>Press F5 to start debugging the app.</p>
</li><li>
<p>When the app launches in Windows Phone Emulator, the initial page shows two buttons, one for updating the Application Tile and one for creating, updating, and deleting the secondary Tile.</p>
</li><li>
<p>Click the button to navigate to the Application Tile properties page. Set some properties and then click the button to set the properties. Valid names for background image files are Red.jpg, Blue.jpg, and Green.jpg.</p>
</li><li>
<p>Navigate out of the app to the App List. Pin the TileSample Application Tile to Start. It should be updated to the properties that you set.</p>
</li><li>
<p>Tap the TileSample Application Tile to re-enter the app. Navigate to Secondary Tiles page. It shows a check box and six text box and button pairs for setting the various properties of a Tile.</p>
</li><li>
<p>Select the check box to create a secondary Tile on Start. Windows Phone Emulator will automatically navigate to Start, where you can see the Tile.</p>
</li><li>
<p>Navigate back to the app. Try setting various values for the Tile properties by filling in a value and clicking the corresponding button. Valid names for background image files are Red.jpg, Blue.jpg, and Green.jpg. After setting a value, you have to navigate
 back to Start to see the result.</p>
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
