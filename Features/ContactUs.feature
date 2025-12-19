Feature: ContactUs

Fill the contactus form with valid credentials

Background: 
 Given User launches the website "https://webdriveruniversity.com/"


@tag1
Scenario: Enter a valid credentials into contactus form
    When user selects the "CONTACT US" header
	And user enters the details in contact-us form
	    | First Name | Last Name   | Email Address        | Comments |
	    | Surendra   | Sanipineedi | surendra@example.com | Good     |
	And user click on the "Submit" Button
	Then the user verifies the confirmation message "Thank You for your Message!"
