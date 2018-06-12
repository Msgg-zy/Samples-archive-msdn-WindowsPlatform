# IXmlReader and IXmlWriter XML data read/write sample (Windows 8)
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
* 2013-06-27 02:26:44
## Description

<div id="mainSection">
<p>This sample demonstrates how to use <a href="http://msdn.microsoft.com/library/windows/apps/ms752743">
<b>IXmlReader</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/ms752860">
<b>IXmlWriter</b></a> in your Windows Store app with C&#43;&#43; to read and write XML data from a flat XML-formatted text file. These interfaces are part of the Windows Win32 and COM APIs, but are supported by the Windows Runtime for use in Windows Store apps. They
 provide a simple, fast, lightweight way to read and write XML elements and attributes from your Windows Store app with C&#43;&#43;.</p>
<p>Specifically, this sample covers the following scenarios:</p>
<ul>
<li>Accessing the <b>IXmlReader</b> and <b>IXmlWriter</b> Win32/COM APIs from a Windows Store app with C&#43;&#43;.
</li><li>Reading the XML-formatted text file using <b>IRandomAccessStream</b>. </li><li>Reading the XML elements and attributes using <b>IXmlReader</b>. </li><li>Creating a text file in the user's local folder (typically My Documents) to store the XML output.
</li><li>Writing to an XML-formatted text file using <b>IRandomAccessStream</b>. </li><li>Formatting XML elements and overall document structure using IXmlWriter properties.
</li></ul>
<p>This sample app uses XAML as the framework for reading user interface events and displaying the results.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/ms752743"><b>IXmlReader</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/ms752860"><b>IXmlWriter</b></a>
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
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
