# Hyper-V Integration Services sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Win32
## Topics
* desktop
## IsPublished
* True
## ModifiedDate
* 2013-10-17 01:15:52
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Hyper-V Integration Services WMI APIs to interact with a virtual machine. The sample demonstrates how to perform the following operation:</p>
<ul>
<li>Copy file to a virtual machine <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/">
<b>CopyFilesToGuest</b></a> method. </li></ul>
<p></p>
<p>This sample is written in C# and requires some experience with WMI programming.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/">Hyper-V integration services API</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh850319">Hyper-V WMI provider (V2)</a>
</dt></dl>
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
<ol>
<li>
<p>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file titled IntegrationServices.sln.</p>
</li><li>
<p>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<h3>Run the sample</h3>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample must be run as a Hyper-V administrator.</p>
<p></p>
<p>This sample can be run in the following mode.</p>
<h4><a id="Copy_a_file_to_a_virtual_machine"></a><a id="copy_a_file_to_a_virtual_machine"></a><a id="COPY_A_FILE_TO_A_VIRTUAL_MACHINE"></a>Copy a file to a virtual machine</h4>
<p>To run this sample in this mode, follow these steps.</p>
<ol>
<li>
<p>Enter the debug command line arguments for the project. The usage of this sample is:</p>
<p><b>IntegrationServices.exe CopyFileToGuest </b><i>vmName</i></p>
<p>where <i>vmName</i> is the name of the virtual machine.</p>
</li><li>
<p>To debug the app and then run it from Visual Studio&nbsp;2013, press F5 or use <b>Debug</b> &gt;
<b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use <b>
Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</li><li>If the operation fails, an error will be displayed in the console window. </li></ol>
</div>
