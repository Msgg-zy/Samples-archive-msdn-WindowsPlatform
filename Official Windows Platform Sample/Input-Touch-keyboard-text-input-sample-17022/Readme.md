# Input: Touch keyboard text input sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
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
* 2014-04-02 11:30:12
## Description

<div id="mainSection">
<p>This sample shows how to enable optimized views on the touch keyboard by using input scopes and input types with controls in the
<a href="http://msdn.microsoft.com/library/windows/apps/br229782">WinJS.UI</a> namespace, and with the
<a href="http://msdn.microsoft.com/library/windows/apps/br209683"><b>TextBox</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br227548"><b>RichEdit</b></a>&nbsp;Extensible Application Markup Language (XAML) controls. Also, this sample demonstrates spell checking by using the
<a href="http://msdn.microsoft.com/library/windows/apps/hh441107"><b>spellcheck</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br209688"><b>IsSpellCheckEnabled</b></a> properties, and it shows text prediction by using the
<a href="http://msdn.microsoft.com/library/windows/apps/br209690"><b>IsTextPredictionEnabled</b></a> property.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p>The input types shown in this sample are:</p>
<ul>
<li>URL </li><li>Email </li><li>Password </li><li>Number </li><li>Search </li><li>Telephone </li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8.1 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkID=393547">
Windows&nbsp;8.1 app samples pack</a>. The samples in the Windows&nbsp;8.1 app samples pack will build and run only on
<a href="http://go.microsoft.com/fwlink/p/?linkid=301697">Visual Studio&nbsp;2013</a>.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/">Getting started with apps</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh965453">Guidelines and checklist for login controls</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh972345">Guidelines and checklist for touch keyboard</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700412">Responding to user interaction</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209688"><b>IsSpellCheckEnabled</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209690"><b>IsTextPredictionEnabled</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br227548"><b>RichEdit</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh441107"><b>spellcheck</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209683"><b>TextBox</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208383"><b>Windows.UI.Core</b></a>
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
<b>Project/Solution</b>. </li><li>Go to the directory to which you unzipped the sample. Then go to the subdirectory named for the sample and double-click the Visual Studio&nbsp;2013 Update&nbsp;2 Solution (.sln) file.
</li><li>Follow the steps for the version of the sample you want:
<ul>
<li>
<p>To build the Windows version of the sample:</p>
<ol>
<li>Select <b>TouchKeyboard.Windows</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B, or use <b>Build</b> &gt; <b>Build Solution</b>, or use <b>
Build</b> &gt; <b>Build TouchKeyboard.Windows</b>. </li></ol>
</li><li>
<p>To build the Windows Phone version of the sample:</p>
<ol>
<li>Select <b>TouchKeyboard.WindowsPhone</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B or use <b>Build</b> &gt; <b>Build Solution</b> or use <b>Build</b> &gt;
<b>Build TouchKeyboard.WindowsPhone</b>. </li></ol>
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
<li>Select <b>TouchKeyboard.Windows</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy TouchKeyboard.Windows</b>.
</li></ol>
</li><li>
<p>To deploy the built Windows Phone version of the sample:</p>
<ol>
<li>Select <b>TouchKeyboard.WindowsPhone</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy TouchKeyboard.WindowsPhone</b>.
</li></ol>
</li></ul>
<p><b>Deploying and running the sample</b></p>
<ul>
<li>
<p>To deploy and run the Windows version of the sample:</p>
<ol>
<li>Right-click <b>TouchKeyboard.Windows</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li><li>
<p>To deploy and run the Windows Phone version of the sample:</p>
<ol>
<li>Right-click <b>TouchKeyboard.WindowsPhone</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li></ul>
</div>
