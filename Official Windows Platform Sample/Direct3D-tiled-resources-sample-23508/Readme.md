# Direct3D tiled resources sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* DirectX
* Windows Runtime
## Topics
* Graphics
* tiled resources
* game app
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:33:54
## Description

<div id="mainSection">
<p>This sample demonstrates how to utilize Direct3D Tiled Resources in a typical game scenario to improve bandwidth and memory efficiency. It renders a 3D representation of the surface of Mars using several tiled texture cubes, dynamically streaming individual
 tiles as they are needed for rendering. </p>
<p>You can determine if a device supports Direct3D Tiled Resources with the following APIs:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/dn280435"><b>D3D11_TILED_RESOURCES_TIER</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dn280377"><b>D3D11_FEATURE_DATA_D3D11_OPTIONS1</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ff476497"><b>ID3D11Device::CheckFeatureSupport</b></a>
</li></ul>
Tiles resources are specified using the D3D11_RESOURCE_MISC_TILED flag, as seen in the following code sample:
<p></p>
<div class="code"><span>
<table>
<tbody>
<tr>
<th>C&#43;&#43;</th>
</tr>
<tr>
<td>
<pre>// Create a tiled texture and view for the normal layer.
    D3D11_TEXTURE2D_DESC normalTextureDesc;
    ZeroMemory(&amp;normalTextureDesc, sizeof(normalTextureDesc));
    normalTextureDesc.Width = SampleSettings::TerrainAssets::Normal::DimensionSize;
    normalTextureDesc.Height = SampleSettings::TerrainAssets::Normal::DimensionSize;
    normalTextureDesc.ArraySize = 6;
    normalTextureDesc.Format = SampleSettings::TerrainAssets::Normal::Format;
    normalTextureDesc.SampleDesc.Count = 1;
    normalTextureDesc.Usage = D3D11_USAGE_DEFAULT;
    normalTextureDesc.BindFlags = D3D11_BIND_SHADER_RESOURCE;
    normalTextureDesc.MiscFlags = D3D11_RESOURCE_MISC_TEXTURECUBE | D3D11_RESOURCE_MISC_TILED;
    DX::ThrowIfFailed(device-&gt;CreateTexture2D(&amp;normalTextureDesc, nullptr, &amp;m_normalTexture));
</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8.1 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=243667">
Windows&nbsp;8.1 app samples pack</a>. The samples in the Windows&nbsp;8.1 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2013.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn280435"><b>D3D11_TILED_RESOURCES_TIER</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn280377"><b>D3D11_FEATURE_DATA_D3D11_OPTIONS1</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/ff476497"><b>ID3D11Device::CheckFeatureSupport</b></a>
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
