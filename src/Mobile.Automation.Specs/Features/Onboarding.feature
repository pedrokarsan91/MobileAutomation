Feature: Onboarding
	As a user 
	I want to see the onboarding
	So that I can navigate around the app

Background: 
	Given I am on the onboarding screen

Scenario: Verify Welcome Onboarding
	Then I should see the skip option
		And the Welcome title
		And the sub text "Watch the TV you love on demand for free"
		And the UKTV logo
		And the register button
		And the sign in with Facebook button
		And the sign in link

Scenario: Verify See It First Onboarding
	When I swipe left once
	Then I should see the skip option
		And the see it first title
		And the sub text "Exclusive previews of brand new shows"
		And the cupcake logo
		And the register button
		And the sign in with Facebook button
		And the sign in link

Scenario: Verify Box Sets Onboarding
	When I swipe left twice
	Then I should see the skip option
		And the box sets title
		And the sub text "Feast on the programs you love"
		And the star logo
		And the register button
		And the sign in with Facebook button
		And the sign in link

Scenario: Skip Registration
	When I skip the registration
	Then I should be on the home screen