# DirectX shadow mapping sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* XAML
* DirectX
## Topics
* depth buffer shadow map
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:32:24
## Description

<div id="mainSection">
<p>This sample demonstrates how to render shadows that are compatible with all Direct3D feature levels. This sample shows how to create depth buffer device resources compatible with Direct3D feature level 9_1, render depth values to the buffer, and use
<a href="http://msdn.microsoft.com/library/windows/apps/bb509696">SampleCmp</a> or
<a href="http://msdn.microsoft.com/library/windows/apps/bb509697">SampleCmpLevelZero</a> in a shader model 4 level 9_1 pixel shader to do depth testing during the final render pass. This sample includes a pixel shader compatible with linear filtering (for softer
 shadows) and point filtering (for faster shadows).</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8.1 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=243667">
Windows&nbsp;8.1 app samples pack</a>. The samples in the Windows&nbsp;8.1 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2013.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn263152">Implementing depth buffers for shadow mapping</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/bb509696">SampleCmp</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/bb509697">SampleCmpLevelZero</a>
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
<p>To build this sample, open the solution (.sln) file titled ShadowMapping.sln from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). Press F6 or go to
<b>Build-&gt;Build Solution</b> from the top menu after the sample has loaded.</p>
<h2>Run the sample</h2>
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the
<b>Debug</b> menu.)</p>
</div>
