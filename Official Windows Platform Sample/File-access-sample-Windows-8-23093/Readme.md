# File access sample (Windows 8)
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
* 2013-06-27 02:13:00
## Description

<div id="mainSection">
<p>This sample shows how to create, read, write, copy and delete a file, how to retrieve file properties, and how to track a file or folder so that your app can access it again. This sample uses
<a href="http://msdn.microsoft.com/library/windows/apps/br227346"><b>Windows.Storage</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br207498"><b>Windows.Storage.AccessCache</b></a> API.
</p>
<p>The sample demonstrates these tasks:</p>
<ol>
<li>
<p><b>Create a file in the Documents library</b></p>
<p>Uses one of the <a href="http://msdn.microsoft.com/library/windows/apps/br227230">
<b>StorageFolder</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br227230_createfileasync"><b>CreateFileAsync</b></a> methods to create the file.</p>
</li><li>
<p><b>Write and read text in a file</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/hh701440"><b>FileIO</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/hh701440_writetextasync"><b>WriteTextAsync</b></a> and
<b>FileIO</b>.<a href="http://msdn.microsoft.com/library/windows/apps/hh701440_readtextasync"><b>ReadTextAsync</b></a> methods to write and read the file. For a walkthrough of this task, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh464978">Quickstart: reading and writing a file</a>.</p>
</li><li>
<p><b>Write and read bytes in a file</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/hh701440"><b>FileIO</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/hh701440_writebufferasync"><b>WriteBufferAsync</b></a> and
<b>FileIO</b>.<a href="http://msdn.microsoft.com/library/windows/apps/hh701440_readbufferasync"><b>ReadBufferAsync</b></a> methods to write and read the file. For a walkthrough of this task, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh464978">Quickstart: reading and writing a file</a>.</p>
</li><li>
<p><b>Write and read a file using a stream</b></p>
<p>Uses the following API to write and read the file using a stream.</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br227171"><b>StorageFile</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br227171_opentransactedwriteasync"><b>OpenTransactedWriteAsync</b></a> method
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br208154"><b>DataWriter</b></a> class
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br208119"><b>DataReader</b></a> class
</li></ul>
<p>For a walkthrough of this task, see <a href="http://msdn.microsoft.com/library/windows/apps/hh464978">
Quickstart: reading and writing a file</a>.</p>
</li><li>
<p><b>Display file properties</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br227171"><b>StorageFile</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br227171_getbasicpropertiesasync"><b>GetBasicPropertiesAsync</b></a> method and the
<b>StorageFile</b>.<a href="http://msdn.microsoft.com/library/windows/apps/br227171_properties"><b>Properties</b></a> property to get the properties of the file.</p>
</li><li>
<p><b>Track a file or folder so that you can access it later (persisting access)</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br207456"><b>StorageApplicationPermissions</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br207456_futureaccesslist"><b>FutureAccessList</b></a> and
<b>StorageApplicationPermissions</b>.<a href="http://msdn.microsoft.com/library/windows/apps/br207456_mostrecentlyusedlist"><b>MostRecentlyUsedList</b></a> properties to remember a file or folder so that it can be accessed later.</p>
<p>For a walkthrough of this task, see <a href="http://msdn.microsoft.com/library/windows/apps/hh972603">
How to track recently used files and folders</a>.</p>
</li><li>
<p><b>Copy a file</b></p>
<p>Uses one of the <a href="http://msdn.microsoft.com/library/windows/apps/br227171">
<b>StorageFile</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br227171_copyasync"><b>CopyAsync</b></a> methods to copy the file.</p>
</li><li>
<p><b>Delete a file</b></p>
<p>Uses one of the <a href="http://msdn.microsoft.com/library/windows/apps/br227171">
<b>StorageFile</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br227171_deleteasync"><b>DeleteAsync</b></a> methods to delete the file.</p>
</li></ol>
<p class="note"><b>Note</b>&nbsp;&nbsp;If you want to learn about accessing files using a file picker, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh771180">Quickstart: Accessing files with file pickers</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Related samples</b> </dt><dt><a href=" http://go.microsoft.com/fwlink/p/?linkid=231464">File picker sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231512">Folder enumeration sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231532">Programmatic file search sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231522">File and folder thumbnail sample</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br227346"><b>Windows.Storage namespace</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br207498"><b>Windows.Storage.AccessCache namespace</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br207831"><b>Windows.Storage.FileProperties</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br241791"><b>Windows.Storage.Streams namespace</b></a>
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
