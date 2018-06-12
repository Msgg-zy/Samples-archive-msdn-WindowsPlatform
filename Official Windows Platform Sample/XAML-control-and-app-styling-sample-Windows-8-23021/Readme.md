# XAML control and app styling sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
* Windows Runtime
## Topics
* Controls
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:07:41
## Description

<div id="mainSection">
<p>This sample demonstrates how to use styles and templates to customize the look controls and apps.
</p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Setting the <a href="http://msdn.microsoft.com/library/windows/apps/br208743">
<b>Style</b></a> property to change the look of a control.
<p>You can apply styling to any element of type <a href="http://msdn.microsoft.com/library/windows/apps/br208706">
<b>FrameworkElement</b></a>, including subclasses of <b>FrameworkElement</b>. This means that almost all XAML elements support the
<a href="http://msdn.microsoft.com/library/windows/apps/br208743"><b>Style</b></a> property.</p>
</li><li>Using a template to change the look of a control.
<p>Elements that derive from the <a href="http://msdn.microsoft.com/library/windows/apps/br209390">
<b>Control</b></a> class also contain a control template which defines the visual look of the control. A control template can be specified using the
<a href="http://msdn.microsoft.com/library/windows/apps/br209465"><b>Template</b></a> property on the
<b>Control</b> class. It can also be specified in a <a href="http://msdn.microsoft.com/library/windows/apps/br208743">
<b>Style</b></a>. </p>
</li><li>Using theme resources.
<p>The XAML runtime provides a list of resources called &quot;theme resources&quot; which can be used anywhere in your app. The look of theme resources changes when you use the Light or Dark app themes, or when the user turns on the High Contrast setting.</p>
</li><li>Creating theme resources for an app.
<p>You can override the default theme resources values in your app by creating <a href="http://msdn.microsoft.com/library/windows/apps/br208794">
<b>ResourceDictionary</b></a> entries using the same key names.</p>
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465381">Quickstart: Styling controls</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465374">Quickstart: Control templates</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for C# and Visual Basic</a>
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
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To run the app and then debug it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
