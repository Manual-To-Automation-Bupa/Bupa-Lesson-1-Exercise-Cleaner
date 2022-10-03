Feature: Login Tests
A short summary of the feature

@Login
Scenario Outline: Login
	Given I am on "https://practicetestautomation.com/practice-test-login/"
	When I login with the username <username> using the password <password>
	Then The login should have <status>

Examples: 
    | username    | password    | status |
    | student     | Password123 | passed |
    | wrongStudent| Password123 | failed |
	| student     | Password456 | failed |