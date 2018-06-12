# Direct2D 3D transform effect sample (Windows 8)
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
* 2013-06-27 02:10:21
## Description

<div id="mainSection">
<p>This sample demonstrates the different methods to transform an image in 3-D space.
</p>
<p>These topics provide more info about the feature areas used in this sample:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a>, which you use to render the images and primitives. It also handles the image effects.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh825871">Xaml</a>, which provides the UI components. See Direct3D and Xaml interop for more info on using
<a href="http://msdn.microsoft.com/library/windows/apps/ff476080">Direct3D</a>, and
<a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a> with Xaml.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh706327">Direct2D effects</a>, which provides the transform effects.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh404534">DXGI</a>, which is you use display rendered content to the
<a href="http://msdn.microsoft.com/library/windows/apps/hh825871">Xaml</a> window.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ee719655">Windows Imaging Component (WIC)</a>, which you use to load, scale, and convert the images.
</li></ul>
<p></p>
<p>Some of the APIs used in this sample are:</p>
<ul>
<li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh702626"><b>SwapChainBackgroundPanel</b></a> class, which allows you to display
<a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a> to the
<a href="http://msdn.microsoft.com/library/windows/apps/hh825871">Xaml</a> window.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh404479"><b>ID2D1DeviceContext</b></a> interface, which performs the rendering.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh404558"><b>CreateSwapChainForComposition</b></a> method to create a swap chain that allows
<a href="http://msdn.microsoft.com/library/windows/apps/dd370990">Direct2D</a> display to the
<a href="http://msdn.microsoft.com/library/windows/apps/hh702626"><b>SwapChainBackgroundPanel</b></a> .
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
