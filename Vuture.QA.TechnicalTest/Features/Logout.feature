Feature: Logout

Scenario: 00 - Logout

	Given I am on the homepage
	When I logout 
	Then I am sent to the login screen

