Feature: Onboarding
	As a user 
	I want to see the onboarding
	So that I can navigate around the app

Scenario: Verify Welcome Onboarding
	Given I am on the onboarding screen
	Then I should see the skip option
		And I should see the Welcome title
		And I should see the sub text "Watch the TV you love on demand for free"
		And the UKTV logo
		And the register button
		And the sign in with Facebook button
		And the sign in link