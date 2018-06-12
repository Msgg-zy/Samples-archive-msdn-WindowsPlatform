# Search Extensibility Sample
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
* 2013-05-03 06:34:14
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>With Windows&nbsp;Phone OS&nbsp;7.1, apps can use App Connect to extend the Search experience on Windows Phone. With App Connect, users that search the web with the
<span class="ui">Search</span> button can launch your app from Bing search results. This sample is a fictitious product recall app for baby, nursery, and toy products. Launch this app from the apps pivot page of a quick card after searching for products like
 “baby doll stroller” and “baby bottle”. For more information, see <a href="http://msdn.microsoft.com/library/windowsphone/develop/hh202957(v=vs.105).aspx">
Search extensibility for Windows Phone</a>.</p>
<p></p>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkId=259204">Windows Phone Dev Center</a>.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Double-click the <span class="ui">.sln</span> file to open the solution.</p>
</li><li>
<p>Press F5 to start debugging the app. When the app launches for the first time, the main page will appear with instructions about how to use the sample with the device. These instructions are described in the following steps.</p>
</li><li>
<p>Press the <span class="ui">Start</span> button to navigate to <span value="Start">
<span class="keyword">Start</span></span>.</p>
</li><li>
<p>Press the <span class="ui">Search</span> button to navigate to <span value="Bing">
<span class="keyword">Bing</span></span>.</p>
</li><li>
<p>Tap the <span class="ui">Search</span> box and enter a baby, nursery, or toy search term such as “baby doll stroller” or “baby bottle”. Then tap
<span class="ui">Go</span> to initiate the search.</p>
</li><li>
<p>After the search results are displayed, scroll the <span class="ui">Web</span> pivot page to the
<span class="ui">Products</span> list. Each item displayed under Products is a product card that represents a product.</p>
</li><li>
<p>Tap a product in the <span class="ui">Products</span> list. This will launch the product card for the selected product.</p>
</li><li>
<p>The product card will show four pivot pages related to the selected product: <span class="ui">
about</span>, <span class="ui">review</span>, <span class="ui">prices</span>, and
<span class="ui">apps</span>. Swipe to the <span class="ui">apps</span> pivot page.</p>
</li><li>
<p>On the <span class="ui">apps</span> pivot page, the sample app appears as an app named
<span class="ui">Trey Research Product Recalls</span>. Tap it to launch the app item page.</p>
</li><li>
<p>On the app item page, the name of the product appears and below that, a randomly generated message that the product has or has not been recalled.</p>
</li></ol>
</div>
<p></p>
<p>Windows&nbsp;Phone Emulator in Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 breaks from the debugging process when an app is relaunched. To debug a launch of the app via App Connect, you need to simulate the navigation URI. To do this, temporarily edit the
<span class="code">DefaultTask</span> element in your app manifest file, <span value="WMAppManifest.xml">
<span class="keyword">WMAppManifest.xml</span></span>, as described in the following steps.</p>
<h3 class="procedureSubHeading">To debug search extensibility on Windows Phone Emulator</h3>
<div class="subSection">
<ol>
<li>
<p>In <span class="ui">Solution Explorer</span>, expand <span class="ui">Properties</span> and double-click
<span class="ui">WMAppManifest.xml</span>.</p>
</li><li>
<p>In the <span class="code">Tasks</span> element, find the <span class="code">
DefaultTask</span> element and comment-out the line of code as shown in the following example.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>&lt;!--&lt;DefaultTask Name=&quot;_default&quot; NavigationPage=&quot;MainPage.xaml&quot; /&gt;--&gt;</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
</li><li>
<p>Add a temporary <span class="code">DefaultTask</span> element to the <span class="code">
Tasks</span> element that simulates a launch from a Search Extras deep link URI. You can un-comment one of the sample
<span class="code">DefaultTask</span> elements that are provided in the sample or create your own. For example, the following shows code that simulates an App Connect launch for a product named “Baby Bottle”.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>&lt;DefaultTask Name=&quot;_default&quot; NavigationPage=&quot;SearchExtras?ProductName=Baby Bottle&amp;amp;Category=Bing_Products_Baby_and_Nursery&quot; /&gt;</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
</li><li>
<p>Select <span class="ui">Windows Phone Emulator</span> in the <span class="ui">
Select Target</span> drop-down menu on the Visual Studio toolbar.</p>
</li><li>
<p>Press F5 to start debugging the app. The app will launch to the app item page as though you had tapped the app in the
<span class="ui">apps</span> pivot page of the corresponding product card.</p>
</li><li>
<p>On the app item page, the name of the product will appear and below that, a randomly generated message that the product has or has not been recalled.</p>
</li><li>
<p>When you are finished debugging the app with Windows&nbsp;Phone Emulator, comment-out the temporary
<span class="code">DefaultTask</span> element and un-comment the original <span class="code">
DefaultTask</span> element that is shown in the following example.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>&lt;DefaultTask Name=&quot;_default&quot; NavigationPage=&quot;MainPage.xaml&quot; /&gt;</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
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
