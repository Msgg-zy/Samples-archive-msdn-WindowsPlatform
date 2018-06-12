# Unselectable content areas with -ms-user-select CSS attribute sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
## Topics
* User Interface
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:34:41
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
<p><a id="none"></a><a id="NONE"></a>none</p>
</td>
<td width="60%">
<p>Blocks selection from starting on that element. It will not block an existing selection from entering the element.</p>
</td>
</tr>
<tr>
<td width="40%">
<p><a id="element"></a><a id="ELEMENT"></a>element</p>
</td>
<td width="60%">
<p>Enables selection to start within the element; however, the selection is contained by the bounds of that element.</p>
</td>
</tr>
<tr>
<td width="40%">
<p><a id="inherit"></a><a id="INHERIT"></a>inherit</p>
</td>
<td width="60%">
<p>Assumes the behavior of the <a href="http://msdn.microsoft.com/library/windows/apps/hh779846">
<b>-ms-user-select</b></a> attribute defined on the parent &lt;div&gt; element.</p>
</td>
</tr>
<tr>
<td width="40%">
<p><a id="text"></a><a id="TEXT"></a>text</p>
</td>
<td width="60%">
<p>Enables selection to start within the element and extend past the element's bounds.
</p>
</td>
</tr>
</tbody>
</table>
</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/?LinkID=272182">How to disable text and image selection</a>
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
