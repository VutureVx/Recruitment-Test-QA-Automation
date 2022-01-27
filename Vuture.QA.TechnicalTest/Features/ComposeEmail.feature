Feature: Compose Email

Scenario: 00 - Compose Email

	Given I have selected an email campaign
	When I create a new email 
	And I publish the email
	Then I verify the email is live

