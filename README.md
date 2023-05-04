# Example of DevOps processes for articles for dev.bg

---

## Continuous Integrations (CI) 👷‍

| Product | Build Status | Workflow |
|--- | --- | --- |
| [Blazor WebAssembly .NET 7](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0#blazor-webassembly) | [![Continuous Integration - .Net](https://github.com/Magik3a/dev.bg/actions/workflows/continuous-integration-blazorapp1.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/continuous-integration-blazorapp1.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/continuous-integration-blazorapp1.yml) |
| [Azure Functions .NET 7](https://learn.microsoft.com/en-us/azure/azure-functions/functions-overview) |  |

> Note: Azure Functions only supports .NET 7 in the isolated process execution model


---

## Continuous Delivery (CD) 👩‍🚀

| Test Sites | URL | Deploy Status | Workflow |
|--- | --- | --- | --- |
| [Azure Static App](https://azure.microsoft.com/en-us/products/app-service/static) | [Check Here](https://polite-hill-06a5a4f03.3.azurestaticapps.net/) | [![Build and Deploy - Azure Static Web Apps CI/CD](https://github.com/Magik3a/dev.bg/actions/workflows/azure-static-web-apps-polite-hill-06a5a4f03.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/azure-static-web-apps-polite-hill-06a5a4f03.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/azure-static-web-apps-polite-hill-06a5a4f03.yml) | 
| [GitHub Pages](https://pages.github.com/) | https://magik3a.github.io/dev.bg/ | [![Build and Deploy - GitHub Pages CI/CD](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-blazorapp1.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-blazorapp1.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/gh-pages-blazorapp1.yml) |

---

## Continuous testing (CT) 🕵️‍

| Automation Tool | Tests Status | Workflow |
|--- | --- | --- |
| [Selenium](https://www.selenium.dev/) | [![Automation Tests - .NET Selenium](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-selenium-tests.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-selenium-tests.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/gh-pages-selenium-tests.yml) |
| [Unit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)  | [![Automation Tests - .NET Unit testing](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-unit-tests.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-unit-tests.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/gh-pages-unit-tests.yml) | 

---

## Continuous Security (CS) 👮‍

| Security Tool | Security Scan Status | Workflow |
|--- | --- | --- |
| [CodeQL](https://codeql.github.com/) | [![Security Scan - CodeQL GitHub](https://github.com/Magik3a/dev.bg/actions/workflows/codeql.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/codeql.yml) |  [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/codeql.yml) |
| [OWASP ZAP Scan](https://github.com/marketplace/actions/owasp-zap-full-scan) | [![Security Scan - OWASP ZAP Scan](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-security-scan.yml/badge.svg)](https://github.com/Magik3a/dev.bg/actions/workflows/gh-pages-security-scan.yml) | [Action.yml](https://github.com/Magik3a/dev.bg/blob/main/.github/workflows/gh-pages-security-scan.yml) |

---

![DevOps](https://github.com/Magik3a/dev.bg/blob/main/articles/dev-ops-diagram.png?raw=true)