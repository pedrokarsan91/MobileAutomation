Feature: Register Validation
	As a user
	I want to see validation errors
	So that I can correct my mistake

Background: 
	Given I am on the onboarding screen
		And I navigate to register

Scenario: No Details Entered
	When I register 
	Then I should see the register error "Whoops! Please enter a valid email address."

Scenario Outline: Register Validation 
	When I register an invalid user with the following details
		| Email   | Password   | FirstName   | LastName   | Gender   | DOB   | PostCode   |
		| <Email> | <Password> | <FirstName> | <LastName> | <Gender> | <DOB> | <PostCode> |
	Then I should see the register error "<Error>"

	Examples: 
		| Email                   | Password    | FirstName | LastName | Gender | DOB     | PostCode | Error                                       |
		|                         | password123 | John      | Smith    | Male   | Default | WD17 1JJ | Whoops! Please enter a valid email address. |
		| ami.patel@testukv.co.uk |             | John      | Smith    | Male   | Default | WD17 1JJ | Please enter a password.                    |
		| ami.patel@testukv.co.uk | password123 |           | Smith    | Male   | Default | WD17 1JJ | Please enter your first name.               |
		| ami.patel@testukv.co.uk | password123 | John      |          | Male   | Default | WD17 1JJ | Please enter your last name.                |
		| ami.patel@testukv.co.uk | password123 | John      | Smith    |        | Default | WD17 1JJ | Please select your gender.                  |
		| ami.patel@testukv.co.uk | password123 | John      | Smith    | Male   | EMPTY   | WD17 1JJ | Please select your date of birth.           |
		| ami.patel@testukv.co.uk | password123 | John      | Smith    | Male   | Default |          | Please enter your postcode.                 |

