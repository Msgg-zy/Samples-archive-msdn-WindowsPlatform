# Auto-upload Sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Web Services
* Extensibility
* Background Agent
* photos
* uri mapping
* auto-upload
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:14:35
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>The auto-upload app is a sample development template that can be used to send pictures stored in the user’s camera roll to a remote service using a background agent. It consists of two major components: the foreground app that allows the user to log in and
 change settings, and the background agent, which connects to and sends photos to the web service. As is, the sample does not connect to a web service; use the TODO comments to customize it and connect to your web service.</p>
<p>As an auto-upload app, it registers for the auto-upload extension and launches to an auto-upload settings page when launched from the
<span class="ui">Settings</span> app. To upload photos, it uses a resource-intensive background agent that has no expiration specified. For more info about the Windows&nbsp;Phone&nbsp;8 auto-upload feature, see
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj571205(v=vs.105).aspx">
Auto-upload apps for Windows Phone 8</a>.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>This app currently is not set up to connect to a web service. To upload photos, you need to customize the app for your specific web service. For more info, see the
<b>Connect your web service</b> section.</p>
</td>
</tr>
</tbody>
</table>
</div>
<p>This sample shows you how to:</p>
<ul>
<li>
<p>Register as an auto-upload app in the app manifest file</p>
</li><li>
<p>Launch to an auto-upload settings page from the <span class="ui">Settings</span> app</p>
</li><li>
<p>Schedule a resource-intensive background agent that will not expire</p>
</li><li>
<p>Encrypt/decrypt access tokens</p>
</li><li>
<p>Access pictures in the media library and pass them to a web service</p>
</li></ul>
<p></p>
<p><b>Build the sample</b> </p>
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.</p>
</li></ol>
<p></p>
<p><b>Run the sample</b> </p>
<p>Although you need to connect your web service to upload photos, you can immediately test auto-upload extensibility and create the resource-intensive background agent. Follow these steps to run the sample as-is.</p>
<ul>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. </p>
</li><li>
<p>To run the app without debugging, press Ctrl&#43;F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Without Debugging</span>.</p>
</li></ul>
<p></p>
<p><b>Test auto-upload extensibility</b> </p>
<p>Users can adjust the settings of an auto-upload app by launching it from the built-in
<span class="ui">Settings</span> app. When launched from <span class="ui">Settings</span>, auto-upload apps display a page that allows the user to adjust settings. This sample provides a basic settings page that allows you to turn the background agent on
 or off. Perform the following steps to test the auto-upload extension point in the
<span class="ui">Settings</span> app.</p>
<ol>
<li>
<p>Run the sample, to make sure it’s installed on your phone or emulator. </p>
</li><li>
<p>Tap <span class="ui">Start</span>. </p>
</li><li>
<p>From <span class="ui">Start</span>, tap <span class="ui">Photos</span> to open the Photos Hub. The Photos Hub provides a “shortcut” to the
<span class="ui">photos&#43;camera</span> settings page in the <span class="ui">Settings</span> app.
</p>
</li><li>
<p>In the Photos Hub, expand the app bar and tap <span class="ui">settings</span> to open the photos and camera settings.
</p>
</li><li>
<p>On the <span class="ui">photos&#43;camera</span> settings page, swipe to the bottom of the page and tap the
<span class="ui">apps</span> link. This will launch a list of auto-upload apps that are installed. Note that you must have at least one auto-upload app installed to activate the
<span class="ui">apps</span> link. </p>
</li><li>
<p>On the <span class="ui">auto upload apps</span> page, tap the name of the sample to launch the auto-upload settings page for the sample.
</p>
</li><li>
<p>On the sample’s settings page, tap <span class="ui">background agent enabled</span> to enable or disable the background agent.
</p>
</li></ol>
<p></p>
<p><b>Connect your web service</b> </p>
<p>This sample includes helper classes, demonstrates auto-upload extensibility, and shows how to create a resource-intensive background agent that will not expire. It does not include the code to connect to a specific web service. You’ll have to update the
 sample in the following ways to get it to connect to the web service.</p>
<ol>
<li>
<p><span class="label">Authentication:</span> see the TODO comments on MainPage.cs. Add code that launches the web-service sign-in flow, receives the auth key from the service, encrypts the key, and saves it to a setting.
</p>
</li><li>
<p><span class="label">Update HTTP POST helper:</span> This sample was written for a web service that communicates with HTTP POST messages. Update the strings in AsyncHttpPostHelper.cs as needed to connect your web service.
</p>
</li><li>
<p><span class="label">Upload tracking:</span> You’ll need to add your own code for tracking whether a photo has been uploaded before or not. See the TODO comments in PhotoDataModel.cs for more info.
</p>
</li><li>
<p><span class="label">Error handling:</span> Review all of the code and add error handling to meet the needs of your app. TODO comments were added to many of the places you’ll need to add error handling.
</p>
</li></ol>
<p></p>
<p><b>Solution overview</b> </p>
<p>The solution contains two projects, <span class="ui">sdkAutoUploadWP8CS</span> and
<span class="ui">ScheduledTaskAgent1</span>. <span class="ui">sdkAutoUploadWP8CS</span> is the foreground app that authenticates the user with the service and registers the background agent with the system. It also has a separate settings page, which is
 shown when the app is accessed via the Photos Hub auto upload settings page. The second,
<span class="ui">ScheduledTaskAgent1</span>, is the background agent that sends the photos to the service. Connecting the app to your web service requires customizing the sample.</p>
<p></p>
<p><b>Foreground app: sdkAutoUploadWP8CS project</b> </p>
<p>The foreground app is contained in this project. It has a basic use flow. First, the user clicks the
<span class="ui">Sign In</span> button, authenticates with the service (perhaps by entering a username and password), and then the user clicks
<span class="ui">Add Agent</span>. This button registers the scheduled task with the system.</p>
<p>Here are a few items to note about this project:</p>
<ul>
<li>
<p><span class="code">WMAppManifest.xml</span> has been updated with the <span class="code">
ExtendedTask</span> and <span class="code">Extensions</span> elements. These declare the background agent and indicate that it is an auto-upload app, respectively.
</p>
</li><li>
<p><span class="code">AutoUploadSettingsPage.xaml</span> contains a checkbox switch for the background agent to turn it on or off.
</p>
</li><li>
<p><span class="code">UriMapper.cs</span> launches AutoUploadSettingsPage.xaml when the app launch URI contains the string
<span class="code">ConfigurePhotoUploadSettings</span>. Otherwise it passes through the URI to the App object.
</p>
</li><li>
<p><span class="code">App.xaml.cs</span> is assigned the <span class="code">UriMapper</span> class in the
<span class="code">InitializePhoneApplication</span> method. </p>
</li></ul>
<p></p>
<p><b>Background agent: PhotoDataModel.cs</b> </p>
<p>This file contains two stub methods: <span class="code">IsAlreadyUploaded</span> and
<span class="code">MarkUploaded</span>. The former is used to avoid duplicate uploads and the latter is used to mark a picture as uploaded. Add code here to perform those actions.</p>
<p></p>
<p><b>Background agent: AsyncHttpPostHelper.cs</b> </p>
<p>This class uploads the file to the web service. Here are some of the key classes and methods:</p>
<ul>
<li>
<p><span class="code">RequestState</span> class: The request state is passed between the callbacks during the upload. It contains a
<span class="code">Picture</span> object as well as an <span class="code">HttpWebRequest</span>. The constructor initializes the
<span class="code">HttpWebRequest</span>. Setting <span class="code">AllowWriteStreamBuffering</span> to
<span class="code">false</span> ensures that data will be sent incrementally, avoiding
<span class="label">Out Of Memory</span> exceptions. </p>
</li><li>
<p><span class="code">ConstantStrings</span> class: This class aims to place all of the customizable portions of the upload template in a central location. Here, the key for the access token, the header and footer sent to the server, the URI, and the content
 type are all wrapped into a single class.</p>
</li><li>
<p><span class="code">BeginSend</span> method: This method sets the callback delegate and starts the request.</p>
</li><li>
<p><span class="code">EndSend</span> method: This method returns the delegate to the
<span class="code">ScheduledAgent</span>.</p>
</li><li>
<p><span class="code">SendNextChunk</span> method: This method handles sending the header, footer, and body to the web service.</p>
</li><li>
<p><span class="code">GetRequestStreamCallback</span> method: This method uses the HttpWebRequest to send the image to the service. It uses asynchronous writes and reads to improve performance and reduce memory use.</p>
</li><li>
<p><span class="code">ScheduledAgentRespCallback</span> method: This method reads the server’s response into a string. It can optionally be saved into a log or used elsewhere. After the response objects are closed, the photo counter is incremented and
<span class="code">UploadPicture</span> is called with the next picture. If all photos in the camera roll have been traversed, then the background agent exits with a callback to
<span class="code">NotifyComplete</span>.</p>
</li></ul>
<p></p>
<p><b>Background agent: ServiceUploadHelper.cs</b> </p>
<p>This class prepares the picture to be uploaded. Here are some of the key methods:</p>
<ul>
<li>
<p><span class="code">UploadPicture</span> method: This method uploads each picture. First it determines if the photo has already been uploaded. Then it initiates a new
<span class="code">RequestState</span> with the photo and sends the request.</p>
</li><li>
<p><span class="code">InitializeSkydriveUpload</span> method: This method preps the upload by setting some variables and by beginning the iteration over the camera roll.</p>
</li><li>
<p><span class="code">OnHttpPostCompleteDelegate</span> method: This method determines if another photo upload needs to be initiated. Otherwise, it uses a callback to notify the system that the background agent has completed its task.</p>
</li></ul>
<p></p>
<p><b>Background agent: upload flow </b></p>
<p>The following (highly simplified) sequence illustrates how the background agent uses these classes to perform the upload.</p>
<ol>
<li>
<p><span class="label">START</span> </p>
</li><li>
<p><span class="code">onInvoke()</span> </p>
</li><li>
<p><span class="code">InitializeServiceUpload()</span> </p>
</li><li>
<p><span class="code">UploadPicture()</span> </p>
</li><li>
<p><span class="code">IsAlreadyUploaded()</span> If true, advance to the next picture with
<span class="code">UploadPicture()</span></p>
</li><li>
<p><span class="code">BeginSend()</span> </p>
</li><li>
<p>UPLOAD PHOTO</p>
</li><li>
<p><span class="code">EndSend()</span> </p>
</li><li>
<p><span class="code">MarkUploaded()</span> </p>
</li><li>
<p>More pictures? If yes, advance to the next picture with <span class="code">UploadPicture()</span>.</p>
</li><li>
<p><span class="code">NotifyComplete()</span> </p>
</li><li>
<p><span class="label">END</span> </p>
</li></ol>
</div>
</div>
