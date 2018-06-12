# Wallet payment instruments sample
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* XAML
* wallet
## IsPublished
* True
## ModifiedDate
* 2013-03-19 03:18:53
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample demonstrates Wallet integration with a bank app that saves cards (payment instruments) to the Wallet. It also demonstrates how a Wallet agent is used to keep cards up to date in the Wallet. It uses the
<span class="label">Microsoft.Phone.Wallet</span> managed APIs to integrate with the Wallet. The app is for a fictitious bank and contains a debit card and a credit card. You add these cards to the Wallet and then refresh the card balances in the Wallet.
 The app demonstrates how to:</p>
<ul>
<li>
<p>Add payment instruments (credit or debit cards) to the Wallet. Each card is added a separate Wallet item.</p>
</li><li>
<p>Use a Wallet agent to keep the cards up to date in the Wallet.</p>
</li></ul>
<div class="alert">
<table width="100%" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<th align="left"><b>Important Note:</b> </th>
</tr>
<tr>
<td>
<p>This sample uses the <span class="label">ID_CAP_WALLET_PAYMENTINSTRUMENTS</span> capability. To deploy or submit an app that uses this capability, you must request special permissions and have that permission applied to your developer account. For more
 info and assistance, contact <a href="http://go.microsoft.com/fwlink/?LinkID=248156">
Dev Center support</a>.</p>
</td>
</tr>
</tbody>
</table>
</div>
<p>The sample consists of three projects:</p>
<ul>
<li>
<p><span class="label">sdkWalletPaymentInstrumentsWP8CS</span>. This is the main app.</p>
</li><li>
<p><span class="label">MockWebService</span>. A mock web service to make mock payments with the cards, update balances and update transaction history.</p>
</li><li>
<p><span class="label">sdkWalletPaymentInstrumentsWP8CSWalletAgent</span>. The Wallet agent called by the Wallet in order to refresh your wallet items.</p>
</li></ul>
<h3 class="procedureSubHeading">Build the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt;<span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone Solution (<span class="label">.sln</span>) file.</p>
</li><li>
<p>Use <span class="ui">Build</span> &gt; <span class="ui">Rebuild Solution</span> to build the sample</p>
</li></ol>
</div>
<h3 class="procedureSubHeading">Run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>To debug the app and then run it, press F5 or use <span class="ui">Debug</span> &gt;
<span class="ui">Start Debugging</span>. To run the app without debugging, press Ctrl&#43;F5 or use
<span class="ui">Debug</span> &gt; <span class="ui">Start Without Debugging</span>.</p>
</li><li>
<p>When the app launches, you see two payment instruments, namely, a debit card and a credit card.</p>
</li><li>
<p>You can save each card to the Wallet by tapping the card and then tapping <span class="ui">
Save to wallet</span>.</p>
</li><li>
<p>Open the Wallet on your phone to see the cards listed in the Wallet. </p>
</li><li>
<p>Tapping on a card will open the details page, where you will see transaction history and other information.
</p>
</li><li>
<p>To perform a fake transaction, tap <span class="ui">Refresh</span> on the app bar of the card item in the Wallet. This causes the Wallet to ask your app to refresh the card. The app performs the fake transaction, changes the card balance and this is reported
 back to the Wallet, which refreshes the card information. </p>
</li></ol>
</div>
</div>
<h1 class="heading"><span><a name="seeAlsoToggle">See Also</span> </h1>
<div id="seeAlsoSection" class="section" name="collapseableSection" style="">
<h4 class="subHeading">Other Resources</h4>
<div class="seeAlsoStyle"></a><a href="http://go.microsoft.com/fwlink/?LinkId=262290">Wallet membership and deals sample</a>
</div>
</div>
</div>
