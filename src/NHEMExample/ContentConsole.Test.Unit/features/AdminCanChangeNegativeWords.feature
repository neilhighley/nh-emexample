Feature: AdminCanChangeNegativeWords
	In order to change the Negative Words Set
	As a Admin
	I want to be able to add new words without code changes

@mytag
Scenario: Change Negative Words Set
	Given I have entered New negative words
	And I have not changed the codebase
	When I press add
	Then the new Negative Words should be used
