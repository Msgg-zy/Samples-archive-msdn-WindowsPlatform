# Playlist sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Audio and video
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:21:07
## Description

<div id="mainSection">
<p>This sample demonstrates how to create, save, display, and edit a playlist of audio files.
</p>
<p>This sample uses classes that are in the <a href="http://msdn.microsoft.com/library/windows/apps/br206938">
<b>Windows.Media.Playlists</b></a> namespace. It provides five scenarios:</p>
<p></p>
<ol>
<li><b>Create and save a playlist from a set of audio files.</b>
<p>This creates a new <a href="http://msdn.microsoft.com/library/windows/apps/br206904">
<b>Playlist</b></a> object and saves it using <a href="http://msdn.microsoft.com/library/windows/apps/br206904_saveasasync">
<b>saveAsAsync</b></a>.</p>
</li><li><b>Display the contents of an existing playlist (WPL, ZPL, M3U).</b>
<p>This loads a <a href="http://msdn.microsoft.com/library/windows/apps/br206904">
<b>Playlist</b></a> object using <a href="http://msdn.microsoft.com/library/windows/apps/br206904_loadasync">
<b>loadAsync</b></a>, and obtains the properties of each file in <a href="http://msdn.microsoft.com/library/windows/apps/br206904_files">
<b>Playlist.Files</b></a> using <a href="http://msdn.microsoft.com/library/windows/apps/hh770649">
<b>Windows.Storage.FileProperties.StorageItemContentProperties.GetMusicPropertiesAsync</b></a>.</p>
</li><li><b>Insert an item at the end of an existing playlist (WPL, ZPL, M3U).</b>
<p>This loads a <a href="http://msdn.microsoft.com/library/windows/apps/br206904">
<b>Playlist</b></a> object using <a href="http://msdn.microsoft.com/library/windows/apps/br206904_loadasync">
<b>loadAsync</b></a>, and appends a file to <a href="http://msdn.microsoft.com/library/windows/apps/br206904_files">
<b>Playlist.Files</b></a>.</p>
</li><li><b>Remove an item from the end of an existing playlist (WPL, ZPL, M3U).</b>
<p>This loads a <a href="http://msdn.microsoft.com/library/windows/apps/br206904">
<b>Playlist</b></a> object using <a href="http://msdn.microsoft.com/library/windows/apps/br206904_loadasync">
<b>loadAsync</b></a>, and removes the file at the end of <a href="http://msdn.microsoft.com/library/windows/apps/br206904_files">
<b>Playlist.Files</b></a>.</p>
</li><li><b>Remove all items from an existing playlist (WPL, ZPL, M3U).</b>
<p>This loads a <a href="http://msdn.microsoft.com/library/windows/apps/br206904">
<b>Playlist</b></a> object using <a href="http://msdn.microsoft.com/library/windows/apps/br206904_loadasync">
<b>loadAsync</b></a>, and clears the files in <a href="http://msdn.microsoft.com/library/windows/apps/br206904_files">
<b>Playlist.Files</b></a>.</p>
</li></ol>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
