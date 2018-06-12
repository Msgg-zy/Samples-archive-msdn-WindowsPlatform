# Route mapper sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Navigation
* Maps
* Extensibility
* uri mapping
* sd card
* external storage
* file associations
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:14:44
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates the external storage APIs, file associations, and how to use the Map control. For more info about these features, see the following topics:</p>
<ul>
<li>
<p><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj720573(v=vs.105).aspx">Reading from the SD card</a>
</p>
</li><li>
<p><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206987(v=vs.105).aspx">Auto-launching apps using file and URI associations</a>
</p>
</li><li>
<p><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj207045(v=vs.105).aspx">Maps and navigation</a>
</p>
</li></ul>
<p></p>
<p><b>Build the sample</b> </p>
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.
</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.
</p>
</li></ol>
<p></p>
<p><b>Run the sample</b> </p>
<ul>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. </p>
</li><li>
<p>To run the app without debugging, press Ctrl&#43;F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Without Debugging</span>. </p>
</li></ul>
<p></p>
<p><b>Launch the app from Internet Explorer for Windows Phone</b> </p>
<ol>
<li>
<p>Confirm that your phone or emulator has an internet connection. </p>
</li><li>
<p>Run the sample by pressing F5 or Ctrl&#43;F5. </p>
</li><li>
<p>Tap <span class="ui">Search</span>. This will open the <span class="ui">Search</span> experience.
</p>
</li><li>
<p>From <span class="ui">Search</span>, query for a GPX file on a website. For example, “marathon gpx” or “export gpx” may display some GPX files that you can use for testing.
</p>
</li><li>
<p>After you locate a GPX file on the internet, initiate a download of the GPX file. When the GPX file begins to download, a file association will be used to launch the Route Mapper Sample. Note that the Route Mapper Sample logo is used by Internet Explorer
 (if there are no other apps installed that can handle GPX files). </p>
</li><li>
<p>The Route Mapper Sample will process the GPX file and display the route on a Map control. Use the pinch gesture to zoom and move the contents of the Map control.
</p>
</li></ol>
<p><b>Read a route from the SD card</b> </p>
<p><span class="label">Note:</span> This procedure can only be performed on a phone that has an SD card. The Windows&nbsp;Phone emulator does not emulate external storage.</p>
<ol>
<li>
<p>Insert an SD card into the phone if one isn’t already. </p>
</li><li>
<p>Tether the phone to your PC. </p>
</li><li>
<p>Add one or more GPX files to a folder named <span class="code">Routes</span> on the SD card. Note that you can use Windows Explorer to transfer files from your PC to the SD card while your phone is tethered.
</p>
</li><li>
<p>Run the sample by pressing F5 or Ctrl&#43;F5. </p>
</li><li>
<p>On the main page, tap the <span class="ui">scan SD card for GPX files</span> button. This will initiate a scan of the SD card. If there are any files with the .gpx extension in a
<span class="code">Routes</span> folder on the SD card, the file name will display in a list on the main page.
</p>
</li><li>
<p>Tap the GPX file name to view the route. The Route Mapper Sample will process the GPX file and display the route on a Map control. Use the pinch gesture to zoom and move the contents of the Map control.
</p>
</li></ol>
<p><b>Launch the app from Outlook</b> </p>
<ol>
<li>
<p>Confirm that your phone or emulator has an internet connection. You also will need an email account so that you can receive email.
</p>
</li><li>
<p>On a PC, attach a GPX file to an email and send it to an account that you can access from your phone or on the emulator.
</p>
</li><li>
<p>Run the sample by pressing F5 or Ctrl&#43;F5. </p>
</li><li>
<p>On your phone or on the emulator, open the email that has the GPX file attached. Note that the Route Mapper Sample logo is used in the Outlook app beside the attachment name (if there are no other apps installed that can handle GPX files).
</p>
</li><li>
<p>Tap the GPX file attachment to download it. After it downloads, tap it again to open it. When the attachment begins to open, a file association will be used to launch the Route Mapper Sample.
</p>
</li><li>
<p>The Route Mapper Sample will process the GPX file and display the route on a Map control. Use the pinch gesture to zoom and move the contents of the Map control.
</p>
</li></ol>
</div>
</div>
