# Stored Contacts Sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* Contacts
* storedcontact
* contactstore
## IsPublished
* True
## ModifiedDate
* 2013-06-05 04:49:14
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>The sample illustrates the use of the <a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.phone.personalinformation.contactstore(v=vs.105).aspx">
ContactStore</a> class and related APIs to create a contact store for your app. This feature is useful if your app uses an existing cloud-based contact store. The provided APIs allow you to create contacts on the phone that represent the contacts in your remote
 store. These contacts are displayed and can be modified in the phone’s People hub, just like contacts that are added through the built-in experience. You can use the APIs to update and delete contacts you have created on the phone and also to query for any
 changes the user has made to the contacts locally so that you can sync those changes to your remote store.</p>
<p>This sample has the following features:</p>
<ul>
<li>
<p><span class="ui">Import Remote Contacts</span> – This button creates the app’s contact store and creates new contacts based on the provided list. Typically, this list would come from a network request to a cloud-based contact store maintained by your app.
 In order to let this sample function as a standalone app, the network request is simulated by reading the remote contacts from a local XML file included with the project, “RemoteContactStore.xml”.</p>
</li><li>
<p><span class="ui">Update Remote Contacts</span> – This button updates the contacts in the app’s contact store. Again, the updates would typically come from the cloud-based remote contact store, but in this case, the updates are read from another local XML
 file, “RemoteContactUpdates.xml”</p>
</li><li>
<p><span class="ui">Get Unsynced Local Changes</span> – This button queries the app’s contact store to get a list of changes the user has made locally to the app’s contacts. These changes are compiled in an XML document that could be sent to your cloud-based
 remote contact store. Because this sample doesn’t use an actual remote store, the resulting XML is simply output to Visual Studio’s Output window.</p>
</li><li>
<p><span class="ui">List Contacts</span> – This hyperlink takes you to the ListContacts.xaml page which creates a list of all of the app’s contacts and binds it to a
<span value="ListBox"><span class="keyword">ListBox</span></span> control.</p>
</li><li>
<p><span value="RemoteIdHelper class"><span class="keyword">RemoteIdHelper class</span>
</span>– The contact store APIs allow you to save a remote ID value with each contact. This allows you to maintain the association between the local contact ID and the ID used by your remote contact store. Your remote contact IDs must be unique among all applications
 on the phone or the save operation will fail. Since many apps use remote IDs that don’t meet this requirement, this sample provides a helper class,
<span value="RemoteIdHelper"><span class="keyword">RemoteIdHelper</span></span>, that helps you to prepend a GUID to each remote ID to make sure that it is unique. The class also allows you to get your original remote ID back, without the attached GUID, so
 that you can use it to communicate with your remote contact store.</p>
</li></ul>
<p>For more info about this feature, see <a href="http://go.microsoft.com/fwlink/?LinkId=299216">
How to perform basic custom contact store operations for Windows Phone.</a>.</p>
<p><b>Build the sample</b> </p>
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.
</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.
</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample.
</p>
</li></ol>
<h3 class="procedureSubHeading">Run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</li><li>
<p>Once the app has launched, press the <span class="ui">Import Remote Contacts</span> button. This will create the contact store for the app and then read the contacts from the RemoteContactStore.xml file and create new contacts for each listing in the file.</p>
</li><li>
<p>To see that the contacts were created, press the <span class="ui">List Contacts</span> hyperlink button. This will take you to the ListContacts.xaml page which uses the contact store APIs to retrieve the all of the app’s contacts. Press the
<span class="ui">Start</span> button to go to Start and then tap on the tile for the
<span class="ui">People</span> hub. You will see that the app’s contacts appear there.
</p>
</li><li>
<p>Use the back button to return to the first page of the sample app, or just launch the app again, and then tap the
<span class="ui">Update Remote Contacts</span> button. This will update the app’s contacts with the data in the RemoteContactUpdates.xml file. In this example, one contact is added, one is deleted, and one is updated with new data.</p>
</li><li>
<p>Repeat step 3 to verify that the changes have been made to the app’s contacts.</p>
</li><li>
<p>While in the <span class="ui">People</span> hub, use the built-in contact tools to modify some of the information for one or more of the app contacts, such as changing the contact’s family name or given name.</p>
</li><li>
<p>Return to or relaunch the app and then tap the <span class="ui">Get Unsynced Local Changes</span> button. This will generate an XML document listing the changes that were made to the local contacts since they were last updated from the remote contact store
 (or in this example, the local XML file). Because this app doesn’t have a Web service to send the contacts to, the change list is simply printed to Visual Studio’s
<span class="ui">Output</span> window.</p>
</li></ol>
</div>
<p><b>See also</b> </p>
<ul>
<li>
<p><a href="http://go.microsoft.com/fwlink/?LinkId=299216">How to perform basic custom contact store operations for Windows Phone</a>
</p>
</li></ul>
</div>
</div>
