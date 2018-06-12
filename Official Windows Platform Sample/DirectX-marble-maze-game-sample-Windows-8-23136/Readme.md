# DirectX marble maze game sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* DirectX
## Topics
* Audio and video
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:18:52
## Description

<div id="mainSection">
<p>This sample demonstrates how to build a basic 3D game using DirectX. This game is a simple labyrinth game where the player is challenged to roll a marble through a maze of pitfalls using tilt controls.</p>
<p>Areas covered include:</p>
<ul>
<li>Incorporating the Windows Runtime into your DirectX game for full Windows Developer Preview support
</li><li>Using DirectX to render 3D graphics for display in a game </li><li>Implementing simple vertex and pixel shaders with HLSL </li><li>Developing simple physics and collision behaviors in a DirectX game </li><li>Handling input from accelerometer, touch, and mouse, and game controller with the Windows Runtime and XInput
</li><li>Playing and mixing sound effects and background music with XAudio2 </li></ul>
<p></p>
<p>This sample is written in C&#43;&#43; and requires some experience with graphics programming and DirectX. Complete content that examines this code can be found at
<a href="http://go.microsoft.com/fwlink/p/?linkid=246499">Developing Marble Maze, agame in C&#43;&#43; and DirectX</a>.</p>
<p>For more info about the concepts and APIs demonstrated in this sample, see these topics:
</p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br229580">Create an app using DirectX</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh780567">UnderstandingDirectX game development</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ff476080">Direct3D 11 graphics</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/dd370987">Direct2D graphics</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/bb509561">DirectX HLSL</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh405049">XAudio2</a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/ee417001">XInput</a> </li><li><a href="http://msdn.microsoft.com/library/windows/apps/hh452744">Developing games</a>
</li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
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
<li>Start Microsoft Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt;
<b>Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To run this sample after building it, press F5 (run with debugging enabled) or Ctrl&#43;F5 (run without debugging enabled) from Visual Studio&nbsp;2012 for Windows&nbsp;8 (any SKU). (Or select the corresponding options from the
<b>Debug</b> menu.)</p>
<h4><a id="Playing_the__game"></a><a id="playing_the__game"></a><a id="PLAYING_THE__GAME"></a>Playing the game</h4>
<p>The Marble Maze game can be played with touch controls, a tilt accelerometer, an Xbox 360 controller, or the mouse.</p>
<p>To start the game, click or tap <b>Start Game</b>. To view high scores for the local session, tap
<b>High Scores</b>.</p>
<p>The controls are as follows:</p>
<ul>
<li>Touch controls: press on the screen in the relative (to the marble) direction that you want the marble to roll.
</li><li>Xbox 360 controller: tilt the left analog stick in the direction that you want the marble to roll.
</li><li>Tile accelerometer: tilt the accelerometer-enabled device in the direction that you want the marble to roll.
</li><li>Mouse: Click and hold the left mouse button while the pointer is on the screen in the relative (to the marble) direction that you want the marble to roll.
</li></ul>
<p></p>
</div>
