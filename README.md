# Selenium Testing Project

This repository contains automated tests for a web application using **Selenium WebDriver** in C#. The tests cover a variety of functionalities such as user login, role management, employee management, and more.

## Features

- **Login Testing**: Verify user authentication for different roles.
- **Role Management**: Change user roles dynamically.
- **Employee Management**:
  - Delete employees by row.
  - Edit employee details.
  - Search employees by name.
- **Test Automation**: Utilize NUnit for organizing and running test cases.

## Technologies Used

- **Selenium WebDriver**
- **C#**
- **NUnit**
- **ChromeDriver**

## Project Structure

```
SeleniumTestingWebsiteEA/
├── EmployeePage/
├── LoginPage/
├── UserPage/
├── TestTasks.cs
├── UserManage.cs
└── ... (other supporting files)
```

## Setup and Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/IlhanBasic/Selenium-Testing-Practice.git
   ```

2. Open the project in your IDE (e.g., Visual Studio).

3. Install dependencies:
   - Add the Selenium WebDriver NuGet package:
     ```bash
     Install-Package Selenium.WebDriver
     ```
   - Add NUnit NuGet package:
     ```bash
     Install-Package NUnit
     ```
   - Add ChromeDriver NuGet package:
     ```bash
     Install-Package Selenium.WebDriver.ChromeDriver
     ```

4. Run the tests using your test runner (e.g., Test Explorer in Visual Studio).

## How to Use

1. Ensure that the web application under test is running locally or is accessible.

2. Modify the `Setup` method in `TestTasks.cs` to point to the correct URL:
   ```csharp
   driver.Navigate().GoToUrl("http://eaapp.somee.com/");
   ```

3. Run the desired test cases from the test suite.

## Sample Test Case

Here is an example of how a test case is structured:

```csharp
[Test]
public void ChangeRoleToUser()
{
    LoginManage lm = new LoginManage(driver);
    lm.GoToLoginPage();
    lm.LoginUser("admin", "password");
    UserManage um = new UserManage(driver);
    um.ChangeUserRoleByRowNumber(3, "Administrator");
}
```

## Troubleshooting

- **Element Not Found**: If you encounter a `NoSuchElementException`, verify the XPath/CSS selectors and ensure the page elements are correctly loaded.
- **Driver Issues**: Ensure that the ChromeDriver version matches your browser version.
- **Timeouts**: Use explicit waits to handle dynamic content.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch.
3. Make your changes and commit them.
4. Push to your fork and submit a pull request.


Feel free to report issues or suggest improvements in the [issues section](https://github.com/IlhanBasic/Selenium-Testing-Practice/issues).

Happy testing! 🚀
