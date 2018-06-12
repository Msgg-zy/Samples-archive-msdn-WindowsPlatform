# Windows Runtime XML data API sample
## Requires
* Visual Studio 2013
## License
* MS-LPL
## Technologies
* Windows Runtime
## Topics
* Data Access
## IsPublished
* True
## ModifiedDate
* 2013-11-25 04:35:14
## Description

<div id="mainSection">
<p>This sample demonstrates common XML API use scenarios for the <a href="http://msdn.microsoft.com/library/windows/apps/br240819">
<b>Windows.Data.Xml.Dom</b></a> and <a href="http://msdn.microsoft.com/library/windows/apps/br225376">
<b>Windows.Data.Xml.Xsl</b></a> namespaces in the Windows Runtime. </p>
<p>The five scenarios demonstrated in this sample are: </p>
<ul>
<li>Scenario1: loading an RSS template XML file asynchronously and adding a CData section. The asynchronous loading is accomplished by using the
<a href="http://msdn.microsoft.com/library/windows/apps/br206261"><b>XmlDocument.loadFromFileAsync</b></a> method from the
<a href="http://msdn.microsoft.com/library/windows/apps/br240819"><b>Windows.Data.Xml.Dom</b></a> namespace.
<a href="http://msdn.microsoft.com/library/windows/apps/br206238"><b>The XmlDocument.CreateCDataSection</b></a> method is used to add the CDATA section to the RSS file.
</li><li>Scenario 2: traversing a Document Object Model (DOM) tree to update the data and save it to a file. When the user presses the<b> Mark Hot Products
</b>button, an XPath query is used to select products from an XML file, which have an attribute named &quot;Sell10day&quot; that exceeds the attribute named &quot;InStore&quot;. The &quot;Sell10Day&quot; value represents the quantity sold in the last ten days. These products are marked
 &quot;hot&quot; by setting the &quot;hot&quot; attribute for the product to 1. When the user presses the
<b>Save</b> button, the <a href="http://msdn.microsoft.com/library/windows/apps/br206284">
<b>XmlDocument.saveToFileAsync</b></a> method is used to save the XML file containing the products list.
</li><li>Scenario 3: using the security settings prohibitDTD and resolveExternals when loading an XML file. prohibitDTD will prevent DTD use in a XML file. A large number of DTD entity references can cause an application to become unresponsive when loading and parsing
 an XML file. resolveExternals determines whether external references can be resolved during parsing. For this scenario, a user chooses a combination of these two security settings, which are properties on the XmlLoadSettings class used with the
<a href="http://msdn.microsoft.com/library/windows/apps/br206261"><b>XmlDocument.loadFromFileAsync</b></a> method. The user presses the
<b>Load XML File</b> button to view the resulting XML or error. </li><li>Scenario 4: using an XPath with the XML API for the Windows Runtime to select and filter data in a DOM tree. When a user presses the
<b>Show Anniversary Gift</b> button, the scenario constructs an array of XPath queries used by the
<a href="http://msdn.microsoft.com/library/windows/apps/br206285"><b>XmlDocument.SelectNodes</b></a> method against an XML file to determine an anniversary gift for each employee based on the year the employee started the job.
<ul>
<li>Employees with between 1 and 4 years on the job receive a gift card. </li><li>Employees with between 5 and 9 years on the job receive an XBOX. </li><li>Employees with 10 or more years on the job receive a Windows Phone. </li></ul>
</li><li>Scenario 5: using eXtensible Stylesheet Language Transformations (XSLT) with the XML APIs to transform an XML file into an HTML webpage. The source XML and XSL are loaded during initialization of the scenario. The XSL transform is applied when the user
 presses the <b>Transform</b> button. The Source XML and Source XSL can both be modified during runtime to see different results when applying an XSL transform. The transform is applied using the
<a href="http://msdn.microsoft.com/library/windows/apps/br225377"><b>XsltProcessor</b></a> class from the
<a href="http://msdn.microsoft.com/library/windows/apps/br225376"><b>Windows.Data.Xml.Xsl</b></a> namespace.
</li></ul>
<p></p>
<ul>
<li><a href="http://msdn.microsoft.com/library/windows/apps/br240819"><b>Windows.Data.Xml.Dom</b></a>
</li><li><a href="http://msdn.microsoft.com/library/windows/apps/br225376"><b>Windows.Data.Xml.Xsl</b></a>
</li></ul>
<p>To obtain an evaluation copy of Windows&nbsp;8.1, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301696">
Windows&nbsp;8.1</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2013, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=301697">
Visual Studio&nbsp;2013</a>.</p>
<p></p>
<p class="note"><b>Note</b>&nbsp;&nbsp;For Windows&nbsp;8 app samples, download the <a href="http://go.microsoft.com/fwlink/p/?LinkId=301698">
Windows&nbsp;8 app samples pack</a>. The samples in the Windows&nbsp;8 app samples pack will build and run only on Microsoft Visual Studio&nbsp;2012.</p>
<p></p>
<h2><a id="related_topics"></a>Related topics</h2>
<dl><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt></dl>
<h2>Related technologies</h2>
<a href="http://msdn.microsoft.com/library/windows/apps/br240819">Windows.Data.Xml.Dom</a> ,
<a href="http://msdn.microsoft.com/library/windows/apps/br225376">Windows.Data.Xml.Xsl</a>
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
<li>Start Visual Studio&nbsp;2013 and select <b>File &gt; Open &gt; Project/Solution</b>.
</li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Microsoft Visual Studio Solution (.sln) file.
</li><li>Press F7 or use <b>Build &gt; Build Solution</b> to build the sample. </li></ol>
<h2>Run the sample</h2>
<p>To run this sample after building it, go to the installation folder for this sample with launch Default.html in your browser. It is located in the &lt;install_root&gt;\bin\Debug folder. Alternatively in Visual Studio&nbsp;2013 for Windows&nbsp;8.1, press F5 (run with
 debugging enabled) or Ctrl&#43;F5 (run without debugging enabled). (Or select the corresponding options from the
<b>Debug</b> menu.)</p>
<p>Click a scenario to run.</p>
<p></p>
<ul>
<li>Scenario 1 is executed by typing some text in the RSS Content text box and pressing the
<b>Build RSS Feed</b> button. </li><li>Scenario 2 is executed by clicking the <b>Mark Hot Products</b> button. Clicking the
<b>Save</b> button will save the updated XML to the Libraries\Documents\HotProducts.xml file.
</li><li>Scenario 3 is executed by clicking a security setting combination and then clicking the
<b>Load XML File</b> button. </li><li>Scenario 4 is executed clicking the <b>Show Anniversary Gift</b> button. </li><li>Scenario 5 is executed by clicking the <b>Transform</b> button. You can also modify the source XML and XSL to see different results.
</li></ul>
<p></p>
</div>
