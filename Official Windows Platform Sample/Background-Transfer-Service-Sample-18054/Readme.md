# Background Transfer Service Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
## Topics
* Networking
* Storage
* multitasking
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:13:02
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample shows how to use the background transfer service to download files in the background, even when the app is no longer running in the foreground. For more information about using background transfers, see
<a href="http://go.microsoft.com/fwlink/?LinkId=219408">Background Transfer Service Overview for Windows Phone</a>. For a walkthrough of creating this sample app, see
<a href="http://go.microsoft.com/fwlink/?LinkId=219409">How to: Implement Background File Transfers for Windows Phone</a>.</p>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Double-click the .sln file to open the solution.</p>
</li><li>
<p>Press F5 to start debugging the app.</p>
</li><li>
<p>When the app launches in Windows Phone Emulator, the initial page will show that there are no background transfers in the queue.</p>
</li><li>
<p>Click the <span class="ui">Add</span> button in the app bar to go to the <span class="ui">
Add Transfers</span> page.</p>
</li><li>
<p>Click the <span class="ui">Add</span> button next to each of the sample files on the page to add them to the queue.</p>
</li><li>
<p>Press the <span class="ui">Back</span> button to return to the initial page and note that the files are being downloaded.
</p>
</li><li>
<p>Click the red <span class="ui">X</span> next to any transfer request to delete it from the queue, or click the
<span class="ui">Clear</span> button in the app bar to remove all completed transfers from the queue.</p>
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
