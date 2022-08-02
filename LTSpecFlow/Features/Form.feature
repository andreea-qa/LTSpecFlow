Feature: LambdaTest Playground

@twoInputFields
Scenario: Add two valid integer numbers
	Given I navigate to the LambdaTest Form Demo page
	When I input the values 5 and 3
	And I press to get the values
	Then the result should be 8