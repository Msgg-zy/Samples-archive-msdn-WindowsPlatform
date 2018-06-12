# File picker contracts sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Storage
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:13:08
## Description

<div id="mainSection">
<p>This sample shows how an app can provide files, a save location, and real-time file updates to other apps through the file picker by participating in the File Open Picker contract, File Save Picker contract, and Cached File Updater contract, respectively.
 This sample uses <a href="http://msdn.microsoft.com/library/windows/apps/br207954">
<b>Windows.Storage.Pickers.Provider</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/hh747812">
<b>Windows.Storage.Provider</b></a> API. </p>
<p>The sample demonstrates these tasks:</p>
<ol>
<li>
<p><b>Provide files by integrating with the File Open Picker contract</b></p>
<p>Uses the following API:</p>
<ul>
<li>
<p>JavaScript: <a href="http://msdn.microsoft.com/library/windows/apps/hh701800">
<b>WebUIFileOpenPickerActivatedEventArgs</b></a> class</p>
<p>C#/C&#43;&#43;/VB: <a href="http://msdn.microsoft.com/library/windows/apps/hh700467"><b>FileOpenPickerActivatedEventArgs</b></a> class</p>
method </li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh738453"><b>FileOpenPickerUI</b></a> class
</li></ul>
</li><li>
<p><b>Provide a save location by integrating with the File Save Picker contract</b></p>
<p>Uses the following API:</p>
<ul>
<li>
<p>JavaScript: <a href="http://msdn.microsoft.com/library/windows/apps/hh701822">
<b>WebUIFileSavePickerActivatedEventArgs</b></a> class</p>
<p>C#/C&#43;&#43;/VB: <a href="http://msdn.microsoft.com/library/windows/apps/hh700489"><b>FileSavePickerActivatedEventArgs</b></a> class</p>
method </li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh738463"><b>FileSavePickerUI</b></a> class
</li></ul>
</li><li>
<p><b>Provide real-time file updates by integrating with the File Save Picker contract</b></p>
<p>Uses the following API:</p>
<ul>
<li>
<p>JavaScript: <a href="http://msdn.microsoft.com/library/windows/apps/hh701752">
<b>WebUICachedFileUpdaterActivatedEventArgs</b></a> class</p>
<p>C#/C&#43;&#43;/VB: <a href="http://msdn.microsoft.com/library/windows/apps/hh700440"><b>CachedFileUpdaterActivatedEventArgs</b></a> class</p>
method </li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh747794"><b>CachedFileUpdaterUI</b></a> class
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh747793"><b>CachedFileUpdater</b></a> class
</li></ul>
<p class="note"><b>Note</b>&nbsp;&nbsp;This scenario requires the <a href="http://go.microsoft.com/fwlink/p/?linkid=231464">
File picker sample</a>.</p>
</li></ol>
<p>To learn more about integrating with file picker contracts, see <a href="http://msdn.microsoft.com/library/windows/apps/hh465192">
Quickstart: Integrating with file picker contracts</a> and <a href="http://msdn.microsoft.com/library/windows/apps/jj150594">
Guidelines and checklist for file picker contracts</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Related samples</b> </dt><dt><a href=" http://go.microsoft.com/fwlink/p/?linkid=231464">File picker sample</a>
</dt><dt><a href=" http://go.microsoft.com/fwlink/p/?linkid=231445">File access sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231522">File and folder thumbnail sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231617">App activate and suspend using WinJS sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231474">App activated, resume, and suspend using the WRL sample</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br207928"><b>Windows.Storage.Pickers namespace</b></a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br207954"><b>Windows.Storage.Pickers.Provider namespace</b></a>
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
</li><li>Press F6 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
