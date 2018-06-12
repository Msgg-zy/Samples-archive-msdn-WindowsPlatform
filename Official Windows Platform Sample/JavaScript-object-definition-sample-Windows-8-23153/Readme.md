# JavaScript object definition sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
## Topics
* App model
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:20:08
## Description

<div id="mainSection">
<p>This sample shows how to use the methods provided by the <a href="http://msdn.microsoft.com/library/windows/apps/br229773_class">
<b>WinJS.Class</b></a> namespace of the Windows Library for JavaScript to define and modify Windows Runtime object prototypes. This namespace defines a set of helper classes and methods used to modify and extend the underlying object model.</p>
<p>Specifically, this sample uses the following APIs from the <a href="http://msdn.microsoft.com/library/windows/apps/br229773_class">
<b>WinJS.Class</b></a> namespace:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br229813"><b>WinJS.Class.define</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br229815"><b>WinJS.Class.derive</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br229836"><b>WinJS.Class.mix</b></a>
</li></ul>
<p>This sample demonstrates the following scenarios:</p>
<ul>
<li>Defining a simple JavaScript object, placing the methods and default properties on the function prototype by using the
<a href="http://msdn.microsoft.com/library/windows/apps/br229813"><b>WinJS.Class.define</b></a> method.
</li><li>Combining methods from multiple prototypes to create new combinatorial types, called &quot;mixin&quot; types. You can accomplish this by using the
<a href="http://msdn.microsoft.com/library/windows/apps/br229836"><b>WinJS.Class.mix</b></a> method.
</li><li>Constructing types through a prototype chain, providing an effect similar to inheritance in class-oriented languages. You can accomplish this by reviewing the implementation of the &quot;Shape&quot; class hierarchy in the sample, which uses the
<a href="http://msdn.microsoft.com/library/windows/apps/br229815"><b>WinJS.Class.derive</b></a> method.
</li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465037">Roadmap for apps using JavaScript</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh967790">Defining and deriving types with WinJS.Class</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh967789">Adding functionality with WinJS mixins</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229813"><b>WinJS.Class.define</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229815"><b>WinJS.Class.derive</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229836"><b>WinJS.Class.mix</b></a>
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
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
