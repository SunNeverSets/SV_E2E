Feature: LoginFailures

Scenario: Verify Get Login Failures for user
	When I call GET session/loginfailtotal with parameters:
		| UserName         | FailCount | FetchLimit |
		| Shulha Volodymyr |           |            |
	Then the following login failures data are returned:
		| UserName         | FailureCount |
		| Shulha Volodymyr | 5            |

Scenario: Verify Reset Login Failures for user
	When I call PUT session/resetloginfailtotal with parameters:
		| UserName      |
		| Avril Lavigne |
	When I call GET session/loginfailtotal with parameters:
		| UserName      | FailCount | FetchLimit |
		| Avril Lavigne |           |            |
	Then the following login failures data are returned:
		| UserName      | FailureCount |
		| Avril Lavigne | 0            |