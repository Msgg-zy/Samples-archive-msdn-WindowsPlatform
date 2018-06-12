# RSS Reader Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* Networking
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:14:03
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample shows you how to create a basic RSS reader that downloads the Windows Phone team blog RSS feed, and then displays the feed items in a ListBox. Although the sample is set up to download a specific RSS feed, you could choose to extend the sample
 to use in your app by adding functionality to dynamically download other RSS feeds.</p>
<p>The sample was created by performing these tasks:</p>
<ol>
<li>
<p>Added a reference to System.ServiceModel.Syndication.dll, so that the sample can access the SyndicationFeed class.</p>
</li><li>
<p>Created an RSS text trimmer class to format each feed item, such as removing HTML tags and newline characters.</p>
</li><li>
<p>Created code to download a feed and display the feed items. Each feed item opens a web browser when clicked.</p>
</li><li>
<p>Created code to support tombstoning.</p>
</li></ol>
<p>For more info about how to create this sample from the ground up see <a href="http://go.microsoft.com/fwlink/?LinkID=229329">
How to: Create a Basic RSS Reader for Windows Phone</a>. Comments in the code examples describe the reasoning behind certain API choices such as DownloadStringAsync versus OpenStreamAsync, and suggest alternative courses of action if you choose to extend the
 sample. </p>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
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
