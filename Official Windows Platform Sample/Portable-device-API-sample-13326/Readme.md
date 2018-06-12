# Portable device API sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Devices and sensors
* Windows Store device app
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:30:57
## Description

<div id="mainSection">
<p>This sample shows how to access the IPortableDevice COM API from a C&#43;&#43; app. To learn how to access the IPortableDevice COM API from a Desktop C&#43;&#43; app, refer to the
<a href="http://code.msdn.microsoft.com/windowsdesktop/Portable-Devices-COM-API-fd4a5f7d">
Portable Devices COM API Sample</a>. </p>
<p>In order for this sample to access a device using the IPortableDevice COM API, the sample must be declared as a Privileged Application in the device metadata. For more info, see
<a href="http://go.microsoft.com/fwlink/p/?LinkID=301381">Windows Store device apps</a>.</p>
<p>This sample requires a portable device, such as the Media Transfer Protocol (MTP) simulator, a cellular phone, media player, or a camera.</p>
<p>Apps that are built on WPD can explore a device, send and receive content, and even control the device, for example, take a picture or send a text message. The system is designed to be flexible so that many types of devices can be explored, and extensible
 so that driver developers can define custom properties and commands for custom devices.</p>
<p>When you connect a portable device, this sample uses the Portable Device COM APIs to demonstrate:</p>
<ul>
<li>how to read the properties of the connected device. </li><li>how to enumerate objects. </li><li>how to send content to the connected device. </li><li>how to receive content from the connected device. </li><li>event registration and unregistration. </li><li>how to get device status from the Media Transfer Protocol (MTP) Device Status Service.
</li></ul>
<p>For more info about the IPortableDevice COM interface, see <a href="http://msdn.microsoft.com/library/windows/apps/dd389005">
WPD Application Programming Interface</a> <a href="http://msdn.microsoft.com/library/windows/apps/dd319361">
<b>IPortableDevice</b></a>.</p>
<p>For more info about reading status using the Media Transfer Protocol (MTP) Device Status Service, see
<a href="http://msdn.microsoft.com/library/windows/apps/dd388753"><b>IPortableDeviceService</b></a>.</p>
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
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd389005">WPD Application Programming Interface</a>
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
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
