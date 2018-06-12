# XAML data binding sample (Windows 8)
## Requires
* Visual Studio 2012
## License
* MS-LPL
## Technologies
* XAML
## Topics
* User Interface
## IsPublished
* False
## ModifiedDate
* 2013-06-27 02:11:20
## Description

<div id="mainSection">
<p>This sample demonstrates basic data binding techniques using the <a href="http://msdn.microsoft.com/library/windows/apps/br209820">
<b>Binding</b></a> class and <a href="http://msdn.microsoft.com/library/windows/apps/hh758283">
Binding markup extension</a>. </p>
<p>Specifically, this sample covers:</p>
<ul>
<li>Controlling the direction of data flow and updates using the <a href="http://msdn.microsoft.com/library/windows/apps/br209820_mode">
<b>Binding.Mode</b></a> property. </li><li>Changing the format of bound values for display purposes by implementing the <a href="http://msdn.microsoft.com/library/windows/apps/br209903">
<b>IValueConverter</b></a> interface. </li><li>Binding to a data model that implements <a href="http://msdn.microsoft.com/library/windows/apps/br209899">
<b>INotifyPropertyChanged</b></a> in order to receive change notifications. </li><li>Binding to string and integer indexer properties. </li><li>Using <a href="http://msdn.microsoft.com/library/windows/apps/br242348"><b>DataTemplate</b></a> instances to customize the appearance of your data.
</li><li>Using <a href="http://msdn.microsoft.com/library/windows/apps/br209833"><b>CollectionViewSource</b></a> to display data in groups.
</li><li>Responding to changes in bound collections using <a href="http://msdn.microsoft.com/library/windows/apps/ms668629">
<b>INotifyCollectionChanged</b></a>. </li><li>Using C&#43;&#43; to implement and bind to an incremental loading collection through the
<a href="http://msdn.microsoft.com/library/windows/apps/hh701916"><b>ISupportIncrementalLoading</b></a> interface.
</li></ul>
<p></p>
<p></p>
<p>This sample is written in XAML. For the HTML version, see the <a href="http://go.microsoft.com/fwlink/p/?linkid=242406">
ListView custom data source and data manipulation sample (HTML)</a>.</p>
<p>To obtain an evaluation copy of Windows&nbsp;8, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241655">
Windows&nbsp;8</a>.</p>
<p>To obtain an evaluation copy of Microsoft Visual Studio&nbsp;2012, go to <a href="http://go.microsoft.com/fwlink/p/?linkid=241656">
Visual Studio&nbsp;2012</a>.</p>
<h3><a id="related_topics"></a>Related topics</h3>
<dl><dt><b>Roadmaps</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br229583">Roadmap for C# and Visual Basic</a>
</dt><dt><b>Samples</b> </dt><dt><a href="http://go.microsoft.com/fwlink/p/?LinkID=227694">Windows 8 app samples</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=226564">XAML GridView grouping and SemanticZoom sample</a>
</dt><dt><a href="http://go.microsoft.com/fwlink/p/?linkid=228621">StorageDataSource and GetVirtualizedFilesVector sample</a>
</dt><dt><b>Reference</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209917"><b>Windows.UI.Xaml.Data</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209820"><b>Binding</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br208706_datacontext"><b>DataContext</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br242362"><b>DependencyProperty</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209833"><b>CollectionViewSource</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/ms668604"><b>ObservableCollection(Of T)</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br242348"><b>DataTemplate</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209390template"><b>ControlTemplate</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209899"><b>INotifyPropertyChanged</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/ms668629"><b>INotifyCollectionChanged</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209903"><b>IValueConverter</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/br209878"><b>ICustomPropertyProvider</b></a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh701916"><b>ISupportIncrementalLoading</b></a>
</dt><dt><b>Concepts</b> </dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/">QuickStart: data binding to controls</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/">Data binding with XAML</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh758322">How to bind to hierarchical data and create a master/details view</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh758283">Binding markup extension</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/jj569302">PropertyPath syntax</a>
</dt><dt><a href="http://msdn.microsoft.com/library/windows/apps/hh758284">RelativeSource markup extension</a>
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
<li>Start Visual Studio Express&nbsp;2012 for Windows&nbsp;8 and select <b>File</b> &gt; <b>
Open</b> &gt; <b>Project/Solution</b>. </li><li>Go to the directory in which you unzipped the sample. Go to the directory named for the sample, and double-click the Visual Studio Express&nbsp;2012 for Windows&nbsp;8 Solution (.sln) file.
</li><li>Press F7 or use <b>Build</b> &gt; <b>Build Solution</b> to build the sample. </li></ol>
<h3>Run the sample</h3>
<p>To debug the app and then run it, press F5 or use <b>Debug</b> &gt; <b>Start Debugging</b>. To run the app without debugging, press Ctrl&#43;F5 or use
<b>Debug</b> &gt; <b>Start Without Debugging</b>.</p>
</div>
