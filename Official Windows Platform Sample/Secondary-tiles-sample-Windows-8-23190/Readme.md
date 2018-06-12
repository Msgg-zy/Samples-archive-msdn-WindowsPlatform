# Secondary tiles sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:22:59
## Description

<div id="mainSection">
<p>This sample shows how to pin and use a secondary tile, which is a tile that directly accesses a specific, non-default section or experience within an app, such as a saved game or a specific friend in a social networking app. Sections or experiences within
 an app that can be pinned to the Start screen as a secondary tile are chosen and exposed by the app, but the creation of the secondary tile is strictly up to the user.</p>
<p>The sample demonstrates the following scenarios: </p>
<ul>
<li>Pinning a secondary tile to the Start screen </li><li>Removing a secondary tile from the Start screen </li><li>Enumerating all secondary tiles owned by the calling app </li><li>Determining whether a particular tile is currently pinned to the Start screen
</li><li>Processing arguments when the app is activated through a secondary tile </li><li>Sending a local tile notification and badge notification to the secondary tile
</li><li>Using push notifications to update a secondary tile </li><li>Using the app bar to pin and unpin tiles. (JavaScript and C# only) </li><li>Updating the secondary tile's default logo </li></ul>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;Some functionality in the sample requires that the tile can receive notifications. Tile notifications can be disabled by a user for a single app or for all apps, or by a system administrator by using group policy. For more info,
 see <a href="http://msdn.microsoft.com/library/windows/apps/hh465439">How to check whether a tile can be updated</a>.</p>
<p>For any functionality that involves non-local content, such as push notifications, the developer must have declared the &quot;Internet (Client)&quot; capability in the app's manifest. In the Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 manifest editor, you find
 this option under the <b>Capabilities</b> tab.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465398">Guidelines and checklist for secondary tiles</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465443">Quickstart: Pinning a secondary tile</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761474">Quickstart: Sending notifications to a secondary tile</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br242183"><b>SecondaryTile class</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465372">Secondary tiles overviews</a>
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
<p>In some of the scenarios, you need to switch to the Start screen to see the effect of the scenario on the secondary tile. Click the sample tile to return to the sample.</p>
</div>
