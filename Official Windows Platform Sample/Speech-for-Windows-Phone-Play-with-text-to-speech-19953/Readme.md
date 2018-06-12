# Speech for Windows Phone: Play with text-to-speech (TTS) installed voices
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
* Bing Speech
## Topics
* XAML
* Speech
* tts
* speech synthesizer
## IsPublished
* True
## ModifiedDate
* 2013-06-25 05:45:57
## Description

<div id="mainBody">
<p>&nbsp;</p>
<div class="introduction">
<p>This sample demonstrates speech synthesis, also known as text-to-speech (TTS). It shows you how to read out content from a text box after configuring the synthesizer for a particular voice/language. When the app runs, it lists all voices installed on your
 device. With a voice selected, tap the <span class="ui">Play</span> button to have the text displayed in the
<span><span class="keyword">TextBox</span></span> read out to you in the voice you selected. You can type in different text and select other installed voices. This sample shows you how to:</p>
<ul>
<li>
<p>List the installed voices on your device</p>
</li><li>
<p>Output spoken text using TTS</p>
</li></ul>
<p>This sample uses the Windows.Phone.Speech.Synthesis Windows Phone Runtime API. For more info about the speech feature in Windows&nbsp;Phone&nbsp;8, see
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
<p><span class="label">Notes</span></p>
<ul>
<li>
<p>This sample can run on the Windows&nbsp;Phone&nbsp;8&nbsp;Emulator and on a Windows&nbsp;Phone&nbsp;8 device.</p>
</li><li>
<p>When running the sample, make sure the audio out is working and the volume is high enough for you to hear the output.</p>
</li><li>
<p>If you are running the app in the emulator, you should see a total of 30 voices, two for each language (male and female). You may see a different number of languages installed on your Windows&nbsp;Phone&nbsp;8 device.</p>
</li><li>
<p>To see the list of supported voices/languages available for speech synthesis on your phone, go to
<span class="ui">Settings | speech | Speech language</span>. Voices not installed are displayed in this list with a download size displayed directly beneath them. You can install these languages by tapping the language and downloading it.</p>
</li></ul>
<p><strong>See also</strong></p>
<ul>
<li>
<p><a href="http://code.msdn.microsoft.com/wpapps/site/search?query=speech&f%5B1%5D.Value=speech&f%5B1%5D.Type=SearchText&f%5B0%5D.Value=Windows%20Phone%20SDK%20Team&f%5B0%5D.Type=Contributors&f%5B0%5D.Text=Windows%20Phone%20SDK&ac=3">Speech Samples for Windows
 Phone 8</a></p>
</li><li>
<p><a href="http://go.microsoft.com/fwlink/?LinkId=270158">Speech for Windows Phone 8</a></p>
</li></ul>
</div>
</div>
