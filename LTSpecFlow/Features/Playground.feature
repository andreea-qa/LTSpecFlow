Feature: ECommerce Playground Demo

@searchItems
Scenario: Search for iPod Nano
	Given I select the Software category
	When I search for iPod Nano
	Then I should get 4 results

@searchItems
Scenario: Search for HTC Touch HD
	Given I select the Tablets category
	When I search for HTC Touch HD
	When I add a new step
	Then I should get 8 results