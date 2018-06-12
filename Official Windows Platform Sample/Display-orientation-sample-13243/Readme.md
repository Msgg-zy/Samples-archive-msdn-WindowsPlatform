# Display orientation sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* XAML
* HTML5
* Windows Runtime
* Windows 8.1
* Windows Phone 8.1
## Topics
* Devices and sensors
* universal app
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:25:08
## Description

<div id="mainSection">
<p>This sample demonstrates the use of the <a href="http://msdn.microsoft.com/library/windows/apps/dn264258">
<b>DisplayInformation</b></a> class for setting the display orientation in an app.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Common settings for portrait and landscape mode </li><li>Accessing the accelerometer to determine orientation </li><li>Adjusting layout to support orientation changes </li></ul>
<p>This sample uses accelerometer data to determine device orientation. You must have an accelerometer (actual or virtual) available and configured on your device to use this sample.</p>
<p>For more info about the concepts and APIs demonstrated in this sample, see:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br206408"><b>Windows.Devices.Sensors</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br226166"><b>Windows.Graphics.Display</b></a>
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013 Update&nbsp;2, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Microsoft Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8.1 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=243667">
Windows&nbsp;8.1 app samples pack</a>. The samples in the Windows&nbsp;8.1 app samples pack will build and run only on Visual Studio&nbsp;2013 and later.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkId=243667">Windows 8.1 app samples</a>
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
<li>Start Visual Studio&nbsp;2013 Update&nbsp;2 and select <b>File</b> &gt; <b>Open</b> &gt;
<b>Project/Solution</b>. </li><li>Go to the directory to which you unzipped the sample. Then go to the subdirectory named for the sample and double-click the Visual Studio&nbsp;2013 Update&nbsp;2 Solution (.sln) file.
</li><li>Follow the steps for the version of the sample you want:
<ul>
<li>
<p>To build the Windows version of the sample:</p>
<ol>
<li>Select <b>DisplayOrientationSample.Windows</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B, or use <b>Build</b> &gt; <b>Build Solution</b>, or use <b>
Build</b> &gt; <b>Build DisplayOrientationSample.Windows</b>. </li></ol>
</li><li>
<p>To build the Windows Phone version of the sample:</p>
<ol>
<li>Select <b>DisplayOrientationSample.WindowsPhone</b> in <b>Solution Explorer</b>.
</li><li>Press Ctrl&#43;Shift&#43;B or use <b>Build</b> &gt; <b>Build Solution</b> or use <b>Build</b> &gt;
<b>Build DisplayOrientationSample.WindowsPhone</b>. </li></ol>
</li></ul>
</li></ol>
<p></p>
<h2>Run the sample</h2>
<p>The next steps depend on whether you just want to deploy the sample or you want to both deploy and run it.</p>
<p><b>Deploying the sample</b></p>
<ul>
<li>
<p>To deploy the built Windows version of the sample:</p>
<ol>
<li>Select <b>DisplayOrientationSample.Windows</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy DisplayOrientationSample.Windows</b>.
</li></ol>
</li><li>
<p>To deploy the built Windows Phone version of the sample:</p>
<ol>
<li>Select <b>DisplayOrientationSample.WindowsPhone</b> in <b>Solution Explorer</b>.
</li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy DisplayOrientationSample.WindowsPhone</b>.
</li></ol>
</li></ul>
<p><b>Deploying and running the sample</b></p>
<ul>
<li>
<p>To deploy and run the Windows version of the sample:</p>
<ol>
<li>Right-click <b>DisplayOrientationSample.Windows</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li><li>
<p>To deploy and run the Windows Phone version of the sample:</p>
<ol>
<li>Right-click <b>DisplayOrientationSample.WindowsPhone</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li></ul>
</div>
