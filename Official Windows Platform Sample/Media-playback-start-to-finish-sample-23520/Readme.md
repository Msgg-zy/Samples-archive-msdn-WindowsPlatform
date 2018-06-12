# Media playback start-to-finish sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* C#
* XAML
## Topics
* Media
## IsPublished
* True
## ModifiedDate
* 2013-10-17 07:49:57
## Description

<h1><span style="font-family:Times New Roman; font-size:small"><span style="font-size:small">&nbsp;</span><span style="line-height:115%; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"><span style="font-family:Times New Roman">
</span>
<p style="margin:0in 0in 10pt; line-height:115%"><span style="line-height:115%; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">An instructional media sample app for Windows 8.1 Preview that implements common and advanced features for playing audio and video.
 This is the companion sample for the </span><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><a href="http://go.microsoft.com/fwlink/?/p/LinkID=310162"><span style=""><span style="color:#0000ff; font-family:Times New Roman">Media playback, start
 to finish</span></span></a> </span><span style="line-height:115%; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">article.
</span></p>
<span style="font-family:Times New Roman"></span>
<p style="margin:0in 0in 0pt"><strong><span lang="EN" style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><br>
</span></strong><span lang="EN" style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;">This sample, and the accompanying
</span><span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:11pt"><a href="http://go.microsoft.com/fwlink/?LinkID=310162"><span style=""><span style="color:#0000ff; font-family:Times New Roman">Media playback, start to finish</span></span></a>
</span><span lang="EN" style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;">documentation,<strong>
</strong></span><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;">goes over how to create a Windows Store app using C# loaded with media features, from start to finish. There are lots of improvements in Windows 8.1 Preview that make this even easier than before,
 such as the new transport controls for the <strong><a href="http://msdn.microsoft.com/en-US/library/windows/apps/windows.ui.xaml.controls.mediaelement"><span style=""><span style="color:#0000ff; font-family:Times New Roman">MediaElement</span></span></a></strong>
 class. We'll cover those, plus:</span></p>
<span style="font-family:Times New Roman"></span>
<ul style="list-style-type:disc; direction:ltr">
<li style="color:#000000; font-size:12pt; font-style:normal">
<p style="color:#000000; line-height:normal; font-size:11pt; font-style:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">Media playback basics</span></strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"> like creating a
</span><strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><a href="http://msdn.microsoft.com/en-US/library/windows/apps/windows.ui.xaml.controls.mediaelement"><span style=""><span style="color:#0000ff; font-family:Times New Roman">MediaElement</span></span></a></span></strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">,
 enabling the transport controls, and loading media files from either the device or the network.
</span></p>
</li><li style="color:#000000; font-family:&quot;Times New Roman&quot;,&quot;serif&quot;; font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">Media playback features</span></strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"> like properly preventing the screen from dimming, playing audio in the background,
 interacting with the system media transport controls, resizing video, creating custom transport controls, and enabling full-window rendering.
</span></p>
</li><li style="font-size:12pt; font-style:normal; font-weight:normal">
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">App basics</span></strong><span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt"> like preserving app state, creating UI on the app bar, creating Settings flyouts, and animating
 UI. </span></p>
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">&nbsp;</span></p>
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<span style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:12pt">This sample includes all the things that are discussed in the Media playback, start to finish topic.</span><strong><span lang="EN" style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><br style="">
<br style="">
</span></strong></p>
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span lang="EN" style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:14pt">&nbsp;</span></strong></p>
<p style="color:#000000; line-height:normal; font-family:&quot;Calibri&quot;,&quot;sans-serif&quot;; font-size:11pt; font-style:normal; font-weight:normal; margin-top:5pt; margin-bottom:5pt">
<strong><span lang="EN" style="font-family:&quot;Arial&quot;,&quot;sans-serif&quot;; font-size:14pt">See Also</span></strong></p>
<p style="font-size:11pt; font-style:normal; font-weight:normal; margin-top:0in; margin-bottom:8pt">
<span style="color:black; font-family:&quot;Arial&quot;,&quot;sans-serif&quot;"><a href="http://go.microsoft.com/fwlink/?LinkID=310162"><span style=""><span style="color:#0000ff; font-family:Times New Roman">Media playback, start to finish</span></span></a></span></p>
</li></ul>
</span></span></h1>
<div id="_mcePaste" class="mcePaste" style="left:-10000px; top:43px; width:1px; height:1px; overflow:hidden">
</div>
