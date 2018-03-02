Feature: Sign Out
	As a user
	I want to sign out
	So that my account is no longer in use

Scenario: Sign Out
	Given I am on the onboarding screen
		And I navigate to sign in
		And I sign in with the following details
			| Email                                | Password    |
			| ami.patel+donotdelete@testuktv.co.uk | password123 |
	When I sign out from home
	Then I should see the sign in screen

Scenario: Sign Out From Burger Menu
	Given I am on the onboarding screen
		And I navigate to sign in
		And I sign in with the following details
			| Email                                | Password    |
			| ami.patel+donotdelete@testuktv.co.uk | password123 |
		And I navigate to "MY PROFILE" from burger menu
	When I sign out
	Then I should see the sign in screen