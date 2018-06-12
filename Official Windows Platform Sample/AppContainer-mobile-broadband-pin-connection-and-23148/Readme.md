# AppContainer mobile broadband pin, connection and management (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
## IsPublished
* False
## ModifiedDate
* 2013-06-27 04:35:03
## Description

<div id="mainSection">
<p>This sample shows how to use Windows&nbsp;8 Win32/COM Mobile Broadband APIs within the AppContainer.
</p>
<p>It demonstrates how to:</p>
<ul>
<li>use the <a href="http://msdn.microsoft.com/library/windows/apps/dd323117"><b>IMbnPinManager</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dd323109"><b>IMbnPin</b></a> APIs to retrieve the pin state and how to unlock it if it is locked.
</li><li>use the <a href="http://msdn.microsoft.com/library/windows/apps/dd430380"><b>IMbnConnectionManager</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dd430368"><b>IMbnConnection</b></a> APIs to issue a connection connect or disconnect.
</li><li>use the <a href="http://msdn.microsoft.com/library/windows/apps/hh780527"><b>IMbnDeviceServicesManager</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/hh780509"><b>IMbnDeviceService</b></a> APIs to enumerate the phone book.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430368"><b>IMbnConnection</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430368events"><b>IMbnConnectionEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430380"><b>IMbnConnectionManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780509"><b>IMbnDeviceService</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780509scontext"><b>IMbnDeviceServicesContext</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780509sevents"><b>IMbnDeviceServicesEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780527"><b>IMbnDeviceServicesManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430406"><b>IMbnInterface</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd430406manager"><b>IMbnInterfaceManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323109"><b>IMbnPin</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323109events"><b>IMbnPinEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323117"><b>IMbnPinManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323117events"><b>IMbnPinManagerEvents</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh780556"><b>MBN_DEVICE_SERVICE</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd323226"><b>MBN_PIN_INFO</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/dd323271">Mobile Broadband</a>
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
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3><a id="Incorporating_the_sample_into_hybrid_applications"></a><a id="incorporating_the_sample_into_hybrid_applications"></a><a id="INCORPORATING_THE_SAMPLE_INTO_HYBRID_APPLICATIONS"></a>Incorporating the sample into hybrid applications</h3>
<p>To use these APIs correctly in hybrid applications (Javascript and C#) that are marked as
<b>Any CPU Type</b>, the COM interop DLL must be created using a 64-bit version of the TLB Importer tool (tlbimp.exe). This avoids alignment issues introduced by the default version of the tool. The 64-bit version of the tool may be found at (for example: C:\Program
 Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\x64\TlbImp.exe) and should be used as follows:
</p>
<p>&quot;Tlbimp.exe &quot;C:\Program Files (x86)\Windows Kits\8.0\Lib\win8\um\x64\mbnapi.tlb&quot; /out:&lt;InteropName&gt;.dll /machine:agnostic&quot;</p>
<p>The generated interop DLL should then be referenced directly from the C# project in the solution.</p>
<p>If the 64-bit version of tlbimp.exe is not available, then the interop DLL may be created for each platform (x86, x64, arm) using the default version of the tlbimp.exe tool as provided below. The solution needs to be marked as platform-specific as well and
 separate packages need to be generated for x86 and arm (and x64 as needed).</p>
<p>For example: &quot;C:\Program Files\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\tlbimp.exe&quot; &quot;C:\Program Files\Windows Kits\8.0\Lib\win8\um\x86\mbnapi.tlb&quot; /out:&lt;InteropName&gt;.dll /machine:x86</p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>The AppContainer Mobile Broadband sample accesses privileged APIs and requires a custom signed Mobile Broadband account metadata package that references this application or the application accessing the device in order to run. The application will display
 an <b>Access is Denied</b> error message if the metadata package doesn't explicitly grant permission to this application. For info about how to create device metadata packages, see the
<a href="http://go.microsoft.com/fwlink/p/?LinkId=242581">Windows 8 Device Apps for Mobile Network Operators</a> white paper.</p>
</div>
