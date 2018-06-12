# Unselectable content areas with -ms-user-select CSS (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 04:35:06
## Description

<div id="mainSection">
<p>This sample demonstrates how your app can make content areas in your Windows Store app using JavaScript unselectable using the
<a href="http://msdn.microsoft.com/library/windows/apps/hh779846"><b>-ms-user-select</b></a> CSS attribute.
</p>
<p>By default, all content in the UI of a Windows Store app using JavaScript can be selected by a user and copied to the clipboard. However, access to UI elements (such as text, images, and other proprietary content) can be limited by excluding them from this
 default behavior with <a href="http://msdn.microsoft.com/library/windows/apps/hh779846">
<b>-ms-user-select</b></a>. </p>
<p><a href="http://msdn.microsoft.com/library/windows/apps/hh779846"><b>-ms-user-select</b></a> supports the following values:</p>
<p>
<table>
<tbody>
<tr>
<th>Term</th>
<th>Description</th>
</tr>
<tr>
<td width="40%">
<p>none</p>
</td>
<td width="60%">
<p>Blocks selection from starting on that element. It will not block an existing selection from entering the element.</p>
</td>
</tr>
<tr>
<td width="40%">
<p>element</p>
</td>
<td width="60%">
<p>Enables selection to start within the element; however, the selection is contained by the bounds of that element.</p>
</td>
</tr>
<tr>
<td width="40%">
<p>inherit</p>
</td>
<td width="60%">
<p>Assumes the behavior of the <a href="http://msdn.microsoft.com/library/windows/apps/hh779846">
<b>-ms-user-select</b></a> attribute defined on the parent &lt;div&gt; element.</p>
</td>
</tr>
<tr>
<td width="40%">
<p>text</p>
</td>
<td width="60%">
<p>Enables selection to start within the element and extend past the element's bounds.
</p>
</td>
</tr>
</tbody>
</table>
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/?LinkID=272182">How to disable text and image selection</a>
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
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
