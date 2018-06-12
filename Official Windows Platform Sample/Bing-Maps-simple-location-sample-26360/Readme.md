# Bing Maps simple location sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
* Bing Maps
## Topics
* Bing Maps
* Geolocation
## IsPublished
* True
## ModifiedDate
* 2013-12-11 10:50:18
## Description

<h1><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">This sample shows you how to display your location using the Bing Maps SDK&nbsp;in a Windows Store app.&nbsp;
</span></h1>
<p><span style="font-family:Times New Roman; font-size:small"></span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">For complete details about creating this sample, plus a short overview video, see
</span><a href="http://go.microsoft.com/fwlink/p/?LinkID=273827"><span style="color:blue; font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">How to display your location on a Bing Map</span></a><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">.</span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">(Note:&nbsp; This project defaults to the &lsquo;ARM&rsquo; as the Active Solution Platform.&nbsp; To change this setting to &lsquo;x64&rsquo;
 or &lsquo;x86&rsquo;, go to the Build menu, select Configuration Manager and set the desired Active Solution Platform.)</span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"></span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">To use the sample, you must first download and install the
</span><a href="http://go.microsoft.com/fwlink/p/?linkid=268360"><span style="color:blue; font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Bing Maps SDK for Windows Store apps</span></a><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">.
 You must also register as a user on the </span><a href="http://go.microsoft.com/fwlink/p/?linkid=187187"><span style="color:blue; font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Bing Maps Portal</span></a><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">
 and then follow the instructions for </span><a href="http://go.microsoft.com/fwlink/p/?LinkID=198152"><span style="color:blue; font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Getting a Bing Maps Key</span></a><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">.
 You insert your Bing Maps Key in the <strong>Credentials </strong>attribute of the Bing Maps control.&nbsp;</span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">The sample demonstrates how to:</span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<ul type="disc">
<span style="font-family:Times New Roman; font-size:small"></span>
<li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Set the active platform to ARM, x86, or x64.</span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Add references to Bing Maps for C#, C&#43;&#43;, or Visual Basic and Microsoft Visual C&#43;&#43; Runtime Package.</span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Enable the location capability.</span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Set the location icon based on the accuracy of the location data.</span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Set up a cancellation token so that the user can cancel location acquisition if the operation is taking too long.
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Get the location asynchronously.
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Set the map to the location.
</span><span style="font-family:Times New Roman; font-size:small"></span></li></ul>
<p><span style="font-family:Times New Roman; font-size:small"></span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt"></span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Build the Sample</span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"></span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">To build this sample, open the solution (.sln) file titled SimpleMapping.sln from Visual Studio 2013 (any SKU). Select Build-&gt;Build
 Solution from the top menu after the sample has loaded. You must have the Bing Maps SDK installed to successfully build this project.</span></p>
<p><span style="font-family:Times New Roman; font-size:small"></span></p>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Run the Sample</span></strong></p>
<p><span style="font-family:Times New Roman; font-size:small"></span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">To run this sample after building it, press F5 (run with debugging enabled) or Ctrl-F5 (run without debugging enabled) from
 Visual Studio 2013 (any SKU). (Or select the corresponding options from the Debug menu.)</span></p>
<div id="_mcePaste" class="mcePaste" style="left:-10000px; top:1px; width:1px; height:1px; overflow:hidden">
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">This sample shows you how to display your location using the Bing Maps SDK&nbsp;in a Windows Store app.&nbsp;
</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">For complete details about creating this sample, plus a short overview video, see
</span><a href="http://go.microsoft.com/fwlink/p/?LinkID=273827"><span style="color:blue; font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">How to display your location on a Bing Map</span></a><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">.</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 12pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">&nbsp;</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">(Note:&nbsp; This project defaults to the &lsquo;ARM&rsquo; as the Active Solution Platform.&nbsp; To change this setting to &lsquo;x64&rsquo;
 or &lsquo;x86&rsquo;, go to the Build menu, select Configuration Manager and set the desired Active Solution Platform.)</span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">&nbsp;</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">To use the sample, you must first download and install the
</span><a href="http://go.microsoft.com/fwlink/p/?linkid=268360"><span style="color:blue; font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Bing Maps SDK for Windows Store apps</span></a><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">.
 You must also register as a user on the </span><a href="http://go.microsoft.com/fwlink/p/?linkid=187187"><span style="color:blue; font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Bing Maps Portal</span></a><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">
 and then follow the instructions for </span><a href="http://go.microsoft.com/fwlink/p/?LinkID=198152"><span style="color:blue; font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Getting a Bing Maps Key</span></a><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">.
 You insert your Bing Maps Key in the <strong>Credentials </strong>attribute of the Bing Maps control.&nbsp;</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">&nbsp;</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">The sample demonstrates how to:</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">&nbsp;</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<ul type="disc">
<span style="font-family:Times New Roman; font-size:small"></span>
<li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Set the active platform to ARM, x86, or x64.</span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Add references to Bing Maps for C#, C&#43;&#43;, or Visual Basic and Microsoft Visual C&#43;&#43; Runtime Package.</span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Enable the location capability.</span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Set the location icon based on the accuracy of the location data.</span><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Set up a cancellation token so that the user can cancel location acquisition if the operation is taking too long.
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Get the location asynchronously.
</span><span style="font-family:Times New Roman; font-size:small"></span></li><li style="margin:0in 0in 8pt; color:#000000; line-height:normal; font-style:normal; font-weight:normal">
<span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Set the map to the location.
</span><span style="font-family:Times New Roman; font-size:small"></span></li></ul>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt"><br>
<br>
&nbsp;</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Build the Sample</span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">To build this sample, open the solution (.sln) file titled SimpleMapping.sln from Visual Studio 2013 (any SKU). Select Build-&gt;Build Solution
 from the top menu after the sample has loaded. You must have the Bing Maps SDK installed to successfully build this project.</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 0pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:12pt">&nbsp;</span></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><strong><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">Run the Sample</span></strong></p>
<span style="font-family:Times New Roman; font-size:small"></span>
<p style="margin:0in 0in 8pt; line-height:normal"><span style="font-family:&quot;Segoe UI&quot;,&quot;sans-serif&quot;; font-size:13.5pt">To run this sample after building it, press F5 (run with debugging enabled) or Ctrl-F5 (run without debugging enabled) from Visual Studio 2013
 (any SKU). (Or select the corresponding options from the Debug menu.)</span></p>
<span style="font-family:Times New Roman; font-size:small"></span></div>
