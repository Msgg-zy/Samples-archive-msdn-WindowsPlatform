# Creating a Windows Runtime EXE component with C++ sample  (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* App model
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:26:21
## Description

<div id="mainSection">
<p>This sample shows how to create an out-of-process EXE component in Microsoft Visual C&#43;&#43; that's used in C&#43;&#43;/CX, JavaScript, and C# client code.
</p>
<p>The OvenServer project contains a runtime class named Oven, which implements an IOven interface and an IAppliance interface and shows how to declare properties, methods, and events by using the Microsoft::WRL namespace. For more info, see
<a href="http://msdn.microsoft.com/library/windows/apps/br224617">Windows Runtime C&#43;&#43; reference</a>.</p>
<p>The WRLOutOfProcessWinRTComponent_server project produces an EXE file named Microsoft.SDKSamples.Kitchen.exe. The WRLOutOfProcessWinRTComponent_server project is built into the Visual&nbsp;C&#43;&#43; component extensions (C&#43;&#43;/CX) project by including the generated header
 file, Microsoft.SDKSamples.Kitchen.h. The WRLOutOfProcessWinRTComponent_server project and its corresponding proxy/stub project are referenced directly in the provided JavaScript and C# projects.</p>
<p>Also, the sample shows how to use the <a href="http://msdn.microsoft.com/library/windows/apps/br224651">
<b>RoOriginateError</b></a> function to report an error and an informative string to an attached debugger.</p>
<p>You can implement an in-process server by using the Microsoft::WRL namespace. For more info, see
<a href="http://go.microsoft.com/fwlink/p/?linkid=258332">Creating a Windows Runtime DLL component sample (C&#43;&#43;)</a>. Also, you can implement a component by using C&#43;&#43;/CX. For more info, see
<a href="http://go.microsoft.com/fwlink/p/?linkid=258330">Creating a Windows Runtime in-process component sample (C&#43;&#43;/CX)</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=258332">Creating a Windows Runtime DLL component sample (C&#43;&#43;)</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=258330">Creating a Windows Runtime in-process component sample (C&#43;&#43;/CX)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224617">Windows Runtime C&#43;&#43; reference</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224651"><b>RoOriginateError</b></a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br224617">Windows Runtime C&#43;&#43; reference</a>
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
