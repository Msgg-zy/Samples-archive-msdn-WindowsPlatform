# In-app purchase receipt verification
## Requires
* Visual Studio 2010
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* in-app purchase
## IsPublished
* True
## ModifiedDate
* 2013-05-03 06:34:35
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample provides code you can use to verify an in-app purchase receipt, in addition to confirming that the in-app purchase product was purchased authentically.</p>
</div>
<h1 class="heading"><span>In-app purchase receipt verification</span> </h1>
<div id="sectionSection0" class="section" name="collapseableSection" style="">
<p>Windows&nbsp;Phone&nbsp;SDK&nbsp;8.0 provides proof-of-purchase authenticity by using secure receipts. You can retrieve receipts for all of your in-app products purchased by the user. A receipt is verification that a transaction has taken place. The receipt also contains
 a digital signature that you can use to verify the integrity of the receipt and make sure no tampering took place.</p>
<p>This sample provides code and a certificate you can use to verify a receipt from the Windows Phone Store service. You use both the receipt that you get when making an in-app product purchase and the provided production certificate (<span class="code">IapReceiptProduction.cer</span>)
 to verify the signature. The signature is contained within the receipt.</p>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Note:</b> </th>
</tr>
<tr>
<td>
<p>The <span class="code">IapReceiptProduction.cer</span> certificate file is used to verify a live in-app purchase receipt from the Windows Phone Store service.</p>
</td>
</tr>
</tbody>
</table>
</div>
<p>The code contained in this sample calls the <span class="code">VerifyXmlSignature</span> method using three parameters:
<span class="parameter">input</span>, <span class="parameter">certificate</span>, and
<span class="parameter">verifySignatureOnly</span>. The <span class="parameter">
input</span> parameter contains the receipt XML as a <span value="string"><span class="keyword">string</span></span>. The
<span class="parameter">certificate</span> parameter contains the public key of the certificate as an
<span class="code">X509Certificate2</span> object. The <span class="parameter">
verifySignatureOnly</span> parameter is a boolean value that determines whether the code should verify both the signature and the certificate, or only the signature.</p>
<p>For additional info about in-app purchase, see <a href="http://msdn.microsoft.com/library/windowsphone/develop/jj206949(v=vs.105).aspx">
In-app purchase for Windows Phone 8</a>.</p>
</div>
<h1 class="heading"><span><a name="seeAlsoToggle">See Also</span> </h1>
<div id="seeAlsoSection" class="section" name="collapseableSection" style="">
<h4 class="subHeading">Other Resources</h4>
<div class="seeAlsoStyle"></a><a href="http://msdn.microsoft.com/library/windowsphone/develop/jj681689(v=vs.105).aspx">In-app purchase testing for Windows Phone 8</a>
</div>
</div>
</div>
