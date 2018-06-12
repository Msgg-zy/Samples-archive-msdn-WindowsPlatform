# AppContainer mobile broadband pin, connection, and device management sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
* Mobile Broadband
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:29:12
## Description

<div id="mainSection">
<p>This sample demonstrates how to use Windows&nbsp;8.1 Win32/COM Mobile Broadband APIs within the AppContainer to access and manage mobile broadband features.
</p>
<p>This sample shows how to:</p>
<ul>
<li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/dd323117"><b>IMbnPinManager</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dd323109"><b>IMbnPin</b></a> interfaces to retrieve the device pin state and how to unlock it if it is locked.
</li><li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/dd430380"><b>IMbnConnectionManager</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dd430368"><b>IMbnConnection</b></a> interfaces to issue a connection connect or disconnect.
</li><li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/hh780527"><b>IMbnDeviceServicesManager</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/hh780509"><b>IMbnDeviceService</b></a> interface to enumerate the phone book.
</li><li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/dd430406"><b>IMbnInterface</b></a> interface to return the state of the mobile broadband device and its capabilities.
</li></ul>
<p></p>
<p>This sample requires the following capabilities:</p>
<ul>
<li>
<p>Mobile broadband device interface identifier </p>
<p><b>&lt;DeviceCapability Name=”BFCD56F7-3943-457F-A312-2E19BB6DC648″ /&gt;</b> </p>
</li></ul>
<p></p>
<p>Versions of this sample are provided in JavaScript and C#. </p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Other resources</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=301754">Mobile Broadband on the Windows Hardware Dev Center</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430368"><b>IMbnConnection</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430375"><b>IMbnConnectionEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430380"><b>IMbnConnectionManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780509"><b>IMbnDeviceService</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780510"><b>IMbnDeviceServicesContext</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780515"><b>IMbnDeviceServicesEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780527"><b>IMbnDeviceServicesManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430406"><b>IMbnInterface</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430416"><b>IMbnInterfaceManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323109"><b>IMbnPin</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323110"><b>IMbnPinEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323117"><b>IMbnPinManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323118"><b>IMbnPinManagerEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780556"><b>MBN_DEVICE_SERVICE</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323220"><b>MBN_INTERFACE_CAPS</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323226"><b>MBN_PIN_INFO</b></a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Related technologies</h2>
<a href="http://msdn.microsoft.com/library/windows/apps/dd323271">Mobile Broadband</a>
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
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>The AppContainer Mobile Broadband sample accesses privileged APIs and requires a custom signed Mobile Broadband account metadata package that references this application or the application accessing the device in order to run. The application will display
 an <b>Access is Denied</b> error message if the metadata package doesn't explicitly grant permission to this application.
</p>
<p>For info about Mobile Broadband, see the <a href="http://go.microsoft.com/fwlink/p/?LinkID=301754">
Windows Hardware Dev Center</a>.</p>
</div>
