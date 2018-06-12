# DirectWrite font enumeration sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* DirectX
## Topics
* Audio and video
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:12:20
## Description

<div id="mainSection">
<p>This sample shows how to use <a href="http://msdn.microsoft.com/library/windows/apps/dd368038">
DirectWrite</a> to enumerate the fonts in the system font collection on a user's device in a
<a href="http://msdn.microsoft.com/library/windows/apps/br229773">WinJS</a> application.
</p>
<p>These topics provide more info about the APIs used in this sample:</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br229773">WinJS</a> for the interface and interacting with the
<a href="http://msdn.microsoft.com/library/windows/apps/dd368038">DirectWrite</a> DLL you create.
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dd368038">DirectWrite</a>, which you use to enumerate the fonts and get the string names based on the user's locale.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/hh465496">WinJS.UI.ListView</a> control which you use to display the fonts on the screen once you have the list
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/dd368183"><b>IDWriteFactory</b></a> interface, which you use to create
<a href="http://msdn.microsoft.com/library/windows/apps/dd368038">DirectWrite</a> objects.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/dd368183_GetSystemFontCollection">
<b>IDWriteFactory::GetSystemFontCollection</b></a> method, which actually returns the list of fonts available.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/dd368214"><b>IDWriteFontCollection</b></a> interface, which holds the collection that
<a href="http://msdn.microsoft.com/library/windows/apps/dd368183_GetSystemFontCollection">
<b>IDWriteFactory::GetSystemFontCollection</b></a> returns. </li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/dd371042"><b>IDWriteFontFamily</b></a> interface, which allows you to retrieve the names of the fonts.
</li><li>The <a href="http://msdn.microsoft.com/library/windows/apps/dd371250"><b>IDWriteLocalizedStrings</b></a> interface, which you use to return the localized name of the font.
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dd368183"><b>IDWriteFactory</b></a>
</dt></dl>
<h3>Operating system requirements</h3>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012 </dt></td>
</tr>
</tbody>
</table>
<h3>Build the sample</h3>
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
