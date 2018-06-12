# Direct3D tutorial sample (Windows 8)
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
* 2013-06-27 02:11:58
## Description

<div id="mainSection">
<p>This sample is a five-lesson tutorial that provides an introduction to the Direct3D API, and which introduces the concepts and code used in many of the other DirectX samples.
</p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Basic initialization of DirectX and Direct3D using the Windows Runtime </li><li>Creating meshes </li><li>Implementing pixel and vertex shaders </li><li>Rendering 3D geometry </li><li>Techniques for basic lighting and texturing </li></ul>
<p></p>
<p>These lessons build upon each other, from configuring DirectX for your C&#43;&#43; app to texturing primitives and adding effects.
</p>
<ol>
<li>Lesson1.Basics. This tutorial sample sets up DirectX resources in a C&#43;&#43; app. </li><li>Lesson2.Triangles. This tutorial sample creates a 3D cube from a mesh using a vertex shader.
</li><li>Lesson3.Cubes. This tutorial sample applies basic vertex lighting and coloring to the cube primitive created in Lesson 2.
</li><li>Lesson4.Textures. This tutorial sample loads DDS textures and applies them to a 3D primitive using the cube created in Lesson 3. It also introduces a simple dot-product lighting model, where the cube surfaces are lighter or darker based on their distance
 and angle relative to a light source. </li><li>Lesson5.Components. This tutorial sample takes the concepts from the previous four lessons and demonstrates how to separate them into separate code objects for reuse.
</li></ol>
<p></p>
<p>This sample is written in C&#43;&#43; and requires basic experience with graphics programming concepts.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465137">An introduction to 3D graphics with DirectX</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd370987">Direct2D graphics</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/ff476080">Direct3D 11 graphics</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/bb205169">DXGI reference</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229580">Getting started: create a aview with DirectX</a>
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
<p>You can also open any of the individual .vcxproj files for each of the lessons, such as Lesson5.Components\Lesson5.Components.vcxproj, and build them separately from the solution.</p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
