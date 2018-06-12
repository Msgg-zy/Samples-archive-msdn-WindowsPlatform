# Speech For Windows Phone: Refreshing a phrase list using a background agent
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
* Bing Speech
## Topics
* Speech
* background
## IsPublished
* True
## ModifiedDate
* 2013-06-25 05:46:30
## Description

<div id="mainBody">
<p>&nbsp;</p>
<div class="introduction">
<p>This sample demonstrates how to modify voice commands and phrase lists at runtime using a
<span class="label">ScheduledTask</span>. A phrase list is a list of phrases that an app recognizes to initiate a command. Updating this list at runtime is useful for cases in which the voice command is specific to a task involving updated data such as a
 user&rsquo;s favorites list or updated app data. In this sample, you ask the app whether a particular team is playing by saying a phrase such as
<span class="term">&ldquo;Background App, Are the Tigers playing today?&rdquo;</span>. The voice command prefix
<span class="label">Background App</span> is specified in the app&rsquo;s Voice Command Definition (VCD) file, which is named BackgroundAppVCD.xml in this project. The list of teams are defined in two phrase lists in the VCD, one for teams that are playing
 today and one for teams that are not playing today. When you tap <span class="ui">
Start/Restart Background Update</span>, a background agent is scheduled to run periodically to change the list of teams in the playing and non-playing phrase lists. Asking
<span class="term">&ldquo;Background App, Are the Tigers playing today?&rdquo;</span> when the background agent has updated the phrase lists, may return a different result depending on whether or not the team
<span class="term">Tigers</span> is in the list of teams playing today. The phrase lists are updated directly within the background agent. This is for demonstration purposes only. In a real app, the agent would typically call a web service to get updated
 data. This sample shows you how to:</p>
<p>&nbsp;</p>
<ul>
<li>
<p>Install void commands using <a href="http://msdn.microsoft.com/library/windowsphone/develop/windows.phone.speech.voicecommands.voicecommandservice.installcommandsetsfromfileasync(v=vs.105).aspx">
VoiceCommandService.InstallCommandSetsFromFileAsync</a></p>
</li><li>
<p>Schedule a <span><span class="keyword">PeriodicTask</span></span></p>
</li><li>
<p>Update a command phrase list at runtime, using <a href="http://msdn.microsoft.com/library/windowsphone/develop/jj207356(v=vs.105).aspx">
VoiceCommandSet.UpdatePhraseListAsync</a> API.</p>
</li><li>
<p>Start, stop and resume a background update</p>
</li></ul>
<p>This sample uses the <a href="http://msdn.microsoft.com/library/windowsphone/develop/windows.phone.speech.voicecommands(v=vs.105).aspx">
Windows.Phone.Speech.VoiceCommands</a> Windows Phone Runtime API.</p>
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
<ol>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</li><li>
<p>When the app runs, tap the <span class="ui">Install CommandSets</span> button to install the voice commands associated with this app.</p>
</li><li>
<p>Tap and hold the <span class="ui">Start</span> button. If the speech privacy policy is displayed, tap
<span class="ui">accept</span> and then say one of the commands installed with the app. For example, say
<span class="term">&rdquo;Background App Are the Lions playing today?&rdquo;</span></p>
</li><li>
<p>You should hear the app say <span class="term">&ldquo;Let me check&rdquo;</span> and then it will return a
<span class="ui">Yes</span> or <span class="ui">No</span> answer. If the app cannot understand what you have said, it will also display
<span class="ui">No</span>.</p>
</li><li>
<p>To schedule updates to the phrase list that the app can interpret, tap <span class="ui">
Start/Restart Background Update</span>. To see background updates in operation, stop running the app by either stopping the debugger or exiting the app using the hardware
<span class="ui">Back</span> button.</p>
</li><li>
<p>After approximately 5 seconds, you should see a toast notification on the main screen of the phone or emulator that reads:
<span class="ui">VoiceCommandsBackgroundApp Updated Phraselists Successfully!</span></p>
</li><li>
<p>The app will continue to be updated approximately every 30 minutes and a toast notification will be displayed. To stop background updates you can uninstall the app or tap
<span class="ui">Stop Background Update</span> in the app or go to <span class="ui">
Settings | applications | background tasks</span> tap on the <span class="ui">sdkSpeechBackgroundAgentWP8CS</span> entry and select
<span class="ui">block</span>. Note that the system will automatically disable updates from this app if the app hasn&rsquo;t been run in two weeks.</p>
</li></ol>
</div>
<p><span class="label">Notes</span></p>
<ul>
<li>
<p>This sample can run on the Windows&nbsp;Phone&nbsp;8&nbsp;Emulator and on a Windows&nbsp;Phone&nbsp;8 device.</p>
</li><li>
<p>When running the sample, make sure the microphone is working.</p>
</li><li>
<p>To run this sample, you must accept the speech privacy policy. Tap and hold the
<span class="ui">Start</span> button, tap the <span class="ui">accept</span> button, and then say &ldquo;What Can I say?&rdquo;. If you are taken to the &ldquo;What can I Say screen&rdquo; and hear text to speech readout of the page, then both the microphone
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
<p><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206959(v=vs.105).aspx">Voice commands for Windows Phone 8</a></p>
</li><li>
<p><a href="http://msdn.microsoft.com/library/windowsphone/develop/hh202942(v=vs.105).aspx">Background agents for Windows Phone</a></p>
</li></ul>
</div>
</div>
