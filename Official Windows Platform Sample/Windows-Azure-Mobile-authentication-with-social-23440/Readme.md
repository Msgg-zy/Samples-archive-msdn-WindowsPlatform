# Windows Azure Mobile Services authentication with social identity providers
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
* 2013-11-25 04:20:22
## Description

<div id="mainSection">
<p>This sample shows how Windows Azure Mobile Services enables your Windows Store apps to authenticate with well known social identity providers such as Microsoft accounts, Facebook, Twitter, and Google.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=308983">free Windows&nbsp;Azure trial</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=306786">Get started with authentication in Mobile Services</a>
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
</li><li>Go to <a href="http://go.microsoft.com/fwlink/p/?LinkId=306786">Get started with authentication in Mobile Services</a>, and follow the instructions to register your Windows&nbsp;Azure Mobile Service with the respective social identity provider, such as Microsoft
 accounts, Facebook, Twitter, or Google. Make note of the client ID and client secret values that the provider supplies to you for your Windows&nbsp;Azure Mobile Service.
</li><li>Update your Windows&nbsp;Azure Mobile Service with the client ID and client secret values by using one of these sets of commands:
<p>Microsoft accounts</p>
<ul>
<li><code>azure mobile config set</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>microsoftAccountClientID</code>&nbsp;<i>[ClientId]</i>
</li><li><code>azure mobile config set</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>microsoftAccountClientSecret</code>&nbsp;<i>[ClientSecret]</i>
</li></ul>
<p>Facebook</p>
<ul>
<li><code>azure mobile config set</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>facebookClientID</code>&nbsp;<i>[AppId]</i>
</li><li><code>azure mobile config set</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>facebookClientSecret</code>&nbsp;<i>[AppSecret]</i>
</li></ul>
<p>Twitter</p>
<ul>
<li><code>azure mobile config set</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>twitterClientID</code>&nbsp;<i>[ConsumerKey]</i>
</li><li><code>azure mobile config set</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>twitterClientSecret</code>&nbsp;<i>[ConsumerSecret]</i>
</li></ul>
<p>Google</p>
<ul>
<li><code>azure mobile config set</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>googleClientID</code>&nbsp;<i>[ClientId]</i>
</li><li><code>azure mobile config set</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>googleClientSecret</code>&nbsp;<i>[ClientSecret]</i>
</li></ul>
</li><li>Get the <code>ApplicationUrl</code> and <code>ApplicationKey</code> for your Windows&nbsp;Azure Mobile Service with this command:
<code>azure mobile show</code>&nbsp;<i>[AzureMobileServiceName]</i> </li><li>Install the <a href="http://go.microsoft.com/fwlink/p/?LinkID=320478">Windows&nbsp;Azure Mobile Services NuGet package</a>.
</li><li>Open the <code>App.xaml.cs</code> file and replace &quot;mobile-service-url&quot; and &quot;mobile-service-key&quot; with the
<code>ApplicationUrl</code> and <code>ApplicationKey</code>. Your Windows Store app is now configured to communicate with your created Windows&nbsp;Azure Mobile Service.
</li><li>Click <b>Build</b> &gt; <b>Build Solution</b>. </li></ol>
<h2>Run the sample</h2>
<ol>
<li>To debug the app and then run it in Microsoft Visual Studio, press F5 or use <b>
Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li><li>After the app starts, select the authentication provider that you configured for your app, and click
<b>Launch</b>. An authentication dialog box for the respective provider appears, prompting you to enter the credentials for the provider. After you enter the credentials and sign in for the first time, a consent dialog box appears, requesting access to the
 app. After you consent, and your credentials are authenticated by the provider, the user ID is shown in the output area.
</li><li>You can also go to the <a href="http://go.microsoft.com/fwlink/p/?LinkId=306779">
Windows Azure management portal</a>, sign in, and view your Windows&nbsp;Azure Mobile Service.
</li></ol>
</div>
