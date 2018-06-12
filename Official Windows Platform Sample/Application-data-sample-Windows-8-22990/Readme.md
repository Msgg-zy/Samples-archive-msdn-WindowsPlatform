# Application data sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Store
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:05:30
## Description

<div id="mainSection">
<p>This sample shows you how to store and retrieve data that is specific to each user and Windows Store app using the Windows Runtime application data APIs.</p>
<p>Application data includes session state, user preferences, and other settings. It is created, read, updated, and deleted when the app is running. The system manages these data stores for your app:</p>
<ul>
<li><b>local</b>: Persistent data that exists only on the current device </li><li><b>roaming</b>: Data that exists on all devices on which the user has installed the app
</li><li><b>temporary</b>: Data that could be removed by the system any time the app isn't running
</li></ul>
<p>If you use roaming data in your app, your users can easily keep your app's application data in sync across multiple devices. Windows replicates roaming data to the cloud when it is updated, and synchronizes the data to any other devices on which the app
 is installed, reducing the amount of setup work that the user needs to do to install your app on multiple devices.</p>
<p>The sample covers these key tasks:</p>
<ul>
<li>Reading and writing settings to an app data store </li><li>Reading and writing files to an app data store </li><li>Responding to roaming events </li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465118">Quickstart: Local application data (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700361">Quickstart: Local application data (C#/VB/C&#43;&#43;)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465123">Quickstart: Roaming application data (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700362">Quickstart: Roaming application data (C#/VB/C&#43;&#43;)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465130">Quickstart: Temporary application data (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700363">Quickstart: Temporary application data (C#/VB/C&#43;&#43;)</a>
</dt><dt><b>Guidelines</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465094">Guidelines for roaming application data</a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh464917">Application data</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241587"><b>Windows.Storage.ApplicationData</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241587compositevalue"><b>Windows.Storage.ApplicationDataCompositeValue</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241587container"><b>Windows.Storage.ApplicationDataContainer</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241587containersettings"><b>Windows.Storage.ApplicationDataContainerSettings</b></a>
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
<p></p>
<ol>
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
