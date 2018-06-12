# Raw Notification Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* User Interface
* Notifications
* Networking
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:13:58
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates how to send a raw notification to a phone using the Microsoft Push Notification Service. This sample contains two projects – one project for the client code that sets up the phone to receive a notification, and another project that
 sends the notification to the Microsoft Push Notification Service.</p>
<p>For more information about Push Notifications, see <a href="http://go.microsoft.com/fwlink/?LinkID=219458">
Push Notifications Overview for Windows Phone</a>. For a walkthrough of creating this sample application, see
<a href="http://go.microsoft.com/fwlink/?LinkID=219462">How to: Send and Receive Raw Notifications for Windows Phone</a>.</p>
<p>The project that sends a raw notification from an ASP.NET webpage running on a web server requires either the full version of Visual Studio or the free
<a href="http://go.microsoft.com/fwlink/?LinkID=216094">Microsoft Visual Web Developer&nbsp;2010 Express</a>.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Important Note:</b> </th>
</tr>
<tr>
<td>
<p>You must install the Windows&nbsp;Phone&nbsp;SDK to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
</td>
</tr>
</tbody>
</table>
</div>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>After unzipping the sample, note that there are two projects. </p>
</li><li>
<p>Double-click <span class="ui">sdkRawNotificationCS.sln</span> or <span class="ui">
sdkRawNotificationVB.sln</span> to open the solution.</p>
</li><li>
<p>Press F5 to start debugging the app.</p>
</li><li>
<p>When the app launches in Windows&nbsp;Phone Emulator, there will be a brief pause and then a message box containing the notification channel URI will appear. Close the message box. The URI also will be displayed in the Visual Studio debugger Output window.</p>
</li><li>
<p>Copy this URI from the Visual Studio debugger Output window to the clipboard. </p>
</li><li>
<p>Now find SendRaw.sln and open it with a full version of Visual Studio or the free
<a href="http://go.microsoft.com/fwlink/?LinkID=216094">Microsoft Visual Web Developer&nbsp;2010 Express</a>.</p>
</li><li>
<p>Press F5 to start debugging the app.</p>
</li><li>
<p>A webpage will open. Paste the notification channel URI into the URI text box on the webpage.</p>
</li><li>
<p>Enter a couple of values for the raw notification and press the <span class="ui">
Send Raw</span> button.</p>
</li><li>
<p>Your client app must be running to receive the notification. A message box will appear with the raw notification values.
</p>
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
