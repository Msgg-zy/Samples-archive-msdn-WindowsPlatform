# Creating a game leaderboard with Windows Azure Mobile Services
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
* 2013-11-25 04:20:26
## Description

<div id="mainSection">
<p>This sample shows how Windows Azure Mobile Services enables you to add, update, and view a game leaderboard for your Windows Store app.
</p>
<p>This Windows Store app demonstrates a simple trivia quiz app. It asks for your user name and shows a random set of predetermined trivia questions. After you answer all of the questions, the app updates your result in a Mobile Services table and then displays
 a leaderboard with your relative position among all of the quiz app players.</p>
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
</li><li>Create a <code>Leaderboard</code> table and a <code>Results</code> table to store to store the positions of all players and the results of each round, with these commands:
<ul>
<li><code>azure mobile table create</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>Leaderboard</code>
</li><li><code>azure mobile table create</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>Result</code>
</li><li><code>azure mobile table create</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>Feedback</code>
</li></ul>
</li><li>Upload a script to your Windows&nbsp;Azure Mobile Service that which will update the score and the position of the player in the leaderboard as the results are entered. From a command line, change to the sample's
<code>Scripts</code> directory, and then run this command: <code>azure mobile script upload</code>&nbsp;<i>[AzureMobileServiceName]</i>&nbsp;<code>table/result.insert.js</code>.
</li><li>Get the <code>ApplicationUrl</code> and <code>ApplicationKey</code> for your Windows&nbsp;Azure Mobile Service with this command:
<code>azure mobile show</code>&nbsp;<i>[AzureMobileServiceName]</i> </li><li>Install the <a href="http://go.microsoft.com/fwlink/p/?LinkID=320478">Windows&nbsp;Azure Mobile Services NuGet package</a>.
</li><li>Open the <code>App.xaml.cs</code> file and replace &quot;mobile-service-url&quot; and &quot;mobile-service-key&quot; with the
<code>ApplicationUrl</code> and <code>ApplicationKey</code>. Your Windows Store app is now configured to communicate with your created Windows&nbsp;Azure Mobile Service.
</li><li>Click <b>Build</b> &gt; <b>Build Solution</b>. </li></ol>
<h2>Run the sample</h2>
<ol>
<li>To debug the app and then run it in Microsoft Visual Studio, press F5 or use <b>
Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li><li>After the app starts, answer the three questions in the app. After you finish the game, your results are then sent to be inserted into your Windows&nbsp;Azure Mobile Service
<code>Results</code> table. As the row is being inserted, the uploaded script runs to update the
<code>Leaderboard</code> table with the new total score and positions. Finally, the app will update to display the leaderboard data from the
<code>Leaderboard</code> table. </li><li>You can also go to the <a href="http://go.microsoft.com/fwlink/p/?LinkId=306779">
Windows Azure management portal</a>, sign in, and view your Windows&nbsp;Azure Mobile Service and the saved data.
</li></ol>
</div>
