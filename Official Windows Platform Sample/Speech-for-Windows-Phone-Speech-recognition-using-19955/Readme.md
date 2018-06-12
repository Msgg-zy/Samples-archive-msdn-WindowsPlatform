# Speech for Windows Phone: Speech recognition using a custom grammar
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
* Bing Speech
## Topics
* Speech
* grammars
* grxml
## IsPublished
* True
## ModifiedDate
* 2013-06-25 05:45:19
## Description

<div id="mainBody">
<p>&nbsp;</p>
<div class="introduction">
<p>This speech recognition sample demonstrates how to define and use a custom grammar for speech recognition. The grammar is a static XAML document that complies with the Speech Recognition Grammar Specification (SRGS) Version 1.0. This grammar schema provides
 a powerful set of tools that allow you to create grammars for speech recognition scenarios ranging from basic to complex. For more info about this grammar schema, see
<a href="http://msdn.microsoft.com/library/windowsphone/develop/jj207051(v=vs.105).aspx">
SRGS Grammars for Windows Phone 8.</a> This sample uses a grammar that contains four alternate paths and demonstrates the full range of grammar complexity that can be used by your app. To use the sample, tap the
<span class="ui">mic</span> and speak a phrase to change colors for the background, border and text of the box displayed in the UI. For example, saying
<span class="ui">&rdquo;blue background&rdquo;</span> will change the background color of the box to blue. Saying
<span class="ui">&ldquo;blue background, red border, white text&rdquo;</span> will change the background color to blue, the border of the box to red and the text in the box to white. This sample shows you how to:</p>
<ul>
<li>
<p>How to create alternate paths in a grammar</p>
</li><li>
<p>Check recognition confidence</p>
</li><li>
<p>Confirm user input</p>
</li><li>
<p>Use the <span><span class="keyword">EndSilenceTimeout</span></span> property to allow users to pause when speaking longer phrases</p>
</li></ul>
<p>The grammar for this sample is defined in the Colors.grxml file in the project and defines four alternate grammar paths. These are:</p>
<ul class="nobullet">
<li>
<p><span class="label">Level 1:</span> This demonstrates simple matching of one phrase from a list of alternatives. This is a simple grammar that defines 3 colors and facilitates changing the background color of a text box. For example, tapping the
<span class="ui">mic</span> button and saying <span class="ui">&ldquo;blue&rdquo;</span> will change the color of the text in the box to blue.</p>
</li><li>
<p><span class="label">Level 2:</span> This demonstrates how to process semantics in the recognition result. This grammar has 2 rules and some rule references with semantics that facilitates changing the color of the background, border, and text. The color
 choices must be made in order, i.e. the user must say &quot;blue background, yellow border, red text&quot;.</p>
</li><li>
<p><span class="label">Level 3:</span> This grammar path introduces repeats, nesting elements, uses special GARBAGE and NULL rules and contains rules for which one or more phrases can be spoken to match the grammar.</p>
</li><li>
<p><span class="label">Level 4:</span> Accepts phrase syntaxes that place the text box feature before the color selection. For example, a user could say: &quot;Make the background blue, the border green, and the text orange&quot;.</p>
</li></ul>
<p>This sample uses the Windows.Phone.Speech.Recognition Windows Phone Runtime API. For more info about the speech feature in Windows&nbsp;Phone&nbsp;8, see
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
<p>When running the sample, make sure the microphone is working.</p>
</li><li>
<p>To run this sample, you must accept the speech privacy policy. Press and hold the
<span class="ui">Start</span> button, press the <span class="ui">accept</span> button, and then say &ldquo;What Can I say?&rdquo;. If you are taken to the &ldquo;What can I Say screen&rdquo; and hear text to speech readout of the page, then both the microphone
 and audio out are working properly. Alternatively, you can manually set the policy via the checkbox under
<span class="ui">Settings | speech | Enable Speech Recognition Service</span>. Note that you must accept the policy each time you start the emulator.</p>
</li></ul>
<p><strong>See also</strong></p>
<ul>
<li>
<p><a href="http://code.msdn.microsoft.com/wpapps/site/search?query=speech&f%5B1%5D.Value=speech&f%5B1%5D.Type=SearchText&f%5B0%5D.Value=Windows%20Phone%20SDK%20Team&f%5B0%5D.Type=Contributors&f%5B0%5D.Text=Windows%20Phone%20SDK&ac=3">Speech Samples for Windows
 Phone 8</a></p>
</li><li>
<p><a href="http://go.microsoft.com/fwlink/?LinkId=270158">Speech for Windows Phone 8</a></p>
</li><li>
<p><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206991(v=vs.105).aspx">Grammars for Windows Phone 8</a></p>
</li><li>
<p><a href="http://go.microsoft.com/fwlink/?LinkID=262302">Speech Recognition Grammar Specification (SRGS) Version 1.0</a></p>
</li></ul>
</div>
</div>
