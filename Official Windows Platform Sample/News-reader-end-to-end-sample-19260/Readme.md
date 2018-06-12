# News reader end-to-end sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-04-09 02:52:57
## Description

<div id="mainSection">
<p>This sample demonstrates the implementation of a basic newsreader application.
</p>
<p>Specifically, this sample demonstrates these newsreader features:</p>
<ul>
<li>Summarized and detailed views for a list of subscribed newsfeeds and individual news articles in a subscribed newsfeed. For details, see the news.css, news.html, and news.js files in the solution's News\pages\news\ folder.
</li><li>A list of news articles for a selected subscribed newsfeed. For details, see the feed.css, feed.html, and feed.js files in the solution's News\pages\feed\ folder.
</li><li>Details for a selected news article. For details, see the article.css, article.html, and article.js files in the solution's News\pages\article\ folder.
</li><li>Available and subscribed newsfeeds. For details, see the subscriptions.css, subscriptions.html, and subscriptions.js files in the solution's News\pages\subscriptions\ folder and the feedCollection.json file in the solution's News folder.
</li><li>Data structures representing available newsfeeds, subscribed newsfeeds, and news articles. For details, see the data.js file in the solution's News\js\ folder.
</li><li>Functions for loading and displaying various newsreader data. For details, see the io.js and render.js files in the solution's News\js\ folder.
</li></ul>
<p></p>
<p>This sample also demonstrates these features:</p>
<ul>
<li>A splash screen on app startup. For details, see the &lt;SplashScreen&gt; tag in the package.appxmanifest file in the solution's News folder and the splashscreen.png file in the solution's News\images\ folder.
</li><li>A single-page navigation control. For details, start with the &lt;div&gt; tag with the
<b>id</b> attribute of &quot;contenthost&quot; in the default.html file, which is in the solution's News folder; and see the navigator.js file, which is in the solution's News\js\ folder.
</li><li>An app bar with <b>Refresh</b> and <b>Subscriptions</b> commands. For details, start with the &lt;div&gt; tag with the
<b>id</b> attribute of &quot;appbar&quot; in the default.html file, which is in the solution's News folder.
</li><li>Semantic zoom, enabling the user to view either a list of subscribed newsfeeds or individual news articles for the selected newsfeed. For details, start with the &lt;div&gt; tags with the
<b>id</b> attributes of &quot;articlesListView-in&quot; and &quot;articlesListView-out&quot; in the news.html file and the initializeLayout function in the news.js file, both of which are in the solution's News\pages\news\ folder.
</li><li>Snapped view, which displays summarized views of subscribed newsfeeds or individual news articles for the selected subscribed newsfeed. For details, start with the article.css file in the solution's News\pages\article\ folder and the feed.css file in the
 solution's News\pages\feed\ folder. </li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/?LinkId=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/?LinkId=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Conceptual</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/Hh465346">Quickstart: Adding a splash screen</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/Hh452768">Quickstart: Using single-page navigation</a>
</dt><dt><a href="m_ui_controls.quickstart__adding_an_app_bar">Quickstart: adding an app bar with commands</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/Hh465492">Quickstart: adding a SemanticZoom</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/apps/JJ150600">Quickstart: Defining app layouts</a>
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
<p>To build this sample:</p>
<ol>
<li>Start Visual Studio and select <b>File</b> &gt; <b>Open Project</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio solution (.sln) file.
</li><li>Select <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, select <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, select
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
<p>To use this sample:</p>
<ol>
<li>Show the list of subscribed newsfeeds: after the sample starts, zoom out (either pinch (touch), press the Ctrl &#43; Minus key (keyboard), or click the Minus button in the lower right corner (mouse)).
</li><li>Show the list of available news articles for a subscribed newsfeed: tap (touch) or click (mouse) one of the tiles.
</li><li>Show a news article's details: tap (touch) or click (mouse) one of the tiles.
</li><li>Show the list of available newsfeeds to subscribe to: show the app bar (either swipe from the bottom (touch) or right-click (mouse)), and tap or click the
<b>Subscriptions</b> button. </li><li>Show the list of available newsfeed categories: zoom out (either pinch (touch), press the Ctrl &#43; Minus key (keyboard), or click the Minus button in the lower right corner (mouse)).
</li><li>Show available newsfeeds for that category: tap (touch) or click (mouse)one of the tiles.
</li><li>Subscribe to one or more of the available newsfeeds: tap (touch) or click (mouse) one or more of the items. When finished, tap (touch) or click (mouse)
<b>Done</b>. </li><li>Show the list of subscribed newsfeeds, including the ones you just subscribed to: zoom out (either pinch (touch), press the Ctrl &#43; Minus key (keyboard), or click the Minus button in the lower right corner (mouse)).
</li><li>Show the list of available news articles for a subscribed newsfeed: tap (touch) or click (mouse) a tile corresponding to one of the newsfeeds you just subscribed to.
</li><li>See a summarized list of subscribed newsfeeds in snapped view: snap the app (swipe from the top of the app over to the left side (touch) or drag from the top of the app over to the left side (mouse)).
</li><li>See a summarized list of available news articles in snapped view: tap (touch) or click (mouse) one of the tiles.
</li><li>See more detailed info about an article in snapped view: tap (touch) or click (mouse) one of the tiles.
</li><li>Return to full-screen view: unsnap the app (swipe from the top of the app over to the center (touch) or drag from the top of the app over to the center (mouse)).
</li></ol>
</div>
