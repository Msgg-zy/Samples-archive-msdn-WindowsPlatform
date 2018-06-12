# Free App With Paid Products
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* Windows Phone 8
## Topics
* in-app purchase
## IsPublished
* True
## ModifiedDate
* 2013-07-11 05:29:37
## Description

<div id="mainBody">
<p></p>
<div class="introduction">
<p>You can use in-app purchase to sell digital content in your app. Windows&nbsp;Phone&nbsp;8 provides a safe purchase experience on the phone, and that means confidence for your customers. As an app developer, you first upload to the Store a list of products that you
 want to sell in your app. Then, add UI to your app that offers your in-app products for purchase. This sample shows two scenarios. In the single-product scenario, the app offers a single product, an ad-removal product in this case, that has an identifier that’s
 hard-coded into the app. This scenario scales to a small, fixed number of products; it’s not suitable for a catalog with a product list that changes over time. In the product list scenario, the app queries the Store for listing information about the products
 associated with the app. The user can browse and purchase from a list of products. In both scenarios, the app UI changes to reflect changes in the purchase state of a product license. Both scenarios portray a monetization strategy for a free app that offers
 in-app purchase.</p>
<p>Follow these steps to take the sample for a test drive.</p>
<h3 class="procedureSubHeading">To run the sample</h3>
<div class="subSection">
<ol>
<li>
<p>Start Visual Studio Express 2012 for Windows&nbsp;Phone and select <span class="ui">
File</span> &gt; <span class="ui">Open</span> &gt; <span class="ui">Project/Solution</span>.</p>
</li><li>
<p>Go to the directory in which you unzipped the sample. Double-click the Visual Studio Express 2012 for Windows&nbsp;Phone solution (<span class="label">.sln</span>) file.</p>
</li><li>
<p>Confirm that the solution configuration drop-down list is set to <span class="ui">
Debug</span> and then, on the <span class="ui">Build</span> menu, click <span class="ui">
Build Solution</span>. (Ctrl&#43;Shift&#43;B)</p>
</li><li>
<p>On the <span class="ui">Debug</span> menu, click <span class="ui">Start Without Debugging</span>. (Ctrl&#43;F5)</p>
<p>The first panorama page (<span class="ui">Single product</span>) reports that you are running a debug build of the sample.</p>
</li><li>
<p>This page shows the single-product scenario. Tap <span class="ui">Buy product</span> to simulate the in-app purchase.
<span class="ui">Use product</span> is now enabled. Tap <span class="ui">Use product</span> to demonstrate that the product is now licensed.</p>
</li><li>
<p>Swipe to the second panorama page (<span class="ui">Product list</span>), which shows the product list scenario, and which displays a list of products for purchase. Tap any product to simulate purchasing it.</p>
</li></ol>
</div>
<p><b>What’s in the project?</b> </p>
<p>The single-product scenario is implemented very simply inside the <span value="MainPage">
<span class="keyword">MainPage</span></span> class. In the product list scenario, a class named
<span value="ProductListViewModel"><span class="keyword">ProductListViewModel</span></span> serves as the view model for the
<span class="ui">Product list</span> panorama page. A <span value="ListBox"><span class="keyword">ListBox</span></span> on the
<span class="ui">Product list</span> page is bound to the view model’s <span value="Products">
<span class="keyword">Products</span></span> property for its items, and to <span value="SelectedProduct">
<span class="keyword">SelectedProduct</span></span> for its selection. The element type of
<span value="Products"><span class="keyword">Products</span></span>, and the type of
<span value="SelectedProduct"><span class="keyword">SelectedProduct</span></span>, is the
<span value="ProductViewModel"><span class="keyword">ProductViewModel</span></span> class. This is the type targeted by the
<span value="ListBox"><span class="keyword">ListBox</span></span> control’s <span value="ItemTemplate">
<span class="keyword">ItemTemplate</span></span>.</p>
<p><b>Which APIs are used?</b> </p>
<div class="caption"></div>
<div class="tableSection">
<table width="50%" cellspacing="2" cellpadding="5" frame="lhs">
<tbody>
<tr>
<th>
<p>API</p>
</th>
<th>
<p>Use</p>
</th>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.currentapp.aspx">Windows.ApplicationModel.Store.CurrentApp</a>
</p>
</td>
<td>
<p>The class used to get license and listing info about the current app and to perform in-app purchase.</p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.currentapp.licenseinformation.aspx">Windows.ApplicationModel.Store.CurrentApp.LicenseInformation</a>
</p>
</td>
<td>
<p>The property that contains the license metadata for the current app. Used in the sample to get license info about the products associated with the current app.</p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.licenseinformation.aspx">Windows.ApplicationModel.Store.LicenseInformation</a>
</p>
</td>
<td>
<p>The type of the <span value="LicenseInformation"><span class="keyword">LicenseInformation</span></span> property. Describes whether the user’s license for the current app is trial or full, and lists all in-app products the user owns that are associated
 with the current app. </p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.licenseinformation.productlicenses.aspx">Windows.ApplicationModel.Store.LicenseInformation.ProductLicenses</a>
</p>
</td>
<td>
<p>The property used to enumerate the in-app products the user owns and that are associated with the current app.
</p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.productlicense.aspx">Windows.ApplicationModel.Store.ProductLicense</a>
</p>
</td>
<td>
<p>The element type of the <span value="ProductLicenses"><span class="keyword">ProductLicenses</span></span> property. Provides proof of purchase for a single in-app product the user owns. The sample uses the
<span value="IsActive"><span class="keyword">IsActive</span></span> property.</p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.productlicense.isactive.aspx">Windows.ApplicationModel.Store.ProductLicense.IsActive</a>
</p>
</td>
<td>
<p>The property that indicates whether the product's license is active. Only active licenses should be fulfilled.</p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.currentapp.loadlistinginformationasync">Windows.ApplicationModel.Store.CurrentApp.LoadListingInformationAsync</a>
</p>
</td>
<td>
<p>The method used to obtain the list of in-app products currently available for purchase in the running app.</p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.listinginformation.aspx">Windows.ApplicationModel.Store.ListingInformation</a>
</p>
</td>
<td>
<p>The type returned by <span value="LoadListingInformationAsync"><span class="keyword">LoadListingInformationAsync</span></span>. Contains info about the app and the products associated with it.</p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.listinginformation.productlistings.aspx">Windows.ApplicationModel.Store.ListingInformation.ProductListings</a>
</p>
</td>
<td>
<p>The property of <span value="ListingInformation"><span class="keyword">ListingInformation</span></span>(the type returned by
<span value="LoadListingInformationAsync"><span class="keyword">LoadListingInformationAsync</span></span>). Used to enumerate the available products.</p>
</td>
</tr>
<tr>
<td>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/windows.applicationmodel.store.productlisting.aspx">Windows.ApplicationModel.Store.ProductListing</a>
</p>
</td>
<td>
<p>The element type of <span value="ProductListings"><span class="keyword">ProductListings</span></span>, which represents a single in-app product that’s available for purchase. Accessible only via a
<span value="ProductListings"><span class="keyword">ProductListings</span></span> enumeration. The sample uses the
<span value="Name"><span class="keyword">Name</span></span> and <span value="ImageUri">
<span class="keyword">ImageUri</span></span> properties.</p>
</td>
</tr>
</tbody>
</table>
</div>
<p></p>
<p><b>Running the sample in debug and release configurations</b> </p>
<p>Code that calls licensing APIs such as those in this sample can access a license only when the app is published to the Store. So, the sample simulates the purchase step in debug configuration only, so you can see how the UI works. You can use the same conditional
 compilation technique in your own app. The app you eventually publish to the Store will be a release build and that build will contain code that accesses real license info.</p>
<p><b>See also</b> </p>
<ul>
<li>
<p><a href="http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206949(v=vs.105).aspx">In-app purchase for Windows Phone 8</a>
</p>
</li></ul>
</div>
</div>
