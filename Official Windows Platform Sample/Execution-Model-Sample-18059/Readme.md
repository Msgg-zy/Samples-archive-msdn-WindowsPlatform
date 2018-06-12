# Execution Model Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* Tombstoning
* App model
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:13:13
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>On Windows&nbsp;Phone, only one app runs in the foreground at a time. When the user navigates away from an app, it is typically put into a dormant state, which is automatically resumed when the user returns. However, it is possible for an app to be tombstoned
 or terminated after the user navigates away. This sample illustrates a technique for preserving and restoring UI and app state as the app is activated and deactivated by the operating system. For more info, see
<a href="http://go.microsoft.com/fwlink/?LinkId=219828">Execution Model Overview for Windows Phone</a>.</p>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
</div>
<h1 class="heading"><span>Running the sample</span> </h1>
<div id="sectionSection0" class="section" name="collapseableSection" style="">
<p>In Windows&nbsp;Phone OS&nbsp;7.1, apps are made dormant when the user navigates away, as long as sufficient memory is available for the foreground app to run smoothly. When an app is dormant and then restored, the UI state is automatically preserved. To verify that
 your page state is restored properly after tombstoning, you need to enable automatic tombstoning in the debugger.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Double-click the .sln file to open the solution.</p>
</li><li>
<p>From the <span class="ui">Project</span> menu, select <span class="ui">ExecutionModelSample Properties…</span>.</p>
</li><li>
<p>On the <span class="ui">Debug</span> tab, check the check box labeled <span class="ui">
Tombstone upon deactivation while debugging</span>.</p>
</li><li>
<p>Press F5 to start debugging.</p>
</li></ol>
</div>
<p>The first time you run the sample, you will see that the app data is retrieved from the web. Press the Start button to automatically tombstone the app, and then press the Back button to reactivate it. You will see that the app data is retrieved from isolated
 storage. Now press the Back button again to quit the app, and press F5 to start debugging again. This time you will see that data is retrieved from isolated storage.</p>
<p>To test page state preservation, press F5 to launch the app. Change the values in the page’s controls. Press the Start button and then the Back button. You will see that the UI state is preserved, even though the app was tombstoned during debugging.</p>
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
