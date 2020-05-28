Feature: DataDrivenWithFeature2
	In order not to repeat my dsts or to be able to update my data from feature file
	I want to add my data to the feature file

@mytag
Scenario: Validate Form Parameter 2
	Given I navigate to site "https://blueskycitadel.com/automation-testing-form/"
	When  I enter the Single Line Text "Doyin"
			And I select an option in the Select box "one" 
			And I enter email "mttest@test.com"
			And i enter password "mysecurePassword"
			And I select the Multi-Select "two", "Three"
			And I select in the Radio List "One"
			And I select the Checkbox List "One", "Two"
			And I select the Country "GB"
			And I select "12th" of the current month
			And i click on submit button
	Then the message "Your form has been successfully submitted" should be displayed

