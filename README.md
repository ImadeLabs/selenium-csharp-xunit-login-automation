# Selenium C# xUnit Login Automation

A simple QA automation project built with **C#**, **Selenium WebDriver**, and **xUnit** using the **Page Object Model (POM)** design pattern.

## Project Overview

This project automates login testing on a sample web application and covers positive and negative login scenarios using xUnit.

## Tech Stack

- C#
- .NET
- Selenium WebDriver
- xUnit
- ChromeDriver

## Test Cases Covered

- Valid login with correct credentials
- Invalid login with wrong credentials
- Empty login submission

## Project Structure

```text
selenium-csharp-xunit-login-automation/
├── Pages/
│   └── LoginPage.cs
├── Tests/
│   └── LoginTests.cs
├── Utilities/
│   └── DriverFactory.cs
├── Screenshots/
├── README.md
├── .gitignore
└── selenium-csharp-xunit-login-automation.csproj