# Marble Maze sample for Windows Phone 8
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Direct3D
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:15:55
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample app is a port of the Marble Maze Windows Store app. Complete implementation details of the original Marble Maze game can be found in the topic
<a href="http://msdn.microsoft.com/en-us/library/windows/apps/br230257.aspx">Developing Marble Maze</a>. Windows&nbsp;Phone&nbsp;8 supports a subset of the features that are available for Windows Store apps. Because of this, several key changes were made to the app as
 it was ported. Details about these changes are provided later in this document. For more info about creating games for the phone, see
<a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206992(v=vs.105).aspx">
Games for Windows Phone</a>.</p>
<p></p>
<p><b>Build the sample</b> </p>
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.
</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.
</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.
</p>
</li></ol>
<p></p>
<p><b>Run the sample</b> </p>
<ol>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</li></ol>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Caution:</b> </th>
</tr>
<tr>
<td>
<p>When running the sample in the debugger, the first time you launch the sample a first-chance exception will be thrown. This is because of the way that Windows Phone Runtime APIs handle the fact that the save game file does not exist yet. It is possible to
 suppress this error, but that could potentially hide other exceptions that may be introduced as you modify the code, so the error is not suppressed in the sample. Click
<span class="ui">Continue</span> in the error dialog to ignore the exception and allow the app to run normally.</p>
</td>
</tr>
</tbody>
</table>
</div>
<p><b>Changes made to the Marble Maze sample to run on Windows Phone</b> </p>
<p>The following list describes the changes that were made to the Marble Maze app when it was ported from a Windows Store app to Windows&nbsp;Phone. Where possible, the source files in the sample solution where the relevant changes were made are listed. For more
 info about what’s different when developing a game for the phone, see <a href="http://msdn.microsoft.com/library/windowsphone/develop/jj662930(v=vs.105).aspx">
Differences in game development between the phone and the desktop</a>.</p>
<ol>
<li>
<p><b>Drawing 2D graphics</b> - Direct2D is not available on Windows&nbsp;Phone. The Windows Store version of the game uses Direct2D to draw 2-D graphics such as GUI elements. The phone version uses helper classes provided by the DirectX Tool Kit (DirectXTK) to
 reimplement the game’s UI. Source files: UserInterface.cpp, LoadScreen.cpp</p>
<p>DirectXTK’s SpriteFont was used in place of Direct2D fonts. Bitmap fonts were precomputed ahead of time. Source files: MarbleMaze.cpp, UserInterface.cpp</p>
</li><li>
<p><b>Loading textures</b> - The Windows Imaging Component (WIC) APIs are not available on Windows&nbsp;Phone. These APIs allow you to load textures in multiple file formats. The phone version of the game uses DDS textures for the load screen instead of PNG images.&nbsp;
 Source files: LoadScreen.cpp</p>
<p>Texture images were downscaled from the versions used on the desktop. This is not for performance reasons but instead to reduce the size of the app. The larger textures greatly increased the app size, but did not provide greater visual fidelity due to the
 phone’s smaller screen. Source files: bridge.dds, bridge_bump.dds, floor_section1.dds, floor_section2.dds, walllevel1.dds</p>
</li><li>
<p><b>Direct3D APIs</b> - Of the Direct3D APIs that are supported on the phone, most function exactly like their desktop counterparts for the supported feature level (feature level 9_3). One of the exceptions is the creation of a swap chain. There are a few
 initialization parameters that have special requirements on the phone. These include:
</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>swapChainDesc.BufferCount = 1;
swapChainDesc.Scaling = DXGI_SCALING_STRETCH;
swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT_DISCARD;</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p>This code can be found in DirectXBase.cpp at lines 152-154.</p>
<p>Other changes to Direct3D code include:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
<ul>
<li>
<p>Removed IDXGISwapChain1::ResizeBuffers call (DirectXBase.cpp)</p>
</li><li>
<p>Using IDXGISwapChain1::Present1 instead of Present (DirectXBase.cpp)</p>
</li><li>
<p>Removed unnecessary window size and DPI change handling code. These events do not occur on the phone (DirectXBase.cpp, DirectXApp.cpp)
</p>
</li></ul>
</li><li>
<p><b>File I/O</b> – On Windows&nbsp;Phone, the <a href="http://msdn.microsoft.com/en-us/library/windows/apps/windows.storage.applicationdata.localsettings.aspx">
LocalSettings</a> folder is not supported.&nbsp; The <span value="PersistentState"><span class="keyword">PersistentState</span></span> class from the desktop version was reimplemented in a custom
<span value="SaveState"><span class="keyword">SaveState</span></span> method. Source files: MarbleMaze.cpp</p>
<p><span value="FileIO"><span class="keyword">FileIO</span> </span>is not available on the phone. The implementation was changed slightly in BasicReaderWriter::ReadDataAsync and BasicReaderWriter::WriteDataAsync. Source files: BasicReaderWriter.cpp</p>
</li><li>
<p><b>Input</b> - To support the phone’s back button, <span value="BackPressed"><span class="keyword">BackPressed</span></span> key handling was added to the game and keyboard events were removed due to the phone’s lack of keyboard support. Source files:
 DirectXApp.cpp, MarbleMaze.cpp</p>
</li><li>
<p><b>Audio</b> - Due to limited support for Microsoft Media Foundation APIs, a custom WAV loading implementation was created. Source files: MediaStreamer.cpp</p>
<p>Code for background music playback was modified to use IMFMediaEngine. Source files: Audio.cpp</p>
</li></ol>
<p><b>See also</b> </p>
<ul>
<li>
<p><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206992(v=vs.105).aspx">Games for Windows Phone</a>
</p>
</li></ul>
</div>
</div>
