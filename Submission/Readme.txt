1. Git URL
https://github.com/chenghao1983/Active_Learning_Service_Group4

2.Database creation Guide
	1. Create MSSQL DB, schema name: Active_Learning_Group4
	2. Run DB/Active_Learning_Group4_CleanDB.sql to create fresh database	

3. Web Project configuration Guide
	1. Create Upload the root and write permission
	2. Web config. Connection string
	3. Add the following in the Appsettings in web.config
	<add key="AllowedFileExtensions" value="mp4,ppt,pptx,txt,doc,docx,pdf,xls,xlsx" />
	<add key="VideoFormats" value="mp4"/>
	<add key="UploadPath" value="/Upload/" />
	<add key="AllowedFileSize" value="40" />
	<add key="ChatHistoryCount" value="100" />
	<add key="CacheDuration" value="6000" />

4. Service Project configuration Guide
	1. App config. Connection string
	2. Make sure the following are in the Appsettings in App.config
	<add key="UploadPath" value="../../../ActiveLearning.Web/Upload/" />    -- this value should be based on the actual upload folder of the upload folder
		

5. Install cert SSL Cert\pt4.activelearning.com.pfx in trusted store

6. WF project configuration guide
	1. App config. Connection string
	3. Add the following in the Appsettings in App.config
	<add key="AllowedFileExtensions" value="png,jpg,mp4,ppt,pptx,txt,doc,docx,pdf,xls,xlsx" />
    	<add key="VideoFormats" value="mp4" />
    	<add key="UploadPath" value="../ActiveLearning.Web/Upload/" />    -- this value should be based on the actual upload folder of the upload folder
	<add key="AllowedFileSize" value="40" />


Test data:

student5 Password: 1qazxsw2!@QW
student6 Password: 1qazxsw2!@QW

Review Enrollment APpplication

instructor1 Password: 1qazxsw2!@QW

Edge case: course:  

7	Scheduling and Producing Project Plans - SE24
8	Advanced Project Estimation - SE24
9	Project Tracking and Control - SE24
10	People Management - SE24


Review contents
admin1 Password: 1qazxsw2!@QW

