# XAML WebView control sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
* Windows Runtime
## Topics
* Controls
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:09:56
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br227702">
<b>WebView</b></a> control to display to a URL, load HTML and interact with script within a
<b>WebView</b>, and use <a href="http://msdn.microsoft.com/library/windows/apps/br227702brush_webviewbrush">
<b>WebViewBrush</b></a>. </p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Navigating a <a href="http://msdn.microsoft.com/library/windows/apps/br227702">
<b>WebView</b></a> to a specific URL by calling the <a href="http://msdn.microsoft.com/library/windows/apps/br227702_navigate">
<b>Navigate</b></a> method. </li><li>Loading your own HTML into a <a href="http://msdn.microsoft.com/library/windows/apps/br227702">
<b>WebView</b></a> by calling the <a href="http://msdn.microsoft.com/library/windows/apps/br227702_navigatetostring">
<b>NavigateToString</b></a> method. </li><li>Invoking JavaScript functions in <a href="http://msdn.microsoft.com/library/windows/apps/br227702">
<b>WebView</b></a>-hosted content from your app code by calling the <a href="http://msdn.microsoft.com/library/windows/apps/br227702_invokescript">
<b>InvokeScript</b></a> method. </li><li>Receiving notifications and data in your app code sent from <a href="http://msdn.microsoft.com/library/windows/apps/br227702">
<b>WebView</b></a>-hosted script by handling the <a href="http://msdn.microsoft.com/library/windows/apps/br227702_scriptnotify">
<b>ScriptNotify</b></a> event. </li><li>Using <a href="http://msdn.microsoft.com/library/windows/apps/br227702_invokescript">
<b>InvokeScript</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br227702_scriptnotify">
<b>ScriptNotify</b></a> in combination with the JavaScript <a href="85587e39-9325-4b75-b9f9-9d7d475a2120">
<b>eval</b></a> function to access information about elements in the document object model (DOM).
</li><li>Using <a href="http://msdn.microsoft.com/library/windows/apps/br227702brush">
<b>WebViewBrush</b></a> to work around the fact that you cannot display other app content overlapping or on top of the
<a href="http://msdn.microsoft.com/library/windows/apps/br227702"><b>WebView</b></a> control. This is necessary because the
<b>WebView</b> is hosted in its own HWND. </li><li>Supporting the <a href="http://msdn.microsoft.com/library/windows/apps/hh464906#share_contract">
Share contract</a> by using the <a href="http://msdn.microsoft.com/library/windows/apps/br227702_datatransferpackage">
<b>DataTransferPackage</b></a> property to retrieve the currently-selected content in the
<a href="http://msdn.microsoft.com/library/windows/apps/br227702"><b>WebView</b></a> control.
</li><li>Supporting the <a href="http://msdn.microsoft.com/library/windows/apps/hh701927">
<b>AppBar</b></a> control when using a full-screen <a href="http://msdn.microsoft.com/library/windows/apps/br227702">
<b>WebView</b></a> control. This scenario requires the <a href="85587e39-9325-4b75-b9f9-9d7d475a2120">
<b>eval</b></a> technique in order to route the <b>AppBar</b> gesture from the <b>
WebView</b>-hosted content to the app. When the app receives the gesture, it can display the
<b>AppBar</b> and resize the <b>WebView</b> so that it doesn't obscure the <b>AppBar</b>.
</li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Roadmaps</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for C# and Visual Basic</a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227702_datatransferpackage"><b>DataTransferPackage</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227702_invokescript"><b>InvokeScript</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227702_navigate"><b>Navigate</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227702_navigatetostring"><b>NavigateToString</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227702_scriptnotify"><b>ScriptNotify</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227702"><b>WebView</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227702brush_webviewbrush"><b>WebViewBrush</b></a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211380#displaying_html_in_a_webview">Create a blog reader: Displaying HTML in a WebView</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh781232">Quickstart: Adding app bars: Handling the Open and Closed events</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for C# and Visual Basic</a>
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
<li>
<p>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.</p>
</li><li>
<p>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
