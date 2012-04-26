﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.AllFeaturesEndToEnd
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceHappyPathFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroupRegistrationEndToEndHappy.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registrant workflow for registering a group of Attendees for a conference (happy " +
                    "path)", "In order to register for conference a group of Attendees\r\nAs a Registrant\r\nI want" +
                    " to be able to select Order Items from one or many available Order Items and mak" +
                    "e a Reservation", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Registrant workflow for registering a group of Attendees for a conference (happy " +
                            "path)")))
            {
                Conference.Specflow.Features.Registration.AllFeaturesEndToEnd.RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceHappyPathFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
            table1.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "$500",
                        "100"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "100"});
#line 8
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference GroupRe" +
                    "gE2Ehappy", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "3"});
            table2.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 13
 testRunner.And("the selected Order Items", ((string)(null)), table2);
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("All the Order Items are available and all get selected, then all get reserved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (happy " +
            "path)")]
        public virtual void AllTheOrderItemsAreAvailableAndAllGetSelectedThenAllGetReserved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are available and all get selected, then all get reserved", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 23
 testRunner.When("the Registrant proceed to make the Reservation");
#line 24
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table3.AddRow(new string[] {
                        "General admission"});
            table3.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young"});
            table3.AddRow(new string[] {
                        "Additional cocktail party"});
#line 25
 testRunner.And("these Order Items should be reserved", ((string)(null)), table3);
#line 30
 testRunner.And("the total should read $1197");
#line 31
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Checkout:Registrant Details")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (happy " +
            "path)")]
        public virtual void CheckoutRegistrantDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Registrant Details", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 34
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address"});
            table4.AddRow(new string[] {
                        "William",
                        "Smith",
                        "William@Smith.com"});
#line 35
 testRunner.And("the Registrant enter these details", ((string)(null)), table4);
#line 38
 testRunner.When("the Registrant proceed to Checkout:Payment");
#line 39
 testRunner.Then("the payment options should be offered for a total of $1197");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Checkout:Payment and sucessfull Order completed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (happy " +
            "path)")]
        public virtual void CheckoutPaymentAndSucessfullOrderCompleted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Payment and sucessfull Order completed", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 42
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address"});
            table5.AddRow(new string[] {
                        "William",
                        "Smith",
                        "William@Smith.com"});
#line 43
 testRunner.And("the Registrant enter these details", ((string)(null)), table5);
#line 46
 testRunner.And("the Registrant proceed to Checkout:Payment");
#line 47
 testRunner.When("the Registrant proceed to confirm the payment");
#line 48
    testRunner.Then("the message \'You will receive a confirmation e-mail in a few minutes.\' will show " +
                    "up");
#line 49
 testRunner.And("the Order should be located from the Find Order page");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Allocate all purchased Seats for a group")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (happy " +
            "path)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void AllocateAllPurchasedSeatsForAGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allocate all purchased Seats for a group", new string[] {
                        "ignore"});
#line 54
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 55
testRunner.Given("the ConfirmSuccessfulRegistration");
#line 56
testRunner.And("the order access code is 6789");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table6.AddRow(new string[] {
                        "William",
                        "Smith",
                        "William@Smith.com",
                        "General admission"});
            table6.AddRow(new string[] {
                        "John",
                        "Doe",
                        "JohnDoe@live.com",
                        "General admission"});
            table6.AddRow(new string[] {
                        "Oliver",
                        "Smith",
                        "Oliver@Smith.com",
                        "Pre-con Workshop with Greg Young"});
            table6.AddRow(new string[] {
                        "Tim",
                        "Martin",
                        "Tim@Martin.com",
                        "Pre-con Workshop with Greg Young"});
            table6.AddRow(new string[] {
                        "Mani",
                        "Kris",
                        "Mani@Kris.com",
                        "Additional cocktail party"});
            table6.AddRow(new string[] {
                        "Jim",
                        "John",
                        "Jim@John.com",
                        "Additional cocktail party"});
#line 57
testRunner.And("the Registrant assign the group purchased Seats to attendees as following", ((string)(null)), table6);
#line 65
testRunner.Then("the Registrant should get a Seat Assignment confirmation");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Access code",
                        "email address",
                        "Seat type"});
            table7.AddRow(new string[] {
                        "6789-1",
                        "William@Smith.com",
                        "General admission"});
            table7.AddRow(new string[] {
                        "6789-2",
                        "JohnDoe@live.com",
                        "General admission"});
            table7.AddRow(new string[] {
                        "6789-3",
                        "Oliver@Smith.com",
                        "Pre-con Workshop with Greg Young"});
            table7.AddRow(new string[] {
                        "6789-4",
                        "Tim@Martin.com",
                        "Pre-con Workshop with Greg Young"});
            table7.AddRow(new string[] {
                        "6789-5",
                        "Mani@Kris.com",
                        "Additional cocktail party"});
            table7.AddRow(new string[] {
                        "6789-6",
                        "Jim@John.com",
                        "Additional cocktail party"});
#line 66
testRunner.And("the Attendees should get an email informing about the conference and the Seat Typ" +
                    "e with Seat Access Code", ((string)(null)), table7);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
