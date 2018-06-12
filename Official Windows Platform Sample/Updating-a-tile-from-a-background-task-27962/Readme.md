# Updating a tile from a background task
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* XAML
* Windows Runtime
* Windows Phone 8.1
## Topics
* RenderTargetBitmap
* Tile background update
* XamlRenderingBackgroundTask
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:56:32
## Description

<div id="mainSection">
<p>This sample shows how to update a tile from a background task in a Windows Phone Store app.
</p>
<p>This sample shows how to update a tile from a background task. It shows how to implement a
<a href="http://msdn.microsoft.com/library/windows/apps/dn633914"><b>XamlRenderingBackgroundTask</b></a> and use
<a href="http://msdn.microsoft.com/library/windows/apps/dn298548"><b>RenderTargetBitmap</b></a> to generate an updated tile image from a custom XAML layout.
</p>
<p class="note"><b>Important</b>&nbsp;&nbsp;To keep the memory footprint of the background task as low as possible, the XamllRenderingBackgroundTask is implemented in a C&#43;&#43; Windows Runtime Component for Windows Phone. The memory footprint will be higher if written
 in C# and will cause out of memory exceptions on low-memory devices which will terminate the background task. For more information on memory constraints, see
<a href="m_multitask_mca.run_background_tasks_to_enhance_your_app#WP_EXTRA_RESOURCE_CONSTRAINTS">
Additional background task resource constraints for Windows Phone</a>.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample requires Windows&nbsp;8.1 and Microsoft Visual Studio&nbsp;2013 with Update 2 or later.
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013 , go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013 </a>. After you install Visual Studio&nbsp;2013, update your installation with Update 2 or later.
</p>
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
