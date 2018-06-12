# App activate and suspend using WinJS sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
## Topics
* App model
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:19:41
## Description

<div id="mainSection">
<p>This sample shows you how to use the WinJS activated and checkpoint events to handle app activation and suspension in your Windows Store app using JavaScript.
</p>
<p>The activated event is fired when your app is being launched. The <a href="http://msdn.microsoft.com/library/windows/apps/br212679">
WinJS.Application.onactivated</a> event gives your app the opportunity to restore the last state the user saw it in. It also allows you to acquire any activation parameters passed to you by the system. The
<a href="http://msdn.microsoft.com/library/windows/apps/br212679">WinJS.Application.onactivated</a> event may also fire while your app is running if there are new activation parameters for your app to respond to.</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/br229839">WinJS.Application.oncheckpoint</a> event fires whenever your app is being suspended by the system.
<a href="http://msdn.microsoft.com/library/windows/apps/br229839">WinJS.Application.oncheckpoint</a> gives your app the opportunity to save the user’s current session so that it can be restored in the case that your app is terminated.</p>
<p>For a sample that demonstrates how to handle activation, suspension, and resumption, see
<a href="http://go.microsoft.com/fwlink/p/?linkid=231474">App activated, resume, and suspend using the WRL sample</a>.</p>
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
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465102">How to activate an app</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465138">How to suspend an app</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465114">How to resume an app</a>
</dt><dt><b>Guidelines</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465088">Guidelines for app suspend and resume</a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh464925">Application lifecycle</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224766"><b>Windows.ApplicationModel.Activation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br242317"><b>Windows.UI.WebUI</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229774"><b>WinJS.Application</b></a>
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
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
</div>
