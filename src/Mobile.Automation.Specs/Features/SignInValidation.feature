Feature: Sign In Validation
	As a user
	I want to see validation errors
	So that I can correct my mistake

Background: 
	Given I am on the onboarding screen
		And I navigate to sign in

Scenario: No Details Entered
	When I sign in
	Then I should see the sign in error "Whoops! Please enter a valid email address."

Scenario Outline: Sign In Validation	
	When I sign in with the following details
		| Email   | Password   |
		| <Email> | <Password> |
	Then I should see the sign in error "<Error>"

	Examples: 
		| Email                                | Password    | Error                                                          |
		|                                      | password123 | Whoops! Please enter a valid email address.                    |
		| ami.patel+donotdelete@testuktv.co.uk |             | Please enter a password.                                       |
		| nonexisting@gmail.com                | password123 | Uh-oh! Your email or password was incorrect. Please try again. |

