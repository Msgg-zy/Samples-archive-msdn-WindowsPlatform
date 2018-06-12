# Quick Card Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* Search
* integration
## IsPublished
* True
## ModifiedDate
* 2013-05-03 06:34:11
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>Take a convenient look at what App Connect sends your app when you extend the Search experience. This sample app displays the App Connect URI parameters when launched from the various quick cards: product cards, place cards, and movie cards. Learn more about
 the types of values that are associated with various search terms, and how to access those values from your app. For step-by-step info about how to develop an app like this, see
<a href="http://go.microsoft.com/fwlink/?LinkId=229003">How to: Extend Search with App Connect for Windows Phone</a>.</p>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
</div>
<a name="BKMK_TestingwithQuickCards">
<h1 class="heading"><span>Using the Quick Card sample</span> </h1>
<div id="sectionSection0" class="section" name="collapseableSection" style="">
<p>This app is designed to help you explore live quick cards. In this section, you search for products, movies, and places that are associated with the extensions in the application manifest file. After locating a quick card, you launch your app to see the
 parameters that were passed to the application from the App Connect deep link URI.
</p>
<p>Launching the app from a quick card breaks the debugging connection. For more info, see the
<span class="label">Debugging the Application</span> section in </a><a href="http://go.microsoft.com/fwlink/?LinkId=229003">How to: Extend Search with App Connect for Windows Phone</a>.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Important Note:</b> </th>
</tr>
<tr>
<td>
<p>This sample requires an internet connection from your PC or Windows&nbsp;Phone device.</p>
</td>
</tr>
</tbody>
</table>
</div>
<h3 class="procedureSubHeading">To view product card URI parameters</h3>
<div class="subSection">
<ol>
<li>
<p>Press F5 to debug your application and deploy it to the emulator or device.</p>
</li><li>
<p>After the app loads, tap the hardware <span class="ui">Search</span> button to open Bing.</p>
</li><li>
<p>In Bing, enter a search term that is related to a product, such as a video game console name. For example,
<span class="label">“xbox 360”</span> will return product cards related to Xbox&nbsp;360 consoles. To test a product card with the
<span class="code">Bing_Products_Video_Games</span> extension, two things are required:</p>
<ul>
<li>
<p>Bing must consider the search term to be relevant to video game products.</p>
</li><li>
<p>Product cards that are relevant to the search term must already exist at Bing and be associated with the
<span class="code">Bing_Products_Video_Games</span> extension.</p>
</li></ul>
</li><li>
<p>On the <span class="ui">web</span> pivot page, select a product under the <span class="ui">
products</span> heading. This will launch the quick card related to the product. </p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Tip:</b> </th>
</tr>
<tr>
<td>
<p>If you do not see the <span class="ui">products</span> heading, try a different search term or add an additional product extension to the
<span value="WMAppManifest.xml"><span class="keyword">WMAppManifest.xml</span></span> and
<span value="Extras.xml"><span class="keyword">Extras.xml</span></span> files. For a complete list of search extensions, see
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/hh202958(v=vs.105).aspx">
Search registration and launch reference for Windows Phone</a>.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>On the quick card for the product, swipe over to the <span class="ui">apps</span> pivot page and tap on the app titled
<span class="ui">Display URI Parameters</span>. Note that the caption reads <span class="ui">
Product URI Details</span>.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>If you do not see an <span class="ui">apps</span> pivot page, the particular product card is not associated with any of the product extensions listed in the
<span value="WMAppManifest.xml"><span class="keyword">WMAppManifest.xml</span></span> and
<span value="Extras.xml"><span class="keyword">Extras.xml</span></span> files. Tap the
<span class="ui">Back</span> button and try a different search term.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>After tapping the app in the <span class="ui">apps</span> pivot page, observe that the
<span class="code">QuickCardTargetPage.xaml</span> page displays the parameters in the App Connect deep link URI for the product.</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">To view movie card URI parameters</h3>
<div class="subSection">
<ol>
<li>
<p>Press F5 to debug your app and deploy it to the emulator or device. This step is optional if you have already deployed the app.</p>
</li><li>
<p>After the app loads, tap the hardware <span class="ui">Search</span> button to open Bing.</p>
</li><li>
<p>In Bing, enter a search term that is related to movies, such as <span class="label">
“movies”</span>, <span class="label">“movies in theaters”</span> or the name of a movie playing near you. To view the parameters from a movie card with the
<span class="code">Bing_Movies</span> extension, two things are required:</p>
<ul>
<li>
<p>Bing must consider the search term to be relevant to movies.</p>
</li><li>
<p>Movie cards that are relevant to the search term must already exist at Bing and be associated with the
<span class="code">Bing_Movies</span> extension.</p>
</li></ul>
</li><li>
<p>On the <span class="ui">web</span> pivot page, select a movie listed in the search results above the
<span class="ui">web</span> heading. This will launch the quick card related to the movie.
</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>If you do not see movies listed above the <span class="ui">web</span> heading, try a different search term. There are no additional extensions available for movies.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>On the quick card for the movie, swipe over to the <span class="ui">apps</span> pivot page and tap on the app titled
<span class="ui">Display URI Parameters</span>. Note that the caption reads <span class="ui">
Movie URI Details</span>.</p>
</li><li>
<p>After tapping the app in the <span class="ui">apps</span> pivot page, observe that the
<span class="code">QuickCardTargetPage.xaml</span> page displays the parameters in the App Connect deep link URI for the movie.</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">To view place card URI parameters</h3>
<div class="subSection">
<ol>
<li>
<p>Press F5 to debug your app and deploy it to the emulator or device.</p>
</li><li>
<p>After the app loads, tap the hardware <span class="ui">Search</span> button to open Bing.</p>
</li><li>
<p>In Bing, enter a search term that is related to a location. For example, for food and dining locations, use a search term such as
<span class="label">“food”</span> or the name of a restaurant near you. To test a place card with the
<span class="code">Bing_Places_Food_and_Dining</span> extension, two things are required:</p>
<ul>
<li>
<p>Bing must consider the search term to be relevant to a food and dining location.</p>
</li><li>
<p>Place cards that are relevant to the search term must already exist at Bing and be associated with the
<span class="code">Bing_Places_Food_and_Dining</span> extension.</p>
</li></ul>
</li><li>
<p>On the <span class="ui">local</span> pivot page, select a food and dining location under the map that is displayed. This will launch the quick card related to the place.
</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Tip:</b> </th>
</tr>
<tr>
<td>
<p>If you do not see results on the <span class="ui">local</span> pivot page, try a different search term. For a complete list of search extensions, see
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/hh202958(v=vs.105).aspx">
Search registration and launch reference for Windows Phone</a>.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>On the quick card for the place, swipe over to the <span class="ui">apps</span> pivot page and tap on the app titled
<span class="ui">Display URI Parameters</span>. Note that the caption reads <span class="ui">
Place URI Details</span>.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>If you do not see an <span class="ui">apps</span> pivot page, the particular place card is not associated with any of the place extensions listed in the
<span value="WMAppManifest.xml"><span class="keyword">WMAppManifest.xml</span></span> and
<span value="Extras.xml"><span class="keyword">Extras.xml</span></span> files. Tap the
<span class="ui">Back</span> button and try a different place card.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>After tapping the app in the <span class="ui">apps</span> pivot page, observe that the
<span class="code">QuickCardTargetPage.xaml</span> page displays the parameters in the App Connect deep link URI for the place.</p>
</li></ol>
</div>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>This sample is packaged as a Windows&nbsp;Phone&nbsp;7.5 project. It can be converted to a Windows&nbsp;Phone&nbsp;8 project, by changing the target Windows Phone OS version of the project. To create a Windows&nbsp;Phone&nbsp;8 project, you must be running the Windows&nbsp;Phone&nbsp;SDK&nbsp;8.0 on
 Visual Studio 2012. You can download the latest version of the SDK from <a href="http://dev.windowsphone.com/downloadsdk">
http://dev.windowsphone.com/downloadsdk</a>.</p>
<p>To convert the sample to a Windows&nbsp;Phone&nbsp;8 project:</p>
<ol>
<li>
<p>Double-click the <span class="ui">.sln</span> file to open the solution in Visual Studio.</p>
</li><li>
<p>Right-click the project in the <span class="ui">Solution Explorer</span> and select
<span class="ui">Properties</span>. This opens the <span class="ui">Project Properties</span> window.</p>
</li><li>
<p>In the <span class="ui">Application</span> tab of the Project Properties window, select
<span class="ui">Windows Phone OS 8.0</span> from the <span class="ui">Target Windows Phone OS Version</span> dropdown. A dialog will appear asking if you want to upgrade this project to Windows Phone OS 8.0.</p>
</li><li>
<p>Select <span class="ui">Yes</span> to upgrade the project.</p>
</li></ol>
</td>
</tr>
</tbody>
</table>
</div>
</div>
</div>
