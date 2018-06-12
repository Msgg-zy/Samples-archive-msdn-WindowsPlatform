# Creating a ThreadPool work item sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Store app
## Topics
* threading
* App model
## IsPublished
* True
## ModifiedDate
* 2013-10-25 03:33:24
## Description

<h1><span style="font-family:Times New Roman; font-size:small">&nbsp;</span>
<p><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small">This sample demonstrates how to use a ThreadPool work item.</span></span></p>
<p><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small">Specifically, this sample shows how to create the work item, manage cancellation, and handle work item completion. For a step-by-step walkthrough of this code, see the
</span><a href="http://go.microsoft.com/fwlink/?LinkID=327565"><span style="color:#0000ff; font-size:small">Quickstart: Submitting a work item to the thread pool</span></a><span style="font-size:small">.</span></span></p>
<p style="margin:0in 0in 0pt"><strong><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small">--</span></span></strong></p>
<p style="margin:0in 0in 0pt"><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:9.5pt">For more information about the programming models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials,
 and reference topics provided in the Windows 8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to indicate or demonstrate the functionality of the programming models and feature APIs for Windows 8.1 and/or
 Windows Server 2012 R2.</span></p>
</h1>
<h3 style="margin:1em 0in"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:medium">Related topics</span></span></h3>
<h1>
<p style="margin:0in 0in 0pt"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small"><a href="http://go.microsoft.com/fwlink/?LinkID=327565"><span style="color:#0000ff">Quickstart: Submitting a work item to the thread pool</span></a></span></span></p>
</h1>
<h3 style="margin:1em 0in"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:medium">Operating system requirements</span></span></h3>
<h1>
<table border="0" cellpadding="0">
<tbody>
<tr>
<td style="padding:0.75pt; border:#000000; background-color:transparent">
<p style="margin:0in 0in 0pt; text-align:center"><strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small">Client</span></span></strong></p>
</td>
<td style="padding:0.75pt; border:#000000; background-color:transparent">
<p style="margin:0in 0in 0pt"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small">Windows&nbsp;8</span></span></p>
</td>
</tr>
<tr>
<td style="padding:0.75pt; border:#000000; background-color:transparent">
<p style="margin:0in 0in 0pt; text-align:center"><strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small">Server</span></span></strong></p>
</td>
<td style="padding:0.75pt; border:#000000; background-color:transparent">
<p style="margin:0in 0in 0pt"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small">Windows Server&nbsp;2012</span></span></p>
</td>
</tr>
</tbody>
</table>
</h1>
<h3 style="margin:1em 0in"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:medium">Build the sample</span></span></h3>
<h1>
<ol type="1">
<li style="margin:0in 0in 0pt; color:#000000; font-style:normal"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:small">Start Visual Studio&nbsp;2012 (or higher) and select
<strong>File</strong> &gt; <strong>Open</strong> &gt; <strong>Project/Solution</strong>.</span>
</li><li style="margin:0in 0in 0pt; color:#000000; font-style:normal"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:small">Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2012
 solution (.sln) file.</span> <span style="font-family:Times New Roman; font-size:small">
</span></li><li style="margin:0in 0in 0pt; color:#000000; font-style:normal"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:small">Press F7 or use
<strong>Build</strong> &gt; <strong>Build Solution</strong> to build the sample</span>.</span>
</li></ol>
</h1>
<h3 style="margin:1em 0in"><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><span style="font-size:medium">Run the sample</span></span></h3>
<h1><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:small">To debug the app and then run it, press F5 or use
<strong>Debug</strong> &gt; <strong>Start Debugging</strong>. To run the app without debugging, press Ctrl&#43;F5 or use
<strong>Debug</strong> &gt; <strong>Start Without Debugging</strong></span></h1>
<div class="mcePaste" id="_mcePaste" style="left:-10000px; top:0px; width:1px; height:1px; overflow:hidden">
</div>
