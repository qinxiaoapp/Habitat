﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Habitat.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class LoginFeature : Xunit.IUseFixture<LoginFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        public LoginFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login", "\nIn order to access secure pages\nAs a website visitor\nI want to be able to log in" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void SetFixture(LoginFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login_UC1_Open Login form")]
        public virtual void Accounts_Login_UC1_OpenLoginForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login_UC1_Open Login form", new string[] {
                        "NeedImplementation"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("User selects Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("Login title presents on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table1.AddRow(new string[] {
                        "E-mail"});
            table1.AddRow(new string[] {
                        "Password"});
#line 13
 testRunner.And("Following fields present on Login form", ((string)(null)), table1, "And ");
#line 17
 testRunner.And("Login button presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("Cancel button presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Aссounts_Login_UC2_Check required fields")]
        public virtual void Aссounts_Login_UC2_CheckRequiredFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aссounts_Login_UC2_Check required fields", new string[] {
                        "NeedImplementation"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("Actor selects Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table2.AddRow(new string[] {
                        "",
                        ""});
#line 26
 testRunner.And("Actor enters data in to the following login fields", ((string)(null)), table2, "And ");
#line 29
 testRunner.When("User clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Required fields error message"});
            table3.AddRow(new string[] {
                        ""});
#line 30
 testRunner.Then("System shows following message for the required fields", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login_UC3_Enter correct Username and Password")]
        public virtual void Accounts_Login_UC3_EnterCorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login_UC3_Enter correct Username and Password", new string[] {
                        "NeedImplementation"});
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table4.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 37
 testRunner.Given("User is registered in Habitat", ((string)(null)), table4, "Given ");
#line 40
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("Actor selects Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table5.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 43
 testRunner.When("Actor entered following data into fields", ((string)(null)), table5, "When ");
#line 46
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table6.AddRow(new string[] {
                        "Login"});
            table6.AddRow(new string[] {
                        "Register"});
#line 47
 testRunner.Then("Following buttons is no longer present under User drop-drop down menu", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table7.AddRow(new string[] {
                        "Logout"});
#line 51
 testRunner.And("Following buttons present under User drop-drop down menu", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login_UC4_Enter correct username and incorrect password")]
        public virtual void Accounts_Login_UC4_EnterCorrectUsernameAndIncorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login_UC4_Enter correct username and incorrect password", new string[] {
                        "NeedImplementation"});
#line 57
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table8.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 58
 testRunner.Given("User is registered in Habitat", ((string)(null)), table8, "Given ");
#line 61
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("Actor selects Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table9.AddRow(new string[] {
                        "kov@sitecore.net",
                        "m"});
#line 64
 testRunner.When("Actor entered following data into fields", ((string)(null)), table9, "When ");
#line 67
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table10.AddRow(new string[] {
                        ""});
#line 68
 testRunner.Then("System shows following message for the Login form", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login_UC5_Enter incorrect username and correct password")]
        public virtual void Accounts_Login_UC5_EnterIncorrectUsernameAndCorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login_UC5_Enter incorrect username and correct password", new string[] {
                        "NeedImplementation"});
#line 74
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table11.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 75
    testRunner.Given("User is registered in Habitat", ((string)(null)), table11, "Given ");
#line 78
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("Actor selects Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table12.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k"});
#line 81
 testRunner.When("Actor entered following data into fields", ((string)(null)), table12, "When ");
#line 84
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table13.AddRow(new string[] {
                        ""});
#line 85
 testRunner.Then("System shows following message for the Login form", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login_UC6_Enter incorrect username and password")]
        public virtual void Accounts_Login_UC6_EnterIncorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login_UC6_Enter incorrect username and password", new string[] {
                        "NeedImplementation"});
#line 91
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table14.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 92
    testRunner.Given("User is registered in Habitat", ((string)(null)), table14, "Given ");
#line 95
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("Actor selects Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table15.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k1"});
#line 98
 testRunner.When("Actor entered following data into fields", ((string)(null)), table15, "When ");
#line 101
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table16.AddRow(new string[] {
                        ""});
#line 102
 testRunner.Then("System shows following message for the Login form", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login_UC7_Login with username and password of recently removed user")]
        public virtual void Accounts_Login_UC7_LoginWithUsernameAndPasswordOfRecentlyRemovedUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login_UC7_Login with username and password of recently removed user", new string[] {
                        "NeedImplementation"});
#line 108
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table17.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 109
    testRunner.Given("User is recently deleted from Habitat", ((string)(null)), table17, "Given ");
#line 112
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("Actor selects Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table18.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 114
 testRunner.When("Actor entered following data into fields", ((string)(null)), table18, "When ");
#line 117
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table19.AddRow(new string[] {
                        ""});
#line 118
 testRunner.Then("System shows following message for the Login form", ((string)(null)), table19, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login_UC8_Click Cancel button on login form")]
        public virtual void Accounts_Login_UC8_ClickCancelButtonOnLoginForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login_UC8_Click Cancel button on login form", new string[] {
                        "NeedImplementation"});
#line 123
this.ScenarioSetup(scenarioInfo);
#line 124
    testRunner.Given("Login form is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table20.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 125
 testRunner.When("Actor enters following data into fields", ((string)(null)), table20, "When ");
#line 128
 testRunner.And("Actor clicks Cancel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And("Actor selects Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table21.AddRow(new string[] {
                        "",
                        ""});
#line 131
 testRunner.Then("Actor presented with following data in fields", ((string)(null)), table21, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                LoginFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                LoginFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
