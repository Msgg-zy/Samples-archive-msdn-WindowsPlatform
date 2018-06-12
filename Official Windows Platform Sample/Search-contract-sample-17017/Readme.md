# Search contract sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* App model
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:32:11
## Description

<div id="mainSection">
<p>This sample shows how to let users search your app when they select the Search charm and open the search pane and how to use the search pane to display suggestions for users' queries. You can add search to your app by participating in the Search contract.
 This sample uses <a href="http://msdn.microsoft.com/library/windows/apps/br225108">
<b>Windows.ApplicationModel.Search</b></a> API, including the <a href="http://msdn.microsoft.com/library/windows/apps/br225058">
<b>SearchPane</b></a> class. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;Use the in-app search control to provide search results within your apps. For more info, see
<a href="http://msdn.microsoft.com/library/windows/apps/dn252771"><b>SearchBox</b></a>.</p>
<p></p>
<p>You should use this sample as you go through the <a href="http://msdn.microsoft.com/library/windows/apps/hh465238">
Quickstart: Adding search to a Windows Store app</a> topic to fully understand how to participate in the Search contract. The sample and quickstart demonstrate these tasks:
</p>
<ol>
<li>
<p><b>Participate in the Search contract so that users can search the app from anywhere in the system</b></p>
<p>If the user is not using your app when they select the Search charm, they can still search your app by selecting it from the list of apps that is visible in the search pane.</p>
</li><li>
<p><b>Display suggestions from an app-defined list in the search pane</b></p>
</li><li>
<p><b>Display suggestions in East-Asian languages in the search pane</b></p>
</li><li>
<p><b>Display suggestions from Windows in the search pane</b></p>
</li><li>
<p><b>Display suggestions from Open Search in the search pane</b></p>
<p>This shows how to supply suggestions to the search pane from a web server that returns suggestions in the
<a href="http://go.microsoft.com/fwlink/p/?linkid=251110">OpenSearch Suggestions format</a>.
</p>
<p>Use these steps to try it in the sample:</p>
<ol>
<li>Enter the URL to a web service that returns suggestions in the <a href="http://www.opensearch.org/Specifications/OpenSearch/Extensions/Suggestions/1.0">
OpenSearch Suggestions format</a>. Use {searchTerms} in the URL to represent where you want the query text to be inserted. (For example, &quot;http://contoso.com?q={searchTerms}&quot;.)
</li><li>Select the Search charm. </li><li>Type in a query. </li><li>Search suggestions are provided. </li></ol>
<p>The following errors may occur during a search.</p>
<ul>
<li><b>Incorrect URL</b>&nbsp;&nbsp; &quot;Suggestions could not be retrieved, please verify that the URL points to a valid service (for example http://contoso.com?q={searchTerms}&quot;
</li><li><b>Ill-formed results</b>&nbsp;&nbsp; &quot;Suggestions could not be displayed, please verify that the service provides valid OpenSearch suggestions&quot;
</li></ul>
</li><li>
<p><b>Display suggestions from a service that returns XML</b></p>
<p>This shows how to supply suggestions to the search pane from a web server that returns suggestions in the
<a href="http://msdn.microsoft.com/library/windows/apps/cc891508">XML search suggestions format</a>.
</p>
<p>Use these steps to try it in the sample:</p>
<ol>
<li>Enter the URL to a web service that returns suggestions in the <a href="http://msdn.microsoft.com/en-us/library/cc848863(v=vs.85).aspx">
XML Search Suggestions format</a>. Use {searchTerms} in the URL to represent where you want the query text to be inserted. (For example, &quot;http://contoso.com?q={searchTerms}&amp;format=xml&quot;.)
</li><li>Select the Search charm. </li><li>Type in a query. </li><li>Search suggestions are provided. </li></ol>
<p></p>
<p>The following errors may occur during a search.</p>
<ul>
<li><b>Incorrect URL</b>&nbsp;&nbsp; &quot;Suggestions could not be retrieved, please verify that the URL points to a valid service (for example http://contoso.com?q={searchTerms}&quot;
</li><li><b>Ill-formed results</b>&nbsp;&nbsp; &quot;Suggestions could not be displayed, please verify that the service provides valid OpenSearch suggestions&quot;
</li></ul>
<p></p>
</li><li>
<p><b>Let the user open the search pane by starting to type a query</b></p>
<p>This lets your users access the Search charm quickly while they are using a keyboard in your app. See
<a href="http://msdn.microsoft.com/library/windows/apps/hh465233">Guidelines and checklist for search</a> to learn about when and where you should consider enabling type to search.</p>
</li></ol>
<p>To learn more about integrating with the Search contract so that the user can search your app, see
<a href="http://msdn.microsoft.com/library/windows/apps/hh465238">Quickstart: Adding search to a Windows Store app</a> and
<a href="http://msdn.microsoft.com/library/windows/apps/hh465233">Guidelines and checklist for search</a>.</p>
<p>Important APIs in this sample include:</p>
<ul>
<li>JavaScript: <a href="http://msdn.microsoft.com/library/windows/apps/hh701913">
<b>WebUISearchActivatedEventArgs</b></a> class </li><li>C#/C&#43;&#43;/VB: <a href="http://msdn.microsoft.com/library/windows/apps/br224747">
<b>SearchActivatedEventArgs</b></a> class </li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225058"><b>SearchPane</b></a> class
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225067"><b>SearchPaneQuerySubmittedEventArgs</b></a> class
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225075"><b>SearchPaneSuggestionsRequestedEventArgs</b></a> class
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225101"><b>SearchSuggestionCollection</b></a> class
</li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn252771"><b>SearchBox</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><b>Related samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231617">App activate and suspend using WinJS sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=231474">App activated, resume, and suspend using the WRL sample</a>
</dt></dl>
<h2>Related technologies</h2>
<a href="http://msdn.microsoft.com/library/windows/apps/br225108"><b>Windows.ApplicationModel.Search namespace</b></a>
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
<p>To build this sample, open the solutions (.sln) file titled SearchContractSample.sln from Visual Studio&nbsp;2013 for Windows&nbsp;8.1 (any SKU). Press F7 or go to Build-&gt;Build Solution from the top menu after the sample has loaded.</p>
<h2>Run the sample</h2>
<p>To run this sample after building it, go to the installation folder for this sample with Windows Explorer and run SearchContractSample.exe from the &lt;install_root&gt;\bin\Debug folder. Alternatively, press F5 (run with debegging enabled) or Ctrl-F5 (run
 without debugging enabled). (Or select the corresponding options from the Debug menu.)</p>
</div>
