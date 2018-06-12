# SearchBox control sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Controls
* Search
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:32:14
## Description

<div id="mainSection">
<p>This sample shows how to provide search suggestions by using the in-app search control.
</p>
<p>The sample demonstrates these tasks:</p>
<ol>
<li>
<p><b>Provide search suggestions for app content</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br225102"><b>AppendQuerySuggestion</b></a> method to provide suggestions from a local list and display them in the
<a href="http://msdn.microsoft.com/library/windows/apps/dn252771"><b>SearchBox</b></a> control.</p>
</li><li>
<p><b>Use linquistic alternatives to query terms for East Asia search</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br225102"><b>AppendQuerySuggestion</b></a> method to provide suggestions from a static list of Japanese text and display them in the
<a href="http://msdn.microsoft.com/library/windows/apps/dn252771"><b>SearchBox</b></a> control.</p>
<p></p>
<p class="note"><b>Important</b>&nbsp;&nbsp;A Japanese Input Method Editor (IME) IME must be enabled on the system for this feature to work.</p>
<p></p>
</li><li>
<p><b>Use suggestions provided by the system for content in libraries and folders</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn252808"><b>SetLocalContentSuggestionSettings</b></a> method to configure the
<a href="http://msdn.microsoft.com/library/windows/apps/dn252771"><b>SearchBox</b></a> to include search suggestions from the Music library.</p>
</li><li>
<p><b>Provide search suggestions from a web server in the OpenSearch format</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn298639"><b>HttpClient</b></a> class and the
<a href="http://msdn.microsoft.com/library/windows/apps/br225102"><b>AppendQuerySuggestion</b></a> method to provide suggestions from a web server that returns suggestions in the OpenSearch format.</p>
</li><li>
<p><b>Provide search suggestions from a web server in XML format</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br206173"><b>XmlDocument</b></a> class and the
<a href="http://msdn.microsoft.com/library/windows/apps/br225102"><b>AppendQuerySuggestion</b></a> method to provide suggestions from a web server that returns suggestions as XML Search Suggestions.</p>
</li><li>
<p><b>Set focus to the search box when the user starts typing</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/dn252793"><b>FocusOnKeyboardInput</b></a> property to set focus on the
<a href="http://msdn.microsoft.com/library/windows/apps/dn252771"><b>SearchBox</b></a> control when the user starts typing.</p>
</li></ol>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn252771"><b>SearchBox</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211591"><b>CreateFileQueryWithOptions</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br225102"><b>AppendQuerySuggestion</b></a>
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
