# SMS background task sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Devices and sensors
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:23:56
## Description

<div id="mainSection">
<p>This sample shows how to use the Windows&nbsp;8 Mobile Broadband SMS API (<a href="http://msdn.microsoft.com/library/windows/apps/br206567"><b>Windows.Devices.Sms</b></a>) with the Background Task API (<a href="http://msdn.microsoft.com/library/windows/apps/br224847"><b>Windows.ApplicationModel.Background</b></a>)
 to send and receive SMS text messages. </p>
<p>It demonstrates how to: </p>
<ul>
<li>register a background work item based on an SMS message trigger and a mobile network operator message trigger.
</li><li>declare the SMS device capability. </li><li>retrieve the contents of an SMS message and raise a toast from the background work item.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224781"><b>BackgroundTaskCompletedEventHandler</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224785"><b>BackgroundTaskProgressEventHandler</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207353"><b>MobileBroadbandAccount</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224831"><b>NetworkOperatorNotificationTrigger</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206502"><b>SmsBinaryMessage</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206511"><b>SmsDevice</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206539"><b>SmsMessageReceivedEventArgs</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206550"><b>SmsTextMessage</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br224847"><b>Windows.ApplicationModel.Background</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br206567"><b>Windows.Devices.Sms</b></a>
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
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To run the C# sample after building it, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Visual Studio Express&nbsp;2012 for Windows&nbsp;8 for Windows&nbsp;8 (any SKU). (Or select the corresponding options from the
<b>Debug</b> menu.)</p>
<p>To run the VB sample after building it, go to <b>Build-&gt;Deploy Solution</b> from the top menu within Visual Studio Express&nbsp;2012 for Windows&nbsp;8 for Windows&nbsp;8 (any SKU) after the sample has built. Click the
<b>SmsBackgroundTaskSample</b> Windows SDK sample in App Launcher to launch the sample.</p>
<p>The SMS background task sample requires access to the mobile broadband network adaptor. For info about how to configure and access the mobile broadband network adaptor, see the
<a href="http://msdn.microsoft.com/en-us/library/windows/hardware/hh852368.aspx">
Mobile Broadband:Device Apps</a> white paper.</p>
</div>
