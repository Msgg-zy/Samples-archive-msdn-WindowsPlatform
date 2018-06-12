# Company Hub Sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* company apps
* lob apps
* enterprise
## IsPublished
* True
## ModifiedDate
* 2013-05-28 04:42:47
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample illustrates the basic components and functionality required to build a Company Hub app. When the app runs, it enumerates the company apps that are available to a user, and then the user can select, install, and launch an app from the list.
</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>This sample requires additional work to enable the functionality described. For details, see
<span class="term">Steps to build and run the sample</span>.</p>
</td>
</tr>
</tbody>
</table>
</div>
<p>This sample shows you how to do the following:</p>
<ul>
<li>
<p>Define a schema for company app management.</p>
</li><li>
<p>Enumerate the install status of company apps.</p>
</li><li>
<p>Allow a user to initiate the installation of a company app.</p>
</li><li>
<p>Allow a user to launch an installed company app.</p>
</li></ul>
<p>This sample uses the Windows Phone installation manager and app model APIs. For more info about company apps and using a Company Hub in Windows&nbsp;Phone&nbsp;8, see
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206943(v=vs.105).aspx">
Company app distribution for Windows Phone</a> and <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj720571(v=vs.105).aspx">
Developing a Company Hub app</a>. For more info about the APIs, see the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.phone.management.deployment(v=vs.105).aspx">
Windows.Phone.Management.Deployment</a> and <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.aspx">
Windows.ApplicationModel</a> API reference pages.</p>
<p></p>
<h3 class="procedureSubHeading">Steps to build and run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Register as a company account on Windows Phone Dev Center. For more info about registering for a Dev Center account, see
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206719(v=vs.105).aspx">
Registration info</a>.</p>
</li><li>
<p>Acquire an enterprise mobile code signing certificate from Symantec. This certificate is required to generate an application enrollment token (AET) and sign company apps. To acquire the certificate, visit the Symantec
<a href="http://go.microsoft.com/fwlink/?LinkId=268441">Enterprise Mobile Code Signing Certificate</a> website.</p>
</li><li>
<p>Import the certificate from Symantec and then export it in PFX format. Be sure to export the private key with the certificate. For info about importing and exporting the certificate, see
<a href="http://go.microsoft.com/fwlink/?LinkId=299100">How to install the Windows Phone Private Enterprise Root and Intermediate certificates</a> on the Symantec website and
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj735576(v=vs.105).aspx">
How to generate an application enrollment token</a> on MSDN.</p>
</li><li>
<p>Create an AET using the AETGenerator tool provided with Windows&nbsp;Phone&nbsp;SDK&nbsp;8.0. The AET is used to enroll phones in the company account, which is a prerequisite for installing apps published by the company. For more info about creating the AET, see
<a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj735576(v=vs.105).aspx">
How to generate an application enrollment token</a>.</p>
</li><li>
<p>Obtain or create a few apps to use with the sample. These mock company apps are just for demonstration purposes and do not need to do anything, but they must match the publisher ID of the Company Hub app and should have an associated app icon.</p>
</li><li>
<p>Prepare the company apps for distribution using the guidance at <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/dn168929(v=vs.105).aspx">
Preparing company apps for distribution</a>.</p>
</li><li>
<p>Upload the prepared company apps (XAPs) and their app icons to a secure site (such as Azure storage) that the Company Hub app can access.</p>
</li><li>
<p>Create an XML file that lists the company apps, their download URLs, and their product IDs as shown in the following code example. Although the format shown here isn’t required for Company Hubs in general, it is required for this specific sample to function.</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>&lt;?xml version=&quot;1.0&quot;?&gt;
&lt;!--This is an example file that demonstrates how a company might expose metadata and download 
    URLs for their XAPs and icons. The data below assumes that the XAPs and icons are stored in
    Azure storage blobs, but they can be stored in any secure site that is accessible from the 
    app. For more information about this file, see the comments in MainPage.xaml.cs.--&gt;
&lt;Applications&gt;
  &lt;App Name=&quot;CompanyApp1&quot;
       IconUrl=&quot;http://contosostorage.blob.core.windows.net/companyapps/CompanyApp1.png&quot;
       XapUrl=&quot;http://contosostorage.blob.core.windows.net/companyapps/CompanyApp1_Debug_AnyCPU.xap&quot; Version=&quot;1.0.0.0&quot;
       ProductId=&quot;{f42567e5-14d8-4bfc-ad05-9dc2150c7614}&quot; Description=&quot;This is CompanyApp1&quot; /&gt; 
  &lt;App Name=&quot;CompanyApp2&quot;
       IconUrl=&quot;http://contosostorage.blob.core.windows.net/companyapps/CompanyApp2.png&quot;
       XapUrl=&quot;http://contosostorage.blob.core.windows.net/companyapps/CompanyApp2_Debug_AnyCPU.xap&quot; Version=&quot;1.0.0.0&quot;
       ProductId=&quot;{6695006b-a359-4f60-aed4-ca07d2ae000d}&quot; Description=&quot;This is CompanyApp2&quot; /&gt;
  &lt;App Name=&quot;CompanyApp3&quot;
       IconUrl=&quot;http://contosostorage.blob.core.windows.net/companyapps/CompanyApp3.png&quot;
       XapUrl=&quot;http://contosostorage.blob.core.windows.net/companyapps/CompanyApp3_Debug_AnyCPU.xap&quot; Version=&quot;1.0.0.0&quot;
       ProductId=&quot;{4776d64b-14e7-4cc2-b20a-fb080ffc6f33}&quot; Description=&quot;This is CompanyApp3&quot; /&gt; 
&lt;/Applications&gt;</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
</li><li>
<p>Upload the XML file to a secure site that the Company Hub app can access.</p>
</li><li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.
</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.</p>
</li><li>
<p>Modify the URI used by the <span value="WebClient"><span class="keyword">WebClient</span></span> in the Company Hub sample MainPage.xaml.cs file with the URL for the XML file you created.
</p>
<div class="code"><span>
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th>&nbsp;</th>
<th></th>
</tr>
<tr>
<td colspan="2">
<pre>client.DownloadStringAsync(new Uri(&quot;http://contosostorage.blob.core.windows.net/companyapps/Applications.xml&quot;));</pre>
</td>
</tr>
</tbody>
</table>
</span></div>
</li><li>
<p>Select <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.</p>
</li><li>
<p>Prepare the Company Hub app sample for distribution using the guidance at <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/dn168929(v=vs.105).aspx">
Preparing company apps for distribution</a>.</p>
</li><li>
<p>Email the AET file and the Company Hub XAP to your device to test the sample.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>Alternatively, these files could be provided through a secure website. Although not necessary for the sample, when distributing a production Company Hub, Microsoft recommends using Information Rights Management (IRM) if you choose email for the app distribution
 method.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>From email, tap the AET file to enroll the device.</p>
</li><li>
<p>From email, tap the XAP to install the Company Hub app.</p>
</li><li>
<p>Go to the App list on the phone and launch the Company Hub app to view, install, and launch your company apps.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>For additional info about this process, see <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206943(v=vs.105).aspx">
Company app distribution for Windows Phone</a> on MSDN.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li></ol>
</div>
<p><b>See also</b> </p>
<ul>
<li>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206943(v=vs.105).aspx">Company app distribution for Windows Phone</a>
</p>
</li><li>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206943(v=vs.105).aspx">Developing a Company Hub app</a>
</p>
</li></ul>
</div>
</div>
