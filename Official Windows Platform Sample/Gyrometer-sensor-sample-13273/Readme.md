# Gyrometer sensor sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
* Windows 8.1
* Windows Phone 8.1
## Topics
* Devices and sensors
* universal app
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:25:57
## Description

<div id="mainSection">
<p>This sample shows how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br225718">
<b>Windows.Devices.Sensors.Gyrometer</b></a> API. </p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p>This sample allows the user to view the angular velocity along the X-, Y-, and Z-axis for a 3-axis gyrometer. You can choose one of two scenarios:
</p>
<ul>
<li>Gyrometer data events </li><li>Poll gyrometer readings </li></ul>
<p><b>Gyrometer Data Events </b></p>
<p>When you click the <b>Enable</b> button for the <b>Gyrometer data events</b> option, the app begins streaming gyrometer readings in real time.</p>
<p><b>Poll Gyrometer Readings </b></p>
<p>When you click the <b>Enable</b> button for the <b>Poll gyrometer readings</b> option, the app will retrieve the sensor readings at a fixed interval.</p>
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
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241981">Windows.Devices.Sensors namespace</a>
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
<td><dt>None supported </dt></td>
</tr>
<tr>
<th>Phone</th>
<td><dt>Windows Phone 8.1 </dt></td>
</tr>
</tbody>
</table>
<h2>Build the sample</h2>
<p></p>
<ol>
<li>Start Microsoft Visual Studio&nbsp;2013 Update&nbsp;2 and select <b>File</b> &gt; <b>Open</b> &gt;
<b>Project/Solution</b>. </li><li>Go to the directory to which you unzipped the sample. Then go to the subdirectory containing the sample in the language you desire - either C&#43;&#43;, C#, JavaScript, or Visual Basic. Double-click the Visual Studio&nbsp;2013 Update&nbsp;2 Solution (.sln) file.
</li><li>Select either the Windows or Windows Phone project version of the sample. Press Ctrl&#43;Shift&#43;B, or select
<b>Build</b> &gt; <b>Build Solution</b>. </li></ol>
<p></p>
<h2>Run the sample</h2>
<p>The next steps depend on whether you just want to deploy the sample or you want to both deploy and run it.</p>
<p><b>Deploying the sample</b></p>
<ol>
<li>Select either the Windows or Windows Phone project version of the sample. </li><li>Select <b>Build</b> &gt; <b>Deploy Solution</b>. </li></ol>
<p><b>Deploying and running the sample</b></p>
<ol>
<li>Right-click either the Windows or Windows Phone project version of the sample in
<b>Solution Explorer</b> and select <b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or select <b>Debug</b> &gt; <b>
Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or select<b>Debug</b> &gt;
<b>Start Without Debugging</b>. </li></ol>
</div>
