Feature: Login

Scenario: Verify non genuine user has no access to Tracking data page
	Given 'non genuine' user logged in to application
	When user navigates to 'Tracking data' page
	Then user is present on login screen
	And user is navigated to '/login'

Scenario: Verify that registered user can login into application
	Given 'genuine' user logged in to application
	Then user sees the header with the following tabs 'tab1, tab2, tab3'

Scenario: Verify that user has access to tracking data
	Given 'genuine' user logged in to application
	When user navigates to 'Tracking data' page
	Then Tracking data page is opened

Scenario: Verify that user can not login into application with invalid credentials
	Given 'non genuine' user logged in to application
	Then user sees 'Please verify your credentials.' validation error on Login page