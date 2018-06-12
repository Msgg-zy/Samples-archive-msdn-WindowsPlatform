# Cube9 (DirectX 9 to DirectX 11.1 Windows Store porting sample)
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* DirectX
* Direct3D
## Topics
* Graphics and 3D
* Direct3D
## IsPublished
* True
## ModifiedDate
* 2013-06-26 11:48:07
## Description

<p>This sample shows the same renderer as the Cube11 sample, but implemented as a DirectX 9 desktop app. By comparing the two samples you can learn about the differences between Direct3D 9 and Direct3D 11.1.</p>
<ul>
<li>The Direct3D 9 desktop app sample uses a viewport based on traditional desktop window (HWND) and Direct3D 9 for rendering.
</li><li>The DirectX 11.1 Windows Store app sample runs in an IFrameworkView, uses DirectX 11.1 for rendering, and uses built-in CoreWindow message processing.
</li></ul>
<p>This sample is a companion to a walkthrough guide. Read <a href="http://go.microsoft.com/fwlink/?LinkID=288781">
Walkthrough: Port a simple Direct3D 9 app to DirectX 11.1 and the Windows Store</a> to start porting Direct3D 9 desktop code to DirectX 11.1 and the Windows Store.</p>
<p><strong>Get both samples</strong></p>
<p>This sample is part of a kit that shows the same rendering code implemented in two different ways. Download the
<a href="http://go.microsoft.com/fwlink/?LinkID=288801">Simple DirectX 9 to DirectX 11.1 Windows Store porting samples</a>&nbsp;to get both code paths.</p>
<p><strong>Build the sample</strong></p>
<p>Use Visual Studio Express 2012 for Windows Desktop, Visual Studio Professional 2012, or Visual Studio Ultimate 2012 to build the DirectX 9 desktop app sample.</p>
<p><strong>NOTE&nbsp;&nbsp;&nbsp;</strong>The DirectX 9 desktop app sample uses the legacy D3DX library, which you can install by
<a href="http://go.microsoft.com/fwlink/?LinkId=271274">downloading the legacy Microsoft DirectX 2010 SDK</a>. The path to the DirectX 2010 SDK must be specified using the
<strong>DXSDK_DIR</strong> environment variable.</p>
<p><strong>Run the sample</strong></p>
<p>To debug the app and then run it, press F5 or use <strong>Debug &gt; Start Debugging</strong>. To run the app without debugging, press Ctrl&#43;F5 or use
<strong>Debug &gt; Start Without Debugging</strong>.</p>
<p><strong>Changes in this version</strong></p>
<p>The sample code has been changed to provide better results when diffing against the DirectX 11 implementation.<strong><br>
</strong></p>
<p><strong>Related topics</strong></p>
<p><a href="http://go.microsoft.com/fwlink/?LinkID=288781">Walkthrough: Port a simple Direct3D 9 app to DirectX 11.1 and the Windows Store
</a></p>
<p><strong>Operating system requirements </strong></p>
<table>
<tbody>
<tr>
<td><strong>Client</strong></td>
<td>Windows　8</td>
</tr>
<tr>
<td><strong>Server</strong></td>
<td>Windows Server　2012</td>
</tr>
</tbody>
</table>
