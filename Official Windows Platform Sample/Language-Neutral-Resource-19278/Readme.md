# Language-Neutral Resource Project
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Globalization
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:15:00
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>You can use this language-neutral resource project in Visual Studio Express 2012 for Windows&nbsp;Phone or Visual Studio to create localized app title and app Tile title string for your Windows Phone app. For more information, see
<a href="http://msdn.microsoft.com/library/windowsphone/develop/ff967550(v=vs.105).aspx">
How to localize an app title for Windows Phone</a>.</p>
</div>
<a name="WP_CreatingLanguageResourceStringsforYourApp">
<h1 class="heading"><span>Creating language resource strings for your app</span>
</h1>
<div id="sectionSection0" class="section" name="collapseableSection" style="">
<p>In this set of procedures, you use Visual Studio or Visual Studio Express 2012 for Windows&nbsp;Phone to edit the language-neutral resource string table to contain localized resource title strings. Then, you rebuild the DLL that contains the new localized title
 strings and rename the DLL file.</p>
<h3 class="subHeading">Creating the first specific language resource strings</h3>
<div class="subsection">
<p>In this procedure, you create localized title strings for English (United States).</p>
<h3 class="procedureSubHeading">To create the first specific language resource strings for your app</h3>
<div class="subSection">
<ol>
<li>
<p>Open the DLL project that you downloaded in Visual Studio or Visual Studio Express 2012 for Windows&nbsp;Phone.</p>
</li><li>
<p>In <span class="ui">Solution Explorer</span>, expand the <span class="ui">
Resource Files</span> folder.</p>
</li><li>
<p>Right-click the AppResLib.rc resource, and then click <span class="ui">View Code</span>.</p>
</li><li>
<p>Modify the AppResLib.rc file by changing the resource string values as follows:</p>
<div class="caption"></div>
<div class="tableSection">
<table width="50%" cellspacing="2" cellpadding="5" frame="lhs">
<tbody>
<tr>
<th>
<p>ID</p>
</th>
<th>
<p>Value</p>
</th>
</tr>
<tr>
<td>
<p>AppTitle</p>
</td>
<td>
<p>en-US App Title</p>
</td>
</tr>
<tr>
<td>
<p>AppTileTitle</p>
</td>
<td>
<p>en-US Tile Title</p>
</td>
</tr>
</tbody>
</table>
</div>
<p>The <span class="code">AppTitle</span> string contains the English (United States) name of your app to be displayed in the app list. The
<span class="code">AppTileTitle</span> string contains the English (United States) name of your app to be displayed in the app Tile when pinned to
<span class="ui">Start</span>.</p>
</li><li>
<p>In the <span class="ui">Build</span> menu, select <span class="ui">Build Solution</span>.</p>
</li><li>
<p>In <span class="ui">Solution Explorer</span>, right-click <span class="ui">
Solution 'AppResLib'</span>, and then click <span class="ui">Open Folder in File Explorer</span>.</p>
<p><span class="ui">File Explorer</span> displays the project files.</p>
</li><li>
<p>In <span class="ui">File Explorer</span>, open the <span class="ui">Release</span> folder, and locate the latest AppResLib.dll file that you built.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>The project folder and the solution folder both contain a <span class="ui">Release</span> folder. The AppResLib.dll file is contained in the
<span class="ui">Release</span> folder at the root of the solution. The solution folder is easy to recognize because it contains the AppResLib.sln solution file.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>Rename the file AppResLib.dll file to AppResLib.dll.0409.mui.</p>
</li></ol>
</div>
<p>The DLL file that you created and renamed contains the English (en-US) app title and the app Tile title. Later, you use this file in your Windows Phone app. Your Windows Phone app recognizes this file based on the 0409 LCID value that represents English
 (en-US).</p>
</div>
<h3 class="subHeading">Creating additional language resource strings</h3>
<div class="subsection">
<p>You can create more language resource strings and the DLL that contains those resources by following the preceding procedure. For each localized set of resource strings, you create a new DLL and rename it with the LCID and .mui extension.</p>
<p>Repeat the previous procedure, however, you must provide a localized AppTitle string value and AppTileTitle string value for each locale. You must also rename the DLL file for each locale. Each DLL file name has the format
<span class="code">AppResLib.dll.[locale ID].mui</span>. For more information about supported display languages, culture codes, and culture values, see
</a><a href="http://msdn.microsoft.com/library/windowsphone/develop/ff967550(v=vs.105).aspx">How to localize an app title for Windows Phone</a>.</p>
<p>In the next procedure, you copy the MUI files and language-neutral DLL file to the root directory of your Windows&nbsp;Phone app.
</p>
</div>
<a name="BKMK_UsingtheLocalizedResourceStringsinyourWindowsPhoneApplication">
<h3 class="subHeading">Using the localized resource strings in your Windows Phone app</h3>
<div class="subsection">
<p>By adding the localized MUI files and the language-neutral DLL file to your Windows&nbsp;Phone app, app users see the localized app title and the localized app Tile title based on the selected Windows&nbsp;Phone language that they choose for their Windows&nbsp;Phone.</p>
<h3 class="procedureSubHeading">To use the localized resource strings in your Windows Phone app</h3>
<div class="subSection">
<ol>
<li>
<p>Open your existing Windows&nbsp;Phone&nbsp;8 app or create a Windows&nbsp;Phone&nbsp;8 app in either Visual Studio or Visual Studio Express 2012 for Windows&nbsp;Phone.</p>
</li><li>
<p>In <span class="ui">Solution Explorer</span>, select your Windows&nbsp;Phone&nbsp;8 project.</p>
</li><li>
<p>On the <span class="ui">Project</span> menu, click <span class="ui">Add</span>, and then click
<span class="ui">Existing Item</span>.</p>
<p>The <span class="ui">Add Existing Item</span> dialog box appears.</p>
</li><li>
<p>Find and select the AppResLibLangNeutral.dll file and all the AppResLib.dll.*.mui files that you created in the preceding procedures, and then click
<span class="ui">Add</span>.</p>
<p>The files are added to the root your Windows&nbsp;Phone project.</p>
</li><li>
<p>In <span class="ui">Solution Explorer</span>, right-click the AppResLibLangNeutral.dll file and rename it to the following:
</p>
<p><span class="code">AppResLib.dll</span> </p>
</li><li>
<p>In <span class="ui">Solution Explorer</span>, select the imported files (AppResLib.dll and AppResLib.dll.*.mui).</p>
<p>In the <span class="ui">Properties</span> window, set the <span class="ui">
Build Action</span> property to <span class="input">Content</span>.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>If the <span class="ui">Properties</span> window is not displayed, select <span class="ui">
Properties Window</span> from the <span class="ui">View</span> menu.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>In <span class="ui">Solution Explorer</span>, expand <span class="ui">Properties</span> and then open the WMAppManifest.xml file.</p>
<p>The Windows&nbsp;Phone app manifest designer is displayed.</p>
</li><li>
<p>Select the <span class="ui">Application UI</span> tab if it’s not already selected.</p>
</li><li>
<p>Set the <span class="ui">Display Name</span> to the following: </p>
<p><span class="code">@AppResLib.dll,-100</span> </p>
</li><li>
<p>Set the <span class="ui">Tile Title</span> to the following: </p>
<p><span class="code">@AppResLib.dll,-200</span> </p>
</li><li>
<p>Save and build the Windows&nbsp;Phone app.</p>
</li></ol>
</div>
<p>The Windows&nbsp;Phone&nbsp;8 app displays the localized app title and the app Tile title based on the language and country settings of the user's Windows&nbsp;Phone&nbsp;8 phone. The
<span class="code">AppTitle</span> string and <span class="code">AppTileTitle</span> string contained in the .mui files correspond to the language and country setting of the user's Windows&nbsp;Phone&nbsp;8 phone. If you don’t include a matching .mui file for a specific
 supported locale, your Windows&nbsp;Phone&nbsp;8 app uses the language-neutral <span class="code">
AppTitle</span> string and <span class="code">AppTileTitle</span> string contained in the AppResLib.dll file.</p>
</div>
</a><a name="BKMK_TestingtheLocalizedTitle">
<h3 class="subHeading">Testing the localized title</h3>
<div class="subsection">
<p>To test your localized app title, follow the steps listed at </a><a href="http://msdn.microsoft.com/library/windowsphone/develop/hh487168(v=vs.105).aspx">How to test a localized app for Windows Phone</a>.</p>
</div>
</div>
<h1 class="heading"><span><a name="seeAlsoToggle">See Also</span> </h1>
<div id="seeAlsoSection" class="section" name="collapseableSection" style="">
<h4 class="subHeading">Other Resources</h4>
<div class="seeAlsoStyle"></a><a href="http://msdn.microsoft.com/library/windowsphone/develop/ff967550(v=vs.105).aspx">How to localize an app title for Windows Phone</a>
</div>
</div>
</div>
