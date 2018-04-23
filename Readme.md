# How to use XtraReports in a Silverlight application using XPO as data source


<p>This example is a follow-up to another example, demonstrating how to use <a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXtraReporttopic"><u>XtraReports</u></a> in <a href="http://www.silverlight.net/"><u>Silverlight</u></a> applications. It demonstrates how to use <a href="http://documentation.devexpress.com/#XPO/CustomDocument1998">the <u>eXpress Persistent Objects</u></a> framework to provide data for XtraReports.<br />
Basically, there is not too many differences in comparison with using <a href="http://msdn.microsoft.com/en-us/library/h43ks021%28VS.71%29.aspx"><u>ADO.NET</u></a> as a data source provider. The only important thing that should be done is to properly initialize <a href="http://documentation.devexpress.com/#XPO/CustomDocument2121"><u>Data Access Layer</u></a>, in order to connect to a correct database. Since the report service is a multi-user application, it is important to use <a href="http://documentation.devexpress.com/#XPO/clsDevExpressXpoThreadSafeDataLayertopic"><u>ThreadSafeDataLayer</u></a>. We suggest that you follow the approach demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/K18061">How to use XPO in an ASP.NET (Web) application</a> Knowledge Base article. Note that <a href="http://documentation.devexpress.com/#XPO/DevExpressXpoXpoDefault_DataLayertopic"><u>XpoDefault.DataLayer</u></a> will remain uninitialized if you use the suggested approach. This means that <a href="http://documentation.devexpress.com/#XPO/CustomDocument2022"><u>Session</u></a> cannot be created in the designer because it will be connected to XpoDefault.DataLayer. To properly assign Session to <a href="http://documentation.devexpress.com/#XPO/CustomDocument2031"><u>XPCollection</u></a>, use the <a href="http://documentation.devexpress.com/#XPO/DevExpressXpoXPBaseCollection_ResolveSessiontopic"><u>XPCollection.ResolveSession</u></a> event.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E2215">How to implement a Document Preview in a Silverlight application</a><br />
<a href="https://www.devexpress.com/Support/Center/p/K18061">How to use XPO in an ASP.NET (Web) application</a></p>


<h3>Description</h3>

<p>Starting from version 2011 vol 1, the DevExpress.XtraReports.Service assembly requires .NET Framework 4.0</p>

<br/>


