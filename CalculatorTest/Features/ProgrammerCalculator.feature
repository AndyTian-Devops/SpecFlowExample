Feature: ProgrammerCalculator
	
@Basic
Scenario: Verify Different Scale
	Given Go To Programmer Calculator
	Given I have entered 80 into the calculator
	Then the result of HEX should be 50
	Then the result of DEC should be 80
	Then the result of OCT should be 120
	Then the result of BIN should be 0101 0000

