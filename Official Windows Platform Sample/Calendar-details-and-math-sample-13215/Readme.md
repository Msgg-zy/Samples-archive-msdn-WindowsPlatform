# Calendar details and math sample
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
* 2014-04-02 11:23:54
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br206724">
<b>Calendar</b></a> class in the <a href="http://msdn.microsoft.com/library/windows/apps/br206813">
<b>Windows.Globalization</b></a> namespace to manipulate and process dates based on a calendar system and the user's globalization preferences.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p>The <a href="http://msdn.microsoft.com/library/windows/apps/br206724"><b>Calendar</b></a> API is in the
<a href="http://msdn.microsoft.com/library/windows/apps/br206813"><b>Windows.Globalization</b></a> namespace. It provides the caller with the details of either the user's default calendar or a caller-specified calendar system. The API gives access to specific
 statistical details as well as the ability to perform calendar-aware math operations. In JavaScript/HTML apps, the calendar can be converted to or from a standard JavaScript Date object.</p>
<p></p>
<p>This sample contains scenarios that demonstrate:</p>
<ul>
<li>How to create a calendar for the user's default preferences or for specific overrides, and how to display calendar details.
</li><li>How to determine statistics for the current calendar date and time, such as the number of days in this month and the number of months in this year.
</li><li>How to enumerate through a calendar and perform calendar math, such as determining the number of hours in a day that spans the transition from Daylight Saving Time.
</li><li>How to create a calendar using language names with supported Unicode extension tags, and how the extension tags are used by the calendar object.
</li><li>How to support time zones in calendars, by changing several time zones within a calendar and showing the effect of the time zone change in the date and time properties of the calendar.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013 Update&nbsp;2, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Microsoft Visual Studio&nbsp;2013</a>.</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br206724"><b>Windows.Globalization.Calendar</b></a>
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
<li>Select <b>CalendarSample.Windows</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B, or use <b>Build</b> &gt; <b>Build Solution</b>, or use <b>
Build</b> &gt; <b>Build CalendarSample.Windows</b>. </li></ol>
</li><li>
<p>To build the Windows Phone version of the sample:</p>
<ol>
<li>Select <b>CalendarSample.WindowsPhone</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B or use <b>Build</b> &gt; <b>Build Solution</b>, or use <b>
Build</b> &gt; <b>Build CalendarSample.WindowsPhone</b>. </li></ol>
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
<li>Select <b>CalendarSample.Windows</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy CalendarSample.Windows</b>.
</li></ol>
</li><li>
<p>To deploy the built Windows Phone version of the sample:</p>
<ol>
<li>Select <b>CalendarSample.WindowsPhone</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy CalendarSample.WindowsPhone</b>.
</li></ol>
</li></ul>
<p><b>Deploying and running the sample</b></p>
<ul>
<li>
<p>To deploy and run the Windows version of the sample:</p>
<ol>
<li>Right-click <b>CalendarSample.Windows</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li><li>
<p>To deploy and run the Windows Phone version of the sample:</p>
<ol>
<li>Right-click <b>CalendarSample.WindowsPhone</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li></ul>
</div>
