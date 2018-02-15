Feature: Register
	As a user
	I want to register
	So that I can login across multiple platforms

Scenario: Register From Onboarding
	Given I am on the onboarding screen
		And I navigate to register
	When I register a new user with the following details
		| Email                    | Password    | FirstName | LastName | Gender | PostCode |
		| ami.patel@testuktv.co.uk | password123 | John      | Smith    | Male   | WD17 1JJ |
	Then I should be successfully signed in

Scenario: Register From Onboarding Sign In
	Given I am on the onboarding screen
		And I navigate to sign in 
		And I navigate to register now
	When I register a new user with the following details
		| Email                    | Password    | FirstName | LastName | Gender | PostCode |
		| ami.patel@testuktv.co.uk | password123 | John      | Smith    | Male   | WD17 1JJ |
	Then I should be successfully signed in

Scenario: Register From Home 
	Given I am on the onboarding screen
		And I skip the registration
		And I navigate to sign in from home
		And I navigate to register now
	When I register a new user with the following details
		| Email                    | Password    | FirstName | LastName | Gender | PostCode |
		| ami.patel@testuktv.co.uk | password123 | John      | Smith    | Male   | WD17 1JJ |
	Then I should be successfully signed in

Scenario: Register From Episode 
	Given I am on the onboarding screen
		And I skip the registration
		And I navigate to a "taskmaster" episode
		And I navigate to register from episode
	When I register a new user with the following details
		| Email                    | Password    | FirstName | LastName | Gender | PostCode |
		| ami.patel@testuktv.co.uk | password123 | John      | Smith    | Male   | WD17 1JJ |
	Then I should be successfully signed in

Scenario: Register From Burger Menu 
	Given I am on the onboarding screen
		And I skip the registration
		And I navigate to "SIGN IN" from burger menu
		And I navigate to register now
	When I register a new user with the following details
		| Email                    | Password    | FirstName | LastName | Gender | PostCode |
		| ami.patel@testuktv.co.uk | password123 | John      | Smith    | Male   | WD17 1JJ |
	Then I should be successfully signed in