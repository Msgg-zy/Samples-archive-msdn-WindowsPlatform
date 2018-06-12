# JavaScript iframe sandbox attribute sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* HTML5
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:15:20
## Description

<div id="mainSection">
<p>This sample shows how to use the <b>sandbox</b> attribute for the <a href="http://msdn.microsoft.com/library/windows/apps/hh465955">
<b>iframe</b></a> element. </p>
<p>This sample covers the following applications of the <b>sandbox</b> attribute:</p>
<ul>
<li>
<p>When you set the <b>sandbox</b> attribute with the <b>allow-forms</b> flag, the
<a href="http://msdn.microsoft.com/library/windows/apps/hh465955"><b>iframe</b></a> content can submit forms but can’t execute scripts, or navigate the top level document. The content is also forced into a unique origin that prevents it from accessing content
 from the same origin, such as cookies. These two <b>iframe</b> elements demonstrate the effects of sandboxing content. They both display the same example content, but one uses the
<b>sandbox</b> attribute with the <b>allow-forms</b> flag and one doesn’t.</p>
</li><li>
<p>When you use the <b>allow-script</b> flag with the <b>sandbox</b> attribute, the sandboxed content can execute script but can’t submit forms, or navigate the top-level document. The content is also forced into a unique origin that prevents it from accessing
 content from the same origin, such as cookies.</p>
</li><li>
<p>To allow a sandboxed page to access content from the same origin (such as cookies), use the
<b>sandbox</b> attribute and specify the <b>allow-same-origin</b> flag. The sandboxed content is still prevented from executing scripts, submitting forms, and navigating the top-level document.The
<b>allow-same-origin</b> flag is useful for allowing content from the same site to be sandboxed to disable scripting, while still allowing access to the document of the sandboxed content. You can also use it to sandbox content from a 3rd party site while still
 allowing the sandboxed content to communicate with its originating site and access data associated with its origin, such as a cookies or IndexedDB.</p>
<p>If the <a href="http://msdn.microsoft.com/library/windows/apps/hh465955"><b>iframe</b></a> content has the same origin as the parent, don’t combine the
<b>allow-script</b> and the <b>allow-same-origin</b> flags. If both tokens are used together and the origins match, the content within the
<b>iframe</b> will be able to remove the sandbox attribute. </p>
</li><li>
<p>To impose a set of security restrictions on content hosted by an <a href="http://msdn.microsoft.com/library/windows/apps/hh465955">
<b>iframe</b></a>, use the <b>sandbox</b> attribute. When you specify the sandbox attribute on an
<b>iframe</b> element, the content is said to be sandboxed. Sandboxed content can’t execute scripts, submit forms, or navigate the top level document. In addition, the content is forced into a unique origin that prevents it from accessing content from the same
 origin, such as cookies.</p>
<p>The <b>sandbox</b> attribute is useful for when you want to display untrusted content that doesn’t originate within your app. (This SDK sample doesn’t cover the
<b>allow-top-navigation</b> or <b>ms-allow-popups</b> flags, because you can’t perform top-level navigations to external content or show popups in app.)</p>
</li><li>To impose a set of security restrictions on content hosted by an <a href="http://msdn.microsoft.com/library/windows/apps/hh465955">
<b>iframe</b></a>, use the <b>sandbox</b> attribute. When you specify the sandbox attribute on an
<b>iframe</b> element, the content is said to be sandboxed. Sandboxed content can’t execute scripts, submit forms, or navigate the top level document. In addition, the content is forced into a unique origin that prevents it from accessing content from the same
 origin, such as cookies. </li></ul>
<p></p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>. </p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>. </p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh465955"><b>iframe</b></a>
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
<p></p>
<ol>
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<p></p>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>. </p>
</div>
