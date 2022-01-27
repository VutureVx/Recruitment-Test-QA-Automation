Feature: Create Email Campaign

Scenario: 00 - Create Email Campaign

	Given I have selected create email campaign
	When I enter text 
	And I click Create
	Then I verify my campaign is created
