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
namespace Dev2.Activities.Specs.Toolbox.Data.AssignObject
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AssignObjectFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AssignObject.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AssignObject", "In order to use json \r\nAs a Warewolf user\r\nI want a tool that assigns data to jso" +
                    "n objects", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "AssignObject")))
            {
                Dev2.Activities.Specs.Toolbox.Data.AssignObject.AssignObjectFeature.FeatureSetup(null);
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign a value to a json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAValueToAJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign a value to a json object", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.Name]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("the json object \"[[Person.Name]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table1.AddRow(new string[] {
                        "1",
                        "[[Person.Name]] =",
                        "Bob"});
#line 11
 testRunner.And("the debug inputs as", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table2.AddRow(new string[] {
                        "1",
                        "[[Person.Name]] = Bob"});
#line 14
 testRunner.And("the debug output as", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign values to json objects")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignValuesToJsonObjects()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign values to json objects", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.FirstName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.And("I assign the value \"Smith\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("the json object \"[[Person.FirstName]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.And("the json object \"[[Person.Surname]]\" equals \"Smith\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table3.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] =",
                        "Bob"});
            table3.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] =",
                        "Smith"});
#line 25
 testRunner.And("the debug inputs as", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table4.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] = Bob"});
            table4.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] = Smith"});
#line 29
 testRunner.And("the debug output as", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign values with different types to json objects")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignValuesWithDifferentTypesToJsonObjects()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign values with different types to json objects", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.FirstName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.And("I assign the value \"Smith\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("I assign the value \"21\" to a json object \"[[Person.Age]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("the json object \"[[Person.FirstName]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("the json object \"[[Person.Surname]]\" equals \"Smith\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("the json object \"[[Person.Age]]\" equals \"21\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table5.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] =",
                        "Bob"});
            table5.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] =",
                        "Smith"});
            table5.AddRow(new string[] {
                        "3",
                        "[[Person.Age]] =",
                        "21"});
#line 43
 testRunner.And("the debug inputs as", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table6.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] = Bob"});
            table6.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] = Smith"});
            table6.AddRow(new string[] {
                        "3",
                        "[[Person.Age]] = 21"});
#line 48
 testRunner.And("the debug output as", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign a json object value to a json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAJsonObjectValueToAJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign a json object value to a json object", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.FirstName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.And("I assign the value \"[[Person.FirstName]]\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("the json object \"[[Person.FirstName]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.And("the json object \"[[Person.Surname]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table7.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] =",
                        "Bob"});
            table7.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] =",
                        "Bob"});
#line 62
 testRunner.And("the debug inputs as", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table8.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] = Bob"});
            table8.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] = Bob"});
#line 66
 testRunner.And("the debug output as", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign a json object value to a json object overwriting the existing value")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAJsonObjectValueToAJsonObjectOverwritingTheExistingValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign a json object value to a json object overwriting the existing value", ((string[])(null)));
#line 72
this.ScenarioSetup(scenarioInfo);
#line 73
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.FirstName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
 testRunner.And("I assign the value \"Smith\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("I assign the value \"[[Person.FirstName]]\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("the json object \"[[Person.FirstName]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.And("the json object \"[[Person.Surname]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table9.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] =",
                        "Bob"});
            table9.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] =",
                        "Smith"});
            table9.AddRow(new string[] {
                        "3",
                        "[[Person.Surname]] = Smith",
                        "[[Person.FirstName]] = Bob"});
#line 80
 testRunner.And("the debug inputs as", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table10.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] = Bob"});
            table10.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] = Smith"});
            table10.AddRow(new string[] {
                        "3",
                        "[[Person.FirstName]] = Bob"});
#line 85
 testRunner.And("the debug output as", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign a value to an invalid json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAValueToAnInvalidJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign a value to an invalid json object", ((string[])(null)));
#line 91
this.ScenarioSetup(scenarioInfo);
#line 92
 testRunner.Given("I assign the value \"[[Person.Score]]\" to a json object \"[[Person..Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 93
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.And("the execution has \"parse error\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign an invalid value to a json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAnInvalidValueToAJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign an invalid value to a json object", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line 98
 testRunner.Given("I assign the value \"[[Person..Score]]\" to a json object \"[[Person..Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 99
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.And("the execution has \"parse error\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign a value with plus in it to a json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAValueWithPlusInItToAJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign a value with plus in it to a json object", ((string[])(null)));
#line 103
this.ScenarioSetup(scenarioInfo);
#line 104
 testRunner.Given("I assign the value \"+10\" to a json object \"[[Person.Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 105
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.Then("the value of \"[[Person.Score]]\" equals +10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table11.AddRow(new string[] {
                        "1",
                        "[[Person.Score]] =",
                        "+10"});
#line 108
 testRunner.And("the debug inputs as", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table12.AddRow(new string[] {
                        "1",
                        "[[Person.Score]] = +10"});
#line 111
 testRunner.And("the debug output as", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign a value with minus in it to a json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAValueWithMinusInItToAJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign a value with minus in it to a json object", ((string[])(null)));
#line 115
this.ScenarioSetup(scenarioInfo);
#line 116
 testRunner.Given("I assign the value \"-10\" to a json object \"[[Person.Score]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 117
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.Then("the value of \"[[Person.Score]]\" equals -10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table13.AddRow(new string[] {
                        "1",
                        "[[Person.Score]] =",
                        "-10"});
#line 120
 testRunner.And("the debug inputs as", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table14.AddRow(new string[] {
                        "1",
                        "[[Person.Score]] = -10"});
#line 123
 testRunner.And("the debug output as", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign a populated json object to a new json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAPopulatedJsonObjectToANewJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign a populated json object to a new json object", ((string[])(null)));
#line 129
this.ScenarioSetup(scenarioInfo);
#line 130
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.FirstName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 131
 testRunner.And("I assign the value \"Smith\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("I assign the json object \"[[Person]]\" to a json object \"[[Staff]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.Then("the json object \"[[Staff.FirstName]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.Then("the json object \"[[Staff.Surname]]\" equals \"Smith\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table15.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] =",
                        "Bob"});
            table15.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] =",
                        "Smith"});
            table15.AddRow(new string[] {
                        "3",
                        "[[Person]] =",
                        "[[Staff]]"});
#line 137
 testRunner.And("the debug inputs as", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table16.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] = Bob"});
            table16.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] = Smith"});
            table16.AddRow(new string[] {
                        "3",
                        "[[Staff.FirstName]] = Bob"});
            table16.AddRow(new string[] {
                        "4",
                        "[[Staff.Surname]] = Smith"});
#line 142
 testRunner.And("the debug output as", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign a populated json object to a child of a new json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignAPopulatedJsonObjectToAChildOfANewJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign a populated json object to a child of a new json object", ((string[])(null)));
#line 151
this.ScenarioSetup(scenarioInfo);
#line 152
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.FirstName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 153
 testRunner.And("I assign the value \"Smith\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.And("I assign the json object \"[[Person]]\" to a json object \"[[Staff.Subordinate]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.When("the assign object tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.Then("the json object \"[[Staff.Subordinate.FirstName]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 157
 testRunner.Then("the json object \"[[Staff.Subordinate.Surname]]\" equals \"Smith\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table17.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] =",
                        "Bob"});
            table17.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] =",
                        "Smith"});
            table17.AddRow(new string[] {
                        "3",
                        "[[Person]] =",
                        "[[Staff.Subordinate]]"});
#line 159
 testRunner.And("the debug inputs as", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table18.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] = Bob"});
            table18.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] = Smith"});
            table18.AddRow(new string[] {
                        "3",
                        "[[Staff.Subordinate.FirstName]] = Bob"});
            table18.AddRow(new string[] {
                        "4",
                        "[[StaffSubordinate..Surname]] = Smith"});
#line 164
 testRunner.And("the debug output as", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign multiple json variables to a json object")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignMultipleJsonVariablesToAJsonObject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign multiple json variables to a json object", ((string[])(null)));
#line 172
this.ScenarioSetup(scenarioInfo);
#line 173
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.FirstName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 174
 testRunner.And("I assign the value \"Smith\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.And("I assign the value \"[[Person.FirstName]][[Person.Surname]]\" to a json object \"[[P" +
                    "erson.FullName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.When("the assign tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 177
 testRunner.Then("the json object \"[[Person.FirstName]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 178
 testRunner.And("the json object \"[[Person.Surname]]\" equals \"Smith\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.And("the value of \"[[Person.FullName]]\" equals BobSmith", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table19.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] =",
                        "Bob"});
            table19.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] =",
                        "Smith"});
            table19.AddRow(new string[] {
                        "3",
                        "[[Person.FullName]] =",
                        "[[Person.FirstName]][[Person.Surname]]"});
#line 181
 testRunner.And("the debug inputs as", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table20.AddRow(new string[] {
                        "1",
                        "[[Person.FirstPart]] = Bob"});
            table20.AddRow(new string[] {
                        "2",
                        "[[Person.SecondPart]] = Smith"});
            table20.AddRow(new string[] {
                        "3",
                        "[[Person.FullName]]  = BobSmith"});
#line 186
 testRunner.And("the debug output as", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Assign multiple json variables to a json object with a literal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AssignObject")]
        public virtual void AssignMultipleJsonVariablesToAJsonObjectWithALiteral()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assign multiple json variables to a json object with a literal", ((string[])(null)));
#line 193
this.ScenarioSetup(scenarioInfo);
#line 194
 testRunner.Given("I assign the value \"Bob\" to a json object \"[[Person.FirstName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 195
 testRunner.And("I assign the value \"Smith\" to a json object \"[[Person.Surname]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
 testRunner.And("I assign the value \"[[Person.FirstName]] the killa [[Person.Surname]]\" to a json " +
                    "object \"[[Person.FullName]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.When("the assign tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
 testRunner.Then("the json object \"[[Person.FirstName]]\" equals \"Bob\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
 testRunner.And("the json object \"[[Person.Surname]]\" equals \"Smith\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
 testRunner.And("the value of \"[[Person.FullName]]\" equals BobSmith", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        "Variable",
                        "New Value"});
            table21.AddRow(new string[] {
                        "1",
                        "[[Person.FirstName]] =",
                        "Bob"});
            table21.AddRow(new string[] {
                        "2",
                        "[[Person.Surname]] =",
                        "Smith"});
            table21.AddRow(new string[] {
                        "3",
                        "[[Person.FullName]] =",
                        "[[Person.FirstName]][[Person.Surname]]"});
#line 202
 testRunner.And("the debug inputs as", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "#",
                        ""});
            table22.AddRow(new string[] {
                        "1",
                        "[[Person.FirstPart]] = Bob"});
            table22.AddRow(new string[] {
                        "2",
                        "[[Person.SecondPart]] = Smith"});
            table22.AddRow(new string[] {
                        "3",
                        "[[Person.FullName]]  = BobSmith"});
#line 207
 testRunner.And("the debug output as", ((string)(null)), table22, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
