# CalculatorApp

A simple calculator web application built using ASP.NET Core MVC. This app allows users to perform basic arithmetic operations, including addition, subtraction, multiplication, and division, with error handling for invalid inputs.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)

## Features

- Basic arithmetic operations: addition, subtraction, multiplication, and division.
- Input validation to ensure both numbers are provided.
- Error handling for division by zero.
- Simple and intuitive UI using Razor Pages and client-side validation.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

- [Visual Studio 2019 or later](https://visualstudio.microsoft.com/downloads/)
- [.NET Core SDK 5.0 or later](https://dotnet.microsoft.com/download/dotnet)

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/CalculatorApp.git
Open the project:
Open CalculatorApp.sln in Visual Studio.
Restore NuGet Packages:
In Visual Studio, go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution and ensure all packages are installed.
Build the project:
In Visual Studio, right-click on the solution and select Build Solution.
Run the project:
Press F5 or select Debug > Start Without Debugging to launch the application.
Usage

Navigate to the calculator page in your browser (should open by default).
Enter the first number, second number, and select an operation (+, -, *, /).
Click on Calculate to see the result displayed on the page.
If there’s an error (like division by zero), an error message will be displayed.
Project Structure

The project follows the MVC (Model-View-Controller) design pattern:

CalculatorApp
├── Controllers
│   └── CalculatorController.cs       # Handles GET and POST requests for calculator operations
├── Models
│   └── CalculatorModel.cs            # Model class defining inputs, result, and error message
├── Views
│   └── Calculator
│       └── Index.cshtml              # Razor view for user interface
└── wwwroot
    └── css, js, lib                  # Static files and libraries
Testing

This project includes both unit testing and input validation testing:

Unit Tests: Located in a separate test project (if created).
Tests cover basic operations and error handling, like division by zero.
Run tests from Test Explorer in Visual Studio.
Manual Testing:
Verify each arithmetic operation.
Check validation for required fields and handling for invalid inputs.
Sample Unit Test
[Fact]
public void AdditionTest()
{
    var model = new CalculatorModel { Num1 = 5, Num2 = 3, Operation = "+" };
    var result = model.Num1 + model.Num2;
    Assert.Equal(8, result);
}
Contributing

Fork the repository.
Create a feature branch: git checkout -b feature-name.
Commit your changes: git commit -m 'Add some feature'.
Push to the branch: git push origin feature-name.
Submit a pull request.
License

This project is licensed under the MIT License - see the LICENSE file for details.

Enjoy using CalculatorApp! If you have any questions or feedback, feel free to open an issue or submit a pull request.
