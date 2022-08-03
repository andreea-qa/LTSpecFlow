Feature: Playground Demo

@threeInputFields
Scenario: Add three valid integer numbers
        Given I navigate to the LambdaTest Form Demo page
        When I input the values 5 and 6
        And I press to get the values
        Then the result should be 11
