# DirectX mappable default buffers  sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* DirectX
## Topics
* depth buffer shadow map
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:25:09
## Description

<div id="mainSection">
<p>This SDK sample demonstrates how apps can use the new Direct3D mappable default buffers functionality in Windows&nbsp;8.1.
</p>
<p>The mappable default buffers feature allows apps to directly access the GPU's default buffers without performing intermediate copies to staging buffers. Apps can use this technique to avoid redundant copies from the default buffers to a mappable buffer,
 increasing performance as a result. Mappable default buffers are only available on feature level 11_0 (and higher) devices and the device must have up-to-date WDDM 1.3 drivers for Windows&nbsp;8.1. This sample demonstrates how to check at runtime whether the device
 supports mappable default buffers, and includes a compute shader example showing how to use the Direct3D API to actually map the GPU's default buffers (when the feature is supported). This sample also shows a fallback path that can be used when mappable default
 buffers are not supported by the device. For more information see the following APIs used in this sample:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/ff476497"><b>ID3D11Device::CheckFeatureSupport</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dn280377"><b>D3D11_FEATURE_DATA_D3D11_OPTIONS1</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ff476259"><b>D3D11_USAGE</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ff476457"><b>ID3D11DeviceContext::Map</b></a>
</li></ul>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8.1 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=243667">
Windows&nbsp;8.1 app samples pack</a>. The samples in the Windows&nbsp;8.1 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2013.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=243667">Windows 8.1 app samples</a>
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
