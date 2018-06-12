# Connectivity Manager Sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* connectivity management
* connection traffic routing
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:21:54
## Description

<div id="mainSection">
<p>This sample demonstrates how an app can activate and use a secondary packet device protocol (PDP) context on a mobile broadband device. More specifically, the sample uses the
<a href="http://msdn.microsoft.com/library/windows/apps/dn266103"><b>AcquireConnectionAsync</b></a> method in the
<a href="http://msdn.microsoft.com/library/windows/apps/dn266102"><b>ConnectivityManager</b></a> class to establish a connection to an access point specified by
<a href="http://msdn.microsoft.com/library/windows/apps/dn266056"><b>CellularApnContext</b></a> class, and the
<a href="http://msdn.microsoft.com/library/windows/apps/dn266105"><b>AddHttpRoutePolicy</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dn266106"><b>RemoveHttpRoutePolicy</b></a> methods to specify and manage
<a href="http://msdn.microsoft.com/library/windows/apps/dn303663"><b>RoutePolicy</b></a> that the Http stack (WinInet) follows when routing traffic.
</p>
<p></p>
<p class="note"><b>Important</b>&nbsp;&nbsp; This sample requires mobile broadband hardware with firmware that supports multiple PDP contexts.</p>
<p></p>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Other resources</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700376">Quickstart: Managing connection events and changes in availability</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh750310">Quickstart: Managing metered network cost constraints</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700381">Quickstart: Retrieving network connection information</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn266103"><b>AcquireConnectionAsync</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn266056"><b>CellularApnContext</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn266102"><b>ConnectivityManager</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn303663"><b>RoutePolicy</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207124"><b>Windows.Networking</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207308"><b>Windows.Networking.Connectivity</b></a>
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
