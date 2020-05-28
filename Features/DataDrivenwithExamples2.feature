Feature: DataDrivenWithExamples2
In order not to repeat my dsts or to be able to update my data
	I want to add my data to the feature file

Scenario Outline: Validate Form Examples 2
	Given I navigate to site "https://blueskycitadel.com/automation-testing-form/"
		
	When I enter the Single Line Text "<Text>"
		And I select an option in the Select box "<Option>"
		And I enter email "<Email>"
		And i enter password "<Password>"
	#And i click on submit button
	#Then the form is submitted

Examples: 
| Text   | Option | Email           | Password          |
| Doyin  | one    | mytest@test.com | mysecurePassword  |
| Fanimo | two    | mytest@test.com | mysecurePassword2 |
