'
'See http://www.devexpress.com/example=E2215, to get the detailed example on using Silverlight XtraReports.
'
'<configuration>
'    <!--
'     Copy these tags to the web.config file.
'    -->
'    <configSections>
'        <section name="xtraReports" type="DevExpress.XtraReports.Service.ConfigSections.XtraReportsSection, DevExpress.XtraReports.v10.1.Service, Version=10.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"/>
'    </configSections>
'    <connectionStrings>
'        <add name="xtraReports" connectionString="XpoProvider=MSAccess;Provider=Microsoft.Jet.OLEDB.4.0;Mode=Share Deny None;data source=|DataDirectory|/ReportService.mdb;user id=Admin;password=;" />
'    </connectionStrings>
'    <xtraReports>
'        <documentStore keepInterval="1200000" connectionStringName="xtraReports" />
'    </xtraReports>
'    <system.serviceModel>
'	    <behaviors>
'		    <endpointBehaviors>
'			    <behavior name="ReportServiceRestBehavior">
'				    <webHttp/>
'    			</behavior>
'	    	</endpointBehaviors>
'		    <serviceBehaviors>
'    			<behavior name="ReportServiceBehavior">
'	    			<serviceMetadata httpGetEnabled="true"/>
'		    		<serviceDebug httpHelpPageEnabled="false" includeExceptionDetailInFaults="true"/>
'			    </behavior>
'    		</serviceBehaviors>
'	    </behaviors>
'    	<services>
'	    	<service behaviorConfiguration="ReportServiceBehavior" name="Q279518.Web.ReportService">
'		    	<endpoint address="" binding="basicHttpBinding" contract="Q279518.Web.IReportService"/>
'			    <endpoint address="rest" behaviorConfiguration="ReportServiceRestBehavior" binding="webHttpBinding" contract="DevExpress.XtraReports.Service.IReportServiceRest"/>
'    			<endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange"/>
'	    	</service>
'    	</services>
'    </system.serviceModel>
'</configuration>
'


Imports Microsoft.VisualBasic
Imports System

Namespace Q279518.Web
	' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in code, svc and config file together.
	Public Class ReportService
		Inherits DevExpress.XtraReports.Service.ReportService
		Implements IReportService
		' Uncomment this method if you need to extent the base interface.
		' public void DoWork()
		' {
		' }
	End Class
End Namespace
