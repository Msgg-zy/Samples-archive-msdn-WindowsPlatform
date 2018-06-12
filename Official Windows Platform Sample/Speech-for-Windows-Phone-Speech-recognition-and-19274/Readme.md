# Speech for Windows Phone: Speech recognition and text-to-speech sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
* Bing Speech
## Topics
* Speech recognition
## IsPublished
* True
## ModifiedDate
* 2013-06-25 05:47:31
## Description

<div id="mainBody">
<p>&nbsp;</p>
<div class="introduction">
<p>This sample demonstrates how to use speech recognition and synthesis to carry on a speech dialog with the user. Speaking a color name changes the background color of a box in the UI, and the app speaks the color back to you. The app continues to listen for
 more input from the user until the user explicitly stops speech recognition. When the app runs, you first must accept the speech privacy policy by following the instructions listed on the app's start screen, and then tap 'Start speech recognition'. Then, simply
 speak the name of a color. The background color of the box shown in the app will be updated, and the app will speak the action that's occurring. This sample shows you how to:</p>
<ul>
<li>
<p>Handle the speech privacy policy</p>
</li><li>
<p>Implement speech recognition</p>
</li><li>
<p>Create a custom list grammar</p>
</li><li>
<p>Output spoken text using TTS</p>
</li><li>
<p>Continuous speech recognition</p>
</li></ul>
<p>This sample uses the Windows.Phone.Speech.Recognition and Windows.Phone.Speech.Synthesis Windows Phone Runtime APIs. For more info about the speech feature in Windows&nbsp;Phone&nbsp;8, see
<a href="http://go.microsoft.com/fwlink/?LinkId=270158">Speech for Windows Phone 8</a>.</p>
<h3 class="procedureSubHeading">Build the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">Run the sample</h3>
<div class="subSection">
<ul>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</li></ul>
</div>
<p><span class="label">Note</span> Before trying your app in the emulator, verify that your microphone and audio are working properly. You can verify they are working with speech by trying a long press of the
<span class="ui">Start</span> button, accepting the Speech Privacy Policy, and then testing a system Voice Command, e.g.,
<span class="ui">&quot;Start Internet Explorer&quot;</span>.</p>
<p><strong>See also</strong></p>
<ul>
<li>
<p><a href="http://go.microsoft.com/fwlink/?LinkId=270158">Speech for Windows Phone 8</a></p>
</li></ul>
</div>
</div>
