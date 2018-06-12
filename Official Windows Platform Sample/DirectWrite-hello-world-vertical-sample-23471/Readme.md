# DirectWrite hello world (vertical) sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* DirectX
* Windows Runtime
## Topics
* DirectWrite
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:25:35
## Description

<div id="mainSection">
<p>Demonstrates creating a DirectWrite vertical text layout by using a Japanese language example.
</p>
<p>This sample demonstrates the following steps to create a vertical text layout in DirectWrite using the Meiryo UI font:</p>
<ul>
<li>Call <a href="http://msdn.microsoft.com/library/windows/apps/dd368203"><b>IDWriteFactory2::CreateTextFormat</b></a> to create a text format object.
</li><li>Set the horizontal text alignment with <a href="http://msdn.microsoft.com/library/windows/apps/dd316709">
<b>IDWriteTextFormat::SetTextAlignment</b></a>, and set the vertical text alignment with
<a href="http://msdn.microsoft.com/library/windows/apps/dd316702"><b>IDWriteTextFormat::SetParagraphAlignment</b></a>.
</li><li>Set the reading direction by calling <a href="http://msdn.microsoft.com/library/windows/apps/dd316705">
<b>IDWriteTextFormat::SetReadingDirection</b></a>, in this case DWRITE_READING_DIRECTION_TOP_TO_BOTTOM for vertical Japanese text.
</li><li>Set the flow direction by calling <a href="http://msdn.microsoft.com/library/windows/apps/dd316691">
<b>IDWriteTextFormat::SetFlowDirection</b></a>, in this case DWRITE_FLOW_DIRECTION_RIGHT_TO_LEFT for vertical Japanese text.
</li><li>Call <a href="http://msdn.microsoft.com/library/windows/apps/dd368205"><b>IDWriteFactory2::CreateTextLayout</b></a> to create a text layout based on the vertical text format.
</li></ul>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8.1 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=243667">
Windows&nbsp;8.1 app samples pack</a>. The samples in the Windows&nbsp;8.1 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2013.</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn280448"><b>IDWriteFactory2</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd316628"><b>IDWriteTextFormat</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=243667">Windows 8.1 app samples</a>
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
