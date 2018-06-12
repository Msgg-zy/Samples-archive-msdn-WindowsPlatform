# Language font mapping sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Globalization
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:27:53
## Description

<div id="mainSection">
<p>This sample demonstrates how to obtain language-specific font recommendations using the
<a href="http://msdn.microsoft.com/library/windows/apps/br206865"><b>LanguageFontGroup</b></a> class in the
<a href="http://msdn.microsoft.com/library/windows/apps/br206881"><b>Windows.Globalization.Fonts</b></a> namespace.
</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/br206865"><b>LanguageFontGroup</b></a> APIs (<a href="http://msdn.microsoft.com/library/windows/apps/br206881"><b>Windows.Globalization.Fonts</b></a> namespace) can indicate an appropriate font
 to use for a given language. The caller is assumed to know the language, by whatever means; the API takes a language identifier tag and returns a recommended font. Scenarios in which this API is recommended are those that include text in multiple languages
 involving different character sets where a single font (even one specified in localized application resources) may not provide optimal results for all of the text. Two typical examples are:</p>
<ul>
<li>An app displays notifications from external sources that might be in different languages.
</li><li>A content-authoring app wants to pre-select recommended fonts that the user can choose in a font-picker control according to the input languages that the user has enabled.
</li></ul>
Be aware that if the content to which the font is applied contains text that is actually in another language, the recommended font may or may not be able to support that language. If not, some text controls or frameworks that display the text might automatically
 select a different font during text layout as a fallback to ensure legible display.
<p></p>
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
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
