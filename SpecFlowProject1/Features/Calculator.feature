Feature: Pet
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120


Scenario: Create a new pet
	Given the pet name is "tamir"
	And the pet category id is  1
	And the pet category name is  "dogs"
	And the pet id is 45
	When creating new pet
	And getting pet with id 45
	Then the pet id should be 45
