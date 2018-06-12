# System media transport controls sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Controls
* Media
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:29:01
## Description

<div id="mainSection">
<p>This sample demonstrate how to register and handle media transport events for hardware and software buttons using the new
<a href="http://msdn.microsoft.com/library/windows/apps/dn278677"><b>SystemMediaTransportControls</b></a> .
</p>
<p>Windows&nbsp;8.1 introduces <a href="http://msdn.microsoft.com/library/windows/apps/dn278677">
<b>SystemMediaTransportControls</b></a> which replace <a href="http://msdn.microsoft.com/library/windows/apps/hh700786">
<b>MediaControl</b></a> class for interacting with the system media transport controls.</p>
<p>Specifically, this sample shows how to: </p>
<ul>
<li>Register for the play, stop, and pause buttons on the system media transport controls using the
<a href="http://msdn.microsoft.com/library/windows/apps/dn278714"><b>IsPlayEnabled</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/dn278713"><b>IsPauseEnabled</b></a>, and
<a href="http://msdn.microsoft.com/library/windows/apps/dn278718"><b>IsStopEnabled</b></a> properties.
</li><li>Handle button presses on the system media transport controls with the <a href="http://msdn.microsoft.com/library/windows/apps/dn278706">
<b>ButtonPressed</b></a> event. You use this event to update the status of the media playing in the app.
</li><li>Update the status of the system media transport controls using the <a href="http://msdn.microsoft.com/library/windows/apps/dn278719">
<b>PlaybackStatus</b></a> property. You need to update system media transport controls so they are in sync with the local media state in the app.
</li><li>Update the media metadata that the system media transport controls displays using the
<a href="http://msdn.microsoft.com/library/windows/apps/dn278686"><b>SystemMediaTransportControlsDisplayUpdater</b></a>. Specifically this sample shows how to use
<a href="http://msdn.microsoft.com/library/windows/apps/dn278694"><b>CopyFromFileAsync</b></a> to automatically extract the metadata from the media file.
</li></ul>
<p></p>
<p>The system media transport controls are different than the transport controls on the XAML
<a href="http://msdn.microsoft.com/library/windows/apps/br242926"><b>MediaElement</b></a> object or the HTML
<a href="http://msdn.microsoft.com/library/windows/apps/hh767373"><b>audio</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/hh767390"><b>video</b></a> objects. These are the controls that pop up when hardware or software media keys are pressed, such as the volume control on a pair of headphones or the media buttons on some
 keyboards. </p>
<p>For more info on the <a href="http://msdn.microsoft.com/library/windows/apps/dn278677">
<b>SystemMediaTransportControls</b></a>, see <a href="http://msdn.microsoft.com/library/windows/apps/dn263187">
How to use the system media transport controls</a>.</p>
<p>For info on background audio, which requires handling the play and pause buttons of the system media transport controls, see
<a href="http://msdn.microsoft.com/library/windows/apps/jj841209">How to play audio in the background</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn278677"><b>SystemMediaTransportControls</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn278686"><b>SystemMediaTransportControlsDisplayUpdater</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn278706"><b>ButtonPressed</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn278694"><b>CopyFromFileAsync</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn263187">How to use the system media transport controls</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj841209">How to play audio in the background</a>
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
