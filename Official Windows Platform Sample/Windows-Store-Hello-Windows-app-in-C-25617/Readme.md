# Windows Store Hello Windows app in C++
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Visual Studio 2013
* Windows Store app
## Topics
* C++
* Getting Started
## IsPublished
* True
## ModifiedDate
* 2013-10-17 09:44:15
## Description

<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 10pt; line-height:115%"><span style="font-family:Calibri"><span style="line-height:115%; font-size:12pt">An instructional sample app for Windows 8.1 that introduces beginning concepts for creating a Windows Store app in Visual Studio
 using C&#43;&#43; and XAML. This is the companion sample for the 4-part set of articles that begins with
</span><span style="color:black"><span style=""><span style="font-size:small">&nbsp;</span></span></span></span><span lang="EN" style=""><a href="http://msdn.microsoft.com/en-us/library/windows/apps/dn263168.aspx"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Hello
 World in C&#43;&#43;</span></a></span><span style="line-height:115%; font-size:12pt"><span style="font-family:Calibri">.
</span></span></p>
<p style="margin:0in 0in 10pt; line-height:115%"><span style="line-height:115%; font-size:12pt"><span style="font-family:Calibri">--<br>
</span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<div id="_mcePaste" class="mcePaste" style="left:-10000px; top:0px; width:1px; height:1px; overflow:hidden">
</div>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 0pt"><span style="font-size:small"><span lang="EN" style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;">This sample, and the accompanying documentation,<strong>
</strong></span><span style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;">introduce the basics of the C&#43;&#43;/CX component extensions that enable you to create a Windows Store app using C&#43;&#43; and XAML in a modern C&#43;&#43; idiom. These articles introduce the following concepts:</span></span></p>
<p><span style="font-family:Times New Roman; font-size:small">&nbsp;</span></p>
<ul style="list-style-type:disc; direction:ltr">
<li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:bold">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">C&#43;&#43;/CX syntax elements</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:bold">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">The Visual Studio IDE and the structure of a C&#43;&#43; Windows Store project</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span style="font-size:12pt">The Windows runtime type system</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span style="font-size:12pt">Basic UI design with XAML</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span style="font-size:12pt">State management</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span style="font-size:12pt">Accessing local files</span></strong></p>
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<span style="font-size:12pt">&nbsp;</span></p>
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:6pt; page-break-after:avoid">
<strong><span style="color:black; font-size:12pt">Operating system requirements</span></strong></p>
</li></ul>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span></p>
<table border="0" cellspacing="0" cellpadding="0" style="border-collapse:collapse">
<tbody>
<tr style="">
<td width="77" style="padding:0in 0.5pt; border:#000000; width:0.8in; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 6pt; text-align:center; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Client</span></span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span></td>
<td width="256" style="padding:0in 0.5pt; border:#000000; width:192pt; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 6pt; line-height:normal"><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Windows 8.1
</span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span></td>
</tr>
<tr style="">
<td width="77" style="padding:0in 0.5pt; border:#000000; width:0.8in; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 6pt; text-align:center; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Server</span></span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span></td>
<td width="256" style="padding:0in 0.5pt; border:#000000; width:192pt; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 6pt; line-height:normal"><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Windows Server 2012 R2
</span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span></td>
</tr>
</tbody>
</table>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Build the sample</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span style=""><span style="font-family:Calibri">1.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Visual Studio 2013 Preview and select File &gt; Open &gt; Project/Solution.
</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span style=""><span style="font-family:Calibri">2.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><span style="color:black; font-size:12pt"><span style="font-family:Calibri"><span style="">&nbsp;</span>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio 2013
 Solution (.sln) file. </span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span style=""><span style="font-family:Calibri">3.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Press F7 or use
<strong>Build</strong> &gt; <strong>Build Solution</strong> to build the sample. </span>
</span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Run the sample</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in 6pt 42pt; line-height:normal"><span style="color:black; font-size:12pt"><span style="font-family:Calibri">To debug the app and then run it, press F5 or use
<strong>Debug</strong> &gt; <strong>Start Debugging</strong>. To run the app without debugging, press Ctrl&#43;F5 or use
<strong>Debug</strong> &gt; <strong>Start Without Debugging</strong>. </span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal"><span style="font-size:12pt"><span style="font-family:Calibri">&nbsp;</span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal"><strong><span lang="EN" style="font-size:14pt"><span style="font-family:Calibri">SEE ALSO</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt"><span lang="EN" style=""><a href="http://msdn.microsoft.com/en-us/library/windows/apps/hh974580.aspx"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Create your first Windows Store app using C&#43;&#43;</span></a></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
