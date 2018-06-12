# App activated, resume, and suspend using the WRL  sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* App model
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:05:06
## Description

<div id="mainSection">
<p>This sample shows you how to use the <b>Windows.UI.WebUI.WebUIApplication</b> <b>
Activated</b>, <b>Suspending</b> and <b>Resuming</b> events in your Windows Store app.
</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/br242314"><b>Windows.UI.WebUI.WebUIApplication.Activated</b></a> event will be fired when your app is being launched.
<a href="http://msdn.microsoft.com/library/windows/apps/br242314"><b>Windows.UI.WebUI.WebUIApplication.Activated</b></a> gives your app the opportunity to restore the last state the user saw it in. It also allows you to acquire any activation parameters passed
 to you by the system. <a href="http://msdn.microsoft.com/library/windows/apps/br242314">
<b>Windows.UI.WebUI.WebUIApplication.Activated</b></a> may also fire while your app is running if there are new activation parameters for your app to respond to.</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/br242316"><b>Windows.UI.WebUI.WebUIApplication.Suspending</b></a> event fires whenever your app is being suspended by the system.
<a href="http://msdn.microsoft.com/library/windows/apps/br242316"><b>Windows.UI.WebUI.WebUIApplication.Suspending</b></a> gives your app the opportunity to save the user’s current session so that it can be restored in the case that your app is terminated. You
 can also use this event to free exclusive system resources like files or references to external devices.</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/br242315"><b>Windows.UI.WebUI.WebUIApplication.Resuming</b></a> event fires whenever your app is woken up from the suspended state. Because your app can stay suspended for hours or even days, it’s
 possible that data within your app has gone stale. <a href="http://msdn.microsoft.com/library/windows/apps/br242315">
<b>Windows.UI.WebUI.WebUIApplication.Resuming</b></a> gives your app the opportunity to refresh this stale data. Note that you do not have to restore saved state during resume.
<a href="http://msdn.microsoft.com/library/windows/apps/br242315"><b>Windows.UI.WebUI.WebUIApplication.Resuming</b></a> keeps your app in memory so your app’s previous state is still loaded.</p>
<p>Windows attempts to keep as many suspended apps in memory as possible. By keeping these apps in memory, Windows ensures that users can quickly and reliably switch between suspended apps. However, if there aren't enough resources to keep your app in memory,
 Windows can terminate your app. Note that apps don't receive notification that they are being terminated, so the only opportunity you have to save your app's data is during suspension. When an app determines that it is activated after being terminated, it
 should load the application data that it saved during suspend so that the app appears as it did when it was suspended.</p>
<p>Generally, users don't need to close apps, they can let Windows manage them. However, a user can choose to close an app. There's no special event to indicate that the user has closed an app. After an app has been closed by the user, it's suspended and terminated.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465102">How to activate an app (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465093">How to activate an app (C#/VB/C&#43;&#43;)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465138">How to suspend an app (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465115">How to suspend an app (C#/VB/C&#43;&#43;)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465114">How to resume an app (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465110">How to resume an app (C#/VB/C&#43;&#43;)</a>
</dt><dt><b>Guidelines</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465088">Guidelines for app suspend and resume</a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh464925">Application lifecycle</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224691"><b>Windows.ApplicationModel</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224766"><b>Windows.ApplicationModel.Activation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br205865"><b>Windows.ApplicationModel.Core</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br242317"><b>Windows.UI.WebUI</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br242324"><b>Windows.UI.Xaml.Application</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229774"><b>WinJS.Application</b></a>
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
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
</div>
