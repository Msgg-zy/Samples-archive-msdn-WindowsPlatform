# Compression sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Storage
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:07:24
## Description

<div id="mainSection">
<p>This sample demonstrates how to read structured data from a file and write compressed data to a new file and how to read compressed data and write decompressed data to a new file.
</p>
<p>Many applications need to compress and decompress data. The <a href="http://msdn.microsoft.com/library/windows/apps/br207698">
<b>Windows.Storage.Compression</b></a> namespace simplifies this task by providing a unified interface that exposes the Windows MSZIP, XPRESS, XPRESS_HUFF, and LZMS compression algorithms. This enables developers of Windows applications to manage versions,
 service, and extend the exposed compression algorithms and frees developers from responsibility for managing block sizes, compression parameters, and other details that the native
<a href="http://msdn.microsoft.com/library/windows/apps/hh437596">Compression API</a> requires. A subset of
<a href="http://go.microsoft.com/fwlink/p/?linkid=246262">Win32 and COM for apps</a> can be used by apps to support scenarios not already covered by the Windows Runtime, HTML/CSS, or other supported languages or standards. For this purpose, the native Compression
 API can also be used by developers of apps.</p>
<p>Specifically, this sample shows the following:</p>
<ul>
<li>Read uncompressed data from an existing file </li><li>Specify the compression algorithm to use. </li><li>Compress the data using the selected compression algorithm. </li><li>Write the compressed data to a new file. </li><li>Read the compressed data from a file. </li><li>Decompress the data. </li></ul>
<p></p>
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
<ol>
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
