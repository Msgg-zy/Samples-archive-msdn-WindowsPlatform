# FMAPI detect boot sector sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Storage
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:19:28
## Description

<div id="mainSection">
<p>This sample shows how to use the FMAPI <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd239110">
<b>DetectBootSector</b></a> function to detect whether the first sector on a volume is a valid boot sector.
</p>
<p>This sample is written in C&#43;&#43;.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;FMAPI can only be used in the Windows Preinstallation Environment (WinPE). Applications that use FMAPI must license WinPE.
</p>
<p></p>
<p>This sample contains the following files:</p>
<ul>
<li>DetectBootSector.cpp </li><li>DetectBootSector.sln </li><li>DetectBootSector.vcxproj </li></ul>
<p></p>
<p>This sample requires Microsoft Visual Studio&nbsp;2013 and will not compile in Microsoft Visual Studio Express&nbsp;2013 for Windows.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd239113">File Management API (FMAPI)</a>
<h3>Operating system requirements</h3>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8.1 </dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012&nbsp;R2 </dt></td>
</tr>
</tbody>
</table>
<h3>Build the sample</h3>
<p>To build this sample from the command prompt:</p>
<ol>
<li>Open the <b>Command Prompt</b> window and navigate to the DetectBootSector directory.
</li><li>Type the following command after the command prompt: <b>msbuild DetectBootSector.sln</b>.
</li></ol>
<p></p>
<p>To build this sample using Microsoft Visual Studio:</p>
<ol>
<li>Open File Explorer and navigate to the DetectBootSector directory. </li><li>Double-click the icon for DetectBootSector.sln to open the file in Visual Studio.
</li><li>In the <b>Build</b> menu, choose <b>Build solution</b>. The sample will be built in the default \Debug or \Release directory.
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p class="note"><b>Note</b>&nbsp;&nbsp;All FMAPI samples must be run in a Windows&nbsp;8.1 or Windows Server&nbsp;2012&nbsp;R2 WinPE environment.</p>
<p>To run the sample:</p>
<ol>
<li>Navigate to the directory that contains the new executable file, using the command prompt or File Explorer.
</li><li>Copy the executable file into a directory that is accessible from WinPE. </li><li>Boot to WinPE and open a <b>Command Prompt</b> window. Navigate to where the executable file is located.
</li><li>Type the name of the executable file at the command prompt. </li></ol>
<p></p>
</div>
