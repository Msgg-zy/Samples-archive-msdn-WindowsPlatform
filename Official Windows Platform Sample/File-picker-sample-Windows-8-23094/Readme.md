# File picker sample (Windows 8)
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
* 2013-06-27 02:13:04
## Description

<div id="mainSection">
<p>This sample shows how to access files and folders by letting the user choose them through the file pickers and how to save a file so that the user can specify the name, file type, and location of a file to save. This sample uses
<a href="http://msdn.microsoft.com/library/windows/apps/br207928"><b>Windows.Storage.Pickers</b></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/br227346"><b>Windows.Storage</b></a> API.
</p>
<p>The sample demonstrates these tasks:</p>
<ol>
<li>
<p><b>Let the user pick one file to access</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br207847"><b>FileOpenPicker</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br207847_picksinglefileasync"><b>PickSingleFileAsync</b></a> method to call a file picker window
 and let the user pick a single file. For a walkthrough of this task, see <a href="http://msdn.microsoft.com/library/windows/apps/hh465199">
Quickstart: accessing files with file pickers</a>.</p>
</li><li>
<p><b>Let the user pick multiple files to access</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br207847"><b>FileOpenPicker</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br207847_pickmultiplefilesasync"><b>PickMultipleFilesAsync</b></a> method to call a file picker window
 and let the user pick multiple files. For a walkthrough of this task, see <a href="http://msdn.microsoft.com/library/windows/apps/hh465199">
Quickstart: accessing files with file pickers</a>.</p>
</li><li>
<p><b>Let the user pick one folder to access</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br207881"><b>FolderPicker</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br207881_picksinglefolderasync"><b>PickSingleFolderAsync</b></a> method to call a file picker window
 and let the user pick multiple files. For a walkthrough of this task, see <a href="http://msdn.microsoft.com/library/windows/apps/hh465199">
Quickstart: accessing files with file pickers</a>.</p>
</li><li>
<p><b>Let the user save a file and specify the name, file type, and/or save location</b></p>
<p>Uses the <a href="http://msdn.microsoft.com/library/windows/apps/br207871"><b>FileSavePicker</b></a>.<a href="http://msdn.microsoft.com/library/windows/apps/br207871_picksavefileasync"><b>PickSaveFileAsync</b></a> method to call a file picker window and
 let the user pick multiple files. For a walkthrough of this task, see <a href="http://msdn.microsoft.com/library/windows/apps/jj150595">
How to save files through file pickers</a>.</p>
</li><li>
<p><b>Let the user pick a locally cached file to access</b></p>
<p>The user may choose access a file that is provided by another app (the providing app) that participates in the Cached File Updater contract. Like the first scenario, this scenario uses the
<a href="http://msdn.microsoft.com/library/windows/apps/br207847"><b>FileOpenPicker</b></a> to access these files and to show how the providing app (the
<a href="http://go.microsoft.com/fwlink/p/?linkid=231536">File picker contracts sample</a>) can interact with the user through the file picker if necessary, for example if credentials are required to access the file.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This scenario requires the <a href="http://go.microsoft.com/fwlink/p/?linkid=231536">
File picker contracts sample</a>.</p>
</li><li>
<p><b>Let the user save a locally cached file</b></p>
<p>The user may choose save a file that was provided by another app (the providing app) that participates in the Cached File Updater contract. This scenario uses the
<a href="http://msdn.microsoft.com/library/windows/apps/br207871"><b>FileSavePicker</b></a> and the
<a href="http://msdn.microsoft.com/library/windows/apps/hh701431"><b>CachedFileManager</b></a> to let the user save a file to another app (the
<a href="http://go.microsoft.com/fwlink/p/?linkid=231536">File picker contracts sample</a>) and how the providing app can interact with the user through the file picker if necessary, for example if there is a version conflict.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This scenario requires the <a href="http://go.microsoft.com/fwlink/p/?linkid=231536">
File picker contracts sample</a>.</p>
</li></ol>
<p>To learn more about accessing and saving files and folders through file pickers, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh465182">Guidelines and checklist for file pickers</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Related samples</b> </dt><dt><a href=" http://go.microsoft.com/fwlink/p/?linkid=231445">File access sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231615">Using a Blob to save and load content sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231522">File and folder thumbnail sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231536">File picker contracts sample</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br207928"><b>Windows.Storage.Pickers namespace</b></a>
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
