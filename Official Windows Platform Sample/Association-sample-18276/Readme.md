# Association sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Win32
## Topics
* Networking
## IsPublished
* True
## ModifiedDate
* 2014-01-10 12:50:55
## Description

<div id="mainSection">
<p>This sample demonstrates associations between OData entities in a Management OData server. It shows how to associate two entities with one another by editing the
<b>Schema.mof</b> file, and how the association is mapped to the supporting cmdlets. It also demonstrates how a client can use JSON and standard OData URL conventions to send requests involving associations. Examples of requests involving associations include
 listing the set of associated entities, adding and removing entities from a reference set, and getting the details of an entity and its associated entities in a single network request.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<h2>Operating system requirements</h2>
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
<h2>Build the sample</h2>
<ol>
<li>
<p>Start Visual Studio and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.</p>
</li><li>
<p>Navigate to the sample folder, and open <b>AssociationClient.sln</b></p>
</li><li>
<p>Press F7 (or F6 for Visual Studio&nbsp;2013) or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample.</p>
</li></ol>
<h2>Run the sample</h2>
<p>1. Setup Management OData endpoint by using the <a href="http://go.microsoft.com/fwlink/p/?linkid=243041">
PSWSRoleBasedPlugin</a> sample. 2. Copy <b>VMSystem.mof</b>, <b>VMSystem.xml</b>,
<b>VMSystem.psm1</b>, <b>HostVMSystem.xml</b> into the virtual directory where you installed the endpoint. 3. Replace
<b>web.config</b> in the virtual directory with the <b>web.config</b> file from this sample. 4. Add a
<b>Module</b> element with the path to the <b>VMSystem.psm1</b> module as it's text nested within the
<b>Modules</b> tag for the <b>AdminGroup</b> in the <b>RbacConfiguration.xml</b> file. 5. Make sure that the value of the
<b>$SystemFileName</b> variable in the <b>VMSystem.psm1</b> setup script points to the path of the
<b>HostVMSystem.xml</b> file on the web server. </p>
</div>
