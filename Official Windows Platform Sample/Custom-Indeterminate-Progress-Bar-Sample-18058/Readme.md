# Custom Indeterminate Progress Bar Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
* Windows Phone 8
## Topics
* User Interface
## IsPublished
* True
## ModifiedDate
* 2013-03-05 01:13:11
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>The CustomIndeterminateProgressBar sample was created to solve two problems: </p>
<ul>
<li>
<p>The need for an indeterminate progress bar that runs on the compositor thread for better performance.</p>
</li><li>
<p>The need for a progress bar that is able to handle scaling due to orientation changes.</p>
</li></ul>
<p>The solution is implemented in both the XAML code, as well as an additional .cs file.
</p>
<p><span class="label">In the XAML Code</span> </p>
<ol>
<li>
<p>A Style in App.xaml for CustomIndeterminateProgressBar contains a custom VisualState for the Indeterminate state. The DoubleAnimationUsingKeyFrames object is used to animate the indeterminate progress bar.</p>
</li><li>
<p>The Value of each key frame is a number that ends with &quot;.1&quot; or “.2”, which is used as a kind of naming convention to identify the values. When the orientation of the page changes, a custom processor looks for values with this suffix and converts them to
 a percentage of the control’s width or height, respectively.</p>
</li><li>
<p>The CustomIndeterminateProgressBar is instantiated in MainPage.xaml. In the sample, a button controls whether the progress bar is visible or not, and toggles both Visibility and the IsIndeterminate flag. For better performance, when you are building an app,
 you would want to ensure that the progress bar is both not visible and not running when it is not being displayed on the screen.</p>
</li></ol>
<p><span class="label">In the Code-behind File</span> </p>
<p>The RelativeAnimatingContentControl.cs file contains the logic that scales the indeterminate progress bar when orientation changes occur. Upon an orientation change, the following steps are taken:</p>
<ol>
<li>
<p>For any VisualState that contains a Storyboard, each DoubleAnimation or DoubleAnimationUsingKeyFrames value is sent to one of two processing methods.</p>
</li><li>
<p>Any double animation key frame value that ends in &quot;.1&quot; is stripped of the &quot;.1&quot; and updated to a percentage of the width of the control. For example, Value=&quot;33.1&quot; is used for a percentage of 33 percent. If the orientation changes and the control’s new width
 is 480, this key frame value would be changed to approximately 160.</p>
</li><li>
<p>Any double animation key frame value that ends in &quot;.2&quot; is stripped of the &quot;.2&quot; and updated to a percentage of the height of the control.</p>
</li></ol>
<p>For more info about this sample, see <a href="http://go.microsoft.com/fwlink/?LinkID=206640">
How to: Create a Custom Indeterminate Progress Bar for Windows Phone</a>.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Important Note:</b> </th>
</tr>
<tr>
<td>
<p>You must install the Windows&nbsp;Phone&nbsp;SDK to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
</td>
</tr>
</tbody>
</table>
</div>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>This sample is packaged as a Windows&nbsp;Phone&nbsp;7.5 project. It can be converted to a Windows&nbsp;Phone&nbsp;8 project, by changing the target Windows Phone OS version of the project. To create a Windows&nbsp;Phone&nbsp;8 project, you must be running the Windows&nbsp;Phone&nbsp;SDK&nbsp;8.0 on
 Visual Studio 2012. You can download the latest version of the SDK from <a href="http://dev.windowsphone.com/downloadsdk">
http://dev.windowsphone.com/downloadsdk</a>.</p>
<p>To convert the sample to a Windows&nbsp;Phone&nbsp;8 project:</p>
<ol>
<li>
<p>Double-click the <span class="ui">.sln</span> file to open the solution in Visual Studio.</p>
</li><li>
<p>Right-click the project in the <span class="ui">Solution Explorer</span> and select
<span class="ui">Properties</span>. This opens the <span class="ui">Project Properties</span> window.</p>
</li><li>
<p>In the <span class="ui">Application</span> tab of the Project Properties window, select
<span class="ui">Windows Phone OS 8.0</span> from the <span class="ui">Target Windows Phone OS Version</span> dropdown. A dialog will appear asking if you want to upgrade this project to Windows Phone OS 8.0.</p>
</li><li>
<p>Select <span class="ui">Yes</span> to upgrade the project.</p>
</li></ol>
</td>
</tr>
</tbody>
</table>
</div>
</div>
</div>
