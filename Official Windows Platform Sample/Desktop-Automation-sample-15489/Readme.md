# Desktop Automation sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Automation
## IsPublished
* True
## ModifiedDate
* 2013-10-17 02:19:20
## Description

<div id="mainSection">
<p>Automating desktop applications may require programmatic dismissal of the Start menu. This sample shows how to create a program that can be used as part of automation to dismiss the Start menu and apps. This binary should be run only for automated testing,
 and should be run prior to starting an automation run. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;This sample requires Microsoft Visual Studio Ultimate&nbsp;2013 to build.
</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. These downloadable samples
 are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile and run the sample. For more information about the programming
 models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the Windows&nbsp;8.1 documentation available in the Windows Developer Center. This sample is provided as-is in order to
 indicate or demonstrate the functionality of the programming models and feature APIs for Windows&nbsp;8.1 and/or Windows Server&nbsp;2012&nbsp;R2. Please provide feedback on this sample!</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="security.using_makecert">Using MakeCert</a> </dt></dl>
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
<p>These steps are meant only for test machines running UI automation. It will require the creation of a self-signed root certificate.</p>
<ol>
<li>Make sure that the UIAccess is requested in the application manifest. The sample already has this set, and can be changed under
<b>Solution Explorer -&gt; Properties -&gt; Linker -&gt; Manifest Tool -&gt; UAC Bypass UI Protection</b>.
</li><li>Create a self-signed root authority certificate and export the private key. Use the MakeCert tool to do this. For example, the following command creates a self-signed certificate with a subject name of &quot;CN=TempCA&quot;:
<b>makecert -n &quot;CN=TempCA&quot; -r -sv TempCA.pvk TempCA.cer</b> You will be prompted to provide a password to protect the private key. This password is required when creating a certificate signed by this root certificate. It's important to keep this PVK in a safe
 place! Binaries signed with this certificate can circumvent a number of security restrictions.
</li><li>Add the self-signed certificate to the trusted root store on the machines running automation. CertUtil can be used to do this. For example, run this command with administrator privileges:
<b>certutil -addstore root TempCA.cer</b> </li><li>Create a certificate signed by the self-signed root authority certificate. Again, use the MakeCert tool. For example, the following command creates a certificate signed by the TempCA root authority certificate with a subject name of &quot;CN=SignedByCA&quot; using
 the private key of the issuer:<b> makecert -sk SignedByCA -iv TempCA.pvk -n &quot;CN=SignedByCA&quot; -ic TempCA.cer SignedByCA.cer -sr currentuser -ss MyCertStore
</b></li><li>Sign the created binary(in this example, DesktopAutomation.exe). SignTool can do this. For example, the following command signs
<b>DesktopAutomation.exe</b>: <b>signtool sign /f SignedByCA.cer DesktopAutomation.exe</b>
</li><li>Install the binary to the Program Files or Windows directory. </li></ol>
<p></p>
<h3>Run the sample</h3>
<h3><a id="Troubleshooting"></a><a id="troubleshooting"></a><a id="TROUBLESHOOTING"></a>Troubleshooting</h3>
<p>Q: The sample fails with error code 5 (<b>ERROR_ACCESS_DENIED</b>) </p>
<p>A: The sample is failing to get UIAccess privileges. </p>
<ul>
<li>Make sure the executable is placed in either the Program Files or Windows directory.
</li><li>Make sure that UIAccess=true is set in the application manifest (see step 1).
</li><li>If you have disabled UAC (LUA) via group policy, re-enable it. Set it to &quot;Never Notify&quot; mode if you must run your tests with UAC disabled. Set &quot;HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\EnableLUA = 1&quot; to turn UAC on. Set &quot;HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\ConsentPromptBehaviorAdmin
 = 0&quot; to turn on &quot;Never Notify&quot; mode. </li></ul>
<p></p>
<p>Q: When running the sample, a dialog appears with &quot;A referral was returned from the server&quot;.
</p>
<p>A: The executable is not signed with a certificate, or the certificate does not chain to a trusted root authority See steps 2-5 above under Building the Sample.
</p>
</div>
