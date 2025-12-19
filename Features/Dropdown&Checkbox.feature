Feature: Dropdown&Checkbox

A short summary of the feature

Background: 
 Given The user launches the website "https://webdriveruniversity.com/"

@tag1
Scenario: Validating Dropdown&checkbox feature
	When user select the "DROPDOWN" header
	And user select the Dropdown Menu
	    |Dropdown Menu(s)|
	    | C#             |
	    | TestNG         |
	    | JavaScript     |
	    
	Then user should verify given languages selected or not
	    | Dropdown Menu(s) |
	    | C#               |
	    | TestNG           |
	    | JavaScript       |

@tag2
Scenario: Validating checkbox feature
	When user select the "CHECKBOXE(S)" header
	And user select the Checkbox Menu'S
	    | Checkboxe(s) |
	    | Option 1     |
	    | Option 2     |
	    | Option 3     |
	    | Option 4     |
	    
	Then user should verify given checkbox selected or not
	    | Checkboxe(s) |
	    | Option 1     |
	    | Option 2     |
	    | Option 3     |
	    | Option 4     |