<?xml version="1.0" encoding="UTF-8"?>
<?PowerDesigner AppLocale="UTF16" ID="{300FB3F5-45BA-49F9-9095-7AB089096042}" Label="" LastModificationDate="1440666196" Name="DAB_Exemple" Objects="96" Symbols="150" Target="Java" TargetLink="Reference" Type="{18112060-1A4B-11D1-83D9-444553540000}" signature="CLD_OBJECT_MODEL" version="15.0.0.2613"?>
<!-- Veuillez ne pas modifier ce fichier -->

<Model xmlns:a="attribute" xmlns:c="collection" xmlns:o="object">

<o:RootObject Id="o1">
<c:Children>
<o:Model Id="o2">
<a:ObjectID>300FB3F5-45BA-49F9-9095-7AB089096042</a:ObjectID>
<a:Name>DAB_Exemple</a:Name>
<a:Code>DAB_Exemple</a:Code>
<a:CreationDate>1381693408</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1440665962</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:PackageOptionsText>[FolderOptions]

[FolderOptions\Class Diagram Objects]
GenerationCheckModel=Yes
GenerationPath=
GenerationOptions=
GenerationTasks=
GenerationTargets=
GenerationSelections=</a:PackageOptionsText>
<a:ModelOptionsText>[ModelOptions]

[ModelOptions\Cld]
CaseSensitive=Yes
DisplayName=Yes
EnableTrans=Yes
EnableRequirements=No
ShowClss=No
DeftAttr=int
DeftMthd=int
DeftParm=int
DeftCont=java.util.Collection
DomnDttp=Yes
DomnChck=No
DomnRule=No
SupportDelay=No
PreviewEditable=Yes
AutoRealize=No
DttpFullName=Yes
DeftClssAttrVisi=private
VBNetPreprocessingSymbols=
CSharpPreprocessingSymbols=

[ModelOptions\Cld\NamingOptionsTemplates]

[ModelOptions\Cld\ClssNamingOptions]

[ModelOptions\Cld\ClssNamingOptions\CLDPCKG]

[ModelOptions\Cld\ClssNamingOptions\CLDPCKG\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,,,firstLowerWord)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDPCKG\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDDOMN]

[ModelOptions\Cld\ClssNamingOptions\CLDDOMN\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDDOMN\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDCLASS]

[ModelOptions\Cld\ClssNamingOptions\CLDCLASS\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,,,FirstUpperChar)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDCLASS\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDINTF]

[ModelOptions\Cld\ClssNamingOptions\CLDINTF\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,,,FirstUpperChar)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDINTF\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\UCDACTR]

[ModelOptions\Cld\ClssNamingOptions\UCDACTR\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\UCDACTR\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\UCDUCAS]

[ModelOptions\Cld\ClssNamingOptions\UCDUCAS\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\UCDUCAS\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\SQDOBJT]

[ModelOptions\Cld\ClssNamingOptions\SQDOBJT\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\SQDOBJT\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\SQDMSSG]

[ModelOptions\Cld\ClssNamingOptions\SQDMSSG\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\SQDMSSG\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CPDCOMP]

[ModelOptions\Cld\ClssNamingOptions\CPDCOMP\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,,,FirstUpperChar)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CPDCOMP\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDATTR]

[ModelOptions\Cld\ClssNamingOptions\CLDATTR\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,,,firstLowerWord)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDATTR\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDMETHOD]

[ModelOptions\Cld\ClssNamingOptions\CLDMETHOD\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,,,firstLowerWord)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDMETHOD\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDPARM]

[ModelOptions\Cld\ClssNamingOptions\CLDPARM\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,,,firstLowerWord)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDPARM\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\OOMPORT]

[ModelOptions\Cld\ClssNamingOptions\OOMPORT\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\OOMPORT\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\OOMPART]

[ModelOptions\Cld\ClssNamingOptions\OOMPART\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\OOMPART\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDASSC]

[ModelOptions\Cld\ClssNamingOptions\CLDASSC\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,,,firstLowerWord)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\CLDASSC\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\UCDASSC]

[ModelOptions\Cld\ClssNamingOptions\UCDASSC\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\UCDASSC\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\GNRLLINK]

[ModelOptions\Cld\ClssNamingOptions\GNRLLINK\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\GNRLLINK\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\RQLINK]

[ModelOptions\Cld\ClssNamingOptions\RQLINK\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\RQLINK\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\RLZSLINK]

[ModelOptions\Cld\ClssNamingOptions\RLZSLINK\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\RLZSLINK\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DEPDLINK]

[ModelOptions\Cld\ClssNamingOptions\DEPDLINK\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DEPDLINK\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\OOMACTV]

[ModelOptions\Cld\ClssNamingOptions\OOMACTV\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\OOMACTV\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\ACDOBST]

[ModelOptions\Cld\ClssNamingOptions\ACDOBST\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\ACDOBST\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\STAT]

[ModelOptions\Cld\ClssNamingOptions\STAT\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\STAT\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DPDNODE]

[ModelOptions\Cld\ClssNamingOptions\DPDNODE\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DPDNODE\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DPDCMPI]

[ModelOptions\Cld\ClssNamingOptions\DPDCMPI\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DPDCMPI\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DPDASSC]

[ModelOptions\Cld\ClssNamingOptions\DPDASSC\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DPDASSC\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\OOMVAR]

[ModelOptions\Cld\ClssNamingOptions\OOMVAR\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\OOMVAR\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\FILO]

[ModelOptions\Cld\ClssNamingOptions\FILO\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=&quot;\/:*?&lt;&gt;|&quot;
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\FILO\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_. &quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\FRMEOBJ]

[ModelOptions\Cld\ClssNamingOptions\FRMEOBJ\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\FRMEOBJ\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\FRMELNK]

[ModelOptions\Cld\ClssNamingOptions\FRMELNK\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\FRMELNK\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DefaultClass]

[ModelOptions\Cld\ClssNamingOptions\DefaultClass\Name]
Template=
MaxLen=254
Case=M
ValidChar=
InvldChar=
AllValid=Yes
NoAccent=No
DefaultChar=_
Script=.convert_name(%Name%,&quot;_&quot;)
ConvTable=

[ModelOptions\Cld\ClssNamingOptions\DefaultClass\Code]
Template=
MaxLen=254
Case=M
ValidChar=&#39;a&#39;-&#39;z&#39;,&#39;A&#39;-&#39;Z&#39;,&#39;0&#39;-&#39;9&#39;,&quot;_&quot;
InvldChar=&quot; &#39;(.)+=*/&quot;
AllValid=Yes
NoAccent=Yes
DefaultChar=_
Script=.convert_code(%Code%,&quot; &quot;)
ConvTable=

[ModelOptions\Generate]

[ModelOptions\Generate\Cdm]
CheckModel=Yes
SaveLinks=Yes
NameToCode=No
Notation=2

[ModelOptions\Generate\Pdm]
CheckModel=Yes
SaveLinks=Yes
ORMapping=No
NameToCode=No
BuildTrgr=No
TablePrefix=
RefrUpdRule=RESTRICT
RefrDelRule=RESTRICT
IndxPKName=%TABLE%_PK
IndxAKName=%TABLE%_AK
IndxFKName=%REFR%_FK
IndxThreshold=
ColnFKName=%.3:PARENT%_%COLUMN%
ColnFKNameUse=No

[ModelOptions\Generate\Xsm]
CheckModel=Yes
SaveLinks=Yes
ORMapping=No
NameToCode=No</a:ModelOptionsText>
<c:ObjectLanguage>
<o:Shortcut Id="o3">
<a:ObjectID>816949B2-3A51-4C0F-882A-A8AC81DCE7C6</a:ObjectID>
<a:Name>Java</a:Name>
<a:Code>Java</a:Code>
<a:CreationDate>1381693408</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693408</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:TargetStereotype/>
<a:TargetID>0DEDDB90-46E2-45A0-886E-411709DA0DC9</a:TargetID>
<a:TargetClassID>1811206C-1A4B-11D1-83D9-444553540000</a:TargetClassID>
</o:Shortcut>
</c:ObjectLanguage>
<c:ExtendedModelDefinitions>
<o:Shortcut Id="o4">
<a:ObjectID>78A4F2F4-E9D1-4C46-9DA6-1E4B8E4EC669</a:ObjectID>
<a:Name>WSDL for Java</a:Name>
<a:Code>WSDLJava</a:Code>
<a:CreationDate>1381693408</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693408</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:TargetStereotype/>
<a:TargetID>C8F5F7B2-CF9D-4E98-8301-959BB6E86C8A</a:TargetID>
<a:TargetClassID>186C8AC3-D3DC-11D3-881C-00508B03C75C</a:TargetClassID>
</o:Shortcut>
</c:ExtendedModelDefinitions>
<c:DefaultDiagram>
<o:UseCaseDiagram Ref="o5"/>
</c:DefaultDiagram>
<c:UseCaseDiagrams>
<o:UseCaseDiagram Id="o5">
<a:ObjectID>3E191E1A-F37A-47FA-834A-960482C97F59</a:ObjectID>
<a:Name>Ucase_etape1</a:Name>
<a:Code>Ucase_etape1</a:Code>
<a:CreationDate>1381693408</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382642283</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:DisplayPreferences>[DisplayPreferences]

[DisplayPreferences\UCD]

[DisplayPreferences\General]
Adjust to text=Yes
Snap Grid=No
Constrain Labels=Yes
Display Grid=No
Show Page Delimiter=Yes
Grid size=0
Graphic unit=2
Window color=255, 255, 255
Background image=
Background mode=8
Watermark image=
Watermark mode=8
Show watermark on screen=No
Gradient mode=0
Gradient end color=255, 255, 255
Show Swimlane=No
SwimlaneVert=Yes
TreeVert=No
CompDark=0

[DisplayPreferences\Object]
Mode=0
Trunc Length=80
Word Length=80
Word Text=!&quot;&quot;#$%&amp;&#39;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~
Shortcut IntIcon=Yes
Shortcut IntLoct=Yes
Shortcut IntFullPath=No
Shortcut IntLastPackage=Yes
Shortcut ExtIcon=Yes
Shortcut ExtLoct=No
Shortcut ExtFullPath=No
Shortcut ExtLastPackage=Yes
Shortcut ExtIncludeModl=Yes
EObjShowStrn=Yes
ExtendedObject.Comment=No
ExtendedObject.IconPicture=No
ExtendedObject_SymbolLayout=
ELnkShowStrn=Yes
ELnkShowName=Yes
ExtendedLink_SymbolLayout=
File Location=No
PckgShowStrn=Yes
Package.Comment=No
Package.IconPicture=No
Package_SymbolLayout=
Display Model Version=Yes
Actor.IconPicture=No
Actor_SymbolLayout=
UseCase.IconPicture=No
UseCase_SymbolLayout=
FileObject.IconPicture=No
FileObject_SymbolLayout=
ActrShowStrn=Yes
UcasShowStrn=Yes
UseCase.Comment=No
AsscShowName=No
AsscShowDirt=No
AsscShowStrn=No
GnrlShowName=No
GnrlShowStrn=No
GnrlShowCntr=No
DepdShowName=No
DepdShowStrn=Yes
DepdShowCntr=No

[DisplayPreferences\Symbol]

[DisplayPreferences\Symbol\FRMEOBJ]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=6000
Height=2000
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=64
Brush gradient color=192 192 192
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 255 128 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FRMELNK]
CENTERFont=Arial,8,N
CENTERFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\CLDPCKG]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 178 178 178
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDACTR]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDUCAS]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=7200
Height=5400
Brush color=192 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDASSC]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\GNRLLINK]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\DEPDLINK]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FILO]
NAMEFont=Arial,8,N
NAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=2400
Height=2400
Brush color=255 255 255
Fill Color=No
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\USRDEPD]
OBJXSTRFont=Arial,8,N
OBJXSTRFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\Free Symbol]
Free TextFont=Arial,8,N
Free TextFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0</a:DisplayPreferences>
<a:PaperSize>(8268, 11693)</a:PaperSize>
<a:PageMargins>((315,354), (433,354))</a:PageMargins>
<a:PageOrientation>1</a:PageOrientation>
<a:PaperSource>7</a:PaperSource>
<c:Symbols>
<o:RectangleSymbol Id="o6">
<a:CreationDate>1381693936</a:CreationDate>
<a:ModificationDate>1381694341</a:ModificationDate>
<a:Rect>((-15337,24412), (15338,-1388))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
</o:RectangleSymbol>
<o:UseCaseAssociationSymbol Id="o7">
<a:CreationDate>1382642274</a:CreationDate>
<a:ModificationDate>1382642367</a:ModificationDate>
<a:Rect>((-22987,19309), (-10312,22703))</a:Rect>
<a:ListOfPoints>((-22987,22703),(-17137,22703),(-17137,19309),(-10312,19309))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o8"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o9"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o10"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:TitleSymbol Id="o11">
<a:Text>Version: </a:Text>
<a:CreationDate>1381953160</a:CreationDate>
<a:ModificationDate>1381953180</a:ModificationDate>
<a:Rect>((2550,28953), (13724,35696))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
</o:TitleSymbol>
<o:UseCaseAssociationSymbol Id="o12">
<a:CreationDate>1381953135</a:CreationDate>
<a:ModificationDate>1382642372</a:ModificationDate>
<a:Rect>((-21412,11324), (-10462,17774))</a:Rect>
<a:ListOfPoints>((-21412,11324),(-21412,17774),(-10462,17774))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o13"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o9"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o14"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o15">
<a:CreationDate>1381693816</a:CreationDate>
<a:ModificationDate>1382642320</a:ModificationDate>
<a:Rect>((-21412,10892), (-5962,10992))</a:Rect>
<a:ListOfPoints>((-21412,10892),(-5962,10892))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o13"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o16"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o17"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o18">
<a:CreationDate>1381693819</a:CreationDate>
<a:ModificationDate>1382642320</a:ModificationDate>
<a:Rect>((-21037,2437), (-9787,8437))</a:Rect>
<a:ListOfPoints>((-21037,8437),(-21037,2437),(-9787,2437))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o13"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o19"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o20"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o21">
<a:CreationDate>1381693835</a:CreationDate>
<a:ModificationDate>1381693835</a:ModificationDate>
<a:Rect>((7454,14662), (20288,17962))</a:Rect>
<a:ListOfPoints>((20288,14662),(20288,17962),(7454,17962))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o22"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o23"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o24"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o25">
<a:CreationDate>1381693837</a:CreationDate>
<a:ModificationDate>1381693837</a:ModificationDate>
<a:Rect>((8793,6412), (20288,12112))</a:Rect>
<a:ListOfPoints>((20288,12112),(20288,6412),(8793,6412))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o22"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o26"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o27"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseSymbol Id="o9">
<a:CreationDate>1381693636</a:CreationDate>
<a:ModificationDate>1382642364</a:ModificationDate>
<a:Rect>((-12337,16087), (-2438,21486))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o28"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o16">
<a:CreationDate>1381693639</a:CreationDate>
<a:ModificationDate>1381953145</a:ModificationDate>
<a:Rect>((-12412,7987), (-2513,13386))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o29"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o19">
<a:CreationDate>1381693640</a:CreationDate>
<a:ModificationDate>1381953150</a:ModificationDate>
<a:Rect>((-11962,487), (-2063,5886))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:Object>
<o:UseCase Ref="o30"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o23">
<a:CreationDate>1381693723</a:CreationDate>
<a:ModificationDate>1381693896</a:ModificationDate>
<a:Rect>((4463,13537), (14362,18936))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o31"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o26">
<a:CreationDate>1381693724</a:CreationDate>
<a:ModificationDate>1381693896</a:ModificationDate>
<a:Rect>((4315,5062), (14213,10461))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o32"/>
</c:Object>
</o:UseCaseSymbol>
<o:ActorSymbol Id="o13">
<a:CreationDate>1381693765</a:CreationDate>
<a:ModificationDate>1382642320</a:ModificationDate>
<a:Rect>((-23512,8437), (-18713,12036))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o33"/>
</c:Object>
</o:ActorSymbol>
<o:ActorSymbol Id="o22">
<a:CreationDate>1381693795</a:CreationDate>
<a:ModificationDate>1381693796</a:ModificationDate>
<a:Rect>((17888,11512), (22687,15111))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o34"/>
</c:Object>
</o:ActorSymbol>
<o:ActorSymbol Id="o8">
<a:CreationDate>1382642258</a:CreationDate>
<a:ModificationDate>1382642367</a:ModificationDate>
<a:Rect>((-23061,19754), (-18262,23353))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o35"/>
</c:Object>
</o:ActorSymbol>
</c:Symbols>
</o:UseCaseDiagram>
<o:UseCaseDiagram Id="o36">
<a:ObjectID>3E51D69D-30BF-4DB2-B215-A3C63CC55CE5</a:ObjectID>
<a:Name>UCase_etape2</a:Name>
<a:Code>UCase_etape2</a:Code>
<a:CreationDate>1381694054</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953896</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:DisplayPreferences>[DisplayPreferences]

[DisplayPreferences\UCD]

[DisplayPreferences\General]
Adjust to text=Yes
Snap Grid=No
Constrain Labels=Yes
Display Grid=No
Show Page Delimiter=Yes
Grid size=0
Graphic unit=2
Window color=255, 255, 255
Background image=
Background mode=8
Watermark image=
Watermark mode=8
Show watermark on screen=No
Gradient mode=0
Gradient end color=255, 255, 255
Show Swimlane=No
SwimlaneVert=Yes
TreeVert=No
CompDark=0

[DisplayPreferences\Object]
Mode=0
Trunc Length=80
Word Length=80
Word Text=!&quot;&quot;#$%&amp;&#39;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~
Shortcut IntIcon=Yes
Shortcut IntLoct=Yes
Shortcut IntFullPath=No
Shortcut IntLastPackage=Yes
Shortcut ExtIcon=Yes
Shortcut ExtLoct=No
Shortcut ExtFullPath=No
Shortcut ExtLastPackage=Yes
Shortcut ExtIncludeModl=Yes
EObjShowStrn=Yes
ExtendedObject.Comment=No
ExtendedObject.IconPicture=No
ExtendedObject_SymbolLayout=
ELnkShowStrn=Yes
ELnkShowName=Yes
ExtendedLink_SymbolLayout=
File Location=No
PckgShowStrn=Yes
Package.Comment=No
Package.IconPicture=No
Package_SymbolLayout=
Display Model Version=Yes
Actor.IconPicture=No
Actor_SymbolLayout=
UseCase.IconPicture=No
UseCase_SymbolLayout=
FileObject.IconPicture=No
FileObject_SymbolLayout=
ActrShowStrn=Yes
UcasShowStrn=Yes
UseCase.Comment=No
AsscShowName=No
AsscShowDirt=No
AsscShowStrn=No
GnrlShowName=No
GnrlShowStrn=No
GnrlShowCntr=No
DepdShowName=No
DepdShowStrn=Yes
DepdShowCntr=No

[DisplayPreferences\Symbol]

[DisplayPreferences\Symbol\FRMEOBJ]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=6000
Height=2000
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=64
Brush gradient color=192 192 192
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 255 128 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FRMELNK]
CENTERFont=Arial,8,N
CENTERFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\CLDPCKG]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 178 178 178
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDACTR]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDUCAS]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=7200
Height=5400
Brush color=192 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDASSC]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\GNRLLINK]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\DEPDLINK]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FILO]
NAMEFont=Arial,8,N
NAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=2400
Height=2400
Brush color=255 255 255
Fill Color=No
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\USRDEPD]
OBJXSTRFont=Arial,8,N
OBJXSTRFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\Free Symbol]
Free TextFont=Arial,8,N
Free TextFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0</a:DisplayPreferences>
<a:PaperSize>(8268, 11693)</a:PaperSize>
<a:PageMargins>((315,354), (433,354))</a:PageMargins>
<a:PageOrientation>1</a:PageOrientation>
<a:PaperSource>7</a:PaperSource>
<c:Symbols>
<o:RectangleSymbol Id="o37">
<a:CreationDate>1381694255</a:CreationDate>
<a:ModificationDate>1381953904</a:ModificationDate>
<a:Rect>((-14250,22169), (13350,1012))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:RectangleSymbol>
<o:TitleSymbol Id="o38">
<a:Text>Version: </a:Text>
<a:CreationDate>1381953893</a:CreationDate>
<a:ModificationDate>1381953908</a:ModificationDate>
<a:Rect>((-14137,23816), (-2963,30559))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
</o:TitleSymbol>
<o:GeneralizationSymbol Id="o39">
<a:CreationDate>1381953412</a:CreationDate>
<a:ModificationDate>1381953550</a:ModificationDate>
<a:Rect>((-19775,7925), (-18775,18711))</a:Rect>
<a:ListOfPoints>((-19275,7925),(-19275,18711))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>7</a:ArrowStyle>
<a:LineColor>16744576</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o40"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSymbol Ref="o41"/>
</c:DestinationSymbol>
<c:Object>
<o:Generalization Ref="o42"/>
</c:Object>
</o:GeneralizationSymbol>
<o:UseCaseAssociationSymbol Id="o43">
<a:CreationDate>1381953494</a:CreationDate>
<a:ModificationDate>1381953540</a:ModificationDate>
<a:Rect>((-18750,9712), (-6900,10912))</a:Rect>
<a:ListOfPoints>((-18750,9712),(-18750,10912),(-6900,10912))</a:ListOfPoints>
<a:CornerStyle>1</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o40"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o44"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o45"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o46">
<a:CreationDate>1381953556</a:CreationDate>
<a:ModificationDate>1381953556</a:ModificationDate>
<a:Rect>((-18525,18524), (-11550,18562))</a:Rect>
<a:ListOfPoints>((-18525,18562),(-11550,18524))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o41"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o47"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o48"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:NoteSymbol Id="o49">
<a:Text>L&#39;acteur Client de la banque est une spécialisation de l&#39;acteur porteur de carte.
Le client de la banque est un porteur de carte particulier. 

==&gt; cela permet de supprimer l&#39;association entre client de la banque et le cas &quot;retirer de l&#39;argent&quot; </a:Text>
<a:CreationDate>1381694505</a:CreationDate>
<a:ModificationDate>1382642458</a:ModificationDate>
<a:Rect>((-13725,-5812), (15669,-240))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:UseCaseAssociationSymbol Id="o50">
<a:CreationDate>1381694213</a:CreationDate>
<a:ModificationDate>1381953446</a:ModificationDate>
<a:Rect>((-19051,4537), (-11550,7537))</a:Rect>
<a:ListOfPoints>((-19051,7537),(-19051,4537),(-11550,4537))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o40"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o51"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o52"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o53">
<a:CreationDate>1381694229</a:CreationDate>
<a:ModificationDate>1381953920</a:ModificationDate>
<a:Rect>((8100,13687), (16950,16912))</a:Rect>
<a:ListOfPoints>((16950,13687),(16950,16912),(8100,16912))</a:ListOfPoints>
<a:CornerStyle>1</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o54"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o55"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o56"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o57">
<a:CreationDate>1381694230</a:CreationDate>
<a:ModificationDate>1381953929</a:ModificationDate>
<a:Rect>((8100,7987), (16725,13012))</a:Rect>
<a:ListOfPoints>((16725,13012),(16725,7987),(8100,7987))</a:ListOfPoints>
<a:CornerStyle>1</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o54"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o58"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o59"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:ActorSymbol Id="o40">
<a:CreationDate>1381694083</a:CreationDate>
<a:ModificationDate>1381953446</a:ModificationDate>
<a:Rect>((-21675,6126), (-16876,9725))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o33"/>
</c:Object>
</o:ActorSymbol>
<o:ActorSymbol Id="o54">
<a:CreationDate>1381694086</a:CreationDate>
<a:ModificationDate>1381694262</a:ModificationDate>
<a:Rect>((14475,11900), (19274,15499))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o34"/>
</c:Object>
</o:ActorSymbol>
<o:UseCaseSymbol Id="o44">
<a:CreationDate>1381694123</a:CreationDate>
<a:ModificationDate>1381953532</a:ModificationDate>
<a:Rect>((-13349,8062), (-3450,13461))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o29"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o51">
<a:CreationDate>1381694128</a:CreationDate>
<a:ModificationDate>1381694184</a:ModificationDate>
<a:Rect>((-13724,1912), (-3825,7311))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:Object>
<o:UseCase Ref="o30"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o47">
<a:CreationDate>1381694132</a:CreationDate>
<a:ModificationDate>1381953552</a:ModificationDate>
<a:Rect>((-13424,15487), (-3525,20886))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o28"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o58">
<a:CreationDate>1381694139</a:CreationDate>
<a:ModificationDate>1381694297</a:ModificationDate>
<a:Rect>((675,6487), (10574,11886))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o32"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o55">
<a:CreationDate>1381694144</a:CreationDate>
<a:ModificationDate>1381694297</a:ModificationDate>
<a:Rect>((675,13912), (10574,19311))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o31"/>
</c:Object>
</o:UseCaseSymbol>
<o:ActorSymbol Id="o41">
<a:CreationDate>1381953211</a:CreationDate>
<a:ModificationDate>1381953550</a:ModificationDate>
<a:Rect>((-21675,16912), (-16876,20511))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o35"/>
</c:Object>
</o:ActorSymbol>
</c:Symbols>
</o:UseCaseDiagram>
<o:UseCaseDiagram Id="o60">
<a:ObjectID>E9F6A009-E39A-4AB5-BF09-C56DCC667301</a:ObjectID>
<a:Name>UCase_etape3</a:Name>
<a:Code>UCase_etape3</a:Code>
<a:CreationDate>1381694768</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954069</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:DisplayPreferences>[DisplayPreferences]

[DisplayPreferences\UCD]

[DisplayPreferences\General]
Adjust to text=Yes
Snap Grid=No
Constrain Labels=Yes
Display Grid=No
Show Page Delimiter=Yes
Grid size=0
Graphic unit=2
Window color=255, 255, 255
Background image=
Background mode=8
Watermark image=
Watermark mode=8
Show watermark on screen=No
Gradient mode=0
Gradient end color=255, 255, 255
Show Swimlane=No
SwimlaneVert=Yes
TreeVert=No
CompDark=0

[DisplayPreferences\Object]
Mode=0
Trunc Length=80
Word Length=80
Word Text=!&quot;&quot;#$%&amp;&#39;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~
Shortcut IntIcon=Yes
Shortcut IntLoct=Yes
Shortcut IntFullPath=No
Shortcut IntLastPackage=Yes
Shortcut ExtIcon=Yes
Shortcut ExtLoct=No
Shortcut ExtFullPath=No
Shortcut ExtLastPackage=Yes
Shortcut ExtIncludeModl=Yes
EObjShowStrn=Yes
ExtendedObject.Comment=No
ExtendedObject.IconPicture=No
ExtendedObject_SymbolLayout=
ELnkShowStrn=Yes
ELnkShowName=Yes
ExtendedLink_SymbolLayout=
File Location=No
PckgShowStrn=Yes
Package.Comment=No
Package.IconPicture=No
Package_SymbolLayout=
Display Model Version=Yes
Actor.IconPicture=No
Actor_SymbolLayout=
UseCase.IconPicture=No
UseCase_SymbolLayout=
FileObject.IconPicture=No
FileObject_SymbolLayout=
ActrShowStrn=Yes
UcasShowStrn=Yes
UseCase.Comment=No
AsscShowName=No
AsscShowDirt=No
AsscShowStrn=No
GnrlShowName=No
GnrlShowStrn=No
GnrlShowCntr=No
DepdShowName=No
DepdShowStrn=Yes
DepdShowCntr=No

[DisplayPreferences\Symbol]

[DisplayPreferences\Symbol\FRMEOBJ]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=6000
Height=2000
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=64
Brush gradient color=192 192 192
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 255 128 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FRMELNK]
CENTERFont=Arial,8,N
CENTERFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\CLDPCKG]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 178 178 178
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDACTR]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDUCAS]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=7200
Height=5400
Brush color=192 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDASSC]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\GNRLLINK]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\DEPDLINK]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FILO]
NAMEFont=Arial,8,N
NAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=2400
Height=2400
Brush color=255 255 255
Fill Color=No
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\USRDEPD]
OBJXSTRFont=Arial,8,N
OBJXSTRFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\Free Symbol]
Free TextFont=Arial,8,N
Free TextFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0</a:DisplayPreferences>
<a:PaperSize>(8268, 11693)</a:PaperSize>
<a:PageMargins>((315,354), (433,354))</a:PageMargins>
<a:PageOrientation>1</a:PageOrientation>
<a:PaperSource>7</a:PaperSource>
<c:Symbols>
<o:RectangleSymbol Id="o61">
<a:CreationDate>1381695225</a:CreationDate>
<a:ModificationDate>1381695254</a:ModificationDate>
<a:Rect>((-14025,25912), (-1349,-2966))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:RectangleSymbol>
<o:TitleSymbol Id="o62">
<a:Text>Version: </a:Text>
<a:CreationDate>1381953874</a:CreationDate>
<a:ModificationDate>1381953878</a:ModificationDate>
<a:Rect>((12885,19554), (24059,26297))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
</o:TitleSymbol>
<o:UseCaseAssociationSymbol Id="o63">
<a:CreationDate>1381953636</a:CreationDate>
<a:ModificationDate>1381953649</a:ModificationDate>
<a:Rect>((-16725,21637), (-10875,21737))</a:Rect>
<a:ListOfPoints>((-16725,21637),(-10875,21637))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o64"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o65"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o66"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o67">
<a:CreationDate>1381953638</a:CreationDate>
<a:ModificationDate>1381953858</a:ModificationDate>
<a:Rect>((-3300,21838), (4049,21938))</a:Rect>
<a:ListOfPoints>((-3300,21838),(4049,21838))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o65"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSymbol Ref="o68"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o69"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o70">
<a:CreationDate>1381953692</a:CreationDate>
<a:ModificationDate>1381953743</a:ModificationDate>
<a:Rect>((-3053,11300), (4147,21200))</a:Rect>
<a:ListOfPoints>((-3053,21200),(622,13325),(4147,11300))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o65"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSymbol Ref="o71"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o72"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o73">
<a:CreationDate>1381953753</a:CreationDate>
<a:ModificationDate>1381953756</a:ModificationDate>
<a:Rect>((-3503,11187), (4372,11287))</a:Rect>
<a:ListOfPoints>((-3503,11187),(4372,11187))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o74"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSymbol Ref="o71"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o75"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:NoteSymbol Id="o76">
<a:Text>{\rtf1\ansi\ansicpg1252\deff0\deflang1036{\fonttbl{\f0\fnil\fcharset0 Times New Roman;}}
\viewkind4\uc1\pard\f0\fs20 Remarque : \par
\pard Quand on s&#39;int\&#39;e9resse aux acteurs secondaires, on constate qu&#39;il n&#39;est pas judicieux de faire h\&#39;e9riter Client banque de porteur de carte.\par
En effet, dans le cas du retrait d&#39;argent, ce n&#39;est pas le m\&#39;eame syst\&#39;e8me qui est interrog\&#39;e9.  \par
}
</a:Text>
<a:CreationDate>1381695302</a:CreationDate>
<a:ModificationDate>1382642513</a:ModificationDate>
<a:Rect>((-19799,-11799), (10725,-4387))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:UseCaseAssociationSymbol Id="o77">
<a:CreationDate>1381694838</a:CreationDate>
<a:ModificationDate>1381695015</a:ModificationDate>
<a:Rect>((-17700,11212), (-11550,20062))</a:Rect>
<a:ListOfPoints>((-17700,11212),(-17100,13087),(-11550,20062))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o78"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o65"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o79"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o80">
<a:CreationDate>1381694840</a:CreationDate>
<a:ModificationDate>1381695239</a:ModificationDate>
<a:Rect>((-16050,11506), (-7950,11511))</a:Rect>
<a:ListOfPoints>((-16050,11511),(-7950,11506))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o78"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o74"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o81"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o82">
<a:CreationDate>1381694913</a:CreationDate>
<a:ModificationDate>1381695134</a:ModificationDate>
<a:Rect>((-20175,1537), (-11625,9712))</a:Rect>
<a:ListOfPoints>((-20175,9712),(-11625,1537))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o78"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o83"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o84"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o85">
<a:CreationDate>1381695108</a:CreationDate>
<a:ModificationDate>1381695265</a:ModificationDate>
<a:Rect>((-5100,1537), (4350,9187))</a:Rect>
<a:ListOfPoints>((4350,9187),(750,1537),(-5100,1537))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o71"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o83"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o86"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:ActorSymbol Id="o78">
<a:CreationDate>1381694787</a:CreationDate>
<a:ModificationDate>1381694883</a:ModificationDate>
<a:Rect>((-20849,9651), (-16050,13250))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o33"/>
</c:Object>
</o:ActorSymbol>
<o:UseCaseSymbol Id="o65">
<a:CreationDate>1381694798</a:CreationDate>
<a:ModificationDate>1381695015</a:ModificationDate>
<a:Rect>((-12824,18712), (-2925,24111))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o28"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o74">
<a:CreationDate>1381694804</a:CreationDate>
<a:ModificationDate>1381694878</a:ModificationDate>
<a:Rect>((-12824,8662), (-2925,14061))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o29"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o83">
<a:CreationDate>1381694807</a:CreationDate>
<a:ModificationDate>1381694878</a:ModificationDate>
<a:Rect>((-12824,-1388), (-2925,4011))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:Object>
<o:UseCase Ref="o30"/>
</c:Object>
</o:UseCaseSymbol>
<o:ActorSymbol Id="o71">
<a:CreationDate>1381694945</a:CreationDate>
<a:ModificationDate>1381695082</a:ModificationDate>
<a:Rect>((2025,9112), (6824,12711))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o87"/>
</c:Object>
</o:ActorSymbol>
<o:ActorSymbol Id="o68">
<a:CreationDate>1381869194</a:CreationDate>
<a:ModificationDate>1381953858</a:ModificationDate>
<a:Rect>((1649,20164), (6448,23763))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o88"/>
</c:Object>
</o:ActorSymbol>
<o:ActorSymbol Id="o64">
<a:CreationDate>1381953630</a:CreationDate>
<a:ModificationDate>1381953632</a:ModificationDate>
<a:Rect>((-20999,20750), (-16200,24349))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o35"/>
</c:Object>
</o:ActorSymbol>
</c:Symbols>
</o:UseCaseDiagram>
<o:UseCaseDiagram Id="o89">
<a:ObjectID>5A5C517E-F8D0-446E-A076-2CD8AFBBDBF0</a:ObjectID>
<a:Name>UCase_etape4</a:Name>
<a:Code>UCase_etape4</a:Code>
<a:CreationDate>1382286007</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382287286</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:DisplayPreferences>[DisplayPreferences]

[DisplayPreferences\UCD]

[DisplayPreferences\General]
Adjust to text=Yes
Snap Grid=No
Constrain Labels=Yes
Display Grid=No
Show Page Delimiter=Yes
Grid size=0
Graphic unit=2
Window color=255, 255, 255
Background image=
Background mode=8
Watermark image=
Watermark mode=8
Show watermark on screen=No
Gradient mode=0
Gradient end color=255, 255, 255
Show Swimlane=No
SwimlaneVert=Yes
TreeVert=No
CompDark=0

[DisplayPreferences\Object]
Mode=0
Trunc Length=80
Word Length=80
Word Text=!&quot;&quot;#$%&amp;&#39;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~
Shortcut IntIcon=Yes
Shortcut IntLoct=Yes
Shortcut IntFullPath=No
Shortcut IntLastPackage=Yes
Shortcut ExtIcon=Yes
Shortcut ExtLoct=No
Shortcut ExtFullPath=No
Shortcut ExtLastPackage=Yes
Shortcut ExtIncludeModl=Yes
EObjShowStrn=Yes
ExtendedObject.Comment=No
ExtendedObject.IconPicture=No
ExtendedObject_SymbolLayout=
ELnkShowStrn=Yes
ELnkShowName=Yes
ExtendedLink_SymbolLayout=
File Location=No
PckgShowStrn=Yes
Package.Comment=No
Package.IconPicture=No
Package_SymbolLayout=
Display Model Version=Yes
Actor.IconPicture=No
Actor_SymbolLayout=
UseCase.IconPicture=No
UseCase_SymbolLayout=
FileObject.IconPicture=No
FileObject_SymbolLayout=
ActrShowStrn=Yes
UcasShowStrn=Yes
UseCase.Comment=No
AsscShowName=No
AsscShowDirt=No
AsscShowStrn=No
GnrlShowName=No
GnrlShowStrn=No
GnrlShowCntr=No
DepdShowName=No
DepdShowStrn=Yes
DepdShowCntr=No

[DisplayPreferences\Symbol]

[DisplayPreferences\Symbol\FRMEOBJ]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=6000
Height=2000
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=64
Brush gradient color=192 192 192
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 255 128 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FRMELNK]
CENTERFont=Arial,8,N
CENTERFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\CLDPCKG]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 178 178 178
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDACTR]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDUCAS]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=7200
Height=5400
Brush color=192 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDASSC]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\GNRLLINK]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\DEPDLINK]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
Line style=2
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FILO]
NAMEFont=Arial,8,N
NAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=2400
Height=2400
Brush color=255 255 255
Fill Color=No
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\USRDEPD]
OBJXSTRFont=Arial,8,N
OBJXSTRFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\Free Symbol]
Free TextFont=Arial,8,N
Free TextFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0</a:DisplayPreferences>
<a:PaperSize>(8268, 11693)</a:PaperSize>
<a:PageMargins>((315,354), (433,354))</a:PageMargins>
<a:PageOrientation>1</a:PageOrientation>
<a:PaperSource>7</a:PaperSource>
<c:Symbols>
<o:TextSymbol Id="o90">
<a:Text>&lt;Texte par défaut&gt;</a:Text>
<a:CreationDate>1382287274</a:CreationDate>
<a:ModificationDate>1382287274</a:ModificationDate>
<a:Rect>((-4238,4476), (2436,876))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:LineColor>0</a:LineColor>
<a:DashStyle>7</a:DashStyle>
<a:FillColor>0</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
</o:TextSymbol>
<o:RectangleSymbol Id="o91">
<a:CreationDate>1382287286</a:CreationDate>
<a:ModificationDate>1382287316</a:ModificationDate>
<a:Rect>((-17401,28177), (15524,-18549))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:RectangleSymbol>
<o:GeneralizationSymbol Id="o92">
<a:CreationDate>1382286416</a:CreationDate>
<a:ModificationDate>1382286494</a:ModificationDate>
<a:Rect>((-11076,127), (-10076,2827))</a:Rect>
<a:ListOfPoints>((-10576,127),(-10576,2827))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>7</a:ArrowStyle>
<a:LineColor>16744576</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o93"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o94"/>
</c:DestinationSymbol>
<c:Object>
<o:Generalization Ref="o95"/>
</c:Object>
</o:GeneralizationSymbol>
<o:GeneralizationSymbol Id="o96">
<a:CreationDate>1382286418</a:CreationDate>
<a:ModificationDate>1382286508</a:ModificationDate>
<a:Rect>((-2433,-2387), (-1433,4177))</a:Rect>
<a:ListOfPoints>((-1933,-2387),(-1933,4177))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>7</a:ArrowStyle>
<a:LineColor>16744576</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o97"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o94"/>
</c:DestinationSymbol>
<c:Object>
<o:Generalization Ref="o98"/>
</c:Object>
</o:GeneralizationSymbol>
<o:UseCaseAssociationSymbol Id="o99">
<a:CreationDate>1382286520</a:CreationDate>
<a:ModificationDate>1382287351</a:ModificationDate>
<a:Rect>((-20626,23564), (-12526,23664))</a:Rect>
<a:ListOfPoints>((-20626,23564),(-12526,23564))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o100"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o101"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o102"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o103">
<a:CreationDate>1382286522</a:CreationDate>
<a:ModificationDate>1382287354</a:ModificationDate>
<a:Rect>((-20926,9352), (-11626,17377))</a:Rect>
<a:ListOfPoints>((-20926,9352),(-20926,17377),(-11626,17377))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o104"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o105"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o106"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o107">
<a:CreationDate>1382286534</a:CreationDate>
<a:ModificationDate>1382287373</a:ModificationDate>
<a:Rect>((-20176,10027), (-11176,11452))</a:Rect>
<a:ListOfPoints>((-20176,10027),(-20176,11452),(-11176,11452))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o104"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o108"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o109"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o110">
<a:CreationDate>1382286549</a:CreationDate>
<a:ModificationDate>1382287302</a:ModificationDate>
<a:Rect>((-21301,4702), (-11701,6727))</a:Rect>
<a:ListOfPoints>((-21301,6727),(-21301,4702),(-11701,4702))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o104"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o94"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o111"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:DependencySymbol Id="o112">
<a:CreationDate>1382286626</a:CreationDate>
<a:ModificationDate>1382287189</a:ModificationDate>
<a:CenterTextOffset>(-2325, 525)</a:CenterTextOffset>
<a:Rect>((-376,15952), (10574,22477))</a:Rect>
<a:ListOfPoints>((-376,22477),(6074,19777),(10574,15952))</a:ListOfPoints>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>16744576</a:LineColor>
<a:DashStyle>2</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o101"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o113"/>
</c:DestinationSymbol>
<c:Object>
<o:Dependency Ref="o114"/>
</c:Object>
</o:DependencySymbol>
<o:DependencySymbol Id="o115">
<a:CreationDate>1382286627</a:CreationDate>
<a:ModificationDate>1382287244</a:ModificationDate>
<a:CenterTextOffset>(975, -300)</a:CenterTextOffset>
<a:Rect>((-1,16551), (7724,18148))</a:Rect>
<a:ListOfPoints>((-1,17752),(2699,17152),(7724,16551))</a:ListOfPoints>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>16744576</a:LineColor>
<a:DashStyle>2</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o105"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o113"/>
</c:DestinationSymbol>
<c:Object>
<o:Dependency Ref="o116"/>
</c:Object>
</o:DependencySymbol>
<o:DependencySymbol Id="o117">
<a:CreationDate>1382286629</a:CreationDate>
<a:ModificationDate>1382287324</a:ModificationDate>
<a:Rect>((-7190,11618), (9674,14102))</a:Rect>
<a:ListOfPoints>((-7190,11777),(1949,12652),(5249,13177),(9674,14102))</a:ListOfPoints>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>16744576</a:LineColor>
<a:DashStyle>2</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o108"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o113"/>
</c:DestinationSymbol>
<c:Object>
<o:Dependency Ref="o118"/>
</c:Object>
</o:DependencySymbol>
<o:UseCaseAssociationSymbol Id="o119">
<a:CreationDate>1382286778</a:CreationDate>
<a:ModificationDate>1382287313</a:ModificationDate>
<a:Rect>((-20851,-7598), (-12001,-7498))</a:Rect>
<a:ListOfPoints>((-20851,-7598),(-12001,-7598))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o120"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o121"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o122"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o123">
<a:CreationDate>1382286780</a:CreationDate>
<a:ModificationDate>1382287313</a:ModificationDate>
<a:Rect>((-20701,-15323), (-12901,-9248))</a:Rect>
<a:ListOfPoints>((-20701,-9248),(-20701,-15323),(-12901,-15323))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSymbol Ref="o120"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o124"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o125"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o126">
<a:CreationDate>1382286888</a:CreationDate>
<a:ModificationDate>1382286898</a:ModificationDate>
<a:Rect>((-826,23677), (19349,23777))</a:Rect>
<a:ListOfPoints>((-826,23677),(19349,23677))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o101"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSymbol Ref="o127"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o128"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o129">
<a:CreationDate>1382286920</a:CreationDate>
<a:ModificationDate>1382287406</a:ModificationDate>
<a:Rect>((74,5902), (19424,16702))</a:Rect>
<a:ListOfPoints>((74,16702),(11324,8152),(19424,5902))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o105"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSymbol Ref="o130"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o131"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o132">
<a:CreationDate>1382286926</a:CreationDate>
<a:ModificationDate>1382287438</a:ModificationDate>
<a:Rect>((-1201,5377), (18749,10702))</a:Rect>
<a:ListOfPoints>((-1201,10702),(12674,5752),(18749,5377))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o108"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSymbol Ref="o130"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o133"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:UseCaseAssociationSymbol Id="o134">
<a:CreationDate>1382286928</a:CreationDate>
<a:ModificationDate>1382287432</a:ModificationDate>
<a:Rect>((-1726,4777), (22199,4877))</a:Rect>
<a:ListOfPoints>((-1726,4777),(22199,4777))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o94"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSymbol Ref="o130"/>
</c:DestinationSymbol>
<c:Object>
<o:UseCaseAssociation Ref="o135"/>
</c:Object>
</o:UseCaseAssociationSymbol>
<o:DependencySymbol Id="o136">
<a:CreationDate>1382287055</a:CreationDate>
<a:ModificationDate>1382287175</a:ModificationDate>
<a:CenterTextOffset>(-1800, -1200)</a:CenterTextOffset>
<a:Rect>((-526,5827), (10349,13627))</a:Rect>
<a:ListOfPoints>((-526,5827),(4124,8527),(10349,13627))</a:ListOfPoints>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>16744576</a:LineColor>
<a:DashStyle>2</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UseCaseSymbol Ref="o94"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UseCaseSymbol Ref="o113"/>
</c:DestinationSymbol>
<c:Object>
<o:Dependency Ref="o137"/>
</c:Object>
</o:DependencySymbol>
<o:ActorSymbol Id="o100">
<a:CreationDate>1382286028</a:CreationDate>
<a:ModificationDate>1382287295</a:ModificationDate>
<a:Rect>((-22874,22176), (-18075,25775))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o35"/>
</c:Object>
</o:ActorSymbol>
<o:ActorSymbol Id="o104">
<a:CreationDate>1382286072</a:CreationDate>
<a:ModificationDate>1382287302</a:ModificationDate>
<a:Rect>((-23474,6726), (-18675,10325))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o33"/>
</c:Object>
</o:ActorSymbol>
<o:ActorSymbol Id="o120">
<a:CreationDate>1382286079</a:CreationDate>
<a:ModificationDate>1382287313</a:ModificationDate>
<a:Rect>((-23174,-10749), (-18375,-7150))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o34"/>
</c:Object>
</o:ActorSymbol>
<o:UseCaseSymbol Id="o101">
<a:CreationDate>1382286093</a:CreationDate>
<a:ModificationDate>1382286748</a:ModificationDate>
<a:Rect>((-12989,20512), (709,25911))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o28"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o105">
<a:CreationDate>1382286098</a:CreationDate>
<a:ModificationDate>1382287039</a:ModificationDate>
<a:Rect>((-13289,14545), (410,19944))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:Object>
<o:UseCase Ref="o138"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o113">
<a:CreationDate>1382286170</a:CreationDate>
<a:ModificationDate>1382287105</a:ModificationDate>
<a:Rect>((7099,12352), (14498,17751))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:Object>
<o:UseCase Ref="o139"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o94">
<a:CreationDate>1382286216</a:CreationDate>
<a:ModificationDate>1382286369</a:ModificationDate>
<a:Rect>((-13214,2311), (485,7710))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o30"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o108">
<a:CreationDate>1382286221</a:CreationDate>
<a:ModificationDate>1382287324</a:ModificationDate>
<a:Rect>((-13214,8128), (484,13527))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o29"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o97">
<a:CreationDate>1382286243</a:CreationDate>
<a:ModificationDate>1382286508</a:ModificationDate>
<a:Rect>((-5970,-4470), (3342,296))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o140"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o93">
<a:CreationDate>1382286270</a:CreationDate>
<a:ModificationDate>1382286458</a:ModificationDate>
<a:Rect>((-15614,-4223), (-6301,543))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:UseCase Ref="o141"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o121">
<a:CreationDate>1382286766</a:CreationDate>
<a:ModificationDate>1382287313</a:ModificationDate>
<a:Rect>((-14000,-10747), (-6101,-5348))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:Object>
<o:UseCase Ref="o32"/>
</c:Object>
</o:UseCaseSymbol>
<o:UseCaseSymbol Id="o124">
<a:CreationDate>1382286772</a:CreationDate>
<a:ModificationDate>1382287313</a:ModificationDate>
<a:Rect>((-14625,-17422), (-5926,-12023))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>16777152</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N
LABL 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:Object>
<o:UseCase Ref="o31"/>
</c:Object>
</o:UseCaseSymbol>
<o:ActorSymbol Id="o127">
<a:CreationDate>1382286850</a:CreationDate>
<a:ModificationDate>1382286850</a:ModificationDate>
<a:Rect>((17849,22927), (22648,26526))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o88"/>
</c:Object>
</o:ActorSymbol>
<o:ActorSymbol Id="o130">
<a:CreationDate>1382286855</a:CreationDate>
<a:ModificationDate>1382287406</a:ModificationDate>
<a:Rect>((18074,4627), (22873,8226))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:LineWidth>1</a:LineWidth>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<a:KeepAspect>1</a:KeepAspect>
<a:KeepCenter>1</a:KeepCenter>
<c:Object>
<o:Actor Ref="o87"/>
</c:Object>
</o:ActorSymbol>
</c:Symbols>
</o:UseCaseDiagram>
</c:UseCaseDiagrams>
<c:SequenceDiagrams>
<o:SequenceDiagram Id="o142">
<a:ObjectID>6093B9E6-2D11-4E69-A709-4AAA04E461EF</a:ObjectID>
<a:Name>Séquence système - Retirer argent - scénario nominal</a:Name>
<a:Code>Sequence_systeme___Retirer_argent___scenario_nominal</a:Code>
<a:CreationDate>1381868108</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382643216</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:DisplayPreferences>[DisplayPreferences]

[DisplayPreferences\SQD]

[DisplayPreferences\General]
Adjust to text=Yes
Snap Grid=No
Constrain Labels=Yes
Display Grid=No
Show Page Delimiter=Yes
Grid size=0
Graphic unit=2
Window color=255, 255, 255
Background image=
Background mode=8
Watermark image=
Watermark mode=8
Show watermark on screen=No
Gradient mode=0
Gradient end color=255, 255, 255
Show Swimlane=No
SwimlaneVert=Yes
TreeVert=No
CompDark=0

[DisplayPreferences\Object]
Mode=0
Trunc Length=80
Word Length=80
Word Text=!&quot;&quot;#$%&amp;&#39;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~
Shortcut IntIcon=Yes
Shortcut IntLoct=Yes
Shortcut IntFullPath=No
Shortcut IntLastPackage=Yes
Shortcut ExtIcon=Yes
Shortcut ExtLoct=No
Shortcut ExtFullPath=No
Shortcut ExtLastPackage=Yes
Shortcut ExtIncludeModl=Yes
EObjShowStrn=Yes
ExtendedObject.Comment=No
ExtendedObject.IconPicture=No
ExtendedObject_SymbolLayout=
ELnkShowStrn=Yes
ELnkShowName=Yes
ExtendedLink_SymbolLayout=
File Location=No
PckgShowStrn=Yes
Package.Comment=No
Package.IconPicture=No
Package_SymbolLayout=
Display Model Version=Yes
InteractionSymbol.IconPicture=No
InteractionSymbol_SymbolLayout=
UMLObject.IconPicture=No
UMLObject_SymbolLayout=
ActivationSymbol.IconPicture=No
ActivationSymbol_SymbolLayout=
Actor.IconPicture=No
Actor_SymbolLayout=
InteractionReference.IconPicture=No
InteractionReference_SymbolLayout=
InteractionFragment.IconPicture=No
InteractionFragment_SymbolLayout=
FileObject.IconPicture=No
FileObject_SymbolLayout=
ActrShowStrn=Yes
ObjtShowStrn=Yes
ObjtShowHead=Yes
MssgShowName=Yes
MssgShowStrn=Yes
MssgShowTime=Yes
MssgShowCond=Yes
MssgShowMthd=Yes
MssgShowSign=Yes
MssgShowActv=No
IRefShowStrn=Yes
FragShowLife=Yes
ShowIntrSym=Yes

[DisplayPreferences\Symbol]

[DisplayPreferences\Symbol\FRMEOBJ]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=6000
Height=2000
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=64
Brush gradient color=192 192 192
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 255 128 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FRMELNK]
CENTERFont=Arial,8,N
CENTERFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\CLDPCKG]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 178 178 178
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SINT]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=22000
Height=28800
Brush color=255 255 255
Fill Color=No
Brush style=4
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SQDOBJT]
OBJSTRNFont=Arial,8,N
OBJSTRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,U
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=236 249 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\ACTVSYM]
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=900
Height=2400
Brush color=208 208 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDACTR]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\IREF]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=208 208 232
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\IFRG]
KWRDFont=Arial,8,N
KWRDFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 255
Fill Color=Yes
Brush style=4
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=208 208 232
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SQDMSSG]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
BTIMFont=Arial,8,N
BTIMFont color=0, 0, 0
ETIMFont=Arial,8,N
ETIMFont color=0, 0, 0
Line style=2
Pen=1 0 128 128 192
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FILO]
NAMEFont=Arial,8,N
NAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=2400
Height=2400
Brush color=255 255 255
Fill Color=No
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\USRDEPD]
OBJXSTRFont=Arial,8,N
OBJXSTRFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\Free Symbol]
Free TextFont=Arial,8,N
Free TextFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0</a:DisplayPreferences>
<a:PaperSize>(8268, 11693)</a:PaperSize>
<a:PageMargins>((315,354), (433,354))</a:PageMargins>
<a:PageOrientation>1</a:PageOrientation>
<a:PaperSource>7</a:PaperSource>
<c:Symbols>
<o:InteractionSymbol Id="o143">
<a:ModificationDate>1382287905</a:ModificationDate>
<a:Rect>((-23475,-17538), (24825,22912))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:BaseSymbol.Flags>4</a:BaseSymbol.Flags>
<a:LineColor>15257808</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>4</a:BrushStyle>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:SequenceDiagram Ref="o142"/>
</c:Object>
</o:InteractionSymbol>
<o:NoteLinkSymbol Id="o144">
<a:CreationDate>1382643206</a:CreationDate>
<a:ModificationDate>1382643210</a:ModificationDate>
<a:Rect>((-451,-11911), (1500,-11811))</a:Rect>
<a:ListOfPoints>((-451,-11911),(1500,-11911))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16711680</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:NoteSymbol Ref="o146"/>
</c:DestinationSymbol>
</o:NoteLinkSymbol>
<o:NoteLinkSymbol Id="o147">
<a:CreationDate>1382643174</a:CreationDate>
<a:ModificationDate>1382643174</a:ModificationDate>
<a:Rect>((-451,-7711), (1875,-7611))</a:Rect>
<a:ListOfPoints>((-451,-7711),(1875,-7711))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16711680</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:NoteSymbol Ref="o148"/>
</c:DestinationSymbol>
</o:NoteLinkSymbol>
<o:NoteLinkSymbol Id="o149">
<a:CreationDate>1382643110</a:CreationDate>
<a:ModificationDate>1382643110</a:ModificationDate>
<a:Rect>((-451,-4036), (1875,-3961))</a:Rect>
<a:ListOfPoints>((-451,-3961),(-451,-4036),(1875,-4036))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16711680</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:NoteSymbol Ref="o150"/>
</c:DestinationSymbol>
</o:NoteLinkSymbol>
<o:NoteSymbol Id="o150">
<a:Text>A3 : ticket refusé</a:Text>
<a:CreationDate>1382643072</a:CreationDate>
<a:ModificationDate>1382643104</a:ModificationDate>
<a:Rect>((1349,-4486), (9225,-2910))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:NoteLinkSymbol Id="o151">
<a:CreationDate>1382643060</a:CreationDate>
<a:ModificationDate>1382643127</a:ModificationDate>
<a:Rect>((-451,-1561), (8250,-1067))</a:Rect>
<a:ListOfPoints>((-451,-1561),(-451,-1067),(8250,-1067))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16711680</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:NoteSymbol Ref="o152"/>
</c:DestinationSymbol>
</o:NoteLinkSymbol>
<o:NoteSymbol Id="o152">
<a:Text>A2 : montant demandé &gt; credit hebdo</a:Text>
<a:CreationDate>1382643013</a:CreationDate>
<a:ModificationDate>1382643127</a:ModificationDate>
<a:Rect>((8138,-1636), (22724,14))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:NoteLinkSymbol Id="o153">
<a:CreationDate>1382642997</a:CreationDate>
<a:ModificationDate>1382642999</a:ModificationDate>
<a:Rect>((-2925,4739), (-451,5264))</a:Rect>
<a:ListOfPoints>((-451,4739),(-451,5264),(-2925,5264))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16711680</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:NoteSymbol Ref="o154"/>
</c:DestinationSymbol>
</o:NoteLinkSymbol>
<o:NoteSymbol Id="o154">
<a:Text>E3 : retrait interdit</a:Text>
<a:CreationDate>1382642954</a:CreationDate>
<a:ModificationDate>1382642999</a:ModificationDate>
<a:Rect>((-10501,4964), (-2849,6765))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:NoteLinkSymbol Id="o155">
<a:CreationDate>1382642932</a:CreationDate>
<a:ModificationDate>1382642943</a:ModificationDate>
<a:Rect>((-451,7289), (7725,9389))</a:Rect>
<a:ListOfPoints>((-451,9389),(-451,7289),(7725,7289))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16711680</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:NoteSymbol Ref="o156"/>
</c:DestinationSymbol>
</o:NoteLinkSymbol>
<o:NoteSymbol Id="o156">
<a:Text>A1 et E2 : code erroné</a:Text>
<a:CreationDate>1382642894</a:CreationDate>
<a:ModificationDate>1382643123</a:ModificationDate>
<a:Rect>((7126,7289), (15524,8714))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:NoteLinkSymbol Id="o157">
<a:CreationDate>1382450954</a:CreationDate>
<a:ModificationDate>1382643119</a:ModificationDate>
<a:Rect>((-451,11471), (6167,11538))</a:Rect>
<a:ListOfPoints>((-451,11538),(-451,11471),(6167,11471))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16711680</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>12632256</a:ShadowColor>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:NoteSymbol Ref="o158"/>
</c:DestinationSymbol>
</o:NoteLinkSymbol>
<o:NoteSymbol Id="o158">
<a:Text>E1 : carte invalide</a:Text>
<a:CreationDate>1382450920</a:CreationDate>
<a:ModificationDate>1382643119</a:ModificationDate>
<a:Rect>((5719,11269), (13689,12839))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:MessageSymbol Id="o159">
<a:CreationDate>1382287905</a:CreationDate>
<a:ModificationDate>1382287936</a:ModificationDate>
<a:Rect>((-451,11787), (5211,13462))</a:Rect>
<a:ListOfPoints>((-451,13462),(3149,13462),(3149,11787),(-451,11787))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o160"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o161">
<a:CreationDate>1381954603</a:CreationDate>
<a:ModificationDate>1381954641</a:ModificationDate>
<a:Rect>((-1388,-888), (7686,712))</a:Rect>
<a:ListOfPoints>((-451,712),(3149,712),(3149,-888),(-451,-888))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o162"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o163">
<a:CreationDate>1381954455</a:CreationDate>
<a:ModificationDate>1381954627</a:ModificationDate>
<a:Rect>((-17249,-12338), (-451,-10742))</a:Rect>
<a:ListOfPoints>((-17249,-12038),(-451,-12038))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o165"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o166">
<a:CreationDate>1381954422</a:CreationDate>
<a:ModificationDate>1381954629</a:ModificationDate>
<a:Rect>((-17249,-10088), (-451,-8492))</a:Rect>
<a:ListOfPoints>((-451,-9788),(-17249,-9788))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o167"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o168">
<a:CreationDate>1381954401</a:CreationDate>
<a:ModificationDate>1381954631</a:ModificationDate>
<a:Rect>((-17249,-8063), (-451,-6467))</a:Rect>
<a:ListOfPoints>((-17249,-7763),(-451,-7763))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o169"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o170">
<a:CreationDate>1381954377</a:CreationDate>
<a:ModificationDate>1381954633</a:ModificationDate>
<a:Rect>((-17249,-5888), (-451,-4292))</a:Rect>
<a:ListOfPoints>((-451,-5588),(-17249,-5588))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o171"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o172">
<a:CreationDate>1381954340</a:CreationDate>
<a:ModificationDate>1381954639</a:ModificationDate>
<a:Rect>((-17249,-1988), (-451,-392))</a:Rect>
<a:ListOfPoints>((-451,-1688),(-17249,-1688))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o173"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o174">
<a:CreationDate>1381954330</a:CreationDate>
<a:ModificationDate>1381954634</a:ModificationDate>
<a:Rect>((-17249,-4238), (-451,-2642))</a:Rect>
<a:ListOfPoints>((-17249,-3938),(-451,-3938))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o175"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o176">
<a:CreationDate>1381954307</a:CreationDate>
<a:ModificationDate>1381954643</a:ModificationDate>
<a:Rect>((-17249,1162), (-451,2758))</a:Rect>
<a:ListOfPoints>((-17249,1462),(-451,1462))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o177"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o178">
<a:CreationDate>1381954286</a:CreationDate>
<a:ModificationDate>1381954487</a:ModificationDate>
<a:Rect>((-17249,2662), (-451,4258))</a:Rect>
<a:ListOfPoints>((-451,2962),(-17249,2962))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o179"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o180">
<a:CreationDate>1381954241</a:CreationDate>
<a:ModificationDate>1381954473</a:ModificationDate>
<a:Rect>((-451,4087), (16424,5683))</a:Rect>
<a:ListOfPoints>((16424,4387),(-451,4387))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o181"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o182"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o183">
<a:CreationDate>1381954211</a:CreationDate>
<a:ModificationDate>1382287940</a:ModificationDate>
<a:Rect>((-451,5437), (16424,7033))</a:Rect>
<a:ListOfPoints>((-451,5737),(16424,5737))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o181"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o184"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o185">
<a:CreationDate>1381954197</a:CreationDate>
<a:ModificationDate>1382288460</a:ModificationDate>
<a:CenterTextOffset>(825, -150)</a:CenterTextOffset>
<a:Rect>((-451,7662), (6786,9262))</a:Rect>
<a:ListOfPoints>((-451,9262),(3149,9262),(3149,7662),(-451,7662))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o186"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o187">
<a:CreationDate>1381954178</a:CreationDate>
<a:ModificationDate>1381954484</a:ModificationDate>
<a:Rect>((-17249,9637), (-451,11233))</a:Rect>
<a:ListOfPoints>((-17249,9937),(-451,9937))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o188"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o189">
<a:CreationDate>1381954153</a:CreationDate>
<a:ModificationDate>1382287907</a:ModificationDate>
<a:Rect>((-17249,10912), (-451,12508))</a:Rect>
<a:ListOfPoints>((-451,11212),(-17249,11212))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o190"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o191">
<a:CreationDate>1381954132</a:CreationDate>
<a:ModificationDate>1382287920</a:ModificationDate>
<a:Rect>((-17249,14062), (-451,15658))</a:Rect>
<a:ListOfPoints>((-17249,14362),(-451,14362))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o164"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o145"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o192"/>
</c:Object>
</o:MessageSymbol>
<o:UMLObjectSequenceSymbol Id="o145">
<a:CreationDate>1381868136</a:CreationDate>
<a:ModificationDate>1381954473</a:ModificationDate>
<a:Rect>((-2851,17737), (1949,21336))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>16775660</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>OBJSTRN 0 Arial,8,N
DISPNAME 0 Arial,8,U</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o193">
<a:ModificationDate>1382287905</a:ModificationDate>
<a:Rect>((-451,-16538), (-351,17737))</a:Rect>
<a:ListOfPoints>((-451,17737),(-451,-16538))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:UMLObject Ref="o194"/>
</c:Object>
</o:UMLObjectSequenceSymbol>
<o:ActorSequenceSymbol Id="o164">
<a:CreationDate>1381954097</a:CreationDate>
<a:ModificationDate>1381954473</a:ModificationDate>
<a:Rect>((-19649,17737), (-14850,21336))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o195">
<a:ModificationDate>1382287905</a:ModificationDate>
<a:Rect>((-17249,-16538), (-17149,17737))</a:Rect>
<a:ListOfPoints>((-17249,17737),(-17249,-16538))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:Actor Ref="o35"/>
</c:Object>
</o:ActorSequenceSymbol>
<o:ActorSequenceSymbol Id="o181">
<a:CreationDate>1381954106</a:CreationDate>
<a:ModificationDate>1381954473</a:ModificationDate>
<a:Rect>((14025,17737), (18824,21336))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o196">
<a:ModificationDate>1382287905</a:ModificationDate>
<a:Rect>((16424,-16538), (16524,17737))</a:Rect>
<a:ListOfPoints>((16424,17737),(16424,-16538))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:Actor Ref="o88"/>
</c:Object>
</o:ActorSequenceSymbol>
<o:NoteSymbol Id="o148">
<a:Text>E4 : carte non reprise</a:Text>
<a:CreationDate>1382643143</a:CreationDate>
<a:ModificationDate>1382643168</a:ModificationDate>
<a:Rect>((1312,-8086), (9188,-6510))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:NoteSymbol Id="o146">
<a:Text>E5 : billets non pris</a:Text>
<a:CreationDate>1382643185</a:CreationDate>
<a:ModificationDate>1382643201</a:ModificationDate>
<a:Rect>((1462,-12211), (9338,-10635))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
</c:Symbols>
</o:SequenceDiagram>
<o:SequenceDiagram Id="o197">
<a:ObjectID>22C81E4D-8643-4DE0-848A-95DA19958905</a:ObjectID>
<a:Name>fragment - s&#39;authentifier</a:Name>
<a:Code>fragment___s_authentifier</a:Code>
<a:CreationDate>1381868794</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382643553</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:DisplayPreferences>[DisplayPreferences]

[DisplayPreferences\SQD]

[DisplayPreferences\General]
Adjust to text=Yes
Snap Grid=No
Constrain Labels=Yes
Display Grid=No
Show Page Delimiter=Yes
Grid size=0
Graphic unit=2
Window color=255, 255, 255
Background image=
Background mode=8
Watermark image=
Watermark mode=8
Show watermark on screen=No
Gradient mode=0
Gradient end color=255, 255, 255
Show Swimlane=No
SwimlaneVert=Yes
TreeVert=No
CompDark=0

[DisplayPreferences\Object]
Mode=0
Trunc Length=80
Word Length=80
Word Text=!&quot;&quot;#$%&amp;&#39;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~
Shortcut IntIcon=Yes
Shortcut IntLoct=Yes
Shortcut IntFullPath=No
Shortcut IntLastPackage=Yes
Shortcut ExtIcon=Yes
Shortcut ExtLoct=No
Shortcut ExtFullPath=No
Shortcut ExtLastPackage=Yes
Shortcut ExtIncludeModl=Yes
EObjShowStrn=Yes
ExtendedObject.Comment=No
ExtendedObject.IconPicture=No
ExtendedObject_SymbolLayout=
ELnkShowStrn=Yes
ELnkShowName=Yes
ExtendedLink_SymbolLayout=
File Location=No
PckgShowStrn=Yes
Package.Comment=No
Package.IconPicture=No
Package_SymbolLayout=
Display Model Version=Yes
InteractionSymbol.IconPicture=No
InteractionSymbol_SymbolLayout=
UMLObject.IconPicture=No
UMLObject_SymbolLayout=
ActivationSymbol.IconPicture=No
ActivationSymbol_SymbolLayout=
Actor.IconPicture=No
Actor_SymbolLayout=
InteractionReference.IconPicture=No
InteractionReference_SymbolLayout=
InteractionFragment.IconPicture=No
InteractionFragment_SymbolLayout=
FileObject.IconPicture=No
FileObject_SymbolLayout=
ActrShowStrn=Yes
ObjtShowStrn=Yes
ObjtShowHead=Yes
MssgShowName=Yes
MssgShowStrn=Yes
MssgShowTime=Yes
MssgShowCond=Yes
MssgShowMthd=Yes
MssgShowSign=Yes
MssgShowActv=No
IRefShowStrn=Yes
FragShowLife=Yes
ShowIntrSym=Yes

[DisplayPreferences\Symbol]

[DisplayPreferences\Symbol\FRMEOBJ]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=6000
Height=2000
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=64
Brush gradient color=192 192 192
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 255 128 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FRMELNK]
CENTERFont=Arial,8,N
CENTERFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\CLDPCKG]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 178 178 178
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SINT]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=22000
Height=28800
Brush color=255 255 255
Fill Color=No
Brush style=4
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SQDOBJT]
OBJSTRNFont=Arial,8,N
OBJSTRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,U
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=236 249 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\ACTVSYM]
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=900
Height=2400
Brush color=208 208 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDACTR]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\IREF]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=208 208 232
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\IFRG]
KWRDFont=Arial,8,N
KWRDFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 255
Fill Color=Yes
Brush style=4
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=208 208 232
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SQDMSSG]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
BTIMFont=Arial,8,N
BTIMFont color=0, 0, 0
ETIMFont=Arial,8,N
ETIMFont color=0, 0, 0
Line style=2
Pen=1 0 128 128 192
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FILO]
NAMEFont=Arial,8,N
NAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=2400
Height=2400
Brush color=255 255 255
Fill Color=No
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\USRDEPD]
OBJXSTRFont=Arial,8,N
OBJXSTRFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\Free Symbol]
Free TextFont=Arial,8,N
Free TextFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0</a:DisplayPreferences>
<a:PaperSize>(8268, 11693)</a:PaperSize>
<a:PageMargins>((315,354), (433,354))</a:PageMargins>
<a:PageOrientation>1</a:PageOrientation>
<a:PaperSource>7</a:PaperSource>
<c:Symbols>
<o:InteractionSymbol Id="o198">
<a:ModificationDate>1381955288</a:ModificationDate>
<a:Rect>((-23499,-8164), (10425,14092))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:BaseSymbol.Flags>4</a:BaseSymbol.Flags>
<a:LineColor>15257808</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>4</a:BrushStyle>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:SequenceDiagram Ref="o197"/>
</c:Object>
</o:InteractionSymbol>
<o:MessageSymbol Id="o199">
<a:CreationDate>1381955178</a:CreationDate>
<a:ModificationDate>1381955285</a:ModificationDate>
<a:Rect>((-18074,-3863), (-149,-2267))</a:Rect>
<a:ListOfPoints>((-149,-3563),(-18074,-3563))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o200"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o201"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o202"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o203">
<a:CreationDate>1381955135</a:CreationDate>
<a:ModificationDate>1381955164</a:ModificationDate>
<a:Rect>((-18074,112), (-149,1708))</a:Rect>
<a:ListOfPoints>((-18074,412),(-149,412))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o201"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o200"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o204"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o205">
<a:CreationDate>1381955119</a:CreationDate>
<a:ModificationDate>1381955163</a:ModificationDate>
<a:Rect>((-18074,2212), (-149,3808))</a:Rect>
<a:ListOfPoints>((-149,2512),(-18074,2512))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o200"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o201"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o206"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o207">
<a:CreationDate>1381955104</a:CreationDate>
<a:ModificationDate>1381955113</a:ModificationDate>
<a:Rect>((-18074,5737), (-149,7333))</a:Rect>
<a:ListOfPoints>((-18074,6037),(-149,6037))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o201"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o200"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o208"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o209">
<a:CreationDate>1381868943</a:CreationDate>
<a:ModificationDate>1381955284</a:ModificationDate>
<a:Rect>((-149,-2388), (6788,-413))</a:Rect>
<a:ListOfPoints>((-149,-413),(3451,-413),(3451,-2388),(-149,-2388))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o200"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o200"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o210"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o211">
<a:CreationDate>1381868930</a:CreationDate>
<a:ModificationDate>1381955160</a:ModificationDate>
<a:Rect>((-149,3237), (6788,4837))</a:Rect>
<a:ListOfPoints>((-149,4837),(3451,4837),(3451,3237),(-149,3237))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o200"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o200"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o212"/>
</c:Object>
</o:MessageSymbol>
<o:UMLObjectSequenceSymbol Id="o200">
<a:CreationDate>1381868876</a:CreationDate>
<a:ModificationDate>1381955081</a:ModificationDate>
<a:Rect>((-2549,8512), (2250,12111))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>16775660</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>OBJSTRN 0 Arial,8,N
DISPNAME 0 Arial,8,U</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o213">
<a:ModificationDate>1381955288</a:ModificationDate>
<a:Rect>((-149,-7164), (-49,8512))</a:Rect>
<a:ListOfPoints>((-149,8512),(-149,-7164))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:UMLObject Ref="o194"/>
</c:Object>
</o:UMLObjectSequenceSymbol>
<o:ActorSequenceSymbol Id="o201">
<a:CreationDate>1381954973</a:CreationDate>
<a:ModificationDate>1381955081</a:ModificationDate>
<a:Rect>((-20474,8512), (-15675,12111))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o214">
<a:ModificationDate>1381955288</a:ModificationDate>
<a:Rect>((-18074,-7164), (-17974,8512))</a:Rect>
<a:ListOfPoints>((-18074,8512),(-18074,-7164))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:Actor Ref="o35"/>
</c:Object>
</o:ActorSequenceSymbol>
</c:Symbols>
</o:SequenceDiagram>
<o:SequenceDiagram Id="o215">
<a:ObjectID>12CC7D91-5EDB-4F1F-9565-2A2B052E0D10</a:ObjectID>
<a:Name>séquence système - Retirer argent - référence au  fragment authentifier</a:Name>
<a:Code>sequence_systeme___Retirer_argent___reference_au__fragment_authentifier</a:Code>
<a:CreationDate>1381869060</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955589</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:DisplayPreferences>[DisplayPreferences]

[DisplayPreferences\SQD]

[DisplayPreferences\General]
Adjust to text=Yes
Snap Grid=No
Constrain Labels=Yes
Display Grid=No
Show Page Delimiter=Yes
Grid size=0
Graphic unit=2
Window color=255, 255, 255
Background image=
Background mode=8
Watermark image=
Watermark mode=8
Show watermark on screen=No
Gradient mode=0
Gradient end color=255, 255, 255
Show Swimlane=No
SwimlaneVert=Yes
TreeVert=No
CompDark=0

[DisplayPreferences\Object]
Mode=0
Trunc Length=80
Word Length=80
Word Text=!&quot;&quot;#$%&amp;&#39;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~
Shortcut IntIcon=Yes
Shortcut IntLoct=Yes
Shortcut IntFullPath=No
Shortcut IntLastPackage=Yes
Shortcut ExtIcon=Yes
Shortcut ExtLoct=No
Shortcut ExtFullPath=No
Shortcut ExtLastPackage=Yes
Shortcut ExtIncludeModl=Yes
EObjShowStrn=Yes
ExtendedObject.Comment=No
ExtendedObject.IconPicture=No
ExtendedObject_SymbolLayout=
ELnkShowStrn=Yes
ELnkShowName=Yes
ExtendedLink_SymbolLayout=
File Location=No
PckgShowStrn=Yes
Package.Comment=No
Package.IconPicture=No
Package_SymbolLayout=
Display Model Version=Yes
InteractionSymbol.IconPicture=No
InteractionSymbol_SymbolLayout=
UMLObject.IconPicture=No
UMLObject_SymbolLayout=
ActivationSymbol.IconPicture=No
ActivationSymbol_SymbolLayout=
Actor.IconPicture=No
Actor_SymbolLayout=
InteractionReference.IconPicture=No
InteractionReference_SymbolLayout=
InteractionFragment.IconPicture=No
InteractionFragment_SymbolLayout=
FileObject.IconPicture=No
FileObject_SymbolLayout=
ActrShowStrn=Yes
ObjtShowStrn=Yes
ObjtShowHead=Yes
MssgShowName=Yes
MssgShowStrn=Yes
MssgShowTime=Yes
MssgShowCond=Yes
MssgShowMthd=Yes
MssgShowSign=Yes
MssgShowActv=No
IRefShowStrn=Yes
FragShowLife=Yes
ShowIntrSym=Yes

[DisplayPreferences\Symbol]

[DisplayPreferences\Symbol\FRMEOBJ]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=6000
Height=2000
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=64
Brush gradient color=192 192 192
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 255 128 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FRMELNK]
CENTERFont=Arial,8,N
CENTERFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\CLDPCKG]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 178 178 178
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SINT]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=22000
Height=28800
Brush color=255 255 255
Fill Color=No
Brush style=4
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SQDOBJT]
OBJSTRNFont=Arial,8,N
OBJSTRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,U
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=236 249 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\ACTVSYM]
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=900
Height=2400
Brush color=208 208 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDACTR]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\IREF]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=208 208 232
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\IFRG]
KWRDFont=Arial,8,N
KWRDFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 255
Fill Color=Yes
Brush style=4
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=208 208 232
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SQDMSSG]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
BTIMFont=Arial,8,N
BTIMFont color=0, 0, 0
ETIMFont=Arial,8,N
ETIMFont color=0, 0, 0
Line style=2
Pen=1 0 128 128 192
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FILO]
NAMEFont=Arial,8,N
NAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=2400
Height=2400
Brush color=255 255 255
Fill Color=No
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\USRDEPD]
OBJXSTRFont=Arial,8,N
OBJXSTRFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\Free Symbol]
Free TextFont=Arial,8,N
Free TextFont color=0, 0, 0
Line style=2
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0</a:DisplayPreferences>
<a:PaperSize>(8268, 11693)</a:PaperSize>
<a:PageMargins>((315,354), (433,354))</a:PageMargins>
<a:PageOrientation>1</a:PageOrientation>
<a:PaperSource>7</a:PaperSource>
<c:Symbols>
<o:InteractionSymbol Id="o216">
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((-24736,-4563), (25488,26167))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:BaseSymbol.Flags>4</a:BaseSymbol.Flags>
<a:LineColor>15257808</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>4</a:BrushStyle>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:SequenceDiagram Ref="o215"/>
</c:Object>
</o:InteractionSymbol>
<o:MessageSymbol Id="o217">
<a:CreationDate>1381955589</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((-18685,637), (514,2183))</a:Rect>
<a:ListOfPoints>((514,937),(-18685,937))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o218"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o219"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o220"/>
</c:Object>
</o:MessageSymbol>
<o:NoteSymbol Id="o221">
<a:Text>Le cadre &quot;ref&quot; permet de faire référence à un autre diagramme (ici fait référence au fragment authentifier) </a:Text>
<a:CreationDate>1381955488</a:CreationDate>
<a:ModificationDate>1381955555</a:ModificationDate>
<a:Rect>((-24975,-8138), (25049,-5528))</a:Rect>
<a:TextStyle>4130</a:TextStyle>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>16711680</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontName>Arial,8,N</a:FontName>
<a:ManuallyResized>1</a:ManuallyResized>
</o:NoteSymbol>
<o:MessageSymbol Id="o222">
<a:CreationDate>1381955466</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((-18685,2812), (515,4358))</a:Rect>
<a:ListOfPoints>((-18685,3112),(515,3112))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o219"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o218"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o223"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o224">
<a:CreationDate>1381955432</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((-18685,4837), (514,6383))</a:Rect>
<a:ListOfPoints>((514,5137),(-18685,5137))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o218"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o219"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o225"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o226">
<a:CreationDate>1381955405</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((515,6712), (18813,8258))</a:Rect>
<a:ListOfPoints>((18813,7012),(515,7012))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:ActorSequenceSymbol Ref="o227"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:UMLObjectSequenceSymbol Ref="o218"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o228"/>
</c:Object>
</o:MessageSymbol>
<o:MessageSymbol Id="o229">
<a:CreationDate>1381955391</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((514,8737), (18813,10283))</a:Rect>
<a:ListOfPoints>((514,9037),(18813,9037))</a:ListOfPoints>
<a:CornerStyle>2</a:CornerStyle>
<a:ArrowStyle>8</a:ArrowStyle>
<a:LineColor>12615808</a:LineColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N
BTIM 0 Arial,8,N
ETIM 0 Arial,8,N</a:FontList>
<c:SourceSymbol>
<o:UMLObjectSequenceSymbol Ref="o218"/>
</c:SourceSymbol>
<c:DestinationSymbol>
<o:ActorSequenceSymbol Ref="o227"/>
</c:DestinationSymbol>
<c:Object>
<o:Message Ref="o230"/>
</c:Object>
</o:MessageSymbol>
<o:ActorSequenceSymbol Id="o219">
<a:CreationDate>1381869086</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((-21085,19237), (-16286,22836))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o231">
<a:ModificationDate>1381955599</a:ModificationDate>
<a:Rect>((-18685,-1688), (-18585,19237))</a:Rect>
<a:ListOfPoints>((-18685,19237),(-18685,-1688))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:Actor Ref="o33"/>
</c:Object>
</o:ActorSequenceSymbol>
<o:UMLObjectSequenceSymbol Id="o218">
<a:CreationDate>1381869097</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((-1885,19237), (2914,22836))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>16775660</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>OBJSTRN 0 Arial,8,N
DISPNAME 0 Arial,8,U</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o232">
<a:ModificationDate>1381955599</a:ModificationDate>
<a:Rect>((514,-1688), (614,19237))</a:Rect>
<a:ListOfPoints>((514,19237),(514,-1688))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:UMLObject Ref="o194"/>
</c:Object>
</o:UMLObjectSequenceSymbol>
<o:ActorSequenceSymbol Id="o227">
<a:CreationDate>1381869218</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((16414,19237), (21213,22836))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o233">
<a:ModificationDate>1381955599</a:ModificationDate>
<a:Rect>((18813,-1688), (18913,19237))</a:Rect>
<a:ListOfPoints>((18813,19237),(18813,-1688))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:Actor Ref="o88"/>
</c:Object>
</o:ActorSequenceSymbol>
<o:InteractionReferenceSymbol Id="o234">
<a:CreationDate>1381869261</a:CreationDate>
<a:ModificationDate>1440666196</a:ModificationDate>
<a:Rect>((-20036,10537), (3139,16688))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>15257808</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
RFNM 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>15257808</a:GradientEndColor>
<a:ManuallyResized>1</a:ManuallyResized>
<c:AttachedLifelines>
<o:ActorSequenceSymbol Ref="o219"/>
<o:UMLObjectSequenceSymbol Ref="o218"/>
</c:AttachedLifelines>
<c:Object>
<o:InteractionReference Ref="o235"/>
</c:Object>
</o:InteractionReferenceSymbol>
</c:Symbols>
</o:SequenceDiagram>
<o:SequenceDiagram Id="o236">
<a:ObjectID>7EB9CC44-F331-4444-9BA8-1AB08DBF58CF</a:ObjectID>
<a:Name>DiagrammeSequence_4</a:Name>
<a:Code>DiagrammeSequence_4</a:Code>
<a:CreationDate>1440665938</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1440665962</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:DisplayPreferences>[DisplayPreferences]

[DisplayPreferences\SQD]

[DisplayPreferences\General]
Adjust to text=Yes
Snap Grid=No
Constrain Labels=Yes
Display Grid=No
Show Page Delimiter=Yes
Grid size=0
Graphic unit=2
Window color=255, 255, 255
Background image=
Background mode=8
Watermark image=
Watermark mode=8
Show watermark on screen=No
Gradient mode=0
Gradient end color=255, 255, 255
Show Swimlane=No
SwimlaneVert=Yes
TreeVert=No
CompDark=0

[DisplayPreferences\Object]
Mode=2
Trunc Length=40
Word Length=40
Word Text=!&quot;&quot;#$%&amp;&#39;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~
Shortcut IntIcon=Yes
Shortcut IntLoct=Yes
Shortcut IntFullPath=No
Shortcut IntLastPackage=Yes
Shortcut ExtIcon=Yes
Shortcut ExtLoct=No
Shortcut ExtFullPath=No
Shortcut ExtLastPackage=Yes
Shortcut ExtIncludeModl=Yes
EObjShowStrn=Yes
ExtendedObject.Comment=No
ExtendedObject.IconPicture=No
ExtendedObject_SymbolLayout=
ELnkShowStrn=Yes
ELnkShowName=Yes
ExtendedLink_SymbolLayout=
File Location=No
PckgShowStrn=Yes
Package.Comment=No
Package.IconPicture=No
Package_SymbolLayout=
Display Model Version=Yes
InteractionSymbol.IconPicture=No
InteractionSymbol_SymbolLayout=
UMLObject.IconPicture=No
UMLObject_SymbolLayout=
ActivationSymbol.IconPicture=No
ActivationSymbol_SymbolLayout=
Actor.IconPicture=No
Actor_SymbolLayout=
InteractionReference.IconPicture=No
InteractionReference_SymbolLayout=
InteractionFragment.IconPicture=No
InteractionFragment_SymbolLayout=
FileObject.IconPicture=No
FileObject_SymbolLayout=
ActrShowStrn=Yes
ObjtShowStrn=Yes
ObjtShowHead=Yes
MssgShowName=Yes
MssgShowStrn=Yes
MssgShowTime=Yes
MssgShowCond=Yes
MssgShowMthd=Yes
MssgShowSign=Yes
MssgShowActv=No
IRefShowStrn=Yes
FragShowLife=Yes
ShowIntrSym=Yes

[DisplayPreferences\Symbol]

[DisplayPreferences\Symbol\FRMEOBJ]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=6000
Height=2000
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=64
Brush gradient color=192 192 192
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 255 128 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FRMELNK]
CENTERFont=Arial,8,N
CENTERFont color=0, 0, 0
Line style=1
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\CLDPCKG]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
LABLFont=Arial,8,N
LABLFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 178 178 178
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SINT]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=22000
Height=28800
Brush color=255 255 255
Fill Color=No
Brush style=4
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SQDOBJT]
OBJSTRNFont=Arial,8,N
OBJSTRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,U
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=236 249 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\ACTVSYM]
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=900
Height=2400
Brush color=208 208 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 128
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\UCDACTR]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 192
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=255 255 255
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\IREF]
STRNFont=Arial,8,N
STRNFont color=0, 0, 0
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 255
Fill Color=Yes
Brush style=6
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=208 208 232
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\IFRG]
KWRDFont=Arial,8,N
KWRDFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Width=4800
Height=3600
Brush color=255 255 255
Fill Color=Yes
Brush style=4
Brush bitmap mode=12
Brush gradient mode=65
Brush gradient color=208 208 232
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 150 208 208 232
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\SQDMSSG]
DISPNAMEFont=Arial,8,N
DISPNAMEFont color=0, 0, 0
BTIMFont=Arial,8,N
BTIMFont color=0, 0, 0
ETIMFont=Arial,8,N
ETIMFont color=0, 0, 0
Line style=0
Pen=1 0 128 128 192
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\FILO]
NAMEFont=Arial,8,N
NAMEFont color=0, 0, 0
AutoAdjustToText=Yes
Keep aspect=Yes
Keep center=Yes
Keep size=No
Width=2400
Height=2400
Brush color=255 255 255
Fill Color=No
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\USRDEPD]
OBJXSTRFont=Arial,8,N
OBJXSTRFont color=0, 0, 0
Line style=1
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=2 0 128 128 255
Shadow color=192 192 192
Shadow=0

[DisplayPreferences\Symbol\Free Symbol]
Free TextFont=Arial,8,N
Free TextFont color=0, 0, 0
Line style=0
AutoAdjustToText=Yes
Keep aspect=No
Keep center=No
Keep size=No
Brush color=255 255 255
Fill Color=Yes
Brush style=1
Brush bitmap mode=12
Brush gradient mode=0
Brush gradient color=118 118 118
Brush background image=
Custom shape=
Custom text mode=0
Pen=1 0 0 0 255
Shadow color=192 192 192
Shadow=0</a:DisplayPreferences>
<a:PaperSize>(8268, 11693)</a:PaperSize>
<a:PageMargins>((315,354), (433,354))</a:PageMargins>
<a:PageOrientation>1</a:PageOrientation>
<a:PaperSource>7</a:PaperSource>
<c:Symbols>
<o:InteractionSymbol Id="o237">
<a:ModificationDate>1440665947</a:ModificationDate>
<a:Rect>((-26061,-9000), (21413,19792))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:BaseSymbol.Flags>4</a:BaseSymbol.Flags>
<a:LineColor>15257808</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>4</a:BrushStyle>
<a:ManuallyResized>1</a:ManuallyResized>
<c:Object>
<o:SequenceDiagram Ref="o236"/>
</c:Object>
</o:InteractionSymbol>
<o:ActorSequenceSymbol Id="o238">
<a:CreationDate>1440665950</a:CreationDate>
<a:ModificationDate>1440665950</a:ModificationDate>
<a:Rect>((-24037,12788), (-19238,16387))</a:Rect>
<a:LineColor>16744448</a:LineColor>
<a:FillColor>12648447</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
DISPNAME 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>16777215</a:GradientEndColor>
<c:SlaveSubSymbols>
<o:LifelineSymbol Id="o239">
<a:Rect>((-21637,-11212), (-21537,12788))</a:Rect>
<a:ListOfPoints>((-21637,12788),(-21637,-11212))</a:ListOfPoints>
<a:ArrowStyle>0</a:ArrowStyle>
<a:LineColor>16744448</a:LineColor>
<a:DashStyle>3</a:DashStyle>
<a:ShadowColor>8421504</a:ShadowColor>
</o:LifelineSymbol>
</c:SlaveSubSymbols>
<c:Object>
<o:Actor Ref="o240"/>
</c:Object>
</o:ActorSequenceSymbol>
<o:InteractionReferenceSymbol Id="o241">
<a:CreationDate>1440665956</a:CreationDate>
<a:ModificationDate>1440665962</a:ModificationDate>
<a:Rect>((-22987,9638), (15488,-1762))</a:Rect>
<a:AutoAdjustToText>0</a:AutoAdjustToText>
<a:LineColor>15257808</a:LineColor>
<a:FillColor>16777215</a:FillColor>
<a:ShadowColor>12632256</a:ShadowColor>
<a:FontList>STRN 0 Arial,8,N
RFNM 0 Arial,8,N</a:FontList>
<a:BrushStyle>6</a:BrushStyle>
<a:GradientFillMode>65</a:GradientFillMode>
<a:GradientEndColor>15257808</a:GradientEndColor>
<c:AttachedLifelines>
<o:ActorSequenceSymbol Ref="o238"/>
</c:AttachedLifelines>
<c:Object>
<o:InteractionReference Ref="o242"/>
</c:Object>
</o:InteractionReferenceSymbol>
</c:Symbols>
</o:SequenceDiagram>
</c:SequenceDiagrams>
<c:InteractionReferences>
<o:InteractionReference Id="o235">
<a:ObjectID>FAD58EA7-B213-4B8B-AE22-BB8332EBA272</a:ObjectID>
<a:CreationDate>1381869261</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381869266</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:ReferencedDiagram>
<o:SequenceDiagram Ref="o197"/>
</c:ReferencedDiagram>
</o:InteractionReference>
<o:InteractionReference Id="o242">
<a:ObjectID>988F29D3-AFEA-4838-BCD2-BDA20FFE2EF8</a:ObjectID>
<a:CreationDate>1440665956</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1440665962</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:ReferencedDiagram>
<o:SequenceDiagram Ref="o197"/>
</c:ReferencedDiagram>
</o:InteractionReference>
</c:InteractionReferences>
<c:Classes>
<o:Class Id="o243">
<a:ObjectID>E693D714-9499-4C68-B808-44C68C170E34</a:ObjectID>
<a:Name>GAB</a:Name>
<a:Code>Gab</a:Code>
<a:CreationDate>1381868149</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381868155</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:UseParentNamespace>0</a:UseParentNamespace>
</o:Class>
</c:Classes>
<c:Generalizations>
<o:Generalization Id="o42">
<a:ObjectID>AE911F0D-F4A2-4B94-8364-18DAA4E3DDA5</a:ObjectID>
<a:Name>Generalisation_1</a:Name>
<a:Code>Generalisation_1</a:Code>
<a:CreationDate>1381953412</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953412</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o35"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:Generalization>
<o:Generalization Id="o95">
<a:ObjectID>DAE4E785-E827-497B-B902-6E7493E14B24</a:ObjectID>
<a:Name>Generalisation_2</a:Name>
<a:Code>Generalisation_2</a:Code>
<a:CreationDate>1382286416</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286416</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o30"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o141"/>
</c:Object2>
</o:Generalization>
<o:Generalization Id="o98">
<a:ObjectID>C9B8C6ED-E329-4699-924F-027361CEEC71</a:ObjectID>
<a:Name>Generalisation_3</a:Name>
<a:Code>Generalisation_3</a:Code>
<a:CreationDate>1382286418</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286418</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o30"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o140"/>
</c:Object2>
</o:Generalization>
</c:Generalizations>
<c:Dependencies>
<o:Dependency Id="o114">
<a:ObjectID>E3E2FE6B-9292-4240-85D1-B9F56629631F</a:ObjectID>
<a:Name>Dependance_1</a:Name>
<a:Code>Dependance_1</a:Code>
<a:CreationDate>1382286626</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286680</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Stereotype>include</a:Stereotype>
<c:Object1>
<o:UseCase Ref="o139"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o28"/>
</c:Object2>
</o:Dependency>
<o:Dependency Id="o116">
<a:ObjectID>A1900D81-5C2D-4211-8387-E9CD3FDE07A0</a:ObjectID>
<a:Name>Dependance_2</a:Name>
<a:Code>Dependance_2</a:Code>
<a:CreationDate>1382286627</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286688</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Stereotype>include</a:Stereotype>
<c:Object1>
<o:UseCase Ref="o139"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o138"/>
</c:Object2>
</o:Dependency>
<o:Dependency Id="o118">
<a:ObjectID>C7DFAF8B-DC39-4229-86A8-AFB51B01FA0B</a:ObjectID>
<a:Name>Dependance_3</a:Name>
<a:Code>Dependance_3</a:Code>
<a:CreationDate>1382286629</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286694</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Stereotype>include</a:Stereotype>
<c:Object1>
<o:UseCase Ref="o139"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o29"/>
</c:Object2>
</o:Dependency>
<o:Dependency Id="o137">
<a:ObjectID>2DFDCB8C-8310-4AA8-B3E3-A53B373AC8EC</a:ObjectID>
<a:Name>Dependance_4</a:Name>
<a:Code>Dependance_4</a:Code>
<a:CreationDate>1382287055</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382287142</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Stereotype>include</a:Stereotype>
<c:Object1>
<o:UseCase Ref="o139"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o30"/>
</c:Object2>
</o:Dependency>
</c:Dependencies>
<c:Actors>
<o:Actor Id="o33">
<a:ObjectID>946A4607-C6C7-4C86-9303-7A590BF4FBA2</a:ObjectID>
<a:Name>Client banque</a:Name>
<a:Code>Client_banque</a:Code>
<a:CreationDate>1381693765</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693789</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:Actor>
<o:Actor Id="o34">
<a:ObjectID>D71BE7B2-F326-48D6-821D-41D01D359ACF</a:ObjectID>
<a:Name>Opérateur de maintenance</a:Name>
<a:Code>Operateur_de_maintenance</a:Code>
<a:CreationDate>1381693795</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693805</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:Actor>
<o:Actor Id="o87">
<a:ObjectID>505B9809-6BE4-489C-8914-9D6961BFCB37</a:ObjectID>
<a:Name>Système Information banque</a:Name>
<a:Code>Systeme_Information_banque</a:Code>
<a:CreationDate>1381694945</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381694982</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Stereotype>system</a:Stereotype>
</o:Actor>
<o:Actor Id="o88">
<a:ObjectID>0364F800-5728-4A1C-9765-C806D45FEB3E</a:ObjectID>
<a:Name>Systeme autorisation</a:Name>
<a:Code>Systeme_autorisation</a:Code>
<a:CreationDate>1381869194</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381869206</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Stereotype>system</a:Stereotype>
</o:Actor>
<o:Actor Id="o35">
<a:ObjectID>ECD9B1E1-00B8-48CD-93FD-453807BD33B4</a:ObjectID>
<a:Name>Porteur de carte</a:Name>
<a:Code>Porteur_de_carte</a:Code>
<a:CreationDate>1381953211</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953216</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:Actor>
<o:Actor Id="o240">
<a:ObjectID>0686405E-C5C8-4A5D-B8FE-E6702081382C</a:ObjectID>
<a:Name>Acteur_6</a:Name>
<a:Code>Acteur_6</a:Code>
<a:CreationDate>1440665950</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1440665950</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:Actor>
</c:Actors>
<c:UseCases>
<o:UseCase Id="o28">
<a:ObjectID>5486DDF5-7908-49C4-8899-60F90A8CF953</a:ObjectID>
<a:Name>Retirer argent</a:Name>
<a:Code>Retirer_argent</a:Code>
<a:CreationDate>1381693636</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286680</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:UseCase>
<o:UseCase Id="o29">
<a:ObjectID>7B37D97F-A8B9-4B66-AD6D-FBF06D4DAB53</a:ObjectID>
<a:Name>Consulter solde</a:Name>
<a:Code>Consulter_solde</a:Code>
<a:CreationDate>1381693639</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286694</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:UseCase>
<o:UseCase Id="o30">
<a:ObjectID>F1F0C97F-17E9-424D-BCBC-7BBE9E21160F</a:ObjectID>
<a:Name>Déposer de l&#39;argent</a:Name>
<a:Code>Deposer_de_l_argent</a:Code>
<a:CreationDate>1381693640</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382287142</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:UseCase>
<o:UseCase Id="o31">
<a:ObjectID>B6ABA005-FCBD-43EA-BBE1-DEE54F4AC60E</a:ObjectID>
<a:Name>Recharger caisse</a:Name>
<a:Code>Recharger_caisse</a:Code>
<a:CreationDate>1381693723</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953072</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:UseCase>
<o:UseCase Id="o32">
<a:ObjectID>F02E14F8-D3A9-4F1B-8044-B31DFB719658</a:ObjectID>
<a:Name>Maintenir l&#39;état</a:Name>
<a:Code>Maintenir_l_etat</a:Code>
<a:CreationDate>1381693724</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693759</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:UseCase>
<o:UseCase Id="o138">
<a:ObjectID>DF1FCDD2-338C-4034-B6FF-DB2F62F0B4B8</a:ObjectID>
<a:Name>Retirer argent carte banque</a:Name>
<a:Code>Retirer_argent_carte_banque</a:Code>
<a:CreationDate>1382286098</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286835</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:UseCase>
<o:UseCase Id="o139">
<a:ObjectID>491E94C0-175F-43F5-93E6-7F7A1AD42AA5</a:ObjectID>
<a:Name>S&#39;aurhentifier</a:Name>
<a:Code>S_aurhentifier</a:Code>
<a:CreationDate>1382286170</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382287142</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Stereotype>fragment</a:Stereotype>
</o:UseCase>
<o:UseCase Id="o140">
<a:ObjectID>00A14CA4-7796-4099-958B-E9035D94F11E</a:ObjectID>
<a:Name>Deposer cheques</a:Name>
<a:Code>Deposer_cheques</a:Code>
<a:CreationDate>1382286243</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286258</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:UseCase>
<o:UseCase Id="o141">
<a:ObjectID>B2AD2CA1-7BA4-44C1-AF4B-6F7F73B0F239</a:ObjectID>
<a:Name>Deposer numéraire</a:Name>
<a:Code>Deposer_numeraire</a:Code>
<a:CreationDate>1382286270</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286278</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
</o:UseCase>
</c:UseCases>
<c:Model.Objects>
<o:UMLObject Id="o194">
<a:ObjectID>82C67206-BD96-4647-836E-81972BD2588E</a:ObjectID>
<a:CreationDate>1381868136</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381868756</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Stereotype>system</a:Stereotype>
<c:InstantiationClass>
<o:Class Ref="o243"/>
</c:InstantiationClass>
</o:UMLObject>
</c:Model.Objects>
<c:Messages>
<o:Message Id="o212">
<a:ObjectID>CDCE5D64-0823-403D-B847-5D1EE3DC1361</a:ObjectID>
<a:Name>Vérification carte</a:Name>
<a:Code>Verification_carte</a:Code>
<a:CreationDate>1381868930</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381868950</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Delay>1</a:Delay>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o210">
<a:ObjectID>B9434B26-3722-42B9-A1D8-1D64ECAC6868</a:ObjectID>
<a:Name>Vérification code</a:Name>
<a:Code>Verification_code</a:Code>
<a:CreationDate>1381868943</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381868961</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Delay>1</a:Delay>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o192">
<a:ObjectID>DE33EA58-7E4D-4B0E-9C9F-B685761E81C8</a:ObjectID>
<a:Name>Introduction carte</a:Name>
<a:Code>Introduction_carte</a:Code>
<a:CreationDate>1381954132</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954141</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
<o:Message Id="o190">
<a:ObjectID>DC830E8A-B187-4C50-9E12-2DC195631D34</a:ObjectID>
<a:Name>Demande code</a:Name>
<a:Code>Demande_code</a:Code>
<a:CreationDate>1381954153</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954173</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o35"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o188">
<a:ObjectID>2759639E-19C2-47C2-94C9-245676C15960</a:ObjectID>
<a:Name>Code</a:Name>
<a:Code>Code</a:Code>
<a:CreationDate>1381954178</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954184</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
<o:Message Id="o186">
<a:ObjectID>693D53DB-6EF2-4629-818D-C098206BDACC</a:ObjectID>
<a:Name>Controle code</a:Name>
<a:Code>Controle_code</a:Code>
<a:CreationDate>1381954197</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954203</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Delay>1</a:Delay>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o184">
<a:ObjectID>52DE00FC-34B2-48C2-9008-8164E91892B8</a:ObjectID>
<a:Name>Demande autorisation (numéro de carte)</a:Name>
<a:Code>Demande_autorisation__numero_de_carte_</a:Code>
<a:CreationDate>1381954211</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954233</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o88"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o182">
<a:ObjectID>B467F37D-E6B7-4C6A-821C-6E44764A9280</a:ObjectID>
<a:Name>Autorisation (credit hebdo)</a:Name>
<a:Code>Autorisation__credit_hebdo_</a:Code>
<a:CreationDate>1381954241</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954274</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o88"/>
</c:Object2>
</o:Message>
<o:Message Id="o179">
<a:ObjectID>92FC5722-DDA6-489E-99F0-DC1A438CB864</a:ObjectID>
<a:Name>Demande montant retrait</a:Name>
<a:Code>Demande_montant_retrait</a:Code>
<a:CreationDate>1381954286</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954302</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o35"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o177">
<a:ObjectID>5DEA6E57-8740-4DBA-B574-74F78FD72EBD</a:ObjectID>
<a:Name>Montant retrait</a:Name>
<a:Code>Montant_retrait</a:Code>
<a:CreationDate>1381954307</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954314</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
<o:Message Id="o175">
<a:ObjectID>2EB8A599-3749-400E-A298-0D50EA5A3933</a:ObjectID>
<a:Name>Réponse ticket</a:Name>
<a:Code>Reponse_ticket</a:Code>
<a:CreationDate>1381954330</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954367</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
<o:Message Id="o173">
<a:ObjectID>E7191AA0-C3A9-4B33-8F12-2C553CF60543</a:ObjectID>
<a:Name>Demande ticket</a:Name>
<a:Code>Demande_ticket</a:Code>
<a:CreationDate>1381954340</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954349</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o35"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o171">
<a:ObjectID>4A7C7210-AE6D-4D7F-9128-6E3DC8C7163F</a:ObjectID>
<a:Name>Ejection carte</a:Name>
<a:Code>Ejection_carte</a:Code>
<a:CreationDate>1381954377</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954393</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o35"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o169">
<a:ObjectID>92141411-BF0D-4295-83F1-2442775EFDEC</a:ObjectID>
<a:Name>récupération carte</a:Name>
<a:Code>recuperation_carte</a:Code>
<a:CreationDate>1381954401</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954408</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
<o:Message Id="o167">
<a:ObjectID>F43A032D-D5D2-4E91-93A7-755681BF454A</a:ObjectID>
<a:Name>Ejection billets &amp; ticket</a:Name>
<a:Code>Ejection_billets_&amp;_ticket</a:Code>
<a:CreationDate>1381954422</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954449</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o35"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o165">
<a:ObjectID>2F6F2691-CB12-4E73-B4DC-4E914E90D8F5</a:ObjectID>
<a:Name>récupération billets et ticket</a:Name>
<a:Code>recuperation_billets_et_ticket</a:Code>
<a:CreationDate>1381954455</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954467</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
<o:Message Id="o162">
<a:ObjectID>A2A2B97F-5366-4630-A935-1AF78090C28A</a:ObjectID>
<a:Name>Controle montant retrait</a:Name>
<a:Code>Controle_montant_retrait</a:Code>
<a:CreationDate>1381954603</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381954624</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Delay>1</a:Delay>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o208">
<a:ObjectID>1CE4548A-D460-4D32-BD39-9A16C777B2A9</a:ObjectID>
<a:Name>Introduction carte</a:Name>
<a:Code>Introduction_carte</a:Code>
<a:CreationDate>1381955104</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955111</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
<o:Message Id="o206">
<a:ObjectID>171B628D-69E7-4955-B572-619FED432500</a:ObjectID>
<a:Name>Demande code</a:Name>
<a:Code>Demande_code</a:Code>
<a:CreationDate>1381955119</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955131</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o35"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o204">
<a:ObjectID>16192B9B-21D3-4E3D-9216-3CD2FCE44EA2</a:ObjectID>
<a:Name>Code</a:Name>
<a:Code>Code</a:Code>
<a:CreationDate>1381955135</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955138</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
<o:Message Id="o202">
<a:ObjectID>E4A51814-0325-4E7E-80EB-48CFCA2E3B56</a:ObjectID>
<a:Name>Code ok</a:Name>
<a:Code>Code_ok</a:Code>
<a:CreationDate>1381955178</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955185</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o35"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o230">
<a:ObjectID>4C51100C-BCDB-4ED9-9945-1E7C83623500</a:ObjectID>
<a:Name>Demande autorisation banque</a:Name>
<a:Code>Demande_autorisation_banque</a:Code>
<a:CreationDate>1381955391</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955399</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o88"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o228">
<a:ObjectID>35C9732B-DDBB-48E9-A582-B08800FDEE99</a:ObjectID>
<a:Name>Autorisation (crédit hebdo)</a:Name>
<a:Code>Autorisation__credit_hebdo_</a:Code>
<a:CreationDate>1381955405</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955416</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o88"/>
</c:Object2>
</o:Message>
<o:Message Id="o225">
<a:ObjectID>4453E2F5-F01E-4238-9DB7-4F64570D3194</a:ObjectID>
<a:Name>Demande montant retrait</a:Name>
<a:Code>Demande_montant_retrait</a:Code>
<a:CreationDate>1381955432</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955446</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o33"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o223">
<a:ObjectID>7D193520-92A5-4DF2-93F1-685B5E7298AB</a:ObjectID>
<a:Name>montant retrait</a:Name>
<a:Code>montant_retrait</a:Code>
<a:CreationDate>1381955466</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955473</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:Message>
<o:Message Id="o220">
<a:ObjectID>DA3C4A57-7C83-4B5A-9E7C-E3B00244B03C</a:ObjectID>
<a:Name>...</a:Name>
<a:Code>___</a:Code>
<a:CreationDate>1381955589</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381955593</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o33"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o160">
<a:ObjectID>F6E913E3-5327-4CA0-AF55-AEAA546A0715</a:ObjectID>
<a:Name>verif carte</a:Name>
<a:Code>verif_carte</a:Code>
<a:CreationDate>1382287905</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382287916</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:Delay>1</a:Delay>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:UMLObject Ref="o194"/>
</c:Object2>
</o:Message>
<o:Message Id="o244">
<a:ObjectID>AE5DFDF7-A9F3-4E67-8DA1-6712482CBA1E</a:ObjectID>
<a:Name>Message_28</a:Name>
<a:Code>Message_28</a:Code>
<a:CreationDate>1382516142</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382516142</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UMLObject Ref="o194"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:Message>
</c:Messages>
<c:UseCaseAssociations>
<o:UseCaseAssociation Id="o17">
<a:ObjectID>D5F57F13-DF56-446E-B061-E8F281A32F10</a:ObjectID>
<a:Name>Association_2</a:Name>
<a:Code>Association_2</a:Code>
<a:CreationDate>1381693816</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693816</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o29"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o20">
<a:ObjectID>7D076E4F-1DF3-4B15-926A-CEC264C752DF</a:ObjectID>
<a:Name>Association_3</a:Name>
<a:Code>Association_3</a:Code>
<a:CreationDate>1381693819</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693819</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o30"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o24">
<a:ObjectID>8059779C-9634-4149-9B1B-86426C894335</a:ObjectID>
<a:Name>Association_4</a:Name>
<a:Code>Association_4</a:Code>
<a:CreationDate>1381693835</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693835</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o31"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o34"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o27">
<a:ObjectID>866A6A26-8378-4464-9BE8-31A2A1CEA4E6</a:ObjectID>
<a:Name>Association_5</a:Name>
<a:Code>Association_5</a:Code>
<a:CreationDate>1381693837</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693837</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o32"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o34"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o52">
<a:ObjectID>2AEBF4B9-3BCA-4AAD-A017-A52213F28187</a:ObjectID>
<a:Name>Association_8</a:Name>
<a:Code>Association_8</a:Code>
<a:CreationDate>1381694213</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381694213</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o30"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o56">
<a:ObjectID>5D4F618D-A35A-4B4D-AFB3-720D65EE268F</a:ObjectID>
<a:Name>Association_9</a:Name>
<a:Code>Association_9</a:Code>
<a:CreationDate>1381694229</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381694229</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o31"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o34"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o59">
<a:ObjectID>F873DEF7-ED84-43ED-9725-C0F5EF77B05D</a:ObjectID>
<a:Name>Association_10</a:Name>
<a:Code>Association_10</a:Code>
<a:CreationDate>1381694230</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381694230</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o32"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o34"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o79">
<a:ObjectID>C18289FE-738F-4222-A555-931F30778D6B</a:ObjectID>
<a:Name>Association_13</a:Name>
<a:Code>Association_13</a:Code>
<a:CreationDate>1381694838</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381694838</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o28"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o81">
<a:ObjectID>DD584A35-A03E-45BF-90AF-F66B603BF47D</a:ObjectID>
<a:Name>Association_14</a:Name>
<a:Code>Association_14</a:Code>
<a:CreationDate>1381694840</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381694840</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o29"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o84">
<a:ObjectID>B1458F28-A751-4982-A381-489DF16950A9</a:ObjectID>
<a:Name>Association_15</a:Name>
<a:Code>Association_15</a:Code>
<a:CreationDate>1381694913</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381694913</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o30"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o86">
<a:ObjectID>4ACAAF43-6F55-403D-9805-AEDB76F24A58</a:ObjectID>
<a:Name>Association_19</a:Name>
<a:Code>Association_19</a:Code>
<a:CreationDate>1381695108</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381695108</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o30"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o87"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o14">
<a:ObjectID>9C3D3A18-A38D-4700-896F-08B5C6235BE8</a:ObjectID>
<a:Name>Association_16</a:Name>
<a:Code>Association_16</a:Code>
<a:CreationDate>1381953135</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953135</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o28"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o45">
<a:ObjectID>9EA65711-CF45-4D01-94A8-B46965CADBB9</a:ObjectID>
<a:Name>Association_20</a:Name>
<a:Code>Association_20</a:Code>
<a:CreationDate>1381953494</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953494</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o29"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o48">
<a:ObjectID>66E15856-EB38-4140-B8A5-FA6795754D4B</a:ObjectID>
<a:Name>Association_21</a:Name>
<a:Code>Association_21</a:Code>
<a:CreationDate>1381953556</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953556</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o28"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o66">
<a:ObjectID>52B7483F-4E27-4FF8-BD8E-ED7844369800</a:ObjectID>
<a:Name>Association_22</a:Name>
<a:Code>Association_22</a:Code>
<a:CreationDate>1381953636</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953636</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o28"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o69">
<a:ObjectID>C6F52FEF-E81A-42AB-A9BA-1996AC2EE801</a:ObjectID>
<a:Name>Association_23</a:Name>
<a:Code>Association_23</a:Code>
<a:CreationDate>1381953638</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953638</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o88"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o28"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o72">
<a:ObjectID>D63EE46C-240F-4C7E-AA81-EB99F2E5691C</a:ObjectID>
<a:Name>Association_18</a:Name>
<a:Code>Association_18</a:Code>
<a:CreationDate>1381953692</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953692</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o87"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o28"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o75">
<a:ObjectID>19597187-2683-47AA-A2C4-DCD9EB8D3E39</a:ObjectID>
<a:Name>Association_24</a:Name>
<a:Code>Association_24</a:Code>
<a:CreationDate>1381953753</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381953753</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o87"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o29"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o102">
<a:ObjectID>D1589D30-8538-4CF2-AA9C-AFD89FD1C4F3</a:ObjectID>
<a:Name>Association_25</a:Name>
<a:Code>Association_25</a:Code>
<a:CreationDate>1382286520</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286520</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o28"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o106">
<a:ObjectID>2A60CBF7-E2D7-48CB-9B93-2EED1049B343</a:ObjectID>
<a:Name>Association_26</a:Name>
<a:Code>Association_26</a:Code>
<a:CreationDate>1382286522</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286522</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o138"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o109">
<a:ObjectID>53F2D128-AE46-44DB-9A1B-798A38227C27</a:ObjectID>
<a:Name>Association_27</a:Name>
<a:Code>Association_27</a:Code>
<a:CreationDate>1382286534</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286534</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o29"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o111">
<a:ObjectID>67310DE5-0C40-44D6-80A8-0237109F0CB5</a:ObjectID>
<a:Name>Association_28</a:Name>
<a:Code>Association_28</a:Code>
<a:CreationDate>1382286549</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286549</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o30"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o33"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o122">
<a:ObjectID>EC0442D8-1B82-4054-9BD0-C062F1265C7C</a:ObjectID>
<a:Name>Association_29</a:Name>
<a:Code>Association_29</a:Code>
<a:CreationDate>1382286778</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286778</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o32"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o34"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o125">
<a:ObjectID>86796F0E-A39D-46C4-BEC6-FB596DF42EBA</a:ObjectID>
<a:Name>Association_30</a:Name>
<a:Code>Association_30</a:Code>
<a:CreationDate>1382286780</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286780</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o31"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o34"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o128">
<a:ObjectID>32B5C7B4-CE03-43D8-A669-D2F895CB7964</a:ObjectID>
<a:Name>Association_31</a:Name>
<a:Code>Association_31</a:Code>
<a:CreationDate>1382286888</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286888</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o88"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o28"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o131">
<a:ObjectID>95EDC6AD-08C9-4E8B-8DE8-27C264FA437B</a:ObjectID>
<a:Name>Association_32</a:Name>
<a:Code>Association_32</a:Code>
<a:CreationDate>1382286920</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286920</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o87"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o138"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o133">
<a:ObjectID>2B869F4F-F505-4A42-AB26-5630E739B60C</a:ObjectID>
<a:Name>Association_33</a:Name>
<a:Code>Association_33</a:Code>
<a:CreationDate>1382286926</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286926</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o87"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o29"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o135">
<a:ObjectID>15A0A181-6397-481B-A20C-A5E8857E4F05</a:ObjectID>
<a:Name>Association_34</a:Name>
<a:Code>Association_34</a:Code>
<a:CreationDate>1382286928</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382286928</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:Actor Ref="o87"/>
</c:Object1>
<c:Object2>
<o:UseCase Ref="o30"/>
</c:Object2>
</o:UseCaseAssociation>
<o:UseCaseAssociation Id="o10">
<a:ObjectID>8BE5CCB9-8959-4011-9226-BF37DE8B8F79</a:ObjectID>
<a:Name>Association_35</a:Name>
<a:Code>Association_35</a:Code>
<a:CreationDate>1382642274</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1382642274</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<c:Object1>
<o:UseCase Ref="o28"/>
</c:Object1>
<c:Object2>
<o:Actor Ref="o35"/>
</c:Object2>
</o:UseCaseAssociation>
</c:UseCaseAssociations>
<c:TargetModels>
<o:TargetModel Id="o245">
<a:ObjectID>1B80C63A-4376-4E2A-9CCE-03AF22E3D98C</a:ObjectID>
<a:Name>Java</a:Name>
<a:Code>Java</a:Code>
<a:CreationDate>1381693408</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693408</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:TargetModelURL>file:///%_OBJLANG%/java5-j2ee14.xol</a:TargetModelURL>
<a:TargetModelID>0DEDDB90-46E2-45A0-886E-411709DA0DC9</a:TargetModelID>
<a:TargetModelClassID>1811206C-1A4B-11D1-83D9-444553540000</a:TargetModelClassID>
<c:SessionShortcuts>
<o:Shortcut Ref="o3"/>
</c:SessionShortcuts>
</o:TargetModel>
<o:TargetModel Id="o246">
<a:ObjectID>0EB7A7DE-C224-4C53-9320-4132E188ED0C</a:ObjectID>
<a:Name>WSDL for Java</a:Name>
<a:Code>WSDLJava</a:Code>
<a:CreationDate>1381693408</a:CreationDate>
<a:Creator>gg</a:Creator>
<a:ModificationDate>1381693408</a:ModificationDate>
<a:Modifier>gg</a:Modifier>
<a:TargetModelURL>file:///%_XEM%/WSDLJ2EE.xem</a:TargetModelURL>
<a:TargetModelID>C8F5F7B2-CF9D-4E98-8301-959BB6E86C8A</a:TargetModelID>
<a:TargetModelClassID>186C8AC3-D3DC-11D3-881C-00508B03C75C</a:TargetModelClassID>
<c:SessionShortcuts>
<o:Shortcut Ref="o4"/>
</c:SessionShortcuts>
</o:TargetModel>
</c:TargetModels>
</o:Model>
</c:Children>
</o:RootObject>

</Model>