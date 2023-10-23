Feature: Login

Scenario: Verify that registered user can login into application
	Given 'test.user@dummy.com' logged in to application
	Then user sees the header with the following tabs 'tab1, tab2, tab3'

Scenario: Verify that user has access to tracking data
	Given 'test.user@dummy.com' logged in to application
	When user navigates to 'Tracking data' page
	Then user sees the list of products

Scenario: Verify that user can not login into application with invalid credentials
	Given 'test.user@dummy.com' logged in to application
	Then user sees ‘Please verify your credentials.’ validation error on Login page

Scenario Outline: Verify that user can navigate to page via tab with specific permissions
	Given ‘<User>’ logged in to application
	When user navigates to ‘<Tab>’
	Then user is navigated to ‘<Url>’

Examples:
	| Tab  | Url        | User                     |
	| tab1 | ui/v1/tab1 | test.user.tab1@dummy.com |
	| tab2 | ui/v2/tab2 | test.user.tab2@dummy.com |