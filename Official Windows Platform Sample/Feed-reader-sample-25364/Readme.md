# Feed reader sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* JSON
* User Interface
* web feed
## IsPublished
* True
## ModifiedDate
* 2014-04-16 10:20:41
## Description

<div id="mainSection">
<p>This Windows Store app sample demonstrates a basic end-to-end implementation of a news feed reader. It uses a
<a href="http://msdn.microsoft.com/library/windows/apps/br242878"><b>ListView</b></a> to organize and display articles from various subscriptions specified in a JSON-formatted data file. The data is obtained over a network connection or from a local cache.</p>
<blockquote><b>Other end-to-end Windows Store app samples:&nbsp;&nbsp;</b><a href="http://msdn.microsoft.com/library/windows/apps/dn263104">End-to-end sample apps</a>.</blockquote>
<p>Specifically, this sample covers these news reader features and Windows Store app&nbsp;APIs.
</p>
<p></p>
<p>This app includes these news reader features and Windows Store app&nbsp;APIs. </p>
<ul>
<li>
<p>A pannable <a href="http://msdn.microsoft.com/library/windows/apps/br242878"><b>ListView</b></a> page showing the subscribed news feeds and up to 15 articles per subscription.</p>
<p>Sample: Look at the news.css, news.html, and news.js files in the \pages\news\ folder.</p>
</li><li>
<p>A section page showing all available articles in the selected subscription.</p>
<p>Sample: See feed.css, feed.html, and feed.js files in the \pages\feed\ folder.</p>
</li><li>
<p>A detail page showing the content of the article selected from the <a href="http://msdn.microsoft.com/library/windows/apps/br242878">
<b>ListView</b></a> or section page.</p>
<p>Sample: Examine article.css, article.html, and article.js files in the \pages\article\ folder.</p>
</li><li>
<p>A subscription page showing all available news feeds. Users can subscribe to a news feed by selecting it.
</p>
<p>Sample: </p>
<ul>
<li>Look at the subscriptions.css, subscriptions.html, and subscriptions.js files in the \pages\subscriptions\ folder and the feedCollection.json file in the Project folder.
</li><li>For default subscriptions, see <code>var defaultSubscriptions = [&quot;Engadget&quot;, &quot;Windows App Builder Blog&quot;];</code> in io.js in the \js folder.
</li><li>Maximum subscriptions and articles are specified by <code>// Constants defining limits of the ListView. WinJS.Namespace.define(&quot;ListViewLimits&quot;, { subLimit: 10, maxItems: 15 });</code> in default.js in the \js folder.
</li></ul>
<p></p>
</li><li>
<p>Data structure representing the available newsfeeds, subscribed newsfeeds, and news articles.
</p>
<p>Sample: See data.js in the \js folder.</p>
</li><li>
<p>Loading, formatting, and displaying of news reader data. </p>
<p>Sample: Review io.js and render.js files in the \js folder.</p>
</li></ul>
<p>Here are some general Windows Store app features demonstrated by this app.</p>
<ul>
<li>
<p>Splash screen on start up.</p>
<p>Sample: Check <code>SplashScreen</code> in the package.appxmanifest file in the Project folder and splashscreen.png in the \images folder.</p>
</li><li>
<p>Single page architecture.</p>
<p>Sample: Inspect the <code>&lt;div id=&quot;contenthost&quot; data-win-control=&quot;Application.PageControlNavigator&quot; data-win-options=&quot;{home: '/pages/news/news.html'}&quot;&gt;&lt;/div&gt;</code> element in default.html, and navigator.js in the \js folder.</p>
</li><li>
<p>App bar with <b>Refresh</b> command and Nav bar with a link to a <b>Subscriptions</b> page.
</p>
<p>Sample: Examine the <code>&lt;div id=&quot;appbar&quot; data-win-control=&quot;WinJS.UI.AppBar&quot;&gt;</code> node in default.html.</p>
</li><li>
<p>Semantic Zoom to view the subscribed news feeds or individual articles for the selected news feed.
</p>
<p>Sample: View the <code>&lt;div id=&quot;articlesListViewArea&quot; data-win-control=&quot;WinJS.UI.SemanticZoom&quot;&gt;</code> and
<code>&lt;div id=&quot;articlesListView-out&quot; aria-label=&quot;List of feeds&quot; data-win-control=&quot;WinJS.UI.ListView&quot; data-win-options=&quot;{ selectionMode: 'none', tapBehavior: 'invokeOnly', swipeBehavior: 'none' }&quot;&gt;</code> nodes in news.html and the initializeLayout function
 in news.js, both of which are in the \pages\news folder.</p>
</li><li>
<p>Adaptive layouts to rearrange content when the app is resized.</p>
<p>Sample: Review article.css in the \pages\article folder and feed.css in the \pages\feed folder.</p>
</li></ul>
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
<dl><dt><b>Samples</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn263104">End-to-end sample apps</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows app samples</a>
</dt><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465382">Adding ListView controls</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh761500">Navigation design for Windows Store apps</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211370">Connecting to networks and web services (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465399">Developing connected applications</a>
</dt><dt><b>Tasks</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465346">Quickstart: Adding a splash screen</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh452768">Quickstart: Using single-page navigation</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465309">Quickstart: adding an app bar with commands</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465492">Quickstart: adding a SemanticZoom</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj150600">Quickstart: Defining app layouts</a>
</dt><dt><b>Reference (feeds)</b> </dt><dt><a href="http://go.microsoft.com/fwlink/?LinkID=308896">JSON Object </a></dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br225998"><b>Uri</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br243456"><b>SyndicationClient</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br207293"><b>NetworkInformation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701482"><b>ReadTextAsync</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh700824"><b>readText</b></a>
</dt><dt><b>Reference (general)</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229774"><b>WinJS.Application Namespace</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229776"><b>WinJS.Class Namespace</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229783"><b>WinJS.Utilities Namespace</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212652"><b>WinJS.Namespace Namespace</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229778"><b>WinJS.Navigation Namespace</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224766"><b>Windows.ApplicationModel.Activation Namespace</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229775"><b>WinJS.Binding Namespace</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211867"><b>WinJS.Promise</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br211837"><b>ListView</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229723"><b>Template</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229690"><b>SemanticZoom</b></a>
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
<h2><a id="build"></a><a id="BUILD"></a></h2>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<h2><a id="run"></a><a id="RUN"></a></h2>
<ol>
<li>Open the sample's project in Visual Studio&nbsp;2013. </li><li>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </li></ol>
<p>App highlights:</p>
<ul>
<li>When the app starts for the first time, the main page displays two default feed subscriptions with articles.
</li><li>Use Semantic Zoom to switch between subscription views. Zoom out by pinching (click the Minus button in the lower right corner with the mouse, Ctrl&#43;Minus key with a keyboard) and zoom in by stretching (click a subscription with the mouse, Ctrl&#43;Plus key
 with a keyboard). </li><li>Swipe from the top edge of the display (or right-click with a mouse, Windows Logo Key&#43;Z or menu key with a keyboard) to display the Nav bar and the App bar.
</li><li>Use the <b>Refresh</b> command on the App bar to sync the subscriptions. </li><li>Use the <b>Subscriptions</b> page link on the Nav bar to view the <b>Subscriptions</b> page. Select feeds to subscribe to and display on the main page. Tap
<b>Done</b> when finished. </li><li>Use Semantic Zoom to switch between feed views on the <b>Subscriptions</b> page. Zoom out by pinching (click the Minus button in the lower right corner with the mouse, Ctrl&#43;Minus key with a keyboard) and zoom in by stretching (click a feed with the mouse,
 Ctrl&#43;Plus key with a keyboard). </li></ul>
</div>
