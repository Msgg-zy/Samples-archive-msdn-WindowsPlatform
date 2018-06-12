# Azure Voice Notes
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
* Bing Speech
## Topics
* Speech recognition
* Windows Azure Mobile Services
## IsPublished
* True
## ModifiedDate
* 2013-06-25 05:48:56
## Description

<div id="mainBody">
<p>&nbsp;</p>
<div class="introduction">
<p>This sample demonstrates the basics of speech recognition for speech-to-text functionality, in addition to the fundamentals of working with Windows Azure Mobile Services to retrieve and store data in a Windows Azure database table. When the app runs, it
 authenticates a user by using a Microsoft Account, retrieves the user&rsquo;s notes that are stored in the Windows Azure database, and gives the user access to record and store new notes in the database, and delete existing notes. This sample shows you how
 to do the following:</p>
<ul>
<li>
<p>Use Mobile Services to authenticate a user by using a Microsoft Account.</p>
</li><li>
<p>Use Mobile Services to store, retrieve, and delete data from a Windows Azure database table.</p>
</li><li>
<p>Generate text from speech using the Windows Phone speech recognition APIs and the predefined dictation grammar.</p>
</li></ul>
<p>This sample uses the Windows Phone speech recognition APIs and the Windows Azure Mobile Services SDK. For more info about speech recognition in Windows&nbsp;Phone&nbsp;8, see
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207021(v=vs.105).aspx">
Speech recognition for Windows Phone 8</a>. For more info about the Windows Azure Mobile Services SDK, visit
<a href="http://www.windowsazure.com/en-us/develop/mobile/">Windows Azure Mobile Services</a>.</p>
<p>&nbsp;</p>
<h3 class="procedureSubHeading">Steps to build and run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Create a Windows Azure account that has the Mobile Services feature enabled. For details about creating a free account and enabling preview features, see
<a href="http://www.windowsazure.com/en-us/develop/mobile/tutorials/create-a-windows-azure-account">
Create a Windows Azure account and enable preview features</a>.</p>
</li><li>
<p>Create a Mobile Service and a Windows Azure database to use for the sample. For info about how to do this, see the section
<span class="ui">Create a new mobile service</span> in the <a href="http://www.windowsazure.com/en-us/develop/mobile/tutorials/get-started-wp8/">
Get started with Mobile Services</a> tutorial.</p>
<div class="alert">
<table cellspacing="0" cellpadding="0" width="100%">
<tbody>
<tr>
<th align="left"><strong>Note:</strong> </th>
</tr>
<tr>
<td>
<p>The <span class="label">Get started with Mobile Services</span> tutorial covers more than is needed for this sample. For this sample you only need to perform the steps specified in the
<span class="label">Create a new mobile service</span> section, using your chosen mobile service and database names.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>Set up a database table named <span class="ui">VoiceNote</span> to use in the sample.</p>
<ol>
<li>
<p>Log on to the <a href="http://manage.windowsazure.com">Windows Azure management portal</a>, and then click the
<span class="ui">Mobile Services</span> tab.</p>
</li><li>
<p>Click the name of your mobile service.</p>
</li><li>
<p>Click the <span class="ui">DATA</span> tab.</p>
</li><li>
<p>Click the <span class="ui">CREATE</span> button at the bottom of the page.</p>
</li><li>
<p>Name the table <span class="ui">VoiceNote</span>.</p>
</li><li>
<p>When you set the permissions for the table, use the <span class="ui">Only Authenticated Users</span> option for all actions.</p>
</li></ol>
<div class="alert">
<table cellspacing="0" cellpadding="0" width="100%">
<tbody>
<tr>
<th align="left"><strong>Note:</strong> </th>
</tr>
<tr>
<td>
<p>For the purposes of this sample, the table must be named <span class="label">
VoiceNote</span>.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>If it&rsquo;s not already installed, install <a href="http://www.microsoft.com/visualstudio/eng/downloads">
Visual Studio Express 2012 for Windows Phone</a>.</p>
</li><li>
<p>Install the <a href="https://go.microsoft.com/fwLink/p/?LinkID=268375">Windows Azure Mobile Services SDK</a>.</p>
</li><li>
<p>Register the sample app for Microsoft Account authentication using the steps shown in
<a href="http://www.windowsazure.com/en-us/develop/mobile/tutorials/get-started-with-users-wp8/">
Get started with authentication in Mobile Services</a>. Although other account types are possible, the sample is currently configured to use a Microsoft Account for authentication.</p>
<div class="alert">
<table cellspacing="0" cellpadding="0" width="100%">
<tbody>
<tr>
<th align="left"><strong>Note:</strong> </th>
</tr>
<tr>
<td>
<p>The code for authentication is included in the sample, you only need to perform the steps in the
<span class="ui">Register your app for authentication and configure Mobile Services</span> section.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>Update the Windows Azure database table read and update scripts to support authentication.</p>
<ol>
<li>
<p>Log on to the <a href="http://manage.windowsazure.com">Windows Azure management portal</a>, and then click the
<span class="ui">Mobile Services</span> tab.</p>
</li><li>
<p>Click the name of your mobile service.</p>
</li><li>
<p>Click the <span class="ui">DATA</span> tab.</p>
</li><li>
<p>Select the <span class="ui">VoiceNote</span> table.</p>
</li><li>
<p>Click the <span class="ui">SCRIPT</span> tab.</p>
</li><li>
<p>In the Action list <span class="ui">OPERATION</span> click <span class="ui">
Insert</span>, and then replace the default code with the following code example.</p>
<div class="code"><span>
<table cellspacing="0" cellpadding="0" width="100%">
<tbody>
<tr>
<th>&nbsp;</th>
<th>&nbsp;</th>
</tr>
<tr>
<td colspan="2">
<pre>function insert(item, user, request) {
    item.userId = user.userId; 
    item.createdAt = new Date();
    request.execute();
}</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
</li><li>
<p>In the Action list <span class="ui">OPERATION</span> click <span class="ui">
Read</span>, and then replace the default code with the following code example.</p>
<div class="code"><span>
<table cellspacing="0" cellpadding="0" width="100%">
<tbody>
<tr>
<th>&nbsp;</th>
<th>&nbsp;</th>
</tr>
<tr>
<td colspan="2">
<pre>function read(query, user, request) {
    query.where({ userId: user.userId });
    request.execute();
}</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
</li></ol>
</li><li>
<p>Add the Azure Application Key and mobile service URL to the sample <strong>App.Xaml.cs</strong> file as shown in the following code example.</p>
<div class="code"><span>
<table cellspacing="0" cellpadding="0" width="100%">
<tbody>
<tr>
<th>&nbsp;</th>
<th>&nbsp;</th>
</tr>
<tr>
<td colspan="2">
<pre>//Static MobileServiceClient object for use by the application
//Initialize with your specific mobile service URL and application key
public static MobileServiceClient MobileService = new MobileServiceClient(
   &quot;Your mobile service URL&quot;,
   &quot;Your application key&quot;);</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<div class="alert">
<table cellspacing="0" cellpadding="0" width="100%">
<tbody>
<tr>
<th align="left"><strong>Note:</strong> </th>
</tr>
<tr>
<td>
<p>To find the mobile service URL and Azure Application Key, go to the Windows Azure management portal and click the
<span class="ui">Mobile Services</span> tab. The URL is specified in the central table. To display the keys, click the
<span class="ui">Manage Keys</span> button at the bottom of the page.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>Build the sample.</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">Build the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.</p>
</li><li>
<p>Select <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">Run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>.</p>
</li><li>
<p>To run the app without debugging, press Ctrl&#43;F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Without Debugging</span>.</p>
</li></ol>
</div>
<p><strong>See also</strong></p>
<ul>
<li>
<p><a href="http://www.windowsazure.com/en-us/develop/mobile/">Windows Azure Mobile Services</a></p>
</li><li>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207021(v=vs.105).aspx">Speech recognition for Windows Phone 8</a></p>
</li></ul>
</div>
</div>
