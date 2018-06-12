# Media Hub sample app
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* video
* Media
* Audio
* Capture
* PlayTo
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:28:41
## Description

<div id="mainSection">
<p>This sample a rich multimedia app for Windows&nbsp;8.1. It plays, records, and converts audio, video, and images and it streams media to Play To devices.
</p>
<p>For a more detailed walk through of this sample, see the <a href="http://msdn.microsoft.com/library/windows/apps/dn263106">
MediaHub sample app</a> article in the <a href="http://msdn.microsoft.com/library/windows/apps/dn263104">
End-to-end sample apps</a> documentation.</p>
<p>Specifically, this sample shows how to: </p>
<ul>
<li>
<p><b>Camera Capture UI</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br241030"><b>CameraCaptureUI</b></a> control to record and trim video and take photos from a camera attached to the device.</p>
<p>For more info on using the <a href="http://msdn.microsoft.com/library/windows/apps/br241030">
<b>CameraCaptureUI</b></a> see <a href="http://msdn.microsoft.com/library/windows/apps/hh465152">
Quickstart: capturing a photo or video using the camera capture UI</a> and <a href="http://msdn.microsoft.com/library/windows/apps/hh452758">
Guidelines for the camera UI</a>.</p>
</li><li>
<p><b>Audio recording</b></p>
<p>Captures audio recordings using the <a href="http://msdn.microsoft.com/library/windows/apps/br241124">
<b>MediaCapture</b></a> class.</p>
<p>For more info on recording audio in a Windows Store app using JavaScript see <a href="http://msdn.microsoft.com/library/windows/apps/hh452798">
How to record audio or video</a>.</p>
</li><li>
<p><b>Converting media</b></p>
<p>Converts audio and video files to different media formats using the <a href="http://msdn.microsoft.com/library/windows/apps/br207080">
<b>Transcoder</b></a>.</p>
<p>For more info on using the <a href="http://msdn.microsoft.com/library/windows/apps/br207080">
<b>Transcoder</b></a> see <a href="http://msdn.microsoft.com/library/windows/apps/hh452795">
Quickstart: transcoding video files</a>.</p>
</li><li>
<p><b>Plays local video and audio and view picture images.</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/hh767373"><b>audio</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/hh767390"><b>video</b></a> objects to play audio and video files and view pictures stored on the local machine or Microsoft SkyDrive .</p>
<p>For more info on playing video in a Windows Store app see <a href="http://msdn.microsoft.com/library/windows/apps/hh452793">
Quickstart: playing video in an app</a>.</p>
</li><li>
<p><b>Plays video and audio from the network </b></p>
<p>Demonstrates how to play audio and video media from the internet using a web URL.</p>
</li><li>
<p><b>Video Stabilization</b></p>
<p>Demonstrates how to add the built-in <a href="http://msdn.microsoft.com/library/windows/apps/hh700862">
<b>videoStabilization</b></a> effect to video.</p>
</li><li>
<p><b>System media transport controls</b></p>
<p>Demonstrators how hook into the new <a href="http://msdn.microsoft.com/library/windows/apps/dn278677">
<b>SystemMediaTransportControls</b></a> for Windows&nbsp;8.1, which replace the <a href="http://msdn.microsoft.com/library/windows/apps/hh700786">
<b>MediaControl</b></a> class. These are the transport controls that are displayed when a hardware media key is pressed, such as the volume button on a pair of headphones.
</p>
<p>For more info on the <a href="http://msdn.microsoft.com/library/windows/apps/dn278677">
<b>SystemMediaTransportControls</b></a> see <a href="http://msdn.microsoft.com/library/windows/apps/dn263187">
How to use the system media transport controls</a> and the <a href="http://go.microsoft.com/fwlink/p/?LinkID=309020">
System media transport controls sample</a>.</p>
</li><li>
<p><b>Background Audio</b></p>
<p>Demonstrates how to implement background audio. Normally when a Windows Store app that is playing audio goes to the background, the app will automatically be muted. But many music apps want to continue to play audio when they are in the background, so the
 user can continue to listen to the music while they use other apps. </p>
<p>For more info on playing audio in the background see <a href="http://msdn.microsoft.com/library/windows/apps/hh700367">
How to play audio in the background</a>.</p>
</li><li>
<p><b>3D Video</b></p>
<p>Demonstrates how to render 3-D video. This requires support from the hardware and the media. The following API are used to determine if 3D playback is supported and set the 3D render mode.
</p>
</li><li>
<p><b>PlayTo Manager</b></p>
<p>Demonstrates how to implement Play To using the <a href="http://msdn.microsoft.com/library/windows/apps/br206972">
<b>PlayToManager</b></a> class and how to invoke the charm programmatically using the
<a href="http://msdn.microsoft.com/library/windows/apps/br206974"><b>PlayToManager.ShowPlayToUI</b></a>.</p>
<p>For mor info on setting up Play To see <a href="http://msdn.microsoft.com/library/windows/apps/hh465176">
Streaming media to devices using Play To</a>.</p>
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=226859">XAML media playback sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=242136">Transcoding media sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241428">Media capture sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=249441">Camera capture UI sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=228588 ">Camera options UI sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231541 ">Device enumeration sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241427">Media extension sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=245973">Real-Time communication sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=245166">Media Play To sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=245167">PlayToReceiver sample</a>
</dt><dt><a href="http://code.msdn.microsoft.com/windowsapps/Playback-Manager-e6526e67">Playback manager sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=309019">Effects discovery sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=309021">MediaStreamSource streaming sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=309020">System media transport controls sample</a>
</dt></dl>
<h2>Operating system requirements</h2>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8.1 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012&nbsp;R2 </dt></td>
</tr>
</tbody>
</table>
<h2>Build the sample</h2>
<p></p>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
