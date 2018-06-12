# Proximity sample (Windows 8)
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
* 2013-06-27 02:21:56
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br241203">
<b>PeerFinder</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br241212">
<b>ProximityDevice</b></a> classes to communicate with nearby computers </p>
<p>You can use the Proximity API to exchange small messages during a tap gesture or set up a socket connection between peer apps. The
<a href="http://msdn.microsoft.com/library/windows/apps/br241203"><b>PeerFinder</b></a> sample (scenario 1) demonstrates how to use the Proximity API to create a socket connection between peer apps on two computers using a tap gesture or by browsing using a
 wireless radio. The <a href="http://msdn.microsoft.com/library/windows/apps/br241212">
<b>ProximityDevice</b></a> samples (scenario 2 and 3) demonstrate how to send small message payloads between two computers during a tap gesture.</p>
<p>This sample must be run on two computers. For scenarios that use a tap gesture, each computer must have a proximity device installed. For scenarios that use wireless browsing, each computer must have a wireless device that supports Wi-Fi Direct installed.
 If you don't have hardware that supports proximity tapping such as Near-Field Communication (NFC) radio, you can use the proximity driver sample that is part of the Windows Driver Kit (WDK) samples. You can use the sample driver to simulate a tap gesture over
 a network connection between two computers. For information on how to download the WDK, see
<a href="http://go.microsoft.com/fwlink/?linkid=136508">Windows Driver Kit (WDK)</a>. After you have installed the WDK and samples, you can find the proximity driver sample in the src\nfp directory in the location where you installed the WDK samples. See the
 NetNfpProvider.html file in the src\nfp\net directory for instructions on building and running the simulator. After you start the simulator, it runs in the background while your proximity app is running in the foreground. Your app must be in the foreground
 for the tap simulation to work.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465207">Quickstart: Connecting applications using tapping or browsing (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465205">Quickstart: Connecting applications using tapping or browsing (C#)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465223">Quickstart: Publishing and subscribing to messages using tapping (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465213">Quickstart: Publishing and subscribing to messages using tapping (C#)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465215">Guidelines and checklist for proximity</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241250">Windows.Networking.Proximity</a>
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
<li>Start Visual Studio&nbsp;2012 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
