# TDDRedGreenPurple

An example project of how the Red Green Purple pattern works on Test Driven Development.

This repository demonstrates TDD concepts following the Red-Green-Purple workflow using .NET 10 (C# 14) and Visual Studio 2026.  
It serves as an educational resource for anyone looking to learn TDD with practical steps and examples.

---

## Project Details

- **Framework:** .NET 10  
- **Language:** C# 14  
- **IDE:** Visual Studio 2026  
- **Languages:** CSS, HTML, C# (see [language composition](#language-composition) below)

---

## What is the Red-Green-Purple Pattern in TDD?

- **Red:** Write a failing test that defines a new function or improvement.
- **Green:** Write just enough code to make the test pass.
- **Purple (Refactor):** Clean up the code, remove duplication, and improve structure while keeping all tests passing.

---

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/)
- [Visual Studio 2026](https://visualstudio.microsoft.com/)
- Git

### Setup

1. **Clone the repo:**
    ```sh
    git clone https://github.com/adintelti/TDDRedGreenPurple.git
    cd TDDRedGreenPurple
    ```

2. **Open the Solution:**  
   Open the `.sln` file with Visual Studio 2026.

3. **Restore and Build:**  
   Restore NuGet packages and build the solution.

---

## Running Tests

- Run tests using Visual Studio's Test Explorer, or:
    ```sh
    dotnet test
    ```

---

## Generating a Code Coverage Report

### Method 1: Using ReportGenerator with Coverlet

#### 1. Install dependencies

- **Install Coverlet and ReportGenerator via NuGet:**
    - Right-click your test project in Visual Studio and choose **Manage NuGet Packages**.
    - Install:
        - `coverlet.collector`
        - `ReportGenerator`

Or with CLI:

```sh
dotnet add <YourTestProject> package coverlet.collector
dotnet add <YourTestProject> package ReportGenerator
```

Or to install the ReportGenerator global tool:

```sh
dotnet tool install --global dotnet-reportgenerator-globaltool
```

#### 2. Collect coverage when running tests

```sh
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
```

#### 3. Generate the coverage report

```sh
reportgenerator "-reports:./<YourTestProject>/coverage.cobertura.xml" "-targetdir:./<YourTestProject>/coverage-report" -reporttypes:Html
```
Replace `<YourTestProject>` with the name of your test project folder.

#### 4. View the report

Open `./<YourTestProject>/coverage-report/index.html` in your web browser.

---

### Method 2: Using the "Run Coverlet Report" Extension for Visual Studio 2022+

1. **Install the Extension:**
    - Download and install [Run Coverlet Report](https://marketplace.visualstudio.com/items?itemName=AdrianDC.run-coverlet-report) from the Visual Studio Marketplace.

2. **Run Coverage via Extension:**
    - Right-click on your test project in Solution Explorer.
    - Select **Run Coverlet Report** from the context menu.

3. **Browse Results:**  
    - A detailed code coverage report will be generated and shown in a browser window or tab inside Visual Studio.

---

## Language Composition

- **CSS:** 57.3%
- **HTML:** 40.3%
- **C#:** 2.4%

---

## Usage

Review the code, commit history, and tests to follow the Red-Green-Purple TDD cycle in practice.

---

## Contributing

Contributions are welcome!  
Open issues or pull requests to improve examples or add TDD exercises.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## Author

- [adintelti](https://github.com/adintelti)

---
