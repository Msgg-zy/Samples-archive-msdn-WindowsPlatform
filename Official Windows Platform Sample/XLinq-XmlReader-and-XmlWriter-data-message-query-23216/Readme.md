# XLinq, XmlReader, and XmlWriter data message query sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Data Access
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:24:35
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br230232">
System.Xml</a> and System.Xml.Linq (XLinq)classes and methods supported by the .NET for Windows Store apps API library. The sample opens a text file that contains an XML document, queries the XML document, and saves the results to another XML text file/
</p>
<p>This sample covers two scenarios: </p>
<ul>
<li>Querying an XML message with XLinq inside a Windows Store app. To accomplish this, the sample uses the
<b>XDocument</b> and <b>XElement</b> and queries against them using LINQ. </li><li>Processing the XML message with <b>XmlReader</b> and <b>XmlWriter</b> inside a Windows Store app.
<b>XmlReader</b> and <b>XmlWriter</b> are part of the <a href="http://msdn.microsoft.com/library/windows/apps/br230232">
System.Xml</a> namespace. These classes are used to create the <b>XDocument</b> instance that the sample queries with LINQ and then serializes to a file, respectively.
</li></ul>
<p></p>
<p>&quot;XLinq&quot; refers to the use of LINQ to query XML documents using the classes (such as
<b>XDocument</b> and <b>XElement</b>) and methods defined in <a href="http://msdn.microsoft.com/library/windows/apps/br230232">
System.Xml.Linq</a>. These namespaces and their classes are only available to Windows Store apps using C&#43;&#43;, C#, or Visual Basic.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;To run this sample you must apply for a Bing Maps key, then replace “INSERT_YOUR_BING_MAPS_KEY” with your key in the source code.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;To run this sample you must apply for a Bing Maps key, then replace “INSERT_YOUR_BING_MAPS_KEY” with your key in the source code.</p>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
