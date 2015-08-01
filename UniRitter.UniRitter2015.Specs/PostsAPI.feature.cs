﻿namespace UniRitter.UniRitter2015.Specs
{
    using TechTalk.SpecFlow;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Posts API")]
    public partial class PostsAPIFeature
    {

        private static TechTalk.SpecFlow.ITestRunner testRunner;


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
            testRunner.Given("an API populated with the following posts", ((string)(null)), table1, "Given ");
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get all post entries")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void GetAllPostEntries()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all post entries", new string[] {
                        "integrated"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Given("the populated API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I GET from the /posts API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("I get a list containing the populated resources", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get a specific post entry")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        [NUnit.Framework.TestCaseAttribute("5e3e751a-490d-4c29-a93d-26dcfd2ce4a2", null)]
        [NUnit.Framework.TestCaseAttribute("cb4e2dae-b29d-4484-8001-9322912a6376", null)]
        [NUnit.Framework.TestCaseAttribute("4c134160-6575-4421-a7ab-1d75ca586774", null)]
        [NUnit.Framework.TestCaseAttribute("c2423529-b1bd-4dfb-8a0b-5541f04e2ce7", null)]
        public virtual void GetASpecificPostEntry(string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "integrated"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a specific post entry", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Given("the populated API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When(string.Format("I GET from the /posts/{0} API endpoint", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the data matches that id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a post")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void AddAPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a post", new string[] {
                        "integrated"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
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
            testRunner.Given("a post resource as described below:", ((string)(null)), table2, "Given ");
            testRunner.When("I post it to the /posts API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("I receive a success (code 200) return message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("I receive the posted resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("the posted resource now has an ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("I can fetch it from the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Invalid post data on insertion")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        [NUnit.Framework.TestCaseAttribute("missing body", "{}", ".*body.*", null)]
        [NUnit.Framework.TestCaseAttribute("title too long", "{}", ".*title.*", null)]
        public virtual void InvalidPostDataOnInsertion(string @case, string data, string messageRegex, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "integrated"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invalid post data on insertion", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Given(string.Format("a {0} resource", @case), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When(string.Format("I post the following data to the /posts API endpoint: {0}", data), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("I receive an error (code 400) return message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And(string.Format("I receive a message that conforms {0}", messageRegex), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a valid post")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void AddAValidPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a valid post", new string[] {
                        "integrated"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Given("a valid post resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("I post is to the /posts endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("I get a success (code 201) response code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("I receive the posted resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("the resource id is populated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid update")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void ValidUpdate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid update", new string[] {
                        "integrated"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Given("an existing person resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("a valid update message to that resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("I run a PUT command against the /people endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("I receive a success (code 200) status message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("I receive the updated resource in the body of the message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Invalid update")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void InvalidUpdate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invalid update", new string[] {
                        "integrated"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Given("an existing person resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("an invalid update message to that resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("I run a PUT command against the /people endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("I receive an error (code 400) status message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("I receive a list of validation errors in the body of the message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
    }
}
