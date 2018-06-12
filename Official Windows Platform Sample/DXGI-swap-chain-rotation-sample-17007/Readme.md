# DXGI swap chain rotation sample
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
* 2013-11-25 04:25:40
## Description

<div id="mainSection">
<p>This sample demonstrates the <a href="http://msdn.microsoft.com/library/windows/apps/hh446801">
<b>IDXGISwapChain1::SetRotation</b></a> method and how you can use the method in conjunction with prerotated content to improve presentation performance.
</p>
<p>The areas that the sample covers includes:</p>
<ul>
<li>Incorporating the Windows Runtime into your Microsoft DirectX app for full Windows&nbsp;8.1 support
</li><li>Using DirectX to render 2D and 3D graphics for display in an app </li><li>Implementing simple vertex and pixel shaders with Microsoft High Level Shader Language (HLSL)
</li></ul>
<p>The sample is written in C&#43;&#43; and requires some experience with graphics programming and DirectX.</p>
<p>For more info about the concepts and APIs demonstrated in this sample, see these topics:
</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br229580">Create an app using DirectX</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ff476080">Direct3D 11 graphics</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh404534">DXGI</a> </li><li><a href="http://msdn.microsoft.com/library/windows/apps/dd370987">Direct2D graphics</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/bb509561">DirectX HLSL</a>
</li></ul>
<p></p>
<p>The sample uses properties of the <a href="http://msdn.microsoft.com/library/windows/apps/br226166">
<b>Windows.Graphics.Display namespace</b></a> from the Windows Runtime to handle Window resize events and to swap width and height based on orientation.</p>
<p>The sample sets the proper orientation for the swap chain and generates 2D and 3D matrix transformations for rendering to the rotated swap chain.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The rotation angle for the 2D and 3D transforms are different. This is due to the difference in coordinate spaces. Additionally, the 3D matrix is specified explicitly to avoid rounding errors.</p>
<p>By default (without using <a href="http://msdn.microsoft.com/library/windows/apps/hh446801">
<b>IDXGISwapChain1::SetRotation</b></a>), when the device is rotated, the (0,0) swap chain surface coordinate always corresponds to the logical top-left of the screen. Physically, however, that coordinate is always in the same place, so the operating system
 rotates your content as necessary to make it display correctly. This behavior causes the
<a href="http://msdn.microsoft.com/library/windows/apps/hh446797"><b>IDXGISwapChain1::Present1</b></a> method to incur a slight overhead, but on low-end devices it can be significant. By using
<b>IDXGISwapChain1::SetRotation</b>, you can indicate that the swap chain contents are already rotated correctly, so the operating system rotation is not necessary. By using
<b>IDXGISwapChain1::SetRotation</b>, however, you need to ensure that your content is actually rendered in the correct orientation. That’s where the sample uses the m_rotationTransform2D and m_rotationTransform3D matrices. Those matrices are calculated in the
 sample when the device is rotated, and can be used with the Direct2D <a href="http://msdn.microsoft.com/library/windows/apps/dd742857">
<b>SetTransform</b></a> method, and vertex shader transforms, respectively, to help prerotate content.</p>
<p>When the sample calls the <a href="http://msdn.microsoft.com/library/windows/apps/hh446797">
<b>IDXGISwapChain1::Present1</b></a> method to deliver the final image to the display, it can optionally specify dirty and/or scroll rectangles in the
<a href="http://msdn.microsoft.com/library/windows/apps/hh404522"><b>DXGI_PRESENT_PARAMETERS</b></a> structure to improve efficiency in certain scenarios. In this sample, however, we don't use those features. The first argument to
<b>DXGI_PRESENT_PARAMETERS</b> instructs DXGI to block until VSync, which puts the sample to sleep until the next VSync. This ensures we don't waste any cycles rendering frames that will never be displayed to the screen.</p>
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
<p>To build this sample, open the solution (.sln) file titled DxgiRotation.sln from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). Press F7 or go to
<b>Build-&gt;Build Solution</b> from the top menu after the sample has loaded.</p>
<h2>Run the sample</h2>
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the
<b>Debug</b> menu.)</p>
</div>
