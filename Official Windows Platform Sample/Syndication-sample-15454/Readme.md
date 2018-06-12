# Syndication sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
* Windows 8.1
* Windows Phone 8.1
## Topics
* Networking
* universal app
## IsPublished
* True
## ModifiedDate
* 2014-04-02 11:29:38
## Description

<div id="mainSection">
<p>This sample shows you how to retrieve feeds from a web service using classes in the
<a href="http://msdn.microsoft.com/library/windows/apps/br243632"><b>Windows.Web.Syndication</b></a> namespace in your Windows Runtime app. This sample is provided in the JavaScript, C#, and C&#43;&#43; programming languages.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample was created using one of the universal app templates available in Visual Studio. It shows how its solution is structured so it can run on both Windows&nbsp;8.1 and Windows Phone 8.1. For more info about how to build apps
 that target Windows and Windows Phone with Visual Studio, see <a href="http://msdn.microsoft.com/library/windows/apps/dn609832">
Build apps that target Windows and Windows Phone 8.1 by using Visual Studio</a>.</p>
<p>This sample demonstrates the following features:</p>
<p></p>
<ul>
<li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/br243456"><b>SyndicationClient</b></a> class and class members to retrieve a web feed.
</li><li>Use the <a href="http://msdn.microsoft.com/library/windows/apps/br243533"><b>SyndicationItem</b></a> class and class members to display items in a web feed.
</li></ul>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;Use of this sample requires Internet or intranet access in order to retrieve feeds.</p>
<p>For a sample that shows how to manage syndicated content on a web service in a Windows Store app, download the
<a href="http://go.microsoft.com/fwlink/p/?linkid=245061">AtomPub sample</a>.</p>
<p><b>Network capabilities</b></p>
<p>This sample requires that network capabilities be set in the <i>Package.appxmanifest</i> file to allow the app to access the network at runtime. These capabilities can be set in the app manifest using Microsoft Visual Studio.
</p>
<p>To build the Windows version of the sample:</p>
<ul>
<li>
<p><b>Internet (Client):</b> The sample can use the Internet for client operations (outbound-initiated access). This allows the app to retrieve feeds from s server on the Internet. This is represented by the
<b>Capability name = &quot;internetClient&quot;</b> tag in the app manifest. </p>
</li><li>
<p>If the sample is used to connect to a server located on a home or work network (a local intranet), the
<b>Private Networks (Client &amp; Server)</b> capability must be set. This is represented by the
<b>Capability name = &quot;privateNetworkClientServer&quot;</b> tag in the app manifest. </p>
</li></ul>
<p>To build the Windows Phone version of the sample:</p>
<ul>
<li>
<p><b>Internet (Client &amp; Server):</b> This sample has complete access to the network for both client operations (outbound-initiated access) and server operations (inbound-initiated access). This allows the app to retrieve feeds from a server on the Internet
 or on a local intranet. This is represented by the <b>Capability name = &quot;internetClientServer&quot;</b> tag in the app manifest.
</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;On Windows Phone, there is only one network capability which enables all network access for the app.</p>
<p></p>
</li></ul>
<p></p>
<p>For more information on network capabilities, see <a href="http://msdn.microsoft.com/library/windows/apps/hh770532">
How to set network capabilities</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013 Update&nbsp;2, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Microsoft Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Other - C#/VB/C&#43;&#43; and XAML</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452981">Accessing and managing syndicated content (Windows Runtime apps using C#/VB/C&#43;&#43; and XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452751">Adding support for networking (Windows Runtime apps using C#/VB/C&#43;&#43; and XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj835817">How to set network capabilities (Windows Runtime apps using C#/VB/C&#43;&#43; and XAML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452994">How to access a web feed (Windows Runtime apps using C#/VB/C&#43;&#43; and XAML)</a>
</dt><dt><b>Other - JavaScript and HTML</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452973">Accessing and managing syndicated content (Windows Runtime apps using JavaScript and HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452752">Adding support for networking (Windows Runtime apps using JavaScript and HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh770532">How to set network capabilities (Windows Runtime apps using JavaScript and HTML)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700374">How to access a web feed (Windows Runtime apps using JavaScript and HTML)</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243456"><b>SyndicationClient</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243533"><b>SyndicationItem</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br210609"><b>Windows.Web.AtomPub</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243632"><b>Windows.Web.Syndication</b></a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=245061">AtomPub sample</a> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
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
<ol>
<li>Start Visual Studio&nbsp;2013 Update&nbsp;2 and select <b>File</b> &gt; <b>Open</b> &gt;
<b>Project/Solution</b>. </li><li>Go to the directory to which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Update&nbsp;2 Solution (.sln) file.
</li><li>Follow the steps for the version of the sample you want:
<ul>
<li>
<p>To build the Windows version of the sample:</p>
<ol>
<li>Select <b>Syndication.Windows</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B, or use <b>Build</b> &gt; <b>Build Solution</b>, or use <b>
Build</b> &gt; <b>Build Syndication.Windows</b>. </li></ol>
</li><li>
<p>To build the Windows Phone version of the sample:</p>
<ol>
<li>Select <b>Syndication.WindowsPhone</b> in <b>Solution Explorer</b>. </li><li>Press Ctrl&#43;Shift&#43;B or use <b>Build</b> &gt; <b>Build Solution</b> or use <b>Build</b> &gt;
<b>Build Syndication.WindowsPhone</b>. </li></ol>
</li></ul>
</li></ol>
<h2>Run the sample</h2>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;To successfully run this sample requires Internet or intranet access.</p>
<p></p>
<p>The next steps depend on whether you just want to deploy the sample or you want to both deploy and run it.</p>
<p><b>Deploying the sample</b></p>
<ul>
<li>
<p>To deploy the built Windows version of the sample:</p>
<ol>
<li>Select <b>Syndication.Windows</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy Syndication.Windows</b>.
</li></ol>
</li><li>
<p>To deploy the built Windows Phone version of the sample:</p>
<ol>
<li>Select <b>Syndication.WindowsPhone</b> in <b>Solution Explorer</b>. </li><li>Use <b>Build</b> &gt; <b>Deploy Solution</b> or <b>Build</b> &gt; <b>Deploy Syndication.WindowsPhone</b>.
</li></ol>
</li></ul>
<p><b>Deploying and running the sample</b></p>
<ul>
<li>
<p>To deploy and run the Windows version of the sample:</p>
<ol>
<li>Right-click <b>Syndication.Windows</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li><li>
<p>To deploy and run the Windows Phone version of the sample:</p>
<ol>
<li>Right-click <b>Syndication.WindowsPhone</b> in <b>Solution Explorer</b> and select
<b>Set as StartUp Project</b>. </li><li>To debug the sample and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the sample without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
</li></ul>
</div>
