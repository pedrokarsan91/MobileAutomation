Feature: Onboarding
	As a user 
	I want to see the onboarding
	So that I can navigate around the app

Scenario: Verify Welcome Onboarding
	Given I am on the onboarding screen
	Then I should see the skip option
		And the Welcome title
		And the sub text "Watch the TV you love on demand for free"
		And the UKTV logo
		And the register button
		And the sign in with Facebook button
		And the sign in link

Scenario: Verify See It First Onboarding
	Given I am on the onboarding screen
	When I swipe left once
	Then I should see the skip option
		And the see it first title
		And the sub text "Exclusive previews of brand new shows"
		And the cupcake logo
		And the register button
		And the sign in with Facebook button
		And the sign in link

Scenario: Verify Box Sets Onboarding
	Given I am on the onboarding screen
	When I swipe left twice
	Then I should see the skip option
		And the box sets title
		And the sub text "Feast on the programs you love"
		And the star logo
		And the register button
		And the sign in with Facebook button
		And the sign in link