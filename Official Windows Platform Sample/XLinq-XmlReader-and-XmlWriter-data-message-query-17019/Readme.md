# XLinq, XmlReader, and XmlWriter data message query sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Data Access
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:33:26
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
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;To run this sample you must apply for a Bing Maps key, then replace “INSERT_YOUR_BING_MAPS_KEY” with your key in the source code.</p>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
