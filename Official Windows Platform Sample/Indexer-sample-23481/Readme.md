# Indexer sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Controls
* indexer
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:27:42
## Description

<div id="mainSection">
<p>This sample shows how to add, update, and retrieve items and properties from the indexer. Two methods of doing so are demonstrated. The first is using the ContentIndexer APIs to directly interface with the indexer. The second is writing .appcontent-ms files,
 which contain information to be indexed that the indexer will pick up once the file has been written.
</p>
<p>The sample demonstrates these tasks:</p>
<ol>
<li>
<p><b>Add an item to the system index</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn298342"><b>AddAsync</b></a> method to make app content searchable in the system index.</p>
</li><li>
<p><b>Update and delete items in the index</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn298355"><b>UpdateAsync</b></a> method to update an item and the
<a href="http://msdn.microsoft.com/library/windows/apps/dn298348"><b>DeleteAsync</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/dn298349"><b>DeleteMultipleAsync</b></a>, and
<a href="http://msdn.microsoft.com/library/windows/apps/dn298347"><b>DeleteAllAsync</b></a> methods to remove content from the system index.</p>
</li><li>
<p><b>Get items from the system index by using a query</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn298343"><b>CreateQuery</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dn298334"><b>GetAsync</b></a> methods to retrieve items from the system index.</p>
</li><li>
<p><b>Check the revision number of the indexer</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn298354"><b>Revision</b></a> property and the app's
<a href="http://msdn.microsoft.com/library/windows/apps/br241622"><b>LocalSettings</b></a> to check if the app's expected revision number matches the actual index revision number.</p>
</li><li>
<p><b>Add app content files to be indexed</b></p>
<p>Copies app-specific files to the app's LocalState\Indexed folder to make app content searchable in the system index.</p>
</li><li>
<p><b>Remove file content from the system index</b></p>
<p>Deletes app-specific files from the app's LocalState\Indexed folder to remove app content from the system index.</p>
</li><li>
<p><b>Get indexed file properties </b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br227252"><b>CreateFileQuery</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br211591"><b>CreateFileQueryWithOptions</b></a> methods to query the system index for file properties.</p>
</li></ol>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn298331"><b>ContentIndexer</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn298332"><b>ContentIndexerQuery</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227252"><b>CreateFileQuery</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211591"><b>CreateFileQueryWithOptions</b></a>
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
<p></p>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
