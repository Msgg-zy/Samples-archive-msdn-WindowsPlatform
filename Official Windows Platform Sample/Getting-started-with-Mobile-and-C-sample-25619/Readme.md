# Getting started with Mobile Services and C++ sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Azure Mobile Services
* Windows Store app
## Topics
* Getting Started
* Windows Azure Mobile Services
## IsPublished
* False
## ModifiedDate
* 2013-10-17 10:01:56
## Description

<p><span lang="EN" style="">&nbsp;</span><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 10pt; line-height:115%"><span style="font-family:Calibri"><span style="line-height:115%; font-size:12pt">An instructional sample app for Windows 8.1 that shows how to add a mobile service to a Windows Store app in Visual Studio using
 C&#43;&#43; and XAML. This is the companion sample for the article </span><span style="color:black"><span style=""><span style="font-size:small">&nbsp;</span></span></span></span><span lang="EN" style=""><a href="http://msdn.microsoft.com/en-us/library/windows/apps/dn263181.aspx"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Quickstart:
 Adding a mobile service using C&#43;&#43;</span></a></span><span style="line-height:115%; font-size:12pt"><span style="font-family:Calibri">.
</span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 0pt"><strong><span lang="EN" style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;"><span style="font-size:small">--</span></span></strong></p>
<p style="margin:0in 0in 0pt">&nbsp;</p>
<p style="margin:0in 0in 0pt"><strong><span lang="EN" style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;"><br>
<span style="font-size:small"></span></span></strong><span style="font-size:small"><span lang="EN" style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;">This sample, and the accompanying documentation,<strong>
</strong></span><span style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;">shows how to create a Windows Azure mobile service and connect it to your Windows Store app using C&#43;&#43; and XAML. This article introduces the following concepts:</span></span></p>
<p style="margin:0in 0in 0pt"><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<ul style="list-style-type:disc; direction:ltr">
<li style="color:#000000; font-style:normal; font-weight:bold">
<p style="color:#000000; line-height:normal; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">Creating a Windows Azure account</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:bold">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">Creating a service on the windowsazure.com dashboard</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">Using the Visual Studio IDE to connect the service to your app</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">Add a table to the service and update the table from your app</span></strong></p>
</li></ul>
<p>&nbsp;</p>
<p style="margin:5pt 0in 6pt; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Operating system requirements</span></span></strong></p>
<p>&nbsp;</p>
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
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in 5pt 0.5in; line-height:normal"><span style="font-size:12pt"><span style="font-family:Calibri">&nbsp;</span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal"><span style="font-size:12pt"><span style="font-family:Calibri">&nbsp;</span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal"><strong><span lang="EN" style="font-size:14pt"><span style="font-family:Calibri">SEE ALSO</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt"><span lang="EN" style=""><a href="http://msdn.microsoft.com/en-us/library/windows/apps/hh974580.aspx"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Create your first Windows Store app using C&#43;&#43;</span></a></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt"><span lang="EN" style=""><a href="http://msdn.microsoft.com/en-us/library/windows/apps/dn263182.aspx"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Quickstart: Adding push notifications for a mobile
 service (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</span></a></span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<div id="_mcePaste" class="mcePaste" style="left:-10000px; top:0px; width:1px; height:1px; overflow:hidden">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 10pt; line-height:115%"><span lang="EN" style=""><span style="font-family:Calibri; font-size:small">Adding a mobile service using C&#43;&#43;</span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 10pt; line-height:115%"><span style="font-family:Calibri"><span style="line-height:115%; font-size:12pt">An instructional sample app for Windows 8.1 that shows how to add a mobile service to a Windows Store app in Visual Studio using
 C&#43;&#43; and XAML. This is the companion sample for the article </span><span style="color:black"><span style=""><span style="font-size:small">&nbsp;</span></span></span></span><span lang="EN" style=""><a href="http://msdn.microsoft.com/en-us/library/windows/apps/dn263181.aspx"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Quickstart:
 Adding a mobile service using C&#43;&#43;</span></a></span><span style="line-height:115%; font-size:12pt"><span style="font-family:Calibri">.
</span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 0pt"><strong><span lang="EN" style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;"><span style="font-size:small">--</span></span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 0pt"><strong><span lang="EN" style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;"><br>
<span style="font-size:small"></span></span></strong><span style="font-size:small"><span lang="EN" style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;">This sample, and the accompanying documentation,<strong>
</strong></span><span style="font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;">shows how to create a Windows Azure mobile service and connect it to your Windows Store app using C&#43;&#43; and XAML. This article introduces the following concepts:</span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<ul style="list-style-type:disc; direction:ltr">
<li style="color:#000000; font-style:normal; font-weight:bold">
<p style="color:#000000; line-height:normal; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">Creating a Windows Azure account</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:bold">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">Creating a service on the windowsazure.com dashboard</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">Using the Visual Studio IDE to connect the service to your app</span></strong></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">Add a table to the service and update the table from your app</span></strong></p>
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong style=""><span style="font-size:12pt">&nbsp;</span></strong></p>
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:6pt; page-break-after:avoid">
<strong><span style="color:black; font-size:12pt">Operating system requirements</span></strong></p>
</li></ul>
<span style="font-family:Times New Roman; font-size:small"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span>
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
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 0in; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Build the sample</span></span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span style=""><span style="font-family:Calibri">1.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Visual Studio 2013 Preview and select File &gt; Open &gt; Project/Solution.
</span></span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span style=""><span style="font-family:Calibri">2.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><span style="color:black; font-size:12pt"><span style="font-family:Calibri"><span style="">&nbsp;</span>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio 2013
 Solution (.sln) file. </span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span style=""><span style="font-family:Calibri">3.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Press F7 or use
<strong>Build</strong> &gt; <strong>Build Solution</strong> to build the sample. </span>
</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Run the sample</span></span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 0in 6pt 42pt; line-height:normal"><span style="color:black; font-size:12pt"><span style="font-family:Calibri">To debug the app and then run it, press F5 or use
<strong>Debug</strong> &gt; <strong>Start Debugging</strong>. To run the app without debugging, press Ctrl&#43;F5 or use
<strong>Debug</strong> &gt; <strong>Start Without Debugging</strong>. </span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 0in 5pt 0.5in; line-height:normal"><span style="font-size:12pt"><span style="font-family:Calibri">&nbsp;</span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 0in; line-height:normal"><span style="font-size:12pt"><span style="font-family:Calibri">&nbsp;</span></span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 0in; line-height:normal"><strong><span lang="EN" style="font-size:14pt"><span style="font-family:Calibri">SEE ALSO</span></span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt"><span lang="EN" style=""><a href="http://msdn.microsoft.com/en-us/library/windows/apps/hh974580.aspx"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Create your first Windows Store app using C&#43;&#43;</span></a></span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt"><span lang="EN" style=""><a href="http://msdn.microsoft.com/en-us/library/windows/apps/dn263182.aspx"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Quickstart: Adding push notifications for a mobile
 service (Windows Store apps using C#/VB/C&#43;&#43; and XAML)</span></a></span></p>
<span style="font-family:Times New Roman; font-size:small"></span></div>
