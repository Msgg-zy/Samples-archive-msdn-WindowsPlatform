# App tiles and badges sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Controls
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:25:04
## Description

<div id="mainSection">
<p>This sample shows how to use an app tile, which is the representation and launch point for your app in the Start screen, and a badge on that tile, which is a method for the app to relay status information to the user when the app is not running. App tiles
 aren't restricted to static icons, but rather can be alive with content, keeping the user aware of news and events or displaying content (such as photos) related to that app. Notification updates, based on a Windows-supplied set of templates, keep the tile
 content fresh and can display both local and web text and images on the tile.</p>
<p>The sample demonstrates the following scenarios: </p>
<ul>
<li>Sending new text content for the tile by using a notification </li><li>Using local images in a tile notification </li><li>Using web images in a tile notification </li><li>Sending a notification to update a badge on the tile </li><li>Providing content for and sending each of the tile templates </li><li>Enabling the notification queue, which allows up to five of the most recent notifications to cycle on the tile, and using the tags to selectively replace notifications in the queue
</li><li>Setting an expiration time for the notification content so that it is removed from the tile
</li><li>Accessing images by using different protocols and by using a pre-defined root path
</li><li>Globalization, including localization, scaling of images, and accessibility </li></ul>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;Most of the functionality in this sample requires that the tile can receive notifications. Tile notifications can be disabled by a user for a single app or for all apps, or by a system administrator by using group policy.</p>
<p>For any functionality that involves non-local content, the developer must have declared the &quot;Internet (Client)&quot; capability in the app's manifest, as has been done in this sample. In the Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 manifest editor,
 you find this option under the <b>Capabilities</b> tab.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779719">Badges overview</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761491">The tile template catalog</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465377">Creating tiles and badges (tutorials)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465403">Guidelines and checklist for tiles and badges</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465429">How to use the notification queue</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465439">Quickstart: Sending a tile update</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779724">Tiles overview</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700418">Quickstart: Sending a badge update</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh781199">Using the notification queue (overview)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208661"><b>Windows.UI.Notifications namespace</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 Windows Store app samples</a>
</dt></dl>
<h3>Operating system requirements</h3>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012 </dt></td>
</tr>
</tbody>
</table>
<h3>Build the sample</h3>
<ol>
<li>Start Visual Studio&nbsp;2012 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<h3><a id="How_to_use_the_sample"></a><a id="how_to_use_the_sample"></a><a id="HOW_TO_USE_THE_SAMPLE"></a>How to use the sample</h3>
<p>After you send a tile notification from one of the scenarios, switch to your Start screen to see the notification appear on this sample's app tile. Click the tile again to return to the sample. For some options to function properly, you must resize the app
 tile between square and wide. Swipe or right-click the tile to display the app bar, from which you can choose
<b>Smaller</b> or <b>Larger</b> to size the tile.</p>
<p>In scenario 5, &quot;Preview all tile notification templates,&quot; if you find that your notification is not appearing on the tile as expected. Ensure that the data you've entered is correct and appropriate to the template. For instance, if you attempt to send a
 wide image to a square tile, that notification will be rejected. Although it says that it is optional, set a language for templates with text elements. For instance, &quot;en-us&quot;.</p>
</div>
