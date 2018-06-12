# 3D Printing Sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* 3D printing
## IsPublished
* True
## ModifiedDate
* 2014-04-08 05:49:49
## Description
<style><!-- pre.syntax { font-size: 110 background: #dddddd; padding: 4px,8px; cursor: text; color: #000000; width: 97 } body{font-family:Verdana,Arial,Helvetica,sans-serif;color:#000;font-size:80%} H1{font-size:150%;font-weight:bold} H1.heading{font-size:110%;font-family:Verdana,Arial,Helvetica,sans-serif;font-weight:bold;line-height:120%}
 H2{font-size:115%;font-weight:700} H2.subtitle{font-size:180%;font-weight:400;margin-bottom:.6em} H3{font-size:110%;font-weight:700} H4,H5,H6{font-size:100%;font-weight:700} h4.subHeading{font-size:100%} dl{margin:0 0 10px;padding:0 0 0 1px} dt{font-style:normal;margin:0}
 li{margin-bottom:3px;margin-left:0} ol{line-height:140%;list-style-type:decimal;margin-bottom:15px;margin-left:24px} ol ol{line-height:140%;list-style-type:lower-alpha;margin-bottom:4px;margin-left:24px;margin-top:3px} ol ul,ul ol{line-height:140%;margin-bottom:15px;margin-top:15px}
 p{margin:0 0 10px;padding:0} div.section p{margin-bottom:15px;margin-top:0} ul{line-height:140%;list-style-position:outside;list-style-type:disc;margin-bottom:15px} ul ul{line-height:140%;list-style-type:disc;margin-bottom:4px;margin-left:17px;margin-top:3px}
 .heading{font-weight:700;margin-bottom:8px;margin-top:18px} .subHeading{font-size:100%;font-weight:700;margin:0} div#mainSection table{border:1px solid #ddd;font-size:100%;margin-bottom:5px;margin-left:5px;margin-top:5px;width:97%;clear:both} div#mainSection
 table tr{vertical-align:top} div#mainSection table th{border-bottom:1px solid #c8cdde;color:#006;padding-left:5px;padding-right:5px;text-align:left} div#mainSection table td{border:1px solid #d5d5d3;margin:1px;padding-left:5px;padding-right:5px} div#mainSection
 table td.imageCell{white-space:nowrap} /* These are the original lines from global-bn1945 div.ContentArea table th,div.ContentArea table td{background:#fff;border:0 solid #ccc;font-family:Verdana;padding:5px;text-align:left;vertical-align:top} div.ContentArea
 table th{background:#ccc none repeat scroll 0% 50%;vertical-align:bottom} div.ContentArea table{border-collapse:collapse;width:auto} */ /* Removing ContentArea class requirement from commented out lines from global-bn1945 above */ table th,table td{background:#fff;border:0
 solid #ccc;font-family:Verdana;padding:5px;text-align:left;vertical-align:top} table th{background:#ccc none repeat scroll 0% 50%;vertical-align:bottom} table{border-collapse:collapse;width:auto} div.clsNote{background-color:#eee;margin-bottom:4px;padding:2px}
 div.code{width:98.9%} code{font-family:Monospace,Courier New,Courier;font-size:105%;color:#006} span.label{font-weight:bold} div.caption{font-weight:bold;font-size:100%;color:#039} .procedureSubHeading{font-size:110%;font-weight:bold} span.sub{vertical-align:sub}
 span.sup{vertical-align:super} span.big{font-size:larger} span.small{font-size:smaller} span.tt{font-family:Courier,"Courier New",Consolas,monospace} div.os_icon_block { padding: 0; margin-top: 5px; margin-bottom: 5px; } ul.os_icon_images { position: absolute;
 list-style: none; padding: 0; margin: 0; } div.os_icon_content_block { position: relative; left: 66px; width: 92%; } .CCE_Message{color:Red;font-size:10pt} --></style>
<div id="mainSection">
<p>Demonstrates 3D printing in a Windows&nbsp;8.1 app.</p>
<p>This sample builds on the <a href="http://go.microsoft.com/fwlink/p/?LinkID=231500">
Direct3D Tutorial Sample</a> to show how to integrate 3D printing into your Windows Store app using DirectX with C&#43;&#43; or desktop app. This sample builds a 3D print payload and sends it to the print pipeline, using the new
<a href="http://msdn.microsoft.com/library/windows/apps/dn280684"><strong>IXpsDocumentPackageTarget3D</strong></a> and
<a href="http://msdn.microsoft.com/library/windows/apps/dn280743"><strong>IXpsOMPackageWriter3D</strong></a> interfaces. It adds 3D printing options to the print UI to allow users to select printer job settings, and it sends those job settings along with the
 3D model to the 3D printer.</p>
<p>To walk through the sample:</p>
<dl><dd>1. Launch the sample app. </dd><dd>2. Invoke the Devices charm. </dd><dd>3. Select Print, and choose a previously installed 3D printer. </dd><dd>4. Click the Print button. </dd></dl>
<p>To use the sample, you need:</p>
<ul>
<li>A printer installed. </li><li>Windows&nbsp;8.1 </li><li>Microsoft Visual Studio&nbsp;2013 </li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=231500">Direct3D Tutorial Sample</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/dn263137">Supporting 3D printing</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows app samples</a>
</dt></dl>
<h2>Operating system requirements</h2>
<table>
<tbody>
<tr>
<th>Client</th>
<td><dt>Windows&nbsp;8.1</dt></td>
</tr>
<tr>
<th>Server</th>
<td><dt>Windows Server&nbsp;2012&nbsp;R2</dt></td>
</tr>
</tbody>
</table>
<h2>Build the sample</h2>
<p>&nbsp;</p>
<ol>
<li>Start Visual Studio&nbsp;2013 and select <strong>File</strong> &gt; <strong>Open</strong> &gt;
<strong>Project/Solution</strong>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio&nbsp;2013 Solution (.sln) file.
</li><li>Press F7 or use <strong>Build</strong> &gt; <strong>Build Solution</strong> to build the sample.
</li></ol>
<p>&nbsp;</p>
<h2>Run the sample</h2>
<p>To debug the app and then run it, press F5 or use <strong>Debug</strong> &gt; <strong>
Start Debugging</strong>. To run the app without debugging, press Ctrl&#43;F5 or use <strong>
Debug</strong> &gt; <strong>Start Without Debugging</strong>.</p>
</div>
