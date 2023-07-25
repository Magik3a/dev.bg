# Example of DevOps processes for articles for dev.bg

> DevOps is a set of practices that can help organizations improve the speed, efficiency, and reliability of software development and deployment. By adopting DevOps practices such as continuous integration, continuous delivery, infrastructure as code, and monitoring and logging, organizations can realize a number of benefits and stay competitive in today's fast-paced business environment.
---

## Continuous Integrations (CI) 👷‍

> Continuous Integration is a software development practice that involves regularly merging code changes from multiple developers into a shared repository. This ensures that all code changes are tested and integrated as soon as possible, reducing the risk of conflicts and errors in the final product.

| Product | Build Status | Workflow |
|--- | --- | --- |
| [Blazor WebAssembly .NET 7](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0#blazor-webassembly) | [![Continuous Integration - .Net](https://github.com/Magik3a/dev.bg/actions/workflows/continuous-integration-blazorapp1.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/continuous-integration-blazorapp1.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/continuous-integration-blazorapp1.yml) |
| [Azure Functions .NET 7](https://learn.microsoft.com/en-us/azure/azure-functions/functions-overview) |  |

> Note: Azure Functions only supports .NET 7 in the isolated process execution model


---

## Continuous Delivery (CD) 👩‍🚀

> Continuous Delivery is a software development practice that involves automating the process of deploying code changes to production. This includes building, testing, and deploying code changes automatically, reducing the time and effort required for each deployment.

| Test Sites | URL | Deploy Status | Workflow |
|--- | --- | --- | --- |
| [BlazorApp1 - Docker](https://github.com/Magik3a?tab=packages&repo_name=dev.bg) | https://localhost:7018 | [![Build BlazorApp1 - Docker](https://github.com/Magik3a/dev.bg/actions/workflows/blazorapp1-docker-github.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/blazorapp1-docker-github.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/actions/workflows/blazorapp1-docker-github.yml) |
| [Azure Static App](https://azure.microsoft.com/en-us/products/app-service/static) | [Check Here](https://polite-hill-06a5a4f03.3.azurestaticapps.net/) | [![Build and Deploy - Azure Static Web Apps CI/CD](https://github.com/Magik3a/dev.bg/actions/workflows/azure-static-web-apps-polite-hill-06a5a4f03.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/azure-static-web-apps-polite-hill-06a5a4f03.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/azure-static-web-apps-polite-hill-06a5a4f03.yml) | 
| [GitHub Pages](https://pages.github.com/) | https://magik3a.github.io/dev.bg/ | [![Build and Deploy - GitHub Pages CI/CD](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-blazorapp1.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-blazorapp1.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/gh-pages-blazorapp1.yml) |

---

## Continuous testing (CT) 🕵️‍

> Continuous Testing (CT) is a software testing practice that involves running automated tests on code changes throughout the development process, from code commit to production deployment. The goal of CT is to provide quick feedback on the quality of code changes, enabling developers to identify and fix issues early and often. By integrating testing into the development process, CT helps to ensure that code changes are thoroughly tested and validated, leading to more reliable and higher-quality software.

| Automation Tool | Tests Status | Workflow |
|--- | --- | --- |
| [Selenium](https://www.selenium.dev/) | [![Automation Tests - .NET Selenium](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-selenium-tests.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-selenium-tests.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/gh-pages-selenium-tests.yml) |
| [Unit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)  | [![Automation Tests - .NET Unit testing](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-unit-tests.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-unit-tests.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/gh-pages-unit-tests.yml) | 

---

## Continuous Security (CS) 👮‍

> Continuous Security (CS) is a software development practice that involves integrating security into every stage of the development process, from design to deployment. The goal of CS is to identify and mitigate security risks as early as possible, rather than waiting until later stages of development or after deployment. By integrating security into every stage of development, CS helps to ensure that security is a priority and that applications are more secure and less vulnerable to attacks.

| Security Tool | Security Scan Status | Workflow |
|--- | --- | --- |
| [CodeQL](https://codeql.github.com/) | [![Security Scan - CodeQL GitHub](https://github.com/Magik3a/dev.bg/actions/workflows/codeql.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/codeql.yml) |  [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/codeql.yml) |
| [OWASP ZAP Scan](https://github.com/marketplace/actions/owasp-zap-full-scan) | [![Security Scan - OWASP ZAP Scan](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-security-scan.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-security-scan.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/gh-pages-security-scan.yml) |

---

![DevOps](https://github.com/Magik3a/dev.bg/blob/main/articles/dev-ops-diagram.png?raw=true)
