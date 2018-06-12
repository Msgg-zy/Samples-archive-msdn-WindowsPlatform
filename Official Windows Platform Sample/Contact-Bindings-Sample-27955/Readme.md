# Contact Bindings Sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* XAML
* Windows Runtime
* Windows Phone 8.1
## Topics
* contact binding
* social integration
* Silverlight 8.1
## IsPublished
* True
## ModifiedDate
* 2014-05-13 11:36:05
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/jj207747">
<b>PersonalInformation</b></a> APIs to connect contacts on the phone with the related contact on your app and web service. .</p>
<p>If your app and web service maintains a list of people associated with the current user, such as friends on a social network, you can use contact bindings to associate the people on your service to the contacts on the device. When you do this, your app will
 be shown as a tile on the Connect pivot for the contact in the People hub, featuring images you provide from your web service to represent the person. From this tile, the user can launch your app and view your app's presentation of the contact, such as recent
 posts or activity on your site.For more information on using this feature, see <a href="http://go.microsoft.com/fwlink/p/?LinkId=394685">
Implementing contact bindings in a Silverlight 8.1 app</a>.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;After initially setting up your contact bindings, the system requests data about your contact bindings on an as-needed basis. This is done by launching a Silverlight
<b>ScheduledTaskAgent</b> from which your app retrieves data from your web service. Due to this mechanism, online media integration is only supported for Windows&nbsp;Phone Silverlight apps.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample requires Windows&nbsp;8.1 and Microsoft Visual Studio&nbsp;2013 with Update 2 or later.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013 , go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013 </a>. After you install Visual Studio&nbsp;2013, update your installation with Update 2 or later.
</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn642093">Quickstart: recording the screen with ScreenCapture</a>
</dt></dl>
<h2>Operating system requirements</h2>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>None supported </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>None supported </dt></td>
</tr>
<tr>
<th>Phone</th>
<td><dt>Windows Phone 8.1 </dt></td>
</tr>
</tbody>
</table>
<h2>Build the sample</h2>
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2013 for Windows --&gt; and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2013 for Windows Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
