# Windows PowerShell Template Provider 01 Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Powershell
## IsPublished
* True
## ModifiedDate
* 2013-10-17 01:17:34
## Description

<div id="mainSection">
<p>This sample creates a template for a provider that hooks into the Windows PowerShell namespaces. It contains all possible provider overrides and interfaces.
</p>
<p>A provider developer can copy this file, change the name of the file, delete those interfaces and methods the provider doesn't need to implement or override, and use the remaining code as a template to create a fully functional provider.
</p>
<p><b>Sample Objectives</b></p>
<p>This sample demonstrates the following: </p>
<ul>
<li>How to create a TemplateProvider class that implements the following interfaces:
<ol>
<li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551375"><b>NavigationCmdletProvider</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551365"><b>IPropertyCmdletProvider</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551352"><b>IContentCmdletProvider</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551362"><b>IDynamicPropertyCmdletProvider</b></a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551369"><b>ISecurityDescriptorCmdletProvider</b></a>
</li></ol>
</li></ul>
<p></p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/?LinkID=178145">Windows PowerShell</a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551375"><b>NavigationCmdletProvider</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551365"><b>IPropertyCmdletProvider</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551352"><b>IContentCmdletProvider</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551362"><b>IDynamicPropertyCmdletProvider</b></a>
</dt><dt><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms551369"><b>ISecurityDescriptorCmdletProvider</b></a>
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
<p></p>
<ol>
<li>Start Microsoft Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>
Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.
<p>The executable will be built in the default<b> \bin</b> or <b>\bin\Debug</b> directory.</p>
</li></ol>
<p></p>
<h3>Run the sample</h3>
<p></p>
<ol>
<li>Start a Command Prompt. </li><li>Navigate to the folder containing the sample executable. </li><li>Run the executable. </li><li>See the output results and the corresponding code. </li></ol>
<p></p>
</div>
