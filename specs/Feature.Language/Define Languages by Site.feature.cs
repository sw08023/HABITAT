﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Language.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "UI")]
    public partial class DefineLanguagesBySiteFeature : Xunit.IClassFixture<DefineLanguagesBySiteFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Define Languages by Site.feature"
#line hidden
        
        public DefineLanguagesBySiteFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Define Languages by Site", "\tAs an editor \r\n\tI want to be able to define the supported languages on a per sit" +
                    "e basis \r\n\tso that different sites can have different languages", ProgrammingLanguage.CSharp, new string[] {
                        "UI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(DefineLanguagesBySiteFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Define Languages by Site")]
        [Xunit.TraitAttribute("Description", "Define Languages by Site_UC1_Set one language on the site")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void DefineLanguagesBySite_UC1_SetOneLanguageOnTheSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define Languages by Site_UC1_Set one language on the site", new string[] {
                        "Ready"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table1.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "SupportedLanguages",
                        "en"});
#line 11
    testRunner.Given("The following languages have been selected", ((string)(null)), table1, "Given ");
#line 14
 testRunner.When("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("there is no Globe icon in the Main menu on the top of the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Define Languages by Site")]
        [Xunit.TraitAttribute("Description", "Define Languages by Site_UC2_No specific languages are defined on the site")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void DefineLanguagesBySite_UC2_NoSpecificLanguagesAreDefinedOnTheSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define Languages by Site_UC2_No specific languages are defined on the site", new string[] {
                        "Ready"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table2.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "SupportedLanguages",
                        ""});
#line 24
 testRunner.Given("Value set to item field", ((string)(null)), table2, "Given ");
#line 29
 testRunner.When("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("Globe icon was hided", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Define Languages by Site")]
        [Xunit.TraitAttribute("Description", "Define Languages by Site_UC3_Check that language with country code appears in the" +
            " list")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void DefineLanguagesBySite_UC3_CheckThatLanguageWithCountryCodeAppearsInTheList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define Languages by Site_UC3_Check that language with country code appears in the" +
                    " list", new string[] {
                        "Ready"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "Charset",
                        "CodePage",
                        "Encoding",
                        "Iso",
                        "RegionalIsoCode"});
            table3.AddRow(new string[] {
                        "/sitecore/system/Languages/ar-BH",
                        "windows-1256",
                        "65001",
                        "utf-8",
                        "ar",
                        "ar-BH"});
            table3.AddRow(new string[] {
                        "/sitecore/system/Languages/ja-JP",
                        "iso-2022-jp",
                        "65001",
                        "utf-8",
                        "ja",
                        "ja-JP"});
            table3.AddRow(new string[] {
                        "/sitecore/system/Languages/uk-UA",
                        "koi8-r",
                        "65001",
                        "utf-8",
                        "ua",
                        "uk-UA"});
#line 35
 testRunner.Given("Following additional languages were defined in Sitecore", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table4.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "SupportedLanguages",
                        "en;da;ar-BH;ja-JP;uk-UA"});
#line 43
 testRunner.When("The following languages have been selected", ((string)(null)), table4, "When ");
#line 51
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("User clicks Globe icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item name"});
            table5.AddRow(new string[] {
                        "English"});
            table5.AddRow(new string[] {
                        "dansk"});
            table5.AddRow(new string[] {
                        "العربية (البحرين)"});
            table5.AddRow(new string[] {
                        "日本語 (日本)"});
            table5.AddRow(new string[] {
                        "українська (Україна)"});
#line 53
 testRunner.Then("Following items available in the list", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Define Languages by Site")]
        [Xunit.TraitAttribute("Description", "Define Languages by Site_UC4_Switch between languages on the site")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void DefineLanguagesBySite_UC4_SwitchBetweenLanguagesOnTheSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define Languages by Site_UC4_Switch between languages on the site", new string[] {
                        "Ready"});
#line 63
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table6.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "SupportedLanguages",
                        "en;da"});
#line 64
 testRunner.Given("The following languages have been selected", ((string)(null)), table6, "Given ");
#line 67
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.When("User clicks Globe icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.And("User selects DANSK from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.Then("Page URL ends on da/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DefineLanguagesBySiteFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DefineLanguagesBySiteFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
