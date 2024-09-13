# MunicipalityReportingApp

Municipality Engagement Application
Overview
This application enables citizens to report municipal issues, track their statuses, and receive notifications regarding local services. The app offers a user-friendly interface with multilingual options, the ability to attach files to reports, and a real-time tracking system. Built on ASP.NET, the application aims to improve communication and interaction between users and their local municipality.

Table of Contents

1. [System Requirements](system-requirements)
2. [Installation & Setup](installation-and-setup)
3. [Compiling the Application](compiling-the-application)
4. [Running the Application](running-the-application)
5. [User Guide](user-guide)
6. [Known Issues](known-issues)
7. [Contact Details](contact-details)




System Requirements
You will need the following to build and run the application:
- Visual Studio (version 2022)
- ASP.NET Framework (version 4.7.2 or later)
- .NET Core SDK
- Windows 10/11 operating system
- Optionally, access to SQL Server for database functionality

Installation & Setup
Step 1: Clone the Repository
Clone the project to your local machine using Git:

git clone https://github.com/ST10440982/MunicipalityReportingApp.git


Step 2: Install Necessary Software
Ensure that you have Visual Studio installed with the required ASP.NET components. You may need to install the following:

- ASP.NET and web development tools
- .NET desktop development
- .NET Core cross-platform development

These can be installed via the Visual Studio Installer.

Step 3: Open the Project in Visual Studio
After cloning the repository, open the project in Visual Studio by navigating to `File -> Open -> Project/Solution`, and select the `.sln` file.

Compiling the Application
Step 1: Restore NuGet Packages
Before compiling, make sure all required packages are installed. Visual Studio may prompt you to restore NuGet packages automatically. If it doesn’t, restore them manually by:

- Right-clicking the solution in the Solution Explorer.
- Selecting `Restore NuGet Packages`.

Step 2: Build the Solution
Once dependencies are restored, proceed with building the solution:

- Go to the Visual Studio toolbar and select `Build -> Build Solution`.
- Address any errors that may appear, such as missing dependencies or incorrect project configurations.

Running the Application
 Step 1: Run via Visual Studio
To run the application in development mode:

- Press `F5` or click the green "Run" button in the Visual Studio toolbar. This will launch the application in your default web browser.
- Visual Studio will use IIS Express or the configured development server to run the application.

Step 2: Access the Application
Once the app is running, open your browser and navigate to the provided local URL, typically:


http://localhost:5000/


User Guide
Home Screen
After launching, you will see the home screen with buttons for different features:

1. Report Issues: This feature allows users to report problems such as road repairs, streetlight failures, etc. You’ll be asked to provide:
   - Location of the issue.
   - Issue category (e.g., Infrastructure, Health, etc.).
   - Description of the problem.
   - Optionally, attach an image.

2. Track Issue Status: Users can check the status of reported issues, which will be categorized as:
   - Pending
   - In Progress
   - Resolved
3. Receive Notifications: Users receive updates about issue status or community updates (if integrated with a notification service such as AWS SNS).

Submitting an Issue
- Go to the Report Issues form.
- Complete the form with the required details, add any necessary attachments, and click Submit.
- The system will confirm the submission, and you’ll be redirected back to the home screen with a success message.

Checking Issue Status
- Select the Track Status option on the home page.
- A list of all your submitted issues and their current statuses will be shown.

Known Issues
- Multilingual Support: Limited language support is currently available; additional languages are under development.
- Mobile Responsiveness: Some layout issues may occur on mobile devices.

Contact Details
For any issues or suggestions, please contact us:
- Email: ST10440982@rcconnect.edu.za
- Phone: +27 644700597
- GitHub: https://github.com/ST10440982/MunicipalityReportingApp.git
