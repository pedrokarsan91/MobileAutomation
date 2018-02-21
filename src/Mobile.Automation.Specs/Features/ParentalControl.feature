Feature: Parental Control
	As a user
	I want to add parental control
	So that a PIN is required

Scenario Outline: Set Up Pin
	Given I am on the onboarding screen
		And I skip the registration
		And I navigate to "SETTINGS" from burger menu
		And I navigate to "Parental Control"
	When I configure a pin for "<Age>" rated content
	Then I should see the message "PIN has been activated."

	Examples: 
		| Age |
		| 15  |
		| 18  |

Scenario Outline: Verify Pin Overlay
	Given I am on the onboarding screen
		And I skip the registration
		And I navigate to "SETTINGS" from burger menu
		And I navigate to "Parental Control"
		And I configure a pin for "<Age>" rated content
	When I play a "<Age>" rated content
	Then I should see the pin overlay 

	Examples: 
		| Age |
		| 15  |
		| 18  |


