Feature: ECommerce Playground Demo

@searchItems
Scenario: Search for iPod Nano
	Given I select the Software category
	When I search for iPod Nano
	Then I should get 4 results for iPod Nano

@searchItems
Scenario: Search for HTC Touch HD
	Given I select the Tablets category
	When I search for HTC Touch HD
	Then I should get 8 results for HTC Touch HD