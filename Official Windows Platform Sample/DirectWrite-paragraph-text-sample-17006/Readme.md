# DirectWrite paragraph text sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* DirectX
## Topics
* Audio and video
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:25:34
## Description

<div id="mainSection">
<p>This sample shows how to use <a href="http://msdn.microsoft.com/library/windows/apps/dd368038">
DirectWrite</a> and <a href="http://msdn.microsoft.com/library/windows/apps/dd370990">
Direct2D</a> to render paragraph text to a <a href="http://msdn.microsoft.com/library/windows/apps/br208225">
<b>CoreWindow</b></a> and apply justification and character spacing to the layout.
</p>
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
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<p>To build this sample, open the solution (.sln) file from Visual Studio&nbsp;2013 (any SKU). Press F7 or go to
<b>Build-&gt;Build Solution</b> from the top menu after the sample has loaded.</p>
<h2>Run the sample</h2>
<p>To run this sample after building it, go to the installation folder for this sample with Windows Explorer and open the executable file. Alternatively, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled). (Or select the corresponding
 options from the <b>Debug</b> menu.)</p>
</div>
