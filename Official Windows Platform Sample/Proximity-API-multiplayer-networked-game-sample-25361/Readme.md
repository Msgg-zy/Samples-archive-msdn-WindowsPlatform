# Proximity API multiplayer networked game sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* proximity
* multi-player game
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:23:29
## Description

<div id="mainSection">
<p>This sample demonstrates key network techniques for multi-player games, including initiating handshake (with the Proximity API) and communicating. It also demonstrates the minimum requirements to create a network connection in games.
</p>
<p>You can use the Proximity (<a href="http://msdn.microsoft.com/library/windows/apps/br241203"><b>PeerFinder</b></a>) API to set up a socket connection between the same application across multiple computers. The application is a simple, multi-player game,
 which demonstrates how to use the Proximity API to create a socket connection between peer apps on multiple computers using a tap gesture or by browsing using a wireless radio.
</p>
<p>In order to see the multi-player scenario, this sample must be run on two computers. For scenarios that use a tap gesture, each computer must have a proximity device installed. For scenarios that use wireless browsing, each computer must have a wireless
 device that supports Wi-Fi Direct installed. If you don't have hardware that supports proximity tapping such as Near-Field Communication (NFC) radio, you can use the proximity driver sample that is part of the
<a href="http://go.microsoft.com/fwlink/?linkid=136508">Windows Driver Kit (WDK)</a> samples. You can use the sample driver to simulate a tap gesture over a network connection between two computers. For information on how to download the WDK, see Windows Driver
 Kit (WDK). After you have installed the WDK and samples, you can find the proximity driver sample in the
<b>src\nfp</b> directory in the location where you installed the WDK samples. See the NetNfpProvider.html file in the
<b>src\nfp\net</b> directory for instructions on building and running the simulator. After you start the simulator, it runs in the background while your proximity app is running in the foreground. Your app must be in the foreground for the tap simulation to
 work.</p>
<p>Playing the game</p>
<p>The Critter Stomp game requires players to tap as many critters on the screen as possible within a period of time. This game can be played by one player, or by up to six players simultaneously to compete with each other.</p>
<ul>
<li>For single player: After launching the game, click <b>STOMP alone</b> to start the game.
</li><li>For two players: After launching the game, both players click <b>STOMP with friends</b>. In the next page, one player (the client player) clicks
<b>Join a game</b>, and the other (the host player) clicks <b>Host a game</b>. The host player sees and clicks the name of the client player to send out an invitation. The client player sees and clicks the name of the host player to accept that invitation.
 The host player sees the accept response from the client player, then clicks <b>
Start Game</b> to start the game. </li><li>For two players with NFC-capable devices: After launching the game, both players click
<b>STOMP with friends</b>. In the next page, one player (the client player) clicks
<b>Join a game</b>, and the other (the host player) clicks <b>Host a game</b>. Two players tap their devices around the NFC modules to initiate connection. The host player sees two devices connected, then clicks
<b>Start Game</b> to start the game. </li><li>For three to six players: There is one and only one host player, and this player is required to connect one client player after another using either of the connection methods above. The host player starts the game with currently connected client players
 by clicking <b>Start Game</b>. </li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>. </p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://channel9.msdn.com/Events/Build/2013/3-051">Build 2013 Talk: Play Together! Leaderboards with Windows Azure and Multiplayer with Wi-Fi Direct</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465207">Quickstart: Connecting apps using tapping or browsing (JavaScript)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465205">Quickstart: Connecting apps using tapping or browsing (C#)</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj659925">Guidelines for developing using proximity</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br241250"><b>Windows.Networking.Proximity</b></a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows app samples</a>
</dt></dl>
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
<p></p>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <b>File</b> &gt; <b>Open</b> &gt; <b>Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
