# Wallet membership and deals sample
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
* 2013-03-19 03:18:50
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>This sample uses the <span class="label">Microsoft.Phone.Wallet</span> managed APIs to integrate with the Wallet. The app is for a fictitious company that offers coupons or deals to members. Once your register your membership with the app, it displays
 coupons. You can add coupons and your membership to the Wallet. When you open the Wallet you will see your membership card as a new Wallet item. With this app, you can:</p>
<ul>
<li>
<p>Add a membership card to the Wallet.</p>
</li><li>
<p>Add deals or coupons to the Wallet.</p>
</li><li>
<p>Refresh Wallet item balances of your app’s items in the Wallet using a refresh agent for the app.</p>
</li><li>
<p>Add custom fields to your app’s Wallet items.</p>
</li></ul>
<p>The sample consists of three projects:</p>
<ul>
<li>
<p><span class="label">WalletMembershipDealsApp</span>. This is the main app.</p>
</li><li>
<p><span class="label">MockWebService</span>. A mock implementation of a web service to demonstrate how the app would typically call a web service to verify membership and retrieve item balances. This was written to enable standalone testing of the sample,
 without the need for real web services or other infrastructure.</p>
</li><li>
<p><span class="label">WalletAgent</span>. The Wallet agent called by the Wallet in order to refresh your wallet items.</p>
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
<p>The first time the app runs, you will have to fill out the membership details. You can then add the membership to the Wallet, as well as coupons.</p>
</li><li>
<p>When you open the Wallet you will see the membership card and coupons you added.
</p>
</li></ol>
</div>
</div>
<h1 class="heading"><span><a name="seeAlsoToggle">See Also</span> </h1>
<div id="seeAlsoSection" class="section" name="collapseableSection" style="">
<h4 class="subHeading">Other Resources</h4>
<div class="seeAlsoStyle"></a><a href="http://go.microsoft.com/fwlink/?LinkId=262291">Wallet payment instruments sample</a>
</div>
</div>
</div>
