# HTML animation library sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* HTML5
* Windows Runtime
## Topics
* User Interface
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:19:52
## Description

<div id="mainSection">
<p>This sample shows how to use the Animation Library APIs. These functions provide you with the ability to use animations in your Windows Store apps and custom controls that are consistent with animations used by Windows.
</p>
<p>The sample demonstrates the following animation scenarios: </p>
<ul>
<li>Bringing an entire page onto the screen, all at one time or as separate parts (enterPage)
</li><li>Transitioning between pages (enterPage/exitPage) </li><li>Bringing partial page content onto the screen (enterContent) </li><li>Transitioning partial page content (enterContent/exitContent) </li><li>Expanding a set of elements to make room for new element, and collapsing the original elements when the new element is removed (createExpandAnimation/createCollapseAnimation)
</li><li>Animating a touch or mouse click response (pointerUp/pointerDown) </li><li>Adding and removing a list item (createAddToListAnimation/createDeleteToListAnimation)
</li><li>Filtering a list of search results (createAddToSearchListAnimation/createDeleteFromSearchListAnimation)
</li><li>Fading content in and out (fadeIn/fadeOut) </li><li>Crossfading an element in place (crossFade) </li><li>Moving an element to a new location (createRepositionAnimation) </li><li>Dragging and dropping an element (dragSourceStart/dragSourceEnd) </li><li>Repositioning elements to allow an element to be dropped and restoring those elements when it is not (dragBetweenEnter/dragBetweenLeave)
</li><li>Showing and hiding pop-up UI (showPopup/hidePopup) </li><li>Showing and hiding edge-based UI (showEdgeUI/hideEdgeUI) </li><li>Showing and hiding a panel (showPanel/hidePanel) </li><li>Revealing whether an item supports swipe (swipeReveal) </li><li>Reacting to a swipe to select or deselect an item (swipeSelect/swipeDeselect)
</li><li>Updating a badge in response to a badge notification (updateBadge) </li><li>Updating a tile in response to a tile notification (createPeekAnimation) </li><li>Running custom CSS animations and transitions (executeAnimation/executeTransition)
</li><li>Enabling/disabling animations and checking whether animations are enabled (enableAnimations/disableAnimations/isAnimationEnabled)
</li></ul>
<p></p>
<p>This sample is written in HTML, CSS, and JavaScript. For the XAML version, see the
<a href="http://go.microsoft.com/fwlink/p/?linkid=242401">XAML personality animations sample</a> and the
<a href="http://go.microsoft.com/fwlink/p/?linkid=242404">XAML animations sample</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465165">Animating your UI with the Animation Library</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212653"><b>createAddToListAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212654"><b>createAddToSearchListAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212655"><b>createCollapseAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212656"><b>createDeleteFromListAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212657"><b>createDeleteFromSearchListAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212658"><b>createExpandAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212659"><b>createPeekAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212660"><b>createRepositionAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212661"><b>crossFade</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779759"><b>disableAnimations</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212668"><b>dragBetweenEnter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212669"><b>dragBetweenLeave</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212670"><b>dragSourceEnd</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212671"><b>dragSourceStart</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779760"><b>enableAnimations</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701582"><b>enterContent</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212672"><b>enterPage</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779762"><b>executeAnimation</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779763"><b>executeTransition</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701585"><b>exitContent</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701586"><b>exitPage</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212673"><b>fadeIn</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212674"><b>fadeOut</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212676"><b>hideEdgeUI</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212677"><b>hidePanel</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212678"><b>hidePopup</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh779793"><b>isAnimationEnabled</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212680"><b>pointerDown</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212681"><b>pointerUp</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br230466"><b>showEdgeUI</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br230467"><b>showPanel</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br230468"><b>showPopup</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212662"><b>swipeDeselect</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212663"><b>swipeReveal</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br212664"><b>swipeSelect</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br230471"><b>updateBadge</b></a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 Windows Store app samples</a>
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
<ol>
<li>Download the sample's .zip file using one of the buttons near the top of the page.
</li><li>Unzip the downloaded file into a folder on your computer. </li><li>Start Visual Studio&nbsp;2013 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the folder where you unzipped the sample. </li><li>Find and open the folder named for the sample and one of its programming language subfolders (C#, JS.
</li><li>Double-click the Microsoft Visual Studio Solution (.sln) file to open it. </li><li>Select <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <b>Debug &gt; Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug &gt; Start Without Debugging</b>.</p>
<h2><a id="How_to_use_the_sample"></a><a id="how_to_use_the_sample"></a><a id="HOW_TO_USE_THE_SAMPLE"></a>How to use the sample</h2>
<p>Each scenario instructs you about what to watch for and how to launch each animation.</p>
<p>Be aware that the badge and tile update scenarios are examples only and do not show the actual mechanisms behind sending badge and tile notifications, only the animation that occurs when a badge or tile notification arrives. For more information about notifications,
 see <a href="http://msdn.microsoft.com/library/windows/apps/hh779725">Tile, badges, and notifications</a>.</p>
</div>
