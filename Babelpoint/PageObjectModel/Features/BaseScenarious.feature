Feature: BaseScenarious
	These scenarious can be used in any project

@Debug
Scenario: Validate the title of a website
	Given I navigate to the homepage
	Then I see the page title contains "Wikipedia"
