# HTML ListView essentials sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
* Windows 8.1
* Windows Phone 8.1
## Topics
* Controls
* universal app
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:24:18
## Description

<div id="mainSection">
<p>This sample demonstrates the basics of using the <a href="http://msdn.microsoft.com/library/windows/apps/br211837">
<b>WinJS.UI.ListView</b></a> control on both Windows and Windows Phone 8.1: binding to data, creating an item template, responding to events, selecting items, and retrieving selected items.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p>Specifically, this sample shows you how to:</p>
<ul>
<li>Use a <a href="http://msdn.microsoft.com/library/windows/apps/hh700774"><b>WinJS.Binding.List</b></a> to create an
<a href="http://msdn.microsoft.com/library/windows/apps/br211786"><b>IListDataSource</b></a> that the
<a href="http://msdn.microsoft.com/library/windows/apps/br211837"><b>ListView</b></a> can display.
</li><li>Use a <a href="http://msdn.microsoft.com/library/windows/apps/br229723"><b>WinJS.Binding.Template</b></a> to display data.
</li><li>Handle the <a href="http://msdn.microsoft.com/library/windows/apps/br211827">
<b>iteminvoked</b></a> event. </li><li>Change the <a href="http://msdn.microsoft.com/library/windows/apps/br211837">
<b>ListView</b></a> control's <a href="http://msdn.microsoft.com/library/windows/apps/br211833">
<b>layout</b></a> from grid to list. </li><li>Programmatically manipulate the <a href="http://msdn.microsoft.com/library/windows/apps/br211837">
<b>ListView</b></a> control's <a href="http://msdn.microsoft.com/library/windows/apps/br211852">
<b>selection</b></a>. </li><li>Store the selection state of the <a href="http://msdn.microsoft.com/library/windows/apps/br211837">
<b>ListView</b></a> so that it can be restored after your app is suspended and resumed.
</li><li>Change the orientation between horizontal and vertical, grid and list layout.
</li></ul>
<p>For more info about the concepts and APIs demonstrated in this sample, see these topics:
</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/hh465496">Quickstart: adding a ListView</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465493">Quickstart: adding Windows Library for JavaScript controls and styles</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465449">How to change the selection mode</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465464">How to group items in a ListView</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465463">Item templates for grid layouts</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465478">Item templates for list layouts</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br211837"><b>ListView reference</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh465037">Roadmap for apps using JavaScript</a>
</li></ul>
<p></p>
<p>This sample is written in HTML, CSS, and JavaScript. For the XAML version, see the
<a href="http://go.microsoft.com/fwlink/p/?linkid=242397">XAML ListView and GridView control sample</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013 Update&nbsp;2, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Microsoft Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465449">How to change the selection mode</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465464">How to group items in a ListView</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465463">Item templates for grid layouts</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465478">Item templates for list layouts</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211837"><b>ListView reference</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465496">Quickstart: adding a ListView</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465493">Quickstart: adding Windows Library for JavaScript controls and styles</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Related technologies</h2>
<a href="http://msdn.microsoft.com/library/windows/apps/br211385">Windows 8 apps using JavaScript</a>,
<a href="http://msdn.microsoft.com/library/windows/apps/br211837"><b>ListView</b></a>
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
<li>Select <b>Controls_ListViewBasic.Windows</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B, or use <b>Build</b> &gt; <b>Build Solution</b>, or use <b>
Build</b> &gt; <b>Build Controls_ListViewBasic.Windows</b>. </li></ol>
</li><li>
<p>To build the Windows Phone version of the sample:</p>
<ol>
<li>Select <b>Controls_ListViewBasic.WindowsPhone</b> in <b>Solution Explorer</b>.
</li><li>Press Ctrl&#43;Shift&#43;B or use <b>Build</b> &gt; <b>Build Solution</b> or use <b>Build</b> &gt;
<b>Build Controls_ListViewBasic.WindowsPhone</b>. </li></ol>
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
<li>Select <b>Controls_ListViewBasic.Windows</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy Controls_ListViewBasic.Windows</b>.
</li></ol>
</li><li>
<p>To deploy the built Windows Phone version of the sample:</p>
<ol>
<li>Select <b>Controls_ListViewBasic.WindowsPhone</b> in <b>Solution Explorer</b>.
</li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy Controls_ListViewBasic.WindowsPhone</b>.
</li></ol>
</li></ul>
<p><b>Deploying and running the sample</b></p>
<ul>
<li>
<p>To deploy and run the Windows version of the sample:</p>
<ol>
<li>Right-click <b>Controls_ListViewBasic.Windows</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li><li>
<p>To deploy and run the Windows Phone version of the sample:</p>
<ol>
<li>Right-click <b>Controls_ListViewBasic.WindowsPhone</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li></ul>
</div>
