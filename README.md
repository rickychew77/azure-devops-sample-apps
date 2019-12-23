# Sample Apps for Azure DevOps

This repo contains sample application source code of various platforms, where each comes with a unit test and [Azure Pipeline YAML](https://docs.microsoft.com/en-us/azure/devops/pipelines/yaml-schema?view=azure-devops&tabs=schema).

|Application Framework|Unit Test Framework|Sample Unit Test|
|---|---|---|
|.NET Framework|[NUnit](https://nunit.org/)|[./dotnetframework/BankTest/BankAccountTest.cs](./dotnetframework/BankTest/BankAccountTest.cs)|
|.NET Core|[NUnit](https://nunit.org/)|[./dotnetcore-nunit/PrimeService.Tests/UnitTest1.cs](./dotnetcore-nunit/PrimeService.Tests/UnitTest1.cs)|
|.NET Core|[xUnit](https://xunit.net/)|[./dotnetcore-xunit/PrimeService.Tests/PrimeService_IsPrimeShould.cs](./dotnetcore-xunit/PrimeService.Tests/PrimeService_IsPrimeShould.cs)|
|<span>ASP.</span>NET Core|[NUnit](https://nunit.org/)|[./asp-dotnetcore/asp-dotnetcore-nunit/UnitTest1.cs](./asp-dotnetcore/asp-dotnetcore-nunit/UnitTest1.cs)|
|Ionic|[Karma](https://karma-runner.github.io/latest/index.html) (test runner) and [Jasmine](https://jasmine.github.io/) (library)|[./ionic/src/app/tab1/tab1.page.spec.ts](./ionic/src/app/tab1/tab1.page.spec.ts)|
|Node.js|[Mocha](https://mochajs.org/) (test runner) and [Chai](https://www.chaijs.com/) (library)|[./nodejs/test/test.js](./nodejs/test/test.js)|

## Other References

|Unit Test Framework|Description|Sample Unit Test|
|---|---|---|
|[NUnit](https://nunit.org/)||https://github.com/nunit/nunit-csharp-samples|
|[xUnit](https://xunit.net/)||https://github.com/xunit/samples.xunit|
|[Jest](https://jestjs.io/)|Typically used for ReactJS and React Native|https://github.com/facebook/jest/tree/master/examples|