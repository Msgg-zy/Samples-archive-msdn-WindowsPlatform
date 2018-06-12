# Folder enumeration sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Storage
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:13:37
## Description

<div id="mainSection">
<p>This sample shows how to enumerate the top-level files and folders inside a location (like a folder, device, or network location), and how to use queries to enumerate all files inside a location by sorting them into file groups.
</p>
<p>This sample uses <a href="http://msdn.microsoft.com/library/windows/apps/br227346">
<b>Windows.Storage</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br208106">
<b>Windows.Storage.Search</b></a> APIs, including <a href="http://msdn.microsoft.com/library/windows/apps/br227230">
<b>StorageFolder</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br208066">
<b>StorageFolderQueryResult</b></a>.</p>
<p>The sample demonstrates these tasks:</p>
<ol>
<li>
<p><b>Enumerate top-level files and subfolders of a folder</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br227230"><b>StorageFolder</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br227230_getfilesasync"><b>GetFilesAsync</b></a> and
<b>StorageFolder</b>.<a href="http://msdn.microsoft.com/library/windows/apps/br227230_getfoldersasync"><b>GetFoldersAsync</b></a> methods to enumerate only the top-level files and folders (the immediate children) of the location (in this case, the Pictures
 library). For a walkthrough of this task, see <a href="http://msdn.microsoft.com/library/windows/apps/jj150596">
Quickstart: Accessing files programmatically</a>.</p>
</li><li>
<p><b>Query all the files in a folder (and its subfolders) and create groups of files to enumerate</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br227230"><b>StorageFolder</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br227230_createfolderquerywithoptions"><b>CreateFolderQueryWithOptions</b></a> method to sort all
 files in the location (in this case, the Pictures library) into groups based on the criteria that you specify and uses a
<a href="http://msdn.microsoft.com/library/windows/apps/br208066"><b>StorageFolderQueryResult</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br208066_getfoldersasync"><b>GetFoldersAsync</b></a> method to retrieve the resulting file groups.</p>
<p>File groups are virtual folders that are represented by <a href="http://msdn.microsoft.com/library/windows/apps/br227230">
<b>StorageFolder</b></a> objects. The files in a file group have the criteria that you specify in common. For example, as the sample shows, the files in a group might have the same rating.</p>
<p>For a walkthrough of this task, see <a href="http://msdn.microsoft.com/library/windows/apps/jj150596">
Quickstart: Accessing files programmatically</a>.</p>
</li><li>
<p><b>Query all the files in a folder (and its subfolders) and retrieve file properties as a part of getting results for the query</b></p>
<p>Uses <a href="http://msdn.microsoft.com/library/windows/apps/br207995"><b>QueryOptions</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br207995_setpropertyprefetch"><b>SetPropertyPrefetch</b></a> to specify properties to retrieve when the
 query is created. <a href="http://msdn.microsoft.com/library/windows/apps/br227230">
<b>StorageFolder</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br227230_createfolderquerywithoptions"><b>CreateFolderQueryWithOptions</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br227230_getfilesasync"><b>GetFilesAsync</b></a> are used to create the query and enumerate results. Similarly, you can use
<a href="http://msdn.microsoft.com/library/windows/apps/br207995_setthumbnailprefetch">
<b>SetThumbnailPrefetch</b></a> to retrieve thumbnails as a part of creating the query.</p>
<p>Using <a href="http://msdn.microsoft.com/library/windows/apps/br207995_setpropertyprefetch">
<b>SetPropertyPrefetch</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br207995_setthumbnailprefetch">
<b>SetThumbnailPrefetch</b></a> might make the query take longer to execute, but will make accessing large amounts of file information more efficient.</p>
</li></ol>
<p>Additional important APIs in this sample include:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br207957"><b>CommonFolderQuery</b></a> enumeration
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br207956"><b>CommonFileQuery</b></a> enumeration
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh973317"><b>PropertyPrefetchOptions</b></a> enumeration
</li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Related samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231532">Programmatic file search sample</a>
</dt><dt><a href=" http://go.microsoft.com/fwlink/p/?linkid=231445">File access sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231522">File and folder thumbnail sample</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br227346"><b>Windows.Storage namespace</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br208106"><b>Windows.Storage.Search namespace</b></a>
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
</li><li>Press F6 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
