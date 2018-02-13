Feature: Login
	As a user
	I want to login
	So that I can see images

Scenario: Login
	Given I am on the login screen
	When I login with the following details
		| Username       | Password       |
		| ENTER USERNAME | ENTER PASSWORD |
	Then I should be successfully loged in
		
