﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UniRitter.UniRitter2015.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Posts API")]
    public partial class PostsAPIFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostsAPI.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Posts API", "In order to allow the easy management of posts in my blog\r\nAs a blog owner\r\nI wan" +
                    "t to have an API that allows my apps to manage post information", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "body",
                        "title",
                        "authorId",
                        "tags"});
            table1.AddRow(new string[] {
                        "5e3e751a-490d-4c29-a93d-26dcfd2ce4a2",
                        "Hello World",
                        "Hello",
                        "8d0d477f-1378-4fc1-bb47-29eb3ea959e1",
                        "Hello,World"});
            table1.AddRow(new string[] {
                        "cb4e2dae-b29d-4484-8001-9322912a6376",
                        "Post 2",
                        "#2",
                        "1a5fd0be-d654-40ff-8190-ca59e3b52e76",
                        "Second,Post"});
            table1.AddRow(new string[] {
                        "4c134160-6575-4421-a7ab-1d75ca586774",
                        "Yet another",
                        "Another",
                        "8d0d477f-1378-4fc1-bb47-29eb3ea959e1",
                        "Post"});
            table1.AddRow(new string[] {
                        "c2423529-b1bd-4dfb-8a0b-5541f04e2ce7",
                        "Last post",
                        "Last",
                        "58b024e9-57dc-49e4-8fc9-2d4d82bf1670",
                        "Last,Post"});
#line 7
 testRunner.Given("an API populated with the following posts", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get all post entries")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void GetAllPostEntries()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all post entries", new string[] {
                        "integrated"});
#line 16
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 17
 testRunner.Given("the populated API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.When("I GET from the /posts API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("I get a list containing the populated resources", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get a specific person entry")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        [NUnit.Framework.TestCaseAttribute("5e3e751a-490d-4c29-a93d-26dcfd2ce4a2", null)]
        [NUnit.Framework.TestCaseAttribute("cb4e2dae-b29d-4484-8001-9322912a6376", null)]
        [NUnit.Framework.TestCaseAttribute("4c134160-6575-4421-a7ab-1d75ca586774", null)]
        [NUnit.Framework.TestCaseAttribute("c2423529-b1bd-4dfb-8a0b-5541f04e2ce7", null)]
        public virtual void GetASpecificPersonEntry(string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "integrated"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a specific person entry", @__tags);
#line 22
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 23
 testRunner.Given("the populated API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.When(string.Format("I GET from the /posts/{0} API endpoint", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the data matches that id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a post")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void AddAPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a post", new string[] {
                        "integrated"});
#line 34
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "body",
                        "title",
                        "authorId",
                        "tags"});
            table2.AddRow(new string[] {
                        "My new Post",
                        "New one",
                        "8d0d477f-1378-4fc1-bb47-29eb3ea959e1",
                        "New,Post"});
#line 35
 testRunner.Given("a person resource as described below:", ((string)(null)), table2, "Given ");
#line 38
 testRunner.When("I post it to the /posts API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("I receive a success (code 200) return message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("I receive the posted resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("the posted resource now has an ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("I can fetch it from the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Invalid post data on insertion")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        [NUnit.Framework.TestCaseAttribute("missing body", "", ".*body.*", null)]
        [NUnit.Framework.TestCaseAttribute("title too long", "", ".*title.*", null)]
        public virtual void InvalidPostDataOnInsertion(string @case, string data, string messageRegex, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "integrated"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invalid post data on insertion", @__tags);
#line 45
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 46
 testRunner.Given(string.Format("a {0} resource", @case), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
 testRunner.When(string.Format("I post the following data to the /posts API endpoint: {0}", data), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("I receive an error (code 400) return message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And(string.Format("I receive a message that conforms {0}", messageRegex), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
