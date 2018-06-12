# Content prefetch sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* XAML
* HTML5
* Windows Runtime
## Topics
* Data
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:24:10
## Description

<div id="mainSection">
<p>Demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/dn279042">
<b>ContentPrefetcher</b></a> to add or clear direct content Uniform Resource Identifiers (URIs) or indirect content URIs. It also shows how to get the last successful prefetch time.
</p>
<p>To force the operating system to perform a prefetch of these contents in a developer scenario for testing, a desktop application must use the
<a href="http://go.microsoft.com/fwlink/?LinkId=327984">IContentPrefetcherTaskTrigger</a>'s
<b>TriggerContentPrefetcherTask</b> method to trigger an immediate prefetch operation.
</p>
<p>The sample demonstrates these tasks:</p>
<ol>
<li>
<p><b>Add a direct content URI</b></p>
<p>This scenario shows how to add direct content URIs to the <a href="http://msdn.microsoft.com/library/windows/apps/dn279043">
<b>ContentUris</b></a> property for content prefetching or to clear all direct content URIs.</p>
</li><li>
<p><b>Set an indirect content URI</b></p>
<p>This scenario shows how to use the <a href="http://msdn.microsoft.com/library/windows/apps/dn279044">
<b>IndirectContentUri</b></a> property to add indirect content URIs for content prefetching or to clear the indirect content URI.
</p>
</li><li>
<p><b>Get the last prefectch time</b></p>
<p>This scenario shows how to use the <a href="http://msdn.microsoft.com/library/windows/apps/dn384045">
<b>LastSuccessfulPrefetchTime</b></a> property to get the last prefetch time.</p>
</li></ol>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain evaluation copies of Microsoft Visual Studio&nbsp;2013 and Microsoft Visual Studio&nbsp;2013 Update&nbsp;2, go to
<a href="http://go.microsoft.com/fwlink/p/?linkid=301697">Visual Studio&nbsp;2013</a>.
</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
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
<li>Start Visual Studio&nbsp;2013 Update&nbsp;2 and select <b>File</b> &gt; <b>Open</b> &gt;
<b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press Ctrl&#43;Shift&#43;B or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.
</li></ol>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
