# XAML two-dimensional transforms sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
* Windows Runtime
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:25:25
## Description

<div id="mainSection">
<p>This sample demonstrates how to use two-dimensional transforms to modify how elements are displayed in your app. A
<i>transform</i> defines how to map, or transform, points from one coordinate space to another coordinate space.
</p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Simple 2-D transforms (<a href="http://msdn.microsoft.com/library/windows/apps/br242932"><b>RotateTransform</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br242940"><b>ScaleTransform</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br242950"><b>SkewTransform</b></a>, and
<a href="http://msdn.microsoft.com/library/windows/apps/br243027"><b>TranslateTransform</b></a>). These classes enable you to transform an object without knowing how the underlying matrix structure is configured. Note that the sample code actually uses
<a href="http://msdn.microsoft.com/library/windows/apps/br228105"><b>CompositeTransform</b></a> in order to make the sample interactive. However, the properties provided to the
<b>CompositeTransform</b> could just as easily be applied to one of the simple transforms where those properties are relevant. For example, the
<a href="http://msdn.microsoft.com/library/windows/apps/br228105_translatex"><b>TranslateX</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br228105_translatey"><b>TranslateY</b></a> values could be set on
<b>TranslateTransform</b> as the <a href="http://msdn.microsoft.com/library/windows/apps/br243027_x">
<b>X</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br243027_y">
<b>Y</b></a> values. </li><li>Using <a href="http://msdn.microsoft.com/library/windows/apps/br210137"><b>MatrixTransform</b></a> and setting up a
<a href="http://msdn.microsoft.com/library/windows/apps/br210127"><b>Matrix</b></a>. This enables you to create transforms that can't be easily expressed as one of the simple 2-D transforms.
</li><li>3-D projections of 2-D elements using <a href="http://msdn.microsoft.com/library/windows/apps/br210192">
<b>PlaneProjection</b></a>. This class enables you to create 3-D rotation and translation effects.
</li><li>Using <a href="http://msdn.microsoft.com/library/windows/apps/br2101273dprojection">
<b>Matrix3DProjection</b></a> and setting up a <a href="http://msdn.microsoft.com/library/windows/apps/br243266">
<b>Matrix3D</b></a> to create complex 3-D transforms. </li></ul>
<p></p>
<p>Common transformation properties where you might apply a transform include:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br228082"><b>Brush.Transform</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br228080"><b>Brush.RelativeTransform</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br208911_rendertransform"><b>UIElement.RenderTransform</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br210066"><b>Geometry.Transform</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br243377_geometrytransform"><b>Shape.GeometryTransform</b></a>
</li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Roadmaps</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for C# and Visual Basic</a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br228105"><b>CompositeTransform</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br210137"><b>MatrixTransform</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br210192"><b>PlaneProjection</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br2101273dprojection"><b>Matrix3DProjection</b></a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700359">3-D effects for apps using XAML</a>
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
<li>
<p>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.</p>
</li><li>
<p>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
