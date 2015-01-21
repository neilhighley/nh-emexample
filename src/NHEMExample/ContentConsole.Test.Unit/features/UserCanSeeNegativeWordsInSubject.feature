Feature: UserCanSeeNegativeWordsInSubject
	In order to track Negative Content
	As a user
	I want to be shown the number of Negative Words in a text input

@Negative_Word_Check
Scenario: Get number of Negative Words from Sentence
	Given I have entered a sentence
	When I submit "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting."
	Then the result should be "Total Number of negative words: 2" on the screen
