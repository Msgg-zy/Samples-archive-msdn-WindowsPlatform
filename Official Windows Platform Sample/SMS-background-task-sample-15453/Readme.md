# SMS background task sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Devices and sensors
* Mobile Broadband
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:33:02
## Description

<div id="mainSection">
<p>This sample shows how to use the Windows&nbsp;8.1 Mobile Broadband SMS API (<a href="http://msdn.microsoft.com/library/windows/apps/br206567"><b>Windows.Devices.Sms</b></a>) with the Background Task API (<a href="http://msdn.microsoft.com/library/windows/apps/br224847"><b>Windows.ApplicationModel.Background</b></a>)
 to send and receive SMS text messages. </p>
<p>It demonstrates how to: </p>
<ul>
<li>register a background work item based on an SMS message trigger and a mobile network operator message trigger.
</li><li>declare the SMS device capability. </li><li>retrieve the contents of an SMS message and raise a toast from the background work item.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=301754">Mobile Broadband on the Windows Hardware Dev Center</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224781"><b>BackgroundTaskCompletedEventHandler</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224785"><b>BackgroundTaskProgressEventHandler</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224831"><b>NetworkOperatorNotificationTrigger</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206502"><b>SmsBinaryMessage</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206511"><b>SmsDevice</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206539"><b>SmsMessageReceivedEventArgs</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206550"><b>SmsTextMessage</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Related technologies</h2>
<a href="http://msdn.microsoft.com/library/windows/apps/br224847"><b>Windows.ApplicationModel.Background</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br206567"><b>Windows.Devices.Sms</b></a>
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
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<p>To run the C# sample after building it, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). (Or select the corresponding options from the
<b>Debug</b> menu.)</p>
<p>To run the VB sample after building it, go to <b>Build-&gt;Deploy Solution</b> from the top menu within Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU) after the sample has built. Click the
<b>SmsBackgroundTaskSample</b> Windows SDK sample in App Launcher to launch the sample.</p>
<p>The SMS background task sample requires access to the mobile broadband network adaptor. For info about Mobile Broadband, see the
<a href="http://go.microsoft.com/fwlink/p/?LinkID=301754">Windows Hardware Dev Center</a>.</p>
</div>
