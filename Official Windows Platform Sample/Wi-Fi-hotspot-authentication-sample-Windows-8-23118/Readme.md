# Wi-Fi hotspot authentication sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Networking
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:14:52
## Description

<div id="mainSection">
<p>This sample demonstrates how to use the Windows&nbsp;8 Mobile Broadband API (<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a>) to perform Wi-Fi hotspot authentication. This mechanism can be used
 as an alternative to configuring static credentials for a Wi-Fi hotspot.</p>
<p>The test hotspot should support WISPr 1.0. This sample is most appropriate for networks that use dynamically generated/retrieved credentials, since static credentials can be supplied in the provisioning file without relying on background events. However,
 static credentials may be used by the test hotspot.</p>
<p>If you are creating a mobile broadband operator app based on this sample, you should also have completed the steps from the
<a href="http://go.microsoft.com/fwlink/p/?linkid=242058">Development Guide to Creating Mobile Operator Apps</a> whitepaper.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=242068">Windows 8 Integration for Wireless Hotspot Operators</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=242064">Providing Mobile Broadband Metadata</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh758372"><b>HotspotAuthenticationContext</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh758383"><b>HotspotAuthenticationEventDetails</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224794"><b>IBackgroundTask</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br224794Instance"><b>IBackgroundTaskInstance</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h3>Related technologies</h3>
<a href="http://msdn.microsoft.com/library/windows/apps/br241148"><b>Windows.Networking.NetworkOperators</b></a> ,
<a href="http://msdn.microsoft.com/library/windows/apps/br224847"><b>Windows.ApplicationModel.Background</b></a>
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
<ol>
<li>Start Visual Studio&nbsp;2012 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>The Wi-Fi hotspot authentication sample has two requirements to run:</p>
<ul>
<li>Windows must be provisioned to trigger the application when authenticating with a certain hotspot. This is achieved by provisioning a WLAN profile with a corresponding configuration. The provisioning XML must either be signed to be consumed by the provisioning
 API, or this sample must be part of a privileged mobile network operator companion application.
</li><li>The provisioning XML built into this application must be modified to match the hotspot's SSID and signed before it can be applied.
</li></ul>
<p></p>
<p>The steps for completing these requirements and running the sample are described below:</p>
<ol>
<li><b>Modify the Provisioning Metadata XML file to match your hotspot by opening ProvisioningData.xml and adjusting the following fields:</b>
<ol>
<li>CarrierProvisioning\Global\CarrierID:
<ul>
<li>If writing a mobile broadband operator app, use the same GUID that you specified as the
<b>Service Number</b> in the metadata authoring wizard. </li><li>If writing a hotspot-only app, generate a new GUID with Visual Studio. On the Tools menu, click
<b>Create GUID</b>. Click <b>Copy</b> to transfer the new GUID to the Clipboard. </li></ul>
</li><li>CarrierProvisioning\Global\SubscriberID:
<ul>
<li>If writing a mobile broadband operator app, use the International Mobile Subscriber Identity (IMSI) of the mobile broadband SIM.
</li><li>If writing a hotspot-only app, use any unique identifier appropriate to your service, such as a username or account number.
</li></ul>
</li><li>CarrierProvisioning\WLANProfiles\WLANProfile\name: Name of your service or test Access Point (AP).
</li><li>CarrierProvisioning\WLANProfiles\WLANProfile\SSIDConfig\SSID\name: Configured SSID of your test hotspot.
</li><li>CarrierProvisioning\WLANProfiles\WLANProfile\MSM\security\HotspotProfile\ExtAuth\ExtensionId: Package family name of the application. To retrieve this name:
<ul>
<li>In Visual Studio, open package.appmanifest </li><li>Click on the <b>Packaging</b> tab </li><li>Copy the <b>Package Family Name</b> </li></ul>
</li></ol>
</li><li><b>Authenticate access to the Provisioning Agent APIs</b>
<ul>
<li><b>Hotspot-only operators: Sign the modified Provisioning Metadata XML file</b>
<ol>
<li>Open a PowerShell console </li><li>Type the following command to import the Provisioning tools:
<pre class="syntax"><code>Import-Module &quot;&lt;path_to_Win8_sdk&gt;\bin\&lt;arch&gt;\ProvisioningTestHelper.psd1&quot;</code></pre>
</li><li>Create and install a test Extended Validation certificate:
<pre class="syntax"><code>Install-TestEVCert -CertName &lt;Certificate Name&gt;</code></pre>
</li><li>Use the new certificate to sign the provisioning file:
<pre class="syntax"><code>ConvertTo-SignedXml -InputFile &lt;complete path to the input XML file&gt; -OutputFile &lt;complete path to the output XML file&gt; -CertName &lt;name of the certificate used to sign the xml&gt;</code></pre>
</li><li>Replace ProvisioningData.xml with the signed file. </li></ol>
</li><li><b>Mobile broadband operators: Modify the sample to use an unsigned Provisioning Metadata XML file</b>
<ol>
<li>Open HotspotAuthenticationApp\Initialization.xaml.cs (or Initialization.xaml.cpp, or js\initialization.js) in Visual Studio
</li><li>Locate the call to the ProvisioningAgent constructor:
<pre class="syntax"><code>// Create ProvisiongAgent Object 
var provisioningAgent = new ProvisioningAgent();
</code></pre>
</li><li>Replace this with a call to the privileged ProvisioningAgent interface:
<pre class="syntax"><code>// Create ProvisiongAgent Object 
var accountIds = Windows.Networking.NetworkOperators.MobileBroadbandAccount.AvailableNetworkAccountIds;

if( accountIds.Count == 0 ) {
  // Throw Exception here; metadata not correctly installed
}

// For simplicity, using the first account ID.
var provisioningAgent = Windows.Networking.NetworkOperators.ProvisioningAgent.CreateFromNetworkAccountId(accountIds[0]); 
</code></pre>
</li></ol>
</li></ul>
</li><li><b>Provide appropriate credentials for your test AP</b>
<ul>
<li><b>If the test AP uses fixed credentials:</b> Modify HotspotAuthenticationTask\ConfigStore.cs to return a valid username and password for your test AP.
</li><li><b>If the test AP uses dynamic credentials:</b> In HotspotAuthenticationTask\BackgroundTask.cs, replace the reference to ConfigStore with your own business logic to generate/retrieve appropriate credentials for the network.
</li></ul>
</li></ol>
<p></p>
<p>To run this sample after completing the steps above, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 for Windows&nbsp;8 (any SKU). (Or select the corresponding options from
 the <b>Debug</b> menu.)</p>
</div>
