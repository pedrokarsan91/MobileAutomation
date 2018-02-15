Feature: Register
	As a user
	I want to register
	So that I can login across multiple platforms

Scenario: Register from onboarding
	Given I am on the onboarding screen
	When I register a new user with the following details
		| Email                    | Password    | FirstName | LastName | Gender | PostCode |
		| ami.patel@testuktv.co.uk | password123 | John      | Smith    | Male   | WD17 1JJ |
	Then I should be successfully signed in
