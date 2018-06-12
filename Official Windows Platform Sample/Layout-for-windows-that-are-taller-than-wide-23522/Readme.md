# Layout for windows that are taller than wide sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* XAML
* Javascript
* HTML5
* Windows Runtime
* XAML with C++
## Topics
* User Interface
## IsPublished
* True
## ModifiedDate
* 2013-10-17 08:42:09
## Description

<h1>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">This sample demonstrates how to design an app that changes from a horizontal layout to a vertical layout any time the app is
 taller than it is wide. The app layout adapts and reflows content when the user resizes the window to any size, down to the minimum width.</span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">--</span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:9.5pt">For more information about the programming models, platforms, languages, and APIs demonstrated in this sample, please refer to the
 guidance, tutorials, and reference topics provided in the Windows 8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to indicate or demonstrate the functionality of the programming models and feature APIs for
 Windows 8.1 and/or Windows Server 2012 R2.</span></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:14pt">Related topics</span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"><a href="http://go.microsoft.com/fwlink/p/?LinkID=309347"><span style="color:#0563c1">Layout for windows that are taller than wide
 sample</span></a></span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"><a href="http://go.microsoft.com/fwlink/p/?LinkId=311826"><span style="color:#0563c1">Quickstart: Designing apps for different
 window sizes</span></a></span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"><a href="http://go.microsoft.com/fwlink/p/?LinkId=311830"><span style="color:#0563c1">Guidelines for window sizes and scaling to
 screens</span></a></span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"><a href="http://go.microsoft.com/fwlink/p/?LinkId=311831"><span style="color:#0563c1">Guidelines for resizing windows to tall and
 narrow layouts</span></a> </span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in 6pt; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:14pt">Operating system requirements</span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span><span style="font-family:Times New Roman"></span>
<table border="0" cellpadding="0" cellspacing="0" style="border-collapse:collapse">
<tbody>
<tr style="">
<td width="77" style="padding:0in 0.5pt; border:#000000; width:0.8in; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 6pt; text-align:center; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">Client</span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span></td>
<td width="256" style="padding:0in 0.5pt; border:#000000; width:192pt; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 6pt; line-height:normal"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">Windows 8.1
</span></p>
<span style="font-family:Times New Roman; font-size:small"></span></td>
</tr>
<tr style="">
<td width="77" style="padding:0in 0.5pt; border:#000000; width:0.8in; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 6pt; text-align:center; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">Server</span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span></td>
<td width="256" style="padding:0in 0.5pt; border:#000000; width:192pt; background-color:transparent">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:5pt 6pt; line-height:normal"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">Windows Server 2012 R2
</span></p>
<span style="font-family:Times New Roman; font-size:small"></span></td>
</tr>
</tbody>
</table>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in; line-height:normal; page-break-after:avoid"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:14pt">Build the sample</span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:16pt"><span style="">1.<span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;
</span></span></span><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">Visual Studio 2013 Preview and select File &gt; Open &gt; Project/Solution.
</span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:16pt"><span style="">2.<span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;
</span></span></span><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"><span style="">&nbsp;</span>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio 2013
 Solution (.sln) file. </span></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt 42pt; line-height:normal; text-indent:-0.25in"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:16pt"><span style="">3.<span style="font:7pt/normal &quot;Times New Roman&quot;">&nbsp;
</span></span></span><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">Press F7 or use
<strong>Build</strong> &gt; <strong>Build Solution</strong> to build the sample. </span>
</p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:14pt">Run the sample</span></strong></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:5pt 0in 6pt 42pt; line-height:normal"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">To debug the app and then run it, press F5 or use
<strong>Debug</strong> &gt; <strong>Start Debugging</strong>. To run the app without debugging, press Ctrl&#43;F5 or use
<strong>Debug</strong> &gt; <strong>Start Without Debugging</strong>. </span></p>
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
<span style="font-family:Times New Roman; font-size:small">&nbsp;</span></p>
<span style="font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:24pt">
<p class="MsoNormal" style="margin:5pt 0in; line-height:normal; page-break-after:avoid">
&nbsp;</p>
<p style="margin:0in 0in 8pt; line-height:normal">&nbsp;</p>
</span></h1>
<div id="_mcePaste" class="mcePaste" style="left:-10000px; top:0px; width:1px; height:1px; overflow:hidden">
</div>
