# DirectWrite hello world sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* DirectX
## Topics
* Audio and video
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:12:22
## Description

<div id="mainSection">
<p>This sample shows how to use <a href="http://msdn.microsoft.com/library/windows/apps/dd368038">
DirectWrite</a> and <a href="http://msdn.microsoft.com/library/windows/apps/dd370990">
Direct2D</a> to render the text &quot;Hello World&quot; to a <a href="http://msdn.microsoft.com/library/windows/apps/br208225">
<b>CoreWindow</b></a>. </p>
<p>These topics provide more info about the feature areas used in this sample:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/dd368038">DirectWrite</a>, which is used to format and layout the text.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a>, which is used to render the text.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh404534">DXGI</a>, which is used to display rendered content to the
<a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>CoreWindow</b></a>.
</li></ul>
<p></p>
<p>Some of the APIs used in this sample are:</p>
<ul>
<li>The <a href="http://msdn.microsoft.com/library/windows/apps/dd316628"><b>IDWriteTextFormat</b></a> interface, which you use to designate formatting for the text (like font face, font size, and so on).
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/dd316718"><b>IDWriteTextLayout</b></a>, which you use to layout the text you are going to display.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/dd371913"><b>ID2D1DeviceContext::DrawTextLayout</b></a> method, which you use to render the text with
<a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a>. </li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>Windows::UI::Core::CoreWindow</b></a> class, which encapsulates the Window and handles the display of the content.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh404479"><b>ID2D1DeviceContext</b></a> interface, which performs the rendering.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh404559"><b>IDXGIFactory2::CreateSwapChainForCoreWindow</b></a> method to create a swap chain that allows
<a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a> to interact with the
<a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>CoreWindow</b></a>.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd368152">Tutorial: Getting Started with DirectWrite</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd316628"><b>IDWriteTextFormat</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd316718"><b>IDWriteTextLayout</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd371913"><b>ID2D1DeviceContext::DrawTextLayout</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd368038">DirectWrite</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
