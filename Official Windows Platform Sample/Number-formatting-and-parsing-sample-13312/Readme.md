# Number formatting and parsing sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
* Windows 8.1
* Windows Phone 8.1
## Topics
* Globalization
* universal app
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:27:43
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br226068">
<b>DecimalFormatter</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br206883">
<b>CurrencyFormatter</b></a>, <a href="http://msdn.microsoft.com/library/windows/apps/br226101">
<b>PercentFormatter</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br226119">
<b>PermilleFormatter</b></a> classes in the <a href="http://msdn.microsoft.com/library/windows/apps/br226136">
<b>Windows.Globalization.NumberFormatting</b></a> namespace to display and parse numbers, currencies, and percent values.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p></p>
<p>The sample also shows how to:</p>
<ul>
<li>Round and pad numbers using the many rounding algorithms (enumerated in <a href="http://msdn.microsoft.com/library/windows/apps/dn278791">
<b>RoundingAlgorithm</b></a>) supported by the <a href="http://msdn.microsoft.com/library/windows/apps/dn278487">
<b>IncrementNumberRounder</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/dn278794">
<b>SignificantDigitsNumberRounder</b></a> classes. </li><li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/dn278744"><b>NumeralSystemTransator</b></a> class to convert strings containing Latin numbers to an appropriate numeral system that can be rendered in an app which does not perform any digit
 substitution. </li><li>Use language names with Unicode extensions to directly set properties of number formatters.
</li></ul>
<p></p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/br226136"><b>Windows.Globalization.NumberFormatting</b></a> namespace provides number formatting and parsing APIs that generate strings for display that respect either the current user's preferences,
 or a caller-specified language(s) and region. There are individual methods for formatting or parsing numbers in the form of decimals, currencies, percentages, and units per thousand (permillages).</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013 Update&nbsp;2, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Microsoft Visual Studio&nbsp;2013</a>.</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206883"><b>Windows.Globalization.NumberFormatting.CurrencyFormatter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226068"><b>Windows.Globalization.NumberFormatting.DecimalFormatter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn278487"><b>Windows.Globalization.NumberFormatting.IncrementNumberRounder</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn278744"><b>Windows.Globalization.NumberFormatting.NumeralSystemTransator</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226101"><b>Windows.Globalization.NumberFormatting.PercentFormatter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br226119"><b>Windows.Globalization.NumberFormatting.PermilleFormatter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn278791"><b>Windows.Globalization.NumberFormatting.RoundingAlgorithm</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn278794"><b>Windows.Globalization.NumberFormatting.SignificantDigitsNumberRounder</b></a>
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
<li>Start Visual Studio&nbsp;2013 Update&nbsp;2 and select <b>File</b> &gt; <b>Open</b> &gt;
<b>Project/Solution</b>. </li><li>Go to the directory to which you unzipped the sample. Then go to the subdirectory named for the sample and double-click the Visual Studio&nbsp;2013 Update&nbsp;2 Solution (.sln) file.
</li><li>Follow the steps for the version of the sample you want:
<ul>
<li>
<p>To build the Windows version of the sample:</p>
<ol>
<li>Select <b>NumberFormattingSample.Windows</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B, or use <b>Build</b> &gt; <b>Build Solution</b>, or use <b>
Build</b> &gt; <b>Build NumberFormattingSample.Windows</b>. </li></ol>
</li><li>
<p>To build the Windows Phone version of the sample:</p>
<ol>
<li>Select <b>NumberFormattingSample.WindowsPhone</b> in <b>Solution Explorer</b>.
</li><li>Press Ctrl&#43;Shift&#43;B or use <b>Build</b> &gt; <b>Build Solution</b> or use <b>Build</b> &gt;
<b>Build NumberFormattingSample.WindowsPhone</b>. </li></ol>
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
<li>Select <b>NumberFormattingSample.Windows</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy NumberFormattingSample.Windows</b>.
</li></ol>
</li><li>
<p>To deploy the built Windows Phone version of the sample:</p>
<ol>
<li>Select <b>NumberFormattingSample.WindowsPhone</b> in <b>Solution Explorer</b>.
</li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy NumberFormattingSample.WindowsPhone</b>.
</li></ol>
</li></ul>
<p><b>Deploying and running the sample</b></p>
<ul>
<li>
<p>To deploy and run the Windows version of the sample:</p>
<ol>
<li>Right-click <b>NumberFormattingSample.Windows</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li><li>
<p>To deploy and run the Windows Phone version of the sample:</p>
<ol>
<li>Right-click <b>NumberFormattingSample.WindowsPhone</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li></ul>
</div>
