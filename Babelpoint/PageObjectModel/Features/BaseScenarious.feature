Feature: BaseScenarious
	These scenarious can be used in any project

@Debug
Scenario: Validate the title of the website
	Given I navigate to the homepage
	Then I see the page title contains "Wikipedia"

@Debug
Scenario: Validate the Url of the website
	Given I navigate to the homepage
	Then I see the page Url contains "www.wikipedia.org"

@Debug
Scenario: Validate the PageSource string on the website
	Given I navigate to the homepage
	Then I see "The Free Encyclopedia" in the PageSource


@Debug
Scenario: Validate existence of multiple texts in PageSource
	Given I navigate to the homepage
	Then I see 
	| expectedText          |
	| The Free Encyclopedia |
	| Deutsch               |
	| Русский               |
	| 日本語                   |