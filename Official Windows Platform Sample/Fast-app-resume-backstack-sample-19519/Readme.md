# Fast app resume backstack sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* fast app resume
* app activation
## IsPublished
* True
## ModifiedDate
* 2013-05-28 04:32:09
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>Fast App Resume is a feature that you enable in your app’s WMAppManifest.xml file. When Fast App Resume is enabled and there is an instance of your app currently suspended on the device, if the user relaunches your app, the previous instance is resumed.
 Without Fast App Resume, the system would instead launch a new instance of your app.
</p>
<p>When you enable Fast App Resume, it’s important to consider what the backstack of previously visited pages for your app will be and how this affects the user experience. If the user expects a “fresh” session experience, then the backstack should be empty
 and pressing the Back button should exit the app. If the user expects a resumed experience, the backstack from the previous session should be intact and the Back button should navigate through previously visited screens. The expected user experience will vary
 depending on whether the app was launched and/or relaunched via a primary launch point, such as the app name in the phone’s App list or from the app’s primary Tile on Start, or through a deep link, such as a secondary Tile on Start or a toast notification.
 This sample shows you how to:</p>
<ul>
<li>
<p>Enable Fast App Resume</p>
</li><li>
<p>Manage your app’s backstack depending on how the app was relaunched</p>
</li></ul>
<p>For more info about Fast App Resume, see <a href="http://msdn.microsoft.com/library/windowsphone/develop/jj735579(v=vs.105).aspx">
Fast app resume for Windows Phone 8</a>.</p>
<p></p>
<p><b>Run the sample</b> </p>
<ol>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</li><li>
<p>The sample app has 3 pages that you can navigate through. When you first run the app, there is a button for creating a secondary Tile for page 3. Tap the
<span class="ui">Create Page 3 Tile</span> button, which will take you to Start where the Tile is pinned.</p>
</li><li>
<p>Stop debugging and press the Start button to return to Start.</p>
</li><li>
<p>Swipe the Start screen to the left to get to the App list. Press and hold on the sample app name, sdkFastResumeBackstack, and select
<span class="ui">pin to start</span> to create a primary Tile.</p>
</li></ol>
<p></p>
<p><b>Walkthrough of different resume experiences</b> </p>
<p>This section will take you through a few scenarios of launching and relaunching the app to demonstrate how the backstack is managed. The following section will show you the code that enables this user experience.</p>
<ul>
<li>
<p><b>Launching from a primary launch point and resuming from a primary launch point.</b>
</p>
<ol>
<li>
<p>On the Start screen, tap the app’s primary Tile.</p>
</li><li>
<p>On the main screen, tap the link to go to screen 2.</p>
</li><li>
<p>On screen 2, tap the Start button to return to Start.</p>
</li><li>
<p>On Start, tap the primary Tile again to resume the app.</p>
</li></ol>
<p>Note that the app resumes on page 2 and that pressing the back button will return to the main page. This is the expected user experience. When the user launches the app from a primary launch point and then resumes the app from a primary launch point, they
 expect that they are resuming the app and that the backstack will be the same as their previous session.</p>
</li><li>
<p><b>Launching from a primary Tile and resuming from a secondary Tile</b> </p>
<ol>
<li>
<p>On Start, tap the app’s primary Tile.</p>
</li><li>
<p>On the app’s main page, tap the link to go to page 2.</p>
</li><li>
<p>Tap the Start button to return to Start.</p>
</li><li>
<p>Tap the Page 3 Tile to relaunch the app.</p>
</li><li>
<p>Press the Back button to exit the app.</p>
</li></ol>
<p>Note that even though the app was resumed, the experience is that of a fresh instance of the app. The backstack was cleared as the app resumed.</p>
</li><li>
<p><b>Launching from a primary Tile and resuming from a primary Tile after a delay</b>
</p>
<ol>
<li>
<p>On Start, tap the app’s primary Tile.</p>
</li><li>
<p>On the app’s main page, tap the link to go to page 2.</p>
</li><li>
<p>Tap the Start button to return to Start.</p>
</li><li>
<p>Wait at least 30 seconds.</p>
</li><li>
<p>Tap the app’s primary Tile.</p>
</li></ol>
<p>Note that the app now returns to the main page, and if you hit the Back button, the backstack has been cleared and so you exit the app. In this case, because there was a delay between when the user left the app and when it was resumed, the app presents the
 user with a fresh experience rather than the resume experience. Whether your app considers the time between launch and relaunch, and how much time must pass to change the experience, depends on your app.</p>
</li></ul>
<p></p>
<p><b>How it works</b> </p>
<p>This section will describe the code that handles the backstack management for the sample app. Before getting started, it’s important to know that when apps fast resume, one or more navigations take place. During these navigations, you can use the navigation
 URI and the <a href="http://msdn.microsoft.com/library/windowsphone/develop/system.windows.navigation.navigationmode(v=vs.105).aspx">
NavigationMode</a> value associated with the navigation to determine how the backstack should be managed.
</p>
<p>To enable Fast App Resume, modify the <span value="DefaultTask"><span class="keyword">DefaultTask</span></span> element in WMAppManifest.xml to include the
<span value="ActivationPolicy"><span class="keyword">ActivationPolicy</span></span> of “Resume”.
</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>Visual Basic&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>&lt;DefaultTask Name=&quot;_default&quot; NavigationPage=&quot;MainPage.xaml&quot; ActivationPolicy=&quot;Resume&quot;/&gt;
</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p>Now, look at the code that creates the secondary Tile for page 3. This is found in MainPage.xaml.cs. Note that the navigation URI for the title includes the query string parameter “DeepLink=true”. The app can check for this value during launch and resume
 navigations to determine if the app was launched from the secondary Tile.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>C#&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>ShellTile.Create(new Uri(&quot;/page3.xaml?DeepLink=true&quot;, UriKind.Relative), NewTileData);</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p>All of the rest of the code that modifies the fast resume behavior of the app is found in App.xaml.cs.</p>
<p>First, a new enumeration, <span value="SessionType"><span class="keyword">SessionType</span></span>, is declared and a variable is declared to store a value from the enumeration. This value will be used to store the method with which the app was launched.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>C#&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>enum SessionType
{
   None,
   Home,
   DeepLink
}

// Set to Home when the app is launched from Primary tile.
// Set to DeepLink when the app is launched from Deep Link.
private SessionType sessionType = SessionType.None;
</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p>When an app resumes, the root frame will be navigated multiple times. If the root frame is navigated with
<span value="NavigationMode.Reset"><span class="keyword">NavigationMode.Reset</span></span>, then the app is being relaunched. This info is stored so that on the next navigation, the app knows that a relaunch is taking place. The
<span class="parameter">mustClearPagestack</span> variable is used for the relaunch timeout behavior. This value will be set to
<span value="true"><span class="keyword">true</span></span> if the relaunch occurred after 30 seconds – for a real app, this time will most likely be a longer interval.
</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>C#&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>// Set to true when the page navigation is being reset 
bool wasRelaunched = false;

// set to true when 30 seconds passed since the app was relaunched
bool mustClearPagestack = false;

</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p>The app lifetime event handlers manage the app’s resume timeout interval and session type. When the app is deactivated, the current time is saved in isolated storage. Later, when the app is activated, the current time is compared against the deactivation
 time and if the interval is greater than the timeout interval, set to 30 seconds for this sample,
<span class="parameter">mustClearPageStack</span> is set to <span value="true">
<span class="keyword">true</span></span>. Also during deactivation, the session type (None, Home, or DeepLink) of the current app instance is saved to isolated storage. This value is loaded during activation. This enables the app to present the same resume
 behavior in the case where the app is tombstoned while it is deactivated. The deactivation time and session type are cleared out of isolated storage in
<span value="Launch"><span class="keyword">Launch</span></span> and <span value="Exit">
<span class="keyword">Exit</span></span>.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>C#&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>
private void Application_Deactivated(object sender, DeactivatedEventArgs e)
{
  SaveCurrentDeactivationSettings();
}
private void Application_Activated(object sender, ActivatedEventArgs e)
{
   
  mustClearPagestack = CheckDeactivationTimeStamp();

  // If IsApplicationInstancePreserved is not true, then set the session type to the value
  // saved in isolated storage. This will make sure the session type is correct for an
  // app that is being resumed after being tombstoned.
  if (!e.IsApplicationInstancePreserved)
  {
    RestoreSessionType();
  }
}
private void Application_Launching(object sender, LaunchingEventArgs e)
{
  RemoveCurrentDeactivationSettings();
}
private void Application_Closing(object sender, ClosingEventArgs e)
{
  RemoveCurrentDeactivationSettings();
}
</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p>The following are helper methods used to by the lifetime event handlers above.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>public void SaveCurrentDeactivationSettings()
{
  if (AddOrUpdateValue(&quot;DeactivateTime&quot;, DateTimeOffset.Now))
  {
    settings.Save();
  }

  if (AddOrUpdateValue(&quot;SessionType&quot;, sessionType))
  {
    settings.Save();
  }
}

public void RemoveCurrentDeactivationSettings()
{
  RemoveValue(&quot;DeactivateTime&quot;);
  RemoveValue(&quot;SessionType&quot;);
  settings.Save();
}

bool CheckDeactivationTimeStamp()
{
  DateTimeOffset lastDeactivated;
           
  if (settings.Contains(&quot;DeactivateTime&quot;))
  {
    lastDeactivated = (DateTimeOffset)settings[&quot;DeactivateTime&quot;];
  }

  var currentDuration = DateTimeOffset.Now.Subtract(lastDeactivated);

  return TimeSpan.FromSeconds(currentDuration.TotalSeconds) &gt; TimeSpan.FromSeconds(30);
}

void RestoreSessionType()
{
  if (settings.Contains(&quot;SessionType&quot;))
  {
    sessionType = (SessionType)settings[&quot;SessionType&quot;];
  }
}

public bool AddOrUpdateValue(string Key, Object value)
{
  bool valueChanged = false;

  // If the key exists
  if (settings.Contains(Key))
  {
    // If the value has changed
    if (settings[Key] != value)
    {
      // Store the new value
      settings[Key] = value;
      valueChanged = true;
    }
  }
  // Otherwise create the key.
  else
  {
    settings.Add(Key, value);
    valueChanged = true;
  }
  return valueChanged;
}

// Helper method for removing a key/value pair from isolated storage
public void RemoveValue(string Key)
{
  // If the key exists
  if (settings.Contains(Key))
  {
    settings.Remove(Key);
  }
}

</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p>Next, the <span value="InitializePhoneApplication"><span class="keyword">InitializePhoneApplication</span></span> method, included with the project template, is modified. An event handler for the
<span value="RootFrame_Navigating"><span class="keyword">RootFrame_Navigating</span></span> method is added.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>C#&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>// Monitor deep link launching 
RootFrame.Navigating &#43;= RootFrame_Navigating</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p>The only other change to App.xaml.cs is the implementation of the <span value="Navigating">
<span class="keyword">Navigating</span></span> event handler for the app’s root frame. There is a lot of code in this method, but there are two things to keep in mind that can make it easier to understand. First, this method will be called multiple times
 because when an app resumes, there are multiple navigations that take place. Second, there are two possible outcomes from this method: one is that the method will determine that the backstack should be cleared. In this case, nothing needs to be done, the template
 code will clear the backstack automatically. The other outcome is that the method will determine that the backstack should not be cleared, in which case it removes the
<span value="ClearBackStackAfterReset"><span class="keyword">ClearBackStackAfterReset</span></span> handler from the root frame
<span value="Navigated"><span class="keyword">Navigated</span></span> event, which stops the backstack from being cleared.</p>
<p>This method performs the following tasks:</p>
<ol>
<li>
<p>It checks to see if the <span value="SessionType"><span class="keyword">SessionType</span></span> is
<span class="code">None</span>. If so, that means that this is a new app instance and sets the
<span class="code">sessionType</span> variable depending on whether the navigation URI contains “DeepLink=true” or “MainPage.xaml”.</p>
</li><li>
<p>It checks to see if the navigation mode is “Reset”. If so, this info is stored so that it can be used during the next navigation.</p>
</li><li>
<p>If the navigation has the navigation mode “New” and the previous navigation was a reset navigation, then the app checks the session type.</p>
</li><li>
<p>If the navigation URI is a deep link, then this info is stored and nothing more needs to be done because the template code will automatically clear the backstack.</p>
</li><li>
<p>If the navigation URI is to the main page and the app was previously launched from a deep link, then nothing is done and the template code automatically clears the backstack.</p>
</li><li>
<p>If the navigation URI is to the main page and the app was previously launched from the primary Tile, and if the timeout window hasn’t expired (<span value="mustClearPagestack"><span class="keyword">mustClearPagestack</span></span> isn’t
<span value="true"><span class="keyword">true</span></span>) then the <span value="ClearBackstackAfterReset">
<span class="keyword">ClearBackstackAfterReset</span></span> event handler is removed and the backstack will not be cleared.</p>
</li></ol>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>C#&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>void RootFrame_Navigating(object sender, NavigatingCancelEventArgs e)
{
  if (sessionType == SessionType.None &amp;&amp; e.NavigationMode == NavigationMode.New)
  {
    // This block will run if the current navigation is part of the app's initial launch

    // Keep track of Session Type 
    if (e.Uri.ToString().Contains(&quot;DeepLink=true&quot;))
    {
      sessionType = SessionType.DeepLink;
    }
    else if (e.Uri.ToString().Contains(&quot;/MainPage.xaml&quot;))
    {
      sessionType = SessionType.Home;
    }
  }

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
  if (e.NavigationMode == NavigationMode.Reset)
  {
    // This block will execute if the current navigation is a relaunch.
    // If so, another navigation will be coming, so this records that a relaunch just happened
    // so that the next navigation can use this info.
    wasRelaunched = true;
  }
  else if (e.NavigationMode == NavigationMode.New &amp;&amp; wasRelaunched)
  {
    // This block will run if the previous navigation was a relaunch
    wasRelaunched = false;

    if (e.Uri.ToString().Contains(&quot;DeepLink=true&quot;))
    {
      // This block will run if the launch Uri contains &quot;DeepLink=true&quot; which
      // was specified when the secondary tile was created in MainPage.xaml.cs

      sessionType = SessionType.DeepLink;
      // The app was relaunched via a Deep Link.
      // The page stack will be cleared.
    }
    else if (e.Uri.ToString().Contains(&quot;/MainPage.xaml&quot;))
    {
      // This block will run if the navigation Uri is the main page
      if (sessionType == SessionType.DeepLink)
      {
        // When the app was previously launched via Deep Link and relaunched via Main Tile, we need to clear the page stack. 
        sessionType = SessionType.Home;
      }
      else
      {
        if (!mustClearPagestack)
        {
          //The app was previously launched via Main Tile and relaunched via Main Tile. Cancel the navigation to resume.
          e.Cancel = true;
          RootFrame.Navigated -= ClearBackStackAfterReset;
        }
      }
    }

    mustClearPagestack = false;
  }&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
}</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
<p><b>See also</b> </p>
<ul>
<li>
<p><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj735579(v=vs.105).aspx">Fast app resume for Windows Phone 8</a>
</p>
</li></ul>
</div>
</div>
