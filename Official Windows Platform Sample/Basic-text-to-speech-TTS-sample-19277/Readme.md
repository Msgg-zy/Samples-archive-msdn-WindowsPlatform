# Basic text-to-speech (TTS) sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
* Bing Speech
## Topics
* Speech recognition
* text-to-speech (tts)
## IsPublished
* True
## ModifiedDate
* 2013-06-25 05:48:13
## Description

<div id="mainBody">
<p>&nbsp;</p>
<div class="introduction">
<p>You can use the classes in the Windows.Phone.Speech.Synthesis namespace to generate synthesized speech, also known as text-to-speech (TTS), in your app. For example, your app could use a synthesized text-to-speech (TTS) voice to prompt users for input, to
 read the contents of a message, to present search results, and more. Note: to use TTS, you must set the ID_CAP_SPEECH_RECOGNITION capability in the app manifest. If you don&rsquo;t set this capability, your app might not work correctly</p>
<p>This basic text-to-speech sample shows and hides an ellipse shape when a button is tapped. While the ellipse is being shown or hidden, a text-to-speech voice speaks &quot;Showing the Ellipse&quot; or &quot;Hiding the Ellipse&quot; by using the asynchronous SpeechSynthesizer.SpeakTextAsync
 method, which reads the content of a plain-text string.</p>
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
<p><strong>See also</strong></p>
<ul>
<li>
<p><a href="http://go.microsoft.com/fwlink/?LinkId=268718">Text-to-Speech (TTS) for Windows Phone</a></p>
</li></ul>
</div>
</div>
