# Accelerometer sensor sample (Windows 8)
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
* 2013-06-27 02:04:59
## Description

<div id="mainSection">
<p>This sample shows how to use the Windows.Devices.Sensors.Accelerometer API. </p>
<p>This sample allows the user to view the acceleration forces along the X-, Y-, and Z-axes for a 3-axis accelerometer. You can choose one of three scenarios:
</p>
<ul>
<li>Accelerometer data events </li><li>Accelerometer shake events </li><li>Current accelerometer reading </li></ul>
<p><b>Acclerometer Data Events</b></p>
<p>When you choose the <b>Enable</b> button for the Accelerometer data events option, the app begins streaming accelerometer readings in real time.</p>
<p><b>Accelerometer Shake Events</b></p>
<p>When you choose the <b>Enable</b> button for the Accelerometer shake events option, the app displays the cumulative number of shake events each time an event occurs. (The app first increments the event count and then renders the most recent value.)</p>
<p><b>Polling Accelerometer Reading</b></p>
<p>When you choose the <b>Enable</b> button for the Current accelerometer reading option, the app retrieves the most recent accelerometer reading.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/br225699"><b>Accelerometer.GetCurrentReading method</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br225702"><b>Accelerometer.ReadingChanged event handler</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465265">Quickstart: Responding to user movement with the accelerometer</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=241981">Windows.Devices.Sensors namespace</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<h3><a id="Building_the_C___Version_of_the_Sample"></a><a id="building_the_c___version_of_the_sample"></a><a id="BUILDING_THE_C___VERSION_OF_THE_SAMPLE"></a>Building the C&#43;&#43; Version of the Sample</h3>
<p>To build this sample, open the solution (.sln) file titled AccelerometerCPP.sln from Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8. Press F7 or go to Build-&gt;Build Solution from the top menu after the sample has loaded.</p>
<h3><a id="Building_the_C__Version_of_the_Sample"></a><a id="building_the_c__version_of_the_sample"></a><a id="BUILDING_THE_C__VERSION_OF_THE_SAMPLE"></a>Building the C# Version of the Sample</h3>
<p>To build this sample, open the solution (.sln) file titled AccelerometerCS.sln from Visual Studio Express&nbsp;2012 for Windows&nbsp;8. Press F7 or go to Build-&gt;Build Solution from the top menu after the sample has loaded.</p>
<h3><a id="Building_the_JavaScript_Version_of_the_Sample"></a><a id="building_the_javascript_version_of_the_sample"></a><a id="BUILDING_THE_JAVASCRIPT_VERSION_OF_THE_SAMPLE"></a>Building the JavaScript Version of the Sample</h3>
<p>To build this sample, open the solution (.sln) file titled Accelerometer.sln from Visual Studio Express&nbsp;2012 for Windows&nbsp;8. Press F7 or go to Build-&gt;Build Solution from the top menu after the sample has loaded.</p>
<h3>Run the sample</h3>
<h3><a id="Running_the_C___and_C__Versions_of_the_Sample"></a><a id="running_the_c___and_c__versions_of_the_sample"></a><a id="RUNNING_THE_C___AND_C__VERSIONS_OF_THE_SAMPLE"></a>Running the C&#43;&#43; and C# Versions of the Sample</h3>
<p>To run this sample after building it, go to the installation folder for this sample with Windows Explorer and run the executable from the &lt;install_root&gt;\bin\Debug folder. Alternatively, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without
 debugging enabled) from Visual Studio Express&nbsp;2012 for Windows&nbsp;8. (Or select the corresponding options from the Debug menu.)</p>
<h3><a id="Running_the_JavaScript_Version_of_the_Sample"></a><a id="running_the_javascript_version_of_the_sample"></a><a id="RUNNING_THE_JAVASCRIPT_VERSION_OF_THE_SAMPLE"></a>Running the JavaScript Version of the Sample</h3>
<p>To run this sample after building it, go to the installation folder for this sample with Windows Explorer and open the default.html file. Alternatively, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Visual Studio Express&nbsp;2012
 for Windows&nbsp;8. (Or select the corresponding options from the Debug menu.)</p>
</div>
