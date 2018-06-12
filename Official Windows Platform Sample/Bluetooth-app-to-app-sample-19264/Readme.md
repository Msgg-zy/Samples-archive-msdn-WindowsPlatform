# Bluetooth app to app sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Bluetooth
* peerfinder
* streamsocket
* datareader
* datawriter
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:14:25
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample is a simple chat app. When the app runs it looks for the app running on other phones in Bluetooth range. These are called peer apps. You can select a peer app from the list of discovered peers, establish a connection and start sending and receiving
 text messages between the apps. This sample shows you how to: </p>
<ul>
<li>
<p>Detect if the Bluetooth radio is on or off.</p>
</li><li>
<p>Advertise your app for discovery by peer apps.</p>
</li><li>
<p>Find peer apps.</p>
</li><li>
<p>Request a connection or accept an incoming connection from a peer app.</p>
</li><li>
<p>Send and receive string data using an open socket.</p>
</li></ul>
<p>This sample uses the <span class="label">PeerFinder</span>, <span class="label">
StreamSocket</span>, <span class="label">DataReader</span> and <span class="label">
DataWriter</span> Windows Phone Runtime APIs. For more information on Bluetooth for Windows&nbsp;Phone&nbsp;8, see
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207007(v=vs.105).aspx">
Bluetooth for Windows Phone 8</a>.</p>
<h3 class="procedureSubHeading">Build the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt;<span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone Solution (<span class="label">.sln</span>) file.</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">Run the sample</h3>
<div class="subSection">
<ul>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without</span> Debugging.</p>
</li></ul>
</div>
</div>
<h1 class="heading"><span>Notes</span> </h1>
<div id="sectionSection0" class="section" name="collapseableSection" style="">
<p>Because Bluetooth is not available on the Windows&nbsp;Phone&nbsp;8&nbsp;Emulator, you should test this sample on Windows&nbsp;Phone&nbsp;8 phones. You’ll need two phones to see the sample in operation.</p>
</div>
<h1 class="heading"><span><a name="seeAlsoToggle">See Also</span> </h1>
<div id="seeAlsoSection" class="section" name="collapseableSection" style="">
<h4 class="subHeading">Other Resources</h4>
<div class="seeAlsoStyle"></a><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj207007(v=vs.105).aspx">Bluetooth for Windows Phone 8</a>
</div>
</div>
</div>
