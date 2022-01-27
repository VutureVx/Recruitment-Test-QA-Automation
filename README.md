# Vuture

## Quality Automation Recruitment Test (Selenium/C#)

The purpose of this test is to be used to assess the technical capabilities of candidates during the hiring for a position at Vuture.
Please read all of the instructions carefully.

### Purpose of this test

* We are looking to see if you can write code that is clean and reusable
* Do you understand best practices of UI automation?
* Most of the role will be implementing UI automation tests
* The test is an insight into how you would develop and improve an existing code base

### Background

Vuture integrates with leading CRMs to automatically extract and update data. Our system was originally built as an easy to use CMS. We utilise the CRM integrations to be able to build email campaign and send emails from templates.

### Instructions

* Throughout the code there are partially completed functionality from the Page Objects to the Step Definitions and finally the Feature files
* We would like you to complete this functionality automating the tasks outlined in this document
* It is important to use the foundations which have already be created so make sure to use the Step Definitions and Driver classes
* We will provide you the details to log in to the system during the interview

### Important

* Use DriverFactory's Driver to interact with the Chrome Driver
* Use and expand the Page Objects, potentially add new ones if you feel these are needed

## Getting started

* Fork or clone the repository, we would love to see your commit history
* Use a code editor of your choice compatible with .NET Framework, we recommend Visual Studio Community 2022
* This test uses .NET Framework v4.6.1, make sure you have the necessary SDK installed
* Install SpecFlow extension. If you are using Visual Studio, this can be done via Extensions > Manage Extensions > Search for SpecFlow. Once installed you will need to restart Visual Studio.

### Tasks

#### Task One - Login

* Navigate to the URL: "https://demo.vuturevx.com/mvc/login/"
* Log in using the details we provide you during the interview
* Assert against an element on the home page to confirm that you have been logged in
* Assert against the URL to ensure you have arrived at "https://demo.vuturevx.com/home/home.aspx"

#### Task Two - Create Email Campaign

* Click on icon or the hyperlink which allows you to create a new email campaign
* Name the campaign on the left frame, you can pick a name of your choice
* Click on the create button, for the first email template in the list.
* Assert and check if the correct name of the container and campaign is displayed at the top of the window.

#### Task Three - Compose Email

* On the right-hand frame of the window name the email, again pick a name of your choice
* Click on invitation template - This should create a new email on the left-hand frame
* On the left-hand frame, use the site actions underneath your newly created email to publish the email. To do this, click on 'publish email' and the 'publish now'
* Assert on the page you have just published to ensure that the status of the email is 'Live'

#### Task Four - Logout

* Click on the logout button on the top on the browser window.
* Assert that URL is "https://demo.vuturevx.com/login/login.aspx"
* Assert that the login boxes for the username and password are visible.

## Think you are finished?

* Have you automated all of the tasks?
* Have you verified that all tests are passing?
* Take another look at your code structure, does it follow good coding standards?

## Let us know you are finished (If you are completing this as a take home test)

* You will need to share the repository with us, please share with us a link to your repository
* We will review your code and provide feedback via TalentPoint
* If you have any questions throughout, please feel free to get in contact with us [kalina.trifunova@vutu.re](mailto:kalina.trifunova@vutu.re) [charly.webster@vutu.re](mailto:charly.webster@vutu.re)
