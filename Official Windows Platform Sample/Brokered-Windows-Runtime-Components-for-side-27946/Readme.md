# Brokered Windows Runtime Components for side-loaded Windows Store apps - Client
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
* Windows Store app
## Topics
* IPC
* Sideloading
## IsPublished
* True
## ModifiedDate
* 2014-04-21 10:51:44
## Description

<p><span style="font-size:small">This sample shows you how to:</span></p>
<p><span style="font-size:small">Create a desktop server component.</span></p>
<p><span style="font-size:small">Create a side-loaded Windows Store App client that calls into the desktop component.</span></p>
<p><span style="font-size:small">This sample is written in C# and requires Visual Studio 2013 Update 2 and Windows 8.1 Update.&nbsp;</span></p>
<p>&nbsp;</p>
<p><span style="font-size:small">Get the Server component of this sample here:&nbsp;<a href="http://code.msdn.microsoft.com/windowsapps/Brokered-Windows-Runtime-9d64cada">http://code.msdn.microsoft.com/windowsapps/Brokered-Windows-Runtime-9d64cada</a></span></p>
<p><span style="font-size:small">The Windows Samples Gallery contains a variety of code samples that exercise the various new programming models, platforms, features, and components available in Visual Studio 2013 Update 2 and/or
<span>Windows 8.1 Update</span>. These downloadable samples are provided as compressed ZIP files that contain a Visual Studio solution (SLN) file for the sample, along with the source files, assets, resources, and metadata necessary to successfully compile
 and run the sample. For more information about the programming models, platforms, languages, and APIs demonstrated in this sample, please refer to the guidance, tutorials, and reference topics provided in the documentation available in the Windows Developer
 Center. This sample is provided as-is in order to indicate or demonstrate the functionality of the programming models and feature APIs for and/or Windows 8.1 Update. Please provide feedback on this sample!</span></p>
<p><span style="font-size:small">Start and select <strong>File</strong> &gt; <strong>
Open</strong> &gt; <strong>Project/Solution</strong>.</span></p>
<p><span style="font-size:small">Go to the directory where you downloaded sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.</span></p>
<p><span style="font-size:small">Press F6 or use <strong>Build</strong> &gt; <strong>
Build Solution</strong>.</span></p>
<p><span style="font-size:small">Note: Please see the associated article for complete instructions.</span></p>
<p><span style="font-size:small">1. Build the EnterpriseIPCServer project.</span></p>
<p><span style="font-size:small">2. Copy the <em>_reference_ winmd</em> file to the project directory of the EnterpriseIPCApplication side-loaded project.</span></p>
<p><span style="font-size:small">3. Open the EnterpriseIPCApplication project, and add a reference to
<em>Fabrikam.winmd</em>.</span></p>
<p><span style="font-size:small">4. Build the EnterpriseIPCApplication solution.</span></p>
<p><span style="font-size:small">5. Copy the <em>_implementation_ winmd</em> file plus ancilliary files (including proxy/stub and msvcr120.dll) to the side-loaded project.</span></p>
<p><span style="font-size:small">6. Register the sampleproxy.dll with regsvr32.</span></p>
<p><span style="font-size:small">7. Enter the command:<strong> icacls ./T /grant *S-1-15-2-1:RX<em>
</em></strong>from the project directory of the EnterpriseIPCApplication project.</span></p>
<p><span style="font-size:small">8. Launch the EnterpriseIPCApplication app.</span></p>
<p><span style="font-size:small">Using network loopback in side-loaded Windows Store apps 4. Build the EnterpriseIPCApplication solution.</span></p>
<p><span style="font-size:small">5. Copy the _implementation_ winmd file plus ancilliary files (including proxy/stub and msvcr120.dll) to the side-loaded project.</span></p>
<p><span style="font-size:small">6. Register the sampleproxy.dll with regsvr32.</span></p>
<p><span style="font-size:small">7. Enter the command: <em>icacls . /T /grant &quot;ALL APPLICATION PACKAGES&quot;:RX</em> from the project directory of the EnterpriseIPCApplication project.</span></p>
<p><span style="font-size:small">8. Launch the <strong>EnterpriseIPCApplication</strong> app.</span></p>
<p><span style="font-size:small"><br>
</span></p>
