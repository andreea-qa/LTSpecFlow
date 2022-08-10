Feature: ECommerce Playground Demo

@addItemsToCart
Scenario: Add laptop to cart
	Given I navigate to Laptops
	When I select the first product
	And I add it to the cart
	Then the total price should be $146.00

@addItemsToCart
Scenario: Add software to cart
	Given I navigate to Software
	When I select the first product
	And I add it to the cart
	Then the total price should be $337.99
