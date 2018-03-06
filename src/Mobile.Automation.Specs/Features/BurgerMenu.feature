Feature: Burger Menu
	As a user
	I want to see menu options on the burger menu
	So that I can navigate

Scenario: Verify Burger Menu Items
	Given I am on the onboarding screen
		And I skip the registration
	When I open the burger menu
	Then I should see the following menu items
		| Menu Item   |
		| HOME        |
		| DAVE        |
		| REALLY      |
		| YESTERDAY   |
		| DRAMA       |
		| BOX SETS    |
		| COLLECTIONS |
		| GENRES      |
		| A-Z         |
		| MY SHOWS    |
		| SETTINGS    |
		| SIGN IN     |

