Feature: DataDrivenWithExamples
In order not to repeat my dsts or to be able to update my data
	I want to add my data to the feature file

Scenario Outline: Validate Form Examples
	Given I navigate to site "https://www.giftrete.com/"
	And I navigate to site "https://blueskycitadel.com/automation-testing-form/"
	When I enter email "<Email>"
	And i enter password "<Password>"
	#And i click on submit button
	#Then the form is submitted

Examples: 
| Email           | Password         |
| mytest@test.com | mysecurePassword |
| mytest@test.com | mysecurePassword2|