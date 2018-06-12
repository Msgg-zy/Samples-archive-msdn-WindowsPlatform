# Reading and writing to Windows Azure Mobile Services
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
* 2013-11-25 04:20:28
## Description

<div id="mainSection">
<p>This sample shows how Windows Azure Mobile Services enables you to use a Windows Store app to store and retrieve data from Windows&nbsp;Azure.
</p>
<p>This Windows Store app demonstrates a simple app to maintain a list of to-do items. You use the app to add to-do items to a Mobile Services table. The app can also get to-do items from the table and display them. You can mark the items in the app Mobile
 Servicesas done after you complete them.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=308983">free Windows&nbsp;Azure trial</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=275464">Windows&nbsp;Azure command line tools</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=306779">Windows Azure management portal</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows app samples</a>
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
<ol>
<li>If you do not have a Windows&nbsp;Azure subscription, sign up for a <a href="http://go.microsoft.com/fwlink/p/?LinkId=308983">
free Windows&nbsp;Azure trial</a>. </li><li>Install the <a href="http://go.microsoft.com/fwlink/p/?LinkID=275464">Windows&nbsp;Azure command line tools</a>.
</li><li>Open a command prompt to download the required credentials to communicate with Windows&nbsp;Azure as follows. This is a one-time setup for running all subsequent commands to manage Mobile Services:
<ol>
<li>Download Windows&nbsp;Azure management credentials with this command: <code>azure account download</code>. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;This will display a web page for you to sign in to the
<a href="http://go.microsoft.com/fwlink/p/?LinkId=306779">Windows Azure management portal</a>. After you sign in, Windows&nbsp;Azure will prompt you to download a publish settings file for your Windows&nbsp;Azure subscription. Save this file to your local computer.
</li><li>Import the publish settings file from this location with this command: <code>
azure account import</code>&nbsp;<i>[SavedLocation]</i>. This will configure your command prompt to manage all of your Windows&nbsp;Azure services from the command line.
</li></ol>
</li><li>Create a Windows&nbsp;Azure Mobile Service with this command: <code>azure mobile create</code>&nbsp;<i>[AzureMobileServiceName] [sqlAdminUsername] [sqlAdminPassword]</i>
</li><li>Create a <code>TodoItem</code> table to store the to-do items, with this command:
<code>azure mobile table create</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>TodoItem</code>
</li><li>Get the <code>ApplicationUrl</code> and <code>ApplicationKey</code> for your Windows&nbsp;Azure Mobile Service with this command:
<code>azure mobile show</code>&nbsp;<i>[AzureMobileServiceName]</i> </li><li>Install the <a href="http://go.microsoft.com/fwlink/p/?LinkID=320478">Windows&nbsp;Azure Mobile Services NuGet package</a>.
</li><li>Open the <code>App.xaml.cs</code> file and replace &quot;mobile-service-url&quot; and &quot;mobile-service-key&quot; with the
<code>ApplicationUrl</code> and <code>ApplicationKey</code>. Your Windows Store app is now configured to communicate with your created Windows&nbsp;Azure Mobile Service.
</li><li>Click <b>Build</b> &gt; <b>Build Solution</b>. </li></ol>
<h2>Run the sample</h2>
<ol>
<li>To debug the app and then run it in Microsoft Visual Studio, press F5 or use <b>
Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li><li>After the app starts, enter a to-do item in the left column and then click <b>
Save</b>. Added items appear as checkbox items in the right column, and then you can mark them as completed.
</li><li>You can also go to the <a href="http://go.microsoft.com/fwlink/p/?LinkId=306779">
Windows Azure management portal</a>, sign in, and view your Windows&nbsp;Azure Mobile Service and the saved data.
</li></ol>
</div>
