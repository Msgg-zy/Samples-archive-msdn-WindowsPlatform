# Multicast Sockets Sample
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 7.5
## Topics
* Sockets
* Networking
## IsPublished
* True
## ModifiedDate
* 2013-05-03 06:34:08
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates how to communicate over a multicast group on a Windows Phone. It implements the classic Rock&nbsp;Paper&nbsp;Scissors game. Players join a multicast group to discover each other. UDP unicasting is then used to challenge a player and play the
 actual game. The <span value="UdpAnySourceMulticastClient"><span class="keyword">UdpAnySourceMulticastClient</span></span> class, available in Windows&nbsp;Phone OS&nbsp;7.1, is used in this sample.</p>
<p>For more information about communicating using multicast on Windows&nbsp;Phone OS&nbsp;7.1, see
<a href="http://msdn.microsoft.com/library/windowsphone/develop/hh286407(v=vs.105).aspx">
How to send and receive data in a multicast group for Windows Phone</a>.</p>
<p>You need to install Windows&nbsp;Phone&nbsp;SDK&nbsp;7.1 to run this sample. To get started, go to the
<a href="http://go.microsoft.com/fwlink/?LinkID=259204">Windows Phone Dev Center</a>.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>After unzipping the sample, note that there is one project. In the following instructions, we will explain how to start the Windows&nbsp;Phone client app.
</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>To effectively demonstrate the multicast scenario, you should deploy this app to the emulator and to a device that is connected to a local Wi-Fi network.</p>
</td>
</tr>
</tbody>
</table>
</div>
</li><li>
<p>Double-click the <span value=".sln"><span class="keyword">.sln</span></span> file to open the solution.</p>
</li><li>
<p>Press F5 to start debugging the app.</p>
</li><li>
<p>The Windows&nbsp;Phone client launches in the emulator. You should also deploy the app to your phone so that you have a minimum of two instances of the game in the multicast group.
</p>
</li><li>
<p>On all client devices where the app is running, enter a name in the <span class="input">
Username</span> field and click <span class="ui">Join</span>. Try to keep the names unique. There is no uniqueness checking in this sample, and using unique names will make it easier to understand the communication between clients. On each client, you will
 see a list of all clients that have joined the game (which is a multicast group).</p>
</li><li>
<p>Select a name in the list on a device and click <span class="ui">Challenge</span>. This sends a challenge request to the player you selected. If the player accepts the challenge, the game will begin.
</p>
</li><li>
<p>The choice that each player makes is sent to the opponent’s device, and is displayed only after both of the players have selected a choice. The result of the round is then communicated to both players, and the score is updated accordingly.</p>
</li><li>
<p>If you exit the game, this information is sent to all other multicast group members.</p>
</li></ol>
</div>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>This sample is packaged as a Windows&nbsp;Phone&nbsp;7.5 project. It can be converted to a Windows&nbsp;Phone&nbsp;8 project, by changing the target Windows Phone OS version of the project. To create a Windows&nbsp;Phone&nbsp;8 project, you must be running the Windows&nbsp;Phone&nbsp;SDK&nbsp;8.0 on
 Visual Studio 2012. You can download the latest version of the SDK from <a href="http://dev.windowsphone.com/downloadsdk">
http://dev.windowsphone.com/downloadsdk</a>.</p>
<p>To convert the sample to a Windows&nbsp;Phone&nbsp;8 project:</p>
<ol>
<li>
<p>Double-click the <span class="ui">.sln</span> file to open the solution in Visual Studio.</p>
</li><li>
<p>Right-click the project in the <span class="ui">Solution Explorer</span> and select
<span class="ui">Properties</span>. This opens the <span class="ui">Project Properties</span> window.</p>
</li><li>
<p>In the <span class="ui">Application</span> tab of the Project Properties window, select
<span class="ui">Windows Phone OS 8.0</span> from the <span class="ui">Target Windows Phone OS Version</span> dropdown. A dialog will appear asking if you want to upgrade this project to Windows Phone OS 8.0.</p>
</li><li>
<p>Select <span class="ui">Yes</span> to upgrade the project.</p>
</li></ol>
</td>
</tr>
</tbody>
</table>
</div>
</div>
</div>
