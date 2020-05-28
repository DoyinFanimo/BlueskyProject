@blueskyform
Feature: BlueSkyCitadelForm
	In order to be a guru tester 
	I want to test the bluesky citadel form
	which has a lot of element that I will be automating in the future

@regression
Scenario: Valid Form Submission
	Given I navigate to the blueskycitadel website
		And I select automation testing form
	When I enter the Single Line Text
		And I select One in the Select box
		And I enter Email
		And i enter password "mysecurePassword"
		And I select the Multi-Select
		And I select the Radio List
		And I select the Checkbox List
		And I select the United Kingdom as Country
		And I select 12th of the current month
		And I click on the submit button
	Then the message "Your form has been successfully submitted" should be displayed


Scenario: Invalid Form Submission
	Given I navigate to the blueskycitadel website
		And I select automation testing form
	When I enter the Single Line Text
		And I select One in the Select box
		And I enter Email
		#And i enter password "mysecurePassword"
		And I select the Multi-Select
		And I select the Radio List
		And I select the Checkbox List
		And I select the United Kingdom as Country
		And I select 12th of the current month
		And I click on the submit button
	Then the error message "Please correct errors before submitting this form." 
		And the page url is "https://blueskycitadel.com/automation-testing-form/"