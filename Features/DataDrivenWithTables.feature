Feature: DataDrivenWithTables
	In order not to repeat my dsts or to be able to update my data from feature file
	I want to add my data to the feature file

@mytag
Scenario: Validate Form Tables
	Given I navigate to site "https://blueskycitadel.com/automation-testing-form/"
	When I enter email and password 
	| Email           | Password         |
	| mttest@test.com | mysecurePassword |
	
