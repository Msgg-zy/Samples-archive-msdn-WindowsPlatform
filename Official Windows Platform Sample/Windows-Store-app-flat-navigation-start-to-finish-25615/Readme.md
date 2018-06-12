# Windows Store app flat navigation, start to finish sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Visual Studio 2013
* Windows Store app
## Topics
* User Interface
* Getting Started
* User Experience
## IsPublished
* True
## ModifiedDate
* 2014-10-17 08:20:35
## Description

<h1><span style="font-size:small"><span style="font-family:Calibri">An instructional sample app for Windows 8.1 that demonstrates the flat navigation pattern and meets all basic Windows Store certification requirements. This is the companion sample for the
</span><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=316374"><span style="color:#0000ff; font-family:Times New Roman">Flat navigation, start to finish (HTML)</span></a><span style="font-family:Calibri"> and
</span><a href="http://go.microsoft.com/fwlink/?LinkID=327893"><span style="color:#0000ff; font-family:Times New Roman">Flat navigation, start to finish (XAML)</span></a><span style="font-family:Calibri">
</span></span><span style="font-family:Calibri">topics.</span></span></h1>
<p><span style="font-family:Calibri; font-size:small"><strong>Note:</strong> The sample is also available in template form through a VSIX template installer. Use the Visual Studio app template for your language (C#/XAML or HTML/JavaScript) as a starting point
 for your Windows Store apps.</span></p>
<p><span style="font-family:Times New Roman; font-size:small">&nbsp;</span><strong><span lang="EN"><br>
<span style="font-family:Calibri; font-size:small">&nbsp;</span></span></strong><span style="font-family:Calibri; font-size:small">Use a flat navigation pattern for your Windows Store app when it has a small number of pages and its information is not organized
 in a hierarchy. In other words, when the pages, tabs, and modes are logical peers.</span></p>
<p><span style="font-family:Calibri; font-size:small">Here, we cover how to create a Windows Store app using JavaScript that uses the flat navigation pattern and meets all basic Windows Store certification requirements, from start to finish. This includes:
</span></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<ul style="list-style-type:disc; direction:ltr">
<li style="color:#000000; font-style:normal; font-weight:normal">
<p style="color:#000000; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<span style="font-size:small"><strong>Image resources</strong> to expose your app throughout the operating system</span></p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<span style="font-size:small"><strong>App bars</strong> to support navigation and commanding</span></p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<span style="font-size:small"><strong>Data roaming</strong> to sync your app across sessions and devices</span></p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<span style="font-size:small"><strong>Settings</strong> to provide privacy, help, and other app info</span></p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<span style="font-size:small"><strong>Globalization</strong> to reach customers in countries and regions around the world</span></p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:8pt">
<span style="font-size:small"><strong>Accessibility</strong> to help users accomplish tasks regardless of physical ability and input<span>&nbsp;
</span>device</span></p>
</li></ul>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 8pt"><span style="font-size:small"><span style="font-family:Calibri">This sample includes everything discussed in the
</span><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=316374"><span style="color:#0000ff; font-family:Times New Roman">Flat navigation, start to finish (HTML)</span></a></span><span style="font-family:Calibri"> and
</span><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=327893"><span style="color:#0000ff; font-family:Times New Roman">Flat navigation, start to finish (XAML)</span></a><span style="font-family:Calibri">
</span></span><span style="font-family:Calibri">topics.</span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:5pt 0in 6pt; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Operating system requirements</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p><span style="font-family:Times New Roman">&nbsp;</span><span style="font-family:Times New Roman">&nbsp;</span><span style="font-family:Times New Roman">&nbsp;</span><span style="font-family:Times New Roman">&nbsp;</span><span style="font-family:Times New Roman">&nbsp;</span><span style="font-family:Times New Roman">&nbsp;</span><span style="font-family:Times New Roman">&nbsp;</span><span style="font-family:Times New Roman">&nbsp;</span><span style="font-family:Times New Roman">&nbsp;</span></p>
<table border="0" cellspacing="0" cellpadding="0" style="border-collapse:collapse">
<tbody>
<tr>
<td width="77" style="padding:0in 0.5pt; border:#000000; width:0.8in; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small">&nbsp;</span>
<p style="margin:5pt 6pt; text-align:center; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Client</span></span></strong></p>
<span style="font-family:Times New Roman; font-size:small">&nbsp;</span></td>
<td width="256" style="padding:0in 0.5pt; border:#000000; width:192pt; background-color:transparent">
<p style="margin:5pt 6pt; line-height:normal"><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Windows 8.1
</span></span></p>
</td>
</tr>
<tr>
<td width="77" style="padding:0in 0.5pt; border:#000000; width:0.8in; background-color:transparent">
<p style="margin:5pt 6pt; text-align:center; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Server</span></span></strong></p>
</td>
<td width="256" style="padding:0in 0.5pt; border:#000000; width:192pt; background-color:transparent">
<p style="margin:5pt 6pt; line-height:normal"><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Windows Server 2012 R2
</span></span></p>
</td>
</tr>
</tbody>
</table>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:5pt 0in; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Build the sample</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span><span style="font-family:Calibri">1.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Visual Studio 2013 Preview and select File &gt; Open &gt; Project/Solution.
</span></span></strong><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span><span style="font-family:Calibri">2.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><span style="color:black; font-size:12pt"><span style="font-family:Calibri"><span>&nbsp;</span>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio 2013 Solution
 (.sln) file. </span></span><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span><span style="font-family:Calibri">3.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Press F7 or use
<strong>Build</strong> &gt; <strong>Build Solution</strong> to build the sample. </span>
</span></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Run the sample</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:5pt 0in 6pt 42pt; line-height:normal"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:small">To debug the app and then run it, press F5 or use
<strong>Debug</strong> &gt; <strong>Start Debugging</strong>. To run the app without debugging, press Ctrl&#43;F5 or use
<strong>Debug</strong> &gt; <strong>Start Without Debugging</strong>. </span></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 8pt"><span style="font-family:Calibri; font-size:small">&nbsp;</span><strong><span lang="EN" style="line-height:107%; font-size:14pt"><span style="font-family:Calibri">SEE ALSO</span></span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 8pt"><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=316374"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Flat navigation, start to finish (HTML)</span></a></span></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<p style="margin:0in 0in 8pt"><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=327893"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Flat navigation, start to finish (XAML)</span></a><span style="font-family:Calibri; font-size:small">
</span></span></p>
<p><span style="font-family:Times New Roman; font-size:small"><br>
</span></p>
<div class="mcePaste" id="_mcePaste" style="left:-10000px; top:0px; width:1px; height:1px; overflow:hidden">
<p style="margin:0in 0in 8pt"><span style="font-size:small"><span style="font-family:Calibri">An instructional sample app for Windows 8.1 that demonstrates the flat navigation pattern and meets all basic Windows Store certification requirements. This is the
 companion sample for the </span><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=316374"><span style="color:#0000ff; font-family:Times New Roman">Flat navigation, start to finish (HTML)</span></a><span style="font-family:Calibri">
 and </span><a href="http://go.microsoft.com/fwlink/?LinkID=327893"><span style="color:#0000ff; font-family:Times New Roman">Flat navigation, start to finish (XAML)</span></a><span style="font-family:Calibri">
</span></span><span style="font-family:Calibri">topics.</span></span></p>
<p style="margin:0in 0in 8pt"><span style="font-family:Calibri; font-size:small">Note: The sample is also available in template form through a VSIX template installer. Use the Visual Studio app template for your language (C#/XAML or HTML/JavaScript) as a starting
 point for your Windows Store apps.</span></p>
<p style="margin:0in 0in 8pt"><strong><span lang="EN"><br>
</span></strong><span style="font-family:Calibri; font-size:small">Use a flat navigation pattern for your Windows Store app when it has a small number of pages and its information is not organized in a hierarchy. In other words, when the pages, tabs, and modes
 are logical peers.</span></p>
<p style="margin:0in 0in 8pt"><span style="font-family:Calibri; font-size:small">Here, we cover how to create a Windows Store app using JavaScript that uses the flat navigation pattern and meets all basic Windows Store certification requirements, from start
 to finish. This includes: </span></p>
<ul style="list-style-type:disc; direction:ltr">
<li style="color:#000000; font-style:normal; font-weight:normal">
<p style="color:#000000; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<strong>Image resources</strong> to expose your app throughout the operating system</p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<strong>App bars</strong> to support navigation and commanding</p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<strong>Data roaming</strong> to sync your app across sessions and devices</p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<strong>Settings</strong> to provide privacy, help, and other app info</p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:0pt">
<strong>Globalization</strong> to reach customers in countries and regions around the world</p>
</li><li style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal">
<p style="color:#000000; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:8pt">
<strong>Accessibility</strong> to help users accomplish tasks regardless of physical ability and input<span>&nbsp;
</span>device</p>
</li></ul>
<p style="margin:0in 0in 8pt"><span style="font-size:small"><span style="font-family:Calibri">This sample includes everything discussed in the
</span><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=316374"><span style="color:#0000ff; font-family:Times New Roman">Flat navigation, start to finish (HTML)</span></a></span><span style="font-family:Calibri"> and
</span><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=327893"><span style="color:#0000ff; font-family:Times New Roman">Flat navigation, start to finish (XAML)</span></a><span style="font-family:Calibri">
</span></span><span style="font-family:Calibri">topics.</span></span></p>
<p style="margin:5pt 0in 6pt; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Operating system requirements</span></span></strong></p>
<table border="0" cellspacing="0" cellpadding="0" style="border-collapse:collapse">
<tbody>
<tr>
<td width="77" style="padding:0in 0.5pt; border:#000000; width:0.8in; background-color:transparent">
<p style="margin:5pt 6pt; text-align:center; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Client</span></span></strong></p>
</td>
<td width="256" style="padding:0in 0.5pt; border:#000000; width:192pt; background-color:transparent">
<p style="margin:5pt 6pt; line-height:normal"><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Windows 8.1
</span></span></p>
</td>
</tr>
<tr>
<td width="77" style="padding:0in 0.5pt; border:#000000; width:0.8in; background-color:transparent">
<p style="margin:5pt 6pt; text-align:center; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Server</span></span></strong></p>
</td>
<td width="256" style="padding:0in 0.5pt; border:#000000; width:192pt; background-color:transparent">
<p style="margin:5pt 6pt; line-height:normal"><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Windows Server 2012 R2
</span></span></p>
</td>
</tr>
</tbody>
</table>
<p style="margin:5pt 0in; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Build the sample</span></span></strong></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span><span style="font-family:Calibri">1.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Visual Studio 2013 Preview and select File &gt; Open &gt; Project/Solution.
</span></span></strong></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span><span style="font-family:Calibri">2.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><span style="color:black; font-size:12pt"><span style="font-family:Calibri"><span>&nbsp;</span>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio 2013 Solution
 (.sln) file. </span></span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-size:16pt"><span><span style="font-family:Calibri">3.</span><span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;&nbsp;&nbsp;
</span></span></span><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Press F7 or use
<strong>Build</strong> &gt; <strong>Build Solution</strong> to build the sample. </span>
</span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="color:black; font-size:12pt"><span style="font-family:Calibri">Run the sample</span></span></strong></p>
<p style="margin:5pt 0in 6pt 42pt; line-height:normal"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">To debug the app and then run it, press F5 or use
<strong>Debug</strong> &gt; <strong>Start Debugging</strong>. To run the app without debugging, press Ctrl&#43;F5 or use
<strong>Debug</strong> &gt; <strong>Start Without Debugging</strong>. </span></p>
<p style="margin:0in 0in 8pt"><span style="font-family:Calibri; font-size:small">&nbsp;</span></p>
<p style="margin:0in 0in 8pt"><strong><span lang="EN"><br>
</span></strong><strong><span lang="EN" style="line-height:107%; font-size:14pt"><span style="font-family:Calibri">SEE ALSO</span></span></strong></p>
<p style="margin:0in 0in 8pt"><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=316374"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Flat navigation, start to finish (HTML)</span></a></span></p>
<p style="margin:0in 0in 8pt"><span style="color:black"><a href="http://go.microsoft.com/fwlink/?LinkID=327893"><span style="color:#0000ff; font-family:Times New Roman; font-size:small">Flat navigation, start to finish (XAML)</span></a><span style="font-family:Calibri; font-size:small">
</span></span></p>
</div>
