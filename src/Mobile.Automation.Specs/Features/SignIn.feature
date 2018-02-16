Feature: Sign In
	As a user
	I want to sign in
	So that I can access my account

Scenario: Sign In From Onboarding
	Given I am on the onboarding screen
		And I navigate to sign in
	When I sign in with the following details
		| Email                                | Password    |
		| ami.patel+donotdelete@testuktv.co.uk | password123 |
	Then I should be successfully signed in

Scenario: Sign In From Onboarding Register
	Given I am on the onboarding screen
		And I navigate to register
		And I navigate to sign in from register
	When I sign in with the following details
		| Email                                | Password    |
		| ami.patel+donotdelete@testuktv.co.uk | password123 |
	Then I should be successfully signed in

Scenario: Sign In From Home 
	Given I am on the onboarding screen
		And I skip the registration
		And I navigate to sign in from home
	When I sign in with the following details
		| Email                                | Password    |
		| ami.patel+donotdelete@testuktv.co.uk | password123 |
	Then I should be successfully signed in

Scenario: Sign In From Episode 
	Given I am on the onboarding screen
		And I skip the registration
		And I navigate to a "taskmaster" episode
		And I navigate to sign in from episode
	When I sign in with the following details
		| Email                                | Password    |
		| ami.patel+donotdelete@testuktv.co.uk | password123 |
	Then I should be successfully signed in

Scenario: Sign In From Burger Menu 
	Given I am on the onboarding screen
		And I skip the registration
		And I navigate to "SIGN IN" from burger menu
	When I sign in with the following details
		| Email                                | Password    |
		| ami.patel+donotdelete@testuktv.co.uk | password123 |
	Then I should be on my profile successfully signed in
