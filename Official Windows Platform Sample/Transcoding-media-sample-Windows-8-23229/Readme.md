# Transcoding media sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Audio and video
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:25:20
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br207105">
<b>Windows.Media.Transcoding</b></a> API to transcode a video file in a Windows Store app. . Transcoding is the conversion of a digital media file, such as a video or audio file, from one format to another. For example, you might convert a Windows Media file
 to MP4 so that it can be played on a portable device that supports MP4 format. Or, you might convert a high-definition video file to a lower resolution. In that case, the re-encoded file might use the same codec as the original file, but it would have a different
 encoding profile.</p>
<p>This sample covers the following scenarios:</p>
<ul>
<li>Converting a video file from one resolution to another resolution. </li><li>Converting a video file using a custom output format. </li><li>Creating a clip from a video using the <a href="http://msdn.microsoft.com/library/windows/apps/br207080_trimstarttime">
<b>TrimStart</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br207080_trimstoptime">
<b>TrimStop</b></a> API. </li></ul>
<p></p>
<p>Some of the transcode API covered in this sample are: </p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br207105"><b>Windows.Media.Transcoding</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br207080"><b>MediaTranscoder</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br207080_preparefiletranscodeasync"><b>MediaTranscoder.PrepareFileTranscodeAsync</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh700941"><b>PrepareTranscodeResult</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh700941_transcodeasync"><b>PrepareTranscodeResult.TranscodeAsync</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh701026"><b>MediaProperties.MediaEncodingProfile</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br207080_trimstarttime"><b>TrimStart</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br207080_trimstoptime"><b>TrimStop</b></a>
</li></ul>
<p>For more info about transcoding video files in Windows Store apps, see <a href="http://msdn.microsoft.com/library/windows/apps/hh452795">
Quickstart: transcoding</a> and <a href="http://msdn.microsoft.com/library/windows/apps/hh452776">
How to trim a video file</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Roadmaps</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for apps using C# and Visual Basic</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465037">Roadmap for apps using JavaScript</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700360">Roadmap for apps using C&#43;&#43;</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh767284">Designing UX for apps</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465134">Adding multimedia</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452795">Quickstart: transcoding</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452776">How to trim a video file</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207105"><b>Windows.Media.Transcoding</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207080"><b>MediaTranscoder</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207080_preparefiletranscodeasync"><b>MediaTranscoder.PrepareFileTranscodeAsync</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700941"><b>PrepareTranscodeResult</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700941_transcodeasync"><b>PrepareTranscodeResult.TranscodeAsync</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701026"><b>MediaProperties.MediaEncodingProfile</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207080_trimstarttime"><b>TrimStart</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207080_trimstoptime"><b>TrimStop</b></a>
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
<li>
<p>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.</p>
</li><li>
<p>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
