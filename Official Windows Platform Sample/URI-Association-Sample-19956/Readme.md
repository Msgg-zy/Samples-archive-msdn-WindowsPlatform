# URI Association Sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Extensibility
* uri mapping
* nfc
* proximity
* uri associations
## IsPublished
* True
## ModifiedDate
* 2013-03-05 11:19:08
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>A URI association allows your app to auto-launch when a specific URI is launched from another app. For example, a game developer may want to allow users to launch into a specific game level from a URI that is sent via text message. The flexibility of this
 feature allows for additional information to be sent in the URI itself. For more info about URI associations, see
<a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206987(v=vs.105).aspx">
Auto-launching apps using file and URI associations</a>.</p>
<p>This sample includes three apps: a URI launcher and two apps to handle the URI schemes that are built in to the launcher app.</p>
<ul>
<li>
<p><span class="label">sdkURIAssociationWP8CS</span>: Use this app to launch pre-set URIs for the
<span class="code">fabrikam</span>, <span class="code">contoso</span>, and <span class="code">
litware</span> URI schemes. You can also use this app to launch custom URI schemes on the same phone and to other phones via Proximity. For more info about this app, see the
<span class="label">Using the sample</span> section.</p>
</li><li>
<p><span class="label">ContosoHandlerApp</span>: Use this app to handle the <span class="code">
contoso</span> URI scheme. When sdkURIAssociationWP8CS launches URIs with the <span class="code">
contoso</span> URI scheme, this app can automatically launch to handle the URI scheme. Note that the ContosoLitwareHandlerApp also handles the
<span class="code">contoso</span> URI scheme; when both apps are installed, the user will be presented with a menu to choose which app they want to open.
</p>
</li><li>
<p><span class="label">ContosoLitwareHandlerApp</span>: Use this app to handle the
<span class="code">contoso</span> and <span class="code">litware</span> URI schemes. When sdkURIAssociationWP8CS launches URIs with the
<span class="code">contoso</span> or <span class="code">litware</span> URI scheme, this app can automatically launch to handle the URI scheme. Note that no other apps (from this sample) handle the
<span class="code">litware</span> URI scheme; when a <span class="code">litware</span> URI is launched, this app will immediately launch to handle the URI scheme.
</p>
</li></ul>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Important Note:</b> </th>
</tr>
<tr>
<td>
<p>Before using the sample, deploy all three apps from the solution to your emulator/phone. For more info, see the following procedures.</p>
</td>
</tr>
</tbody>
</table>
</div>
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
<p><b>Deploy the sample</b> </p>
<p>All three apps in the sample—sdkURIAssociationWP8CS, ContosoHandlerApp, and ContosoLitwareHandlerApp—must be deployed to the emulator/phone for the sample to work as intended. This procedure describes one of the ways you can deploy all three apps to your
 emulator/phone.</p>
<ol>
<li>
<p>In <span class="ui">Solution Explorer</span>, right-click <span class="ui">
ContosoHandlerApp</span>, then click <span class="ui">Set as StartUp Project</span>.</p>
</li><li>
<p>In the Visual Studio toolbar, confirm that the appropriate debugging target is selected.
</p>
</li><li>
<p>Right-click <span class="ui">ContosoHandlerApp</span> again, and then click <span class="ui">
Deploy</span>.</p>
</li><li>
<p>In the <span class="ui">Output</span> window, confirm that the app was deployed to the intended target.</p>
</li></ol>
<p>Repeat steps 1–4 for the other two apps in the sample: <span class="ui">ContosoLitwareHandlerApp</span> and
<span class="ui">sdkURIAssociationWP8CS</span>. </p>
<p></p>
<p><b>Run the sample</b> </p>
<ul>
<li>
<p>Confirm that sdkURIAssociationWP8CS is set as the startup project.</p>
</li><li>
<p>To run the app with debugging, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>.</p>
</li><li>
<p>To run the app without debugging, press Ctrl&#43;F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Without Debugging</span>.</p>
</li></ul>
<p><b>Using the sample</b> </p>
<p>Use the sdkURIAssociationWP8CS app to test URI associations on your phone or emulator. The app includes the following UI elements:</p>
<ul>
<li>
<p><span class="ui">Launch Fabrikam URI scheme</span>: Use this button to see what happens when no installed apps have registered to handle a URI association. The sample does not include an app to handle the
<span class="code">fabrikam</span> URI scheme, so the emulator/phone will ask if you want to want to search for apps in the Store. Note that at the time of this writing, no apps have registered to handle the fictitious
<span class="code">fabrikam</span> URI scheme.</p>
</li><li>
<p><span class="ui">Launch Litware URI scheme</span>: Use this button to see what happens when only one installed app as registered to handle a URI association. The ContosoLitwareHandlerApp launches immediately to handle the
<span class="code">litware</span> URI scheme. </p>
</li><li>
<p><span class="ui">Launch Contoso URI scheme</span>: Use this button to see what happens when multiple installed apps have registered to handle a URI association. The ContosoLitwareHandlerApp and the ContosoHandlerApp are registered to handle the
<span class="code">contoso</span> URI scheme. A menu appears to allow the user to choose which app to open.
</p>
</li><li>
<p><span class="ui">current URI scheme</span>: Use this text box to edit the current URI scheme or replace it with your own custom scheme. When you are finished editing, launch the URI by taping one of the launch buttons under it. Note that you can also use
 this to launch built-in apps. For example, <span class="code">ms-settings-wifi:</span> can be used to launch the built-in Wi-Fi Settings app.
</p>
</li><li>
<p><span class="ui">Launch current URI scheme</span>: Use this button to launch the URI that is shown in the
<span class="ui">current URI scheme</span> text box.</p>
</li><li>
<p><span class="ui">Launch current URI via Proximity</span>: Use this button to launch the URI that is shown in the
<span class="ui">current URI scheme</span> text box on another phone. Note that both phones must support NFC for this to work.
</p>
</li></ul>
</div>
</div>
