# Updating a pinned secondary tile on Deactivate
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* XAML
* Windows Phone 8.1
## Topics
* Update
* Tiles
* Silverlight 8.1
* secondary tiles
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:56:20
## Description

<div id="mainSection">
<p>This sample demonstrates how to update a pinned secondary tile in a Windows&nbsp;Phone Silverlight 8.1 app.
</p>
<p>When using <a href="http://msdn.microsoft.com/library/windows/apps/br242213"><b>RequestCreateAsync</b></a> to pin a secondary tile to the user's start screen, the app will be deactivated. This is a different behavior from how this API works in an app running
 on a PC. Because of this behavior, any code called after RequestCreateAsync is not guaranteed to run before the app is deactivated. To avoid this potential issue, you should update a pinned tile in the Deactivated event of your app.
</p>
<p>The sample demonstrates two scenarios. The first scenario shows the pattern that is not recommend, so that you can understand the issue. The second scenario shows the recommended pattern that updates the tile during the Deactivated event.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample requires Windows&nbsp;8.1 and Microsoft Visual Studio&nbsp;2013 with Update 2 or later.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013 , go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013 </a>. After you install Visual Studio&nbsp;2013, update your installation with Update 2 or later.
</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=394241">Choosing MPN or WNS for a Silverlight 8.1 app</a>
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
