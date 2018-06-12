# Basic Storage Recipes
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* storagefile
* storagefolder
* local storage
## IsPublished
* True
## ModifiedDate
* 2013-06-05 04:49:06
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>The sample demonstrates the basics of reading and writing text and binary files using the
<b>StorageFolder</b> and <b>StorageFile</b> classes. When the app runs, it displays a menu of individual tasks that you can test.
</p>
<p>This sample shows you how to use the following APIs:</p>
<div class="caption"></div>
<div class="tableSection">
<table width="50%" cellspacing="2" cellpadding="5" frame="lhs">
<tbody>
<tr>
<th>
<p>Group</p>
</th>
<th>
<p>API methods</p>
</th>
</tr>
<tr>
<td>
<p>Location of important folders</p>
</td>
<td>
<p>Package.Current.InstalledLocation</p>
<p>ApplicationData.Current.LocalFolder</p>
</td>
</tr>
<tr>
<td>
<p><b>StorageFolder</b> methods</p>
</td>
<td>
<p>CreateFileAsync</p>
<p>CreateFolderAsync</p>
<p>DeleteAsync</p>
<p>GetFilesAsync</p>
<p>GetFolderAsync</p>
<p>GetFoldersAsync</p>
<p></p>
</td>
</tr>
<tr>
<td>
<p><b>StorageFile</b> methods</p>
</td>
<td>
<p>DeleteAsync</p>
<p>GetFileAsync</p>
<p>OpenAsync</p>
<p>OpenReadAsync</p>
<p>OpenStreamForWriteAsync</p>
</td>
</tr>
<tr>
<td>
<p><b>DataReader</b> methods</p>
</td>
<td>
<p>LoadAsync</p>
<p>ReadString</p>
</td>
</tr>
<tr>
<td>
<p><b>DataWriter</b> methods</p>
</td>
<td>
<p>WriteString</p>
<p>StoreAsync</p>
</td>
</tr>
<tr>
<td>
<p><b>Stream</b> methods</p>
</td>
<td>
<p>CopyToAsync</p>
</td>
</tr>
</tbody>
</table>
</div>
<p>This sample also demonstrates the following features and tasks:</p>
<ul>
<li>
<p>Recursive navigation of directory free.</p>
</li><li>
<p>Passing data from one page to another page without using the query string in the page URI.</p>
</li><li>
<p>Persisting app-level data when the app is deactivated.</p>
</li><li>
<p>Capturing the output of the <span value="PhotoChooserTask"><span class="keyword">PhotoChooserTask</span></span>.</p>
</li><li>
<p>Capturing the output of the <span value="CameraCaptureTask"><span class="keyword">CameraCaptureTask</span></span>.</p>
</li><li>
<p>Including all UI strings as localizable resources.</p>
</li></ul>
<p>For more info about file handling in Windows&nbsp;Phone&nbsp;8, see <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj681698(v=vs.105).aspx">
Quickstart: Working with files and folders in Windows Phone 8</a>.</p>
<p><b>Build the sample</b> </p>
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.
</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.
</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.
</p>
</li></ol>
<p><b>Run the sample</b> </p>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
<p><b>How to work with photos in the samples</b> </p>
<p>To test the <span class="ui">Copy existing photo to local folder</span> task in the Emulator, you first have to visit the Photos Hub one time to populate it with some sample images. By default there are no sample photos.</p>
<p>To test the <span class="ui">Save new photo to local folder</span> function in the Emulator, press F7 in the camera view to take a picture, and then click
<span class="ui">accept</span>. The picture is simply a gray rectangle.</p>
</div>
</div>
