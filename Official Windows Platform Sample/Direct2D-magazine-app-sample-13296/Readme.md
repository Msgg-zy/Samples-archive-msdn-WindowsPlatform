# Direct2D magazine app sample
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
* 2013-11-25 04:28:16
## Description

<div id="mainSection">
<p>This sample shows how to use <a href="http://msdn.microsoft.com/library/windows/apps/dd370990">
Direct2D</a>, <a href="http://msdn.microsoft.com/library/windows/apps/dd368038">DirectWrite</a>,
<a href="http://msdn.microsoft.com/library/windows/apps/ee719902">Windows Imaging Component (WIC)</a>, and
<a href="http://msdn.microsoft.com/library/windows/apps/hh700354">XAML</a> to build an app with magazine-type presentation.
</p>
<p>Specifically, this sample shows: </p>
<ul>
<li>How to render 2D graphics using <a href="http://msdn.microsoft.com/library/windows/apps/jj262109">
DirectX</a>. </li><li>How to integrate <a href="http://msdn.microsoft.com/library/windows/apps/jj262109">
DirectX</a> content with <a href="http://msdn.microsoft.com/library/windows/apps/hh700354">
XAML</a> using <a href="http://msdn.microsoft.com/library/windows/apps/hh702050">
<b>Virtual Surface Image Source</b></a>. </li><li>How to use <a href="http://msdn.microsoft.com/library/windows/apps/hh700354">
XAML's</a> <a href="http://msdn.microsoft.com/library/windows/apps/hh465425">FlipView</a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br209527"><b>ScrollViewer</b></a> controls to create a magazine reading experience.
</li><li>How to load application-specific custom fonts using <a href="http://msdn.microsoft.com/library/windows/apps/dd368038">
DirectWrite</a>. </li><li>How to decode image files using <a href="http://msdn.microsoft.com/library/windows/apps/ee719902">
WIC</a>. </li><li>How to apply image effects such as <a href="http://msdn.microsoft.com/library/windows/apps/hh706338">
Gaussian Blur</a> using <a href="http://msdn.microsoft.com/library/windows/apps/">
Direct2D</a>'s effects APIs. </li></ul>
<p>These topics provide more info about the feature areas used in this sample:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/dd368038">DirectWrite</a>, which you use to layout the text.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a>, which you use to render the images, primitives, and text. It also handles the image effects.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh404534">DXGI</a>, which is you use display rendered content to the
<a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>CoreWindow</b></a>.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ee719902">WIC</a>, which you use to load, scale, and convert the images.
</li></ul>
<p></p>
<p>Some of the APIs used in this sample are:</p>
<ul>
<li>The <a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>Windows::UI::Core::CoreWindow</b></a> class, which encapsulates the window and handles the display of the content.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh404479"><b>ID2D1DeviceContext</b></a> interface, which performs the rendering.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh404559"><b>IDXGIFactory2::CreateSwapChainForCoreWindow</b></a> method to create a swap chain that allows
<a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a> to interact with the
<a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>CoreWindow</b></a>.
</li></ul>
<p></p>
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
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd368038">DirectWrite</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh404534">DXGI</a> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh825871">DirectX and XAML interop</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/ee719902">WIC</a> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208225"><b>CoreWindow</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh702050"><b>VirtualSurfaceImageSource</b></a>
</dt><dt><b>Windows::UI::Core::CoreWindow</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh404479"><b>ID2D1DeviceContext</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh404559"><b>IDXGIFactory2::CreateSwapChainForCoreWindow</b></a>
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
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
