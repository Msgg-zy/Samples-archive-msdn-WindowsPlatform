# Sharing content source app sample (Windows 8)
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
* 2013-06-27 02:23:08
## Description

<div id="mainSection">
<p>This sample demonstrates how an app can share content with another app. This sample uses classes from the
<a href="http://msdn.microsoft.com/library/windows/apps/br205967"><b>Windows.ApplicationModel.DataTransfer</b></a> namespace. Some of the classes you might want to review in more detail are the
<a href="http://msdn.microsoft.com/library/windows/apps/br205932"><b>DataTransferManager</b></a> class, which you use to initiate a share operation, and the
<a href="http://msdn.microsoft.com/library/windows/apps/br205873"><b>DataPackage</b></a> class, which you use to package the content. Because each share scenario usually involves two apps—the source app and a target app that receives the content—we recommend
 you install and deploy the <a href="http://go.microsoft.com/fwlink/p/?linkid=231519">
Sharing content target app sample</a> before you install and run this one. That way, you can see how sharing works from end to end.
</p>
<p>This sample covers how to share content in a variety of formats, including:</p>
<ul>
<li>Text </li><li>URIs </li><li>Files </li><li>Images </li></ul>
<p></p>
<p>To learn more about sharing and the <a href="http://msdn.microsoft.com/library/windows/apps/br205967">
<b>Windows.ApplicationModel.DataTransfer</b></a> namespace, we recommend you take a look at the
<a href="http://msdn.microsoft.com/library/windows/apps/hh464923">Sharing and exchanging data</a> section of our documentation, which describes how sharing works and contains several how-to topics that cover how to share
<a href="http://msdn.microsoft.com/library/windows/apps/hh758313">text</a>, an <a href="http://msdn.microsoft.com/library/windows/apps/hh758305">
image</a>, files, and other formats. Our <a href="http://msdn.microsoft.com/library/windows/apps/hh465251">
Guidelines for sharing content</a> can also help you create a great user experience with the share feature.
</p>
<p>For more info about the concepts and APIs demonstrated in this sample, see these topics:</p>
<ul>
<li><a href="http://go.microsoft.com/fwlink/p/?linkid=231519">Sharing content target app sample</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh464923">Sharing and exchanging data</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh758308">How to share files (Windows Store apps using JavaScript and HTML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh871371">How to share files (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh758310">How to share HTML (Windows Store apps using JavaScript and HTML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh973055">How to share HTML (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</li><li><a href="m_clipboard.share_links">How to share a link (Windows Store apps using JavaScript and HTML)</a>
</li><li><a href="m_clipboard_mca.share_links">How to share a link (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh758305">How to share an image (Windows Store apps using JavaScript and HTML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh871370">How to share an image (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh758313">How to share text (Windows Store apps using JavaScript and HTML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh871372">How to share text (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465261">Quickstart: Sharing content (Windows Store apps using JavaScript and HTML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh871368">Quickstart: Sharing content (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br205873view"><b>DataPackageView</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br205977"><b>ShareOperation</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br205967"><b>Windows.ApplicationModel.DataTransfer</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br205989"><b>Windows.ApplicationModel.DataTransfer.Share</b></a>
</li></ul>
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
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
