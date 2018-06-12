# Doto Windows Azure Mobile Services sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* azure mobile services
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:25:16
## Description

<div id="mainSection">
<p>The doto sample is a simple, social to-do list application that demonstrates how easy it is to add the power of Windows Azure Mobile Services to your Windows Store game.
</p>
<p>This doto sample is an updated version of the <a href="http://go.microsoft.com/fwlink/p/?LinkID=266386">
sample</a> for Windows&nbsp;8 . Both versions use the Windows Azure Mobile Services in the same way.</p>
<p>You can read more about the technology in the doto sample <a href="http://go.microsoft.com/fwlink/p/?LinkID=309107">
here</a>.</p>
<p>Doto uses the following features from Mobile Services:</p>
<ul>
<li>Authentication using Microsoft account. </li><li>Structured storage with server scripts to provide validation and authorization.
</li><li>Integration with Windows Notification Services to send Live Tile updates and toast notifications.
</li></ul>
<p>The Doto sample is a Windows Store game that allows you to:</p>
<ul>
<li>create multiple lists. </li><li>add and delete items from your lists. </li><li>share your lists with other users. </li><li>add and delete items from shared lists. </li></ul>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=308983">free Windows&nbsp;Azure trial</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=306779">Windows Azure management portal</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Operating system requirements</h2>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8.1 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012&nbsp;R2 </dt></td>
</tr>
</tbody>
</table>
<h2>Build the sample</h2>
<p>To use the sample:</p>
<ol>
<li>If you do not have an Windows&nbsp;Azure subscription already, then sign up for a <a href="http://go.microsoft.com/fwlink/p/?linkid=286807">
free trial</a> . This will enable you to host 10 mobile services for free. </li><li>Install the <a href="http://go.microsoft.com/fwlink/p/?linkid=275464">command line tools</a> for Windows&nbsp;Azure.
</li><li>Download the credentials needed to talk to Windows&nbsp;Azure. You need to do this once to manage all subsequent commands to Mobile Services.
<p>To do this:</p>
<ul>
<li>Download the Windows&nbsp;Azure management credentials by entering the command <b>
azure account download</b>. This will open up a web page to login to the <a href="http://go.microsoft.com/fwlink/p/?LinkID=306562">
Management Portal</a> for Windows&nbsp;Azure. Once you log in, it will generate and prompt you to download a publishsettings file for your Windows&nbsp;Azure subscription. Save this file to a location on your machine.
</li><li>
<p>Import the publishsettings file from the saved location. This will configure your command line client to manage all your Windows&nbsp;Azure services from the command line. To do this, enter the command:</p>
<dl><dd><b>azure account import [SaveLocation]</b> </dd></dl>
</li></ul>
</li><li>
<p>Create a Windows&nbsp;Azure Mobile Service by entering the command:</p>
<dl><dd><b>azure mobile create [AzureMobileServiceName] [sqlAdminUsername] [sqlAdminPassword]</b>
</dd></dl>
</li><li>
<p>Setup the tables and set the permissions for the table operations for your Windows&nbsp;Azure Mobile Service by entering the following commands:</p>
<dl><dd><b>azure mobile table create [AzureMobileServiceName] devices --permissions insert=user,update=admin,delete=admin,read=admin</b>
</dd><dd><b>azure mobile table create [AzureMobileServiceName] invites --permissions insert=user,update=user,delete=admin,read=user</b>
</dd><dd><b>azure mobile table create [AzureMobileServiceName] items --permissions insert=user,update=admin,delete=user,read=user</b>
</dd><dd><b>azure mobile table create [AzureMobileServiceName] listMembers --permissions insert=user,update=admin,delete=user,read=user</b>
</dd><dd><b>azure mobile table create [AzureMobileServiceName] profiles --permissions insert=user,update=admin,delete=admin,read=user</b>
</dd><dd><b>azure mobile table create [AzureMobileServiceName] settings --permissions insert=admin,update=admin,delete=admin,read=application</b>
</dd></dl>
</li><li>
<p>Upload the scripts to your Windows&nbsp;Azure Mobile Service which will set up the database. In the command line, change to the
<b>Scripts</b> directory the under sample installation location. Run the following commands to upload this scripts:</p>
<dl><dd><b>azure mobile script upload [AzureMobileServiceName] table/devices.insert.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/invites.insert.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/invites.read.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/invites.update.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/items.delete.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/items.insert.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/items.read.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/listMembers.insert.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/listmembers.delete.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/listMembers.read.js</b>
</dd><dd><b>azure mobile script upload [AzureMobileServiceName] table/profiles.insert.js</b>
</dd></dl>
</li><li><a href="http://go.microsoft.com/fwlink/p/?linkid=266582">Register</a> your app to receive push notifications.
</li><li>In Microsoft Visual Studio, open the sample solution and right click the <b>doto</b> project and then select
<b>Store -&gt; Associate App with the Store</b> from the context menu. Complete the wizard by logging in and then select the app you previously registered in the store.
</li><li>
<p>Collect information from the <a href="http://go.microsoft.com/fwlink/p/?LinkId=262039">
Live Connect Developer Center</a>.</p>
<ul>
<li>Go to the <a href="http://go.microsoft.com/fwlink/p/?LinkId=262039">Live Connect Developer Center</a> and select your app in the
<b>My Applications</b> list. </li><li>Once in your app, click <b>Edit Settings</b>. </li><li>Under <b>API Settings</b>, make a note of the <b>Client ID</b>, <b>Client secret</b> and the
<b>Package security identifier (SID)</b> values. </li><li>Set the <b>Redirect Domain</b> to be the URI of your mobile service. </li></ul>
</li><li>
<p>Configure your Windows&nbsp;Azure Mobile Service with the <b>Client secret</b> and <b>
Package security identifier</b> values obtained in the previous step:</p>
<dl><dd><b>azure mobile config set [AzureMobileServiceName] microsoftAccountClientId [ClientId]</b>
</dd><dd><b>azure mobile config set [AzureMobileServiceName] microsoftAccountClientSecret [ClientSecret]</b>
</dd><dd><b>azure mobile config set [AzureMobileServiceName] microsoftAccountPackageSID [PackageSID]</b>
</dd></dl>
</li><li>
<p>Get the ApplicationUrl and ApplicationKey for your Windows&nbsp;Azure Mobile Service:</p>
<dl><dd><b>azure mobile show [AzureMobileServiceName]</b> </dd></dl>
</li><li>
<p>Update sample code so that the sample can talk to Mobile Services.</p>
<ul>
<li>Install the <a href="http://go.microsoft.com/fwlink/p/?LinkID=320478">Windows&nbsp;Azure Mobile Services NuGet package</a>.
</li><li>Open up the <b>App.xaml.cs</b> file. </li><li>Replace the <i>mobile-service-url</i> and <i>mobile-service-key</i> with the <i>
ApplicationUrl</i> and <i>ApplicationKey</i> retrieved in the previous step. Now your Windows store app is all set to talk to your newly created Mobile Services.
</li></ul>
</li><li>
<p>This step is optional. Doto uses the <i>settings</i> table to implement a simple updatable theming system. This allows the app developer to change the look of doto for all users. You can point to any background image you like and set any accent color. To
 set your own theme, you can connect to your SQL database which is backing up your Windows&nbsp;Azure Mobile Service and insert/update the settings with a SQL script. This exercise demonstrates how you can perform operations directly on the SQL Azure database, including
 adding new columns and running scripts:</p>
<ul>
<li>In the <a href="http://go.microsoft.com/fwlink/p/?LinkID=306562">Management Portal</a> for Windows&nbsp;Azure, click on the database icon on the left.
</li><li>Find the database that your Mobile Service is connected to by looking at your Mobile Service's dashboard in the portal. Choose the database then choose the
<b>Manage</b> command on the dashboard. </li><li>This should open the SQL Database in the browser management experience. You may be prompted to open the appropriate IP addresses to allow your browser to connect.
</li><li>Login using the administrator account for your SQL Server and choose <b>New Query</b>.
</li><li>
<p>Run the following T-SQL script to manually create some columns and insert some new settings. Note that the schema name
<i>doto</i> used below should be replaced with the name of your application. </p>
<ul>
<li><b>ALTER TABLE doto.settings</b> </li><li><b>ADD [key] nvarchar(50), [value] nvarchar(255)</b> </li><li><b>GO</b> </li><li><b>INSERT INTO doto.settings VALUES ('accentColor', '#769334'), ('backgroundImage', 'http://[someUrl]/dotoBackground.png');</b>
</li><li>Notice that when you start the doto app a different picture loads after startup based on the URL below.
</li></ul>
</li></ul>
</li></ol>
<h2>Run the sample</h2>
<ol>
<li>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li><li>When first starting <b>doto</b>, you'll be asked to register. Adding your location details makes it easier to search for someone to search for you when they want to share a list.
</li><li>Once registered, you will be asked to create a new list. Choose the <b>Create a new list</b> button, enter a name for your list and select
<b>Save</b>. </li><li>You can add more lists at any time by using the bottom app bar. You can right click the screen to view the app bar.
</li><li>You can also use the bottom app bar to add, remove items, refresh the current list and invite other users or leave a list.
</li><li>You can switch between multiple lists by choosing the name of your list from the top left of the screen which will show a dropdown of all available lists.
</li><li>Doto was designed to be extremely simple. Items can be removed from a list but there is no way to edit an item or mark it complete. To remove items from the list, just select them and click
<b>remove item</b> in the app bar. </li><li>You can invite other users to share a list by clicking on the <b>invite user</b> button and searching for people by name. To test this feature, you may need to sign out, by using the settings charm, and then sign in again with a second Microsoft account
 account. </li><li>When a user is invited to share a list, they will receive a toast notification. Users can then click the
<b>view invite</b> button in the app bar to accept or reject an invite. Note that an invited user gets full permissions over your list, including the ability to invite other users.
</li><li>You can also go to the <a href="http://go.microsoft.com/fwlink/p/?LinkID=306562">
Management Portal</a> for Windows&nbsp;Azure, login and view your Mobile service and the saved data.
</li></ol>
</div>
