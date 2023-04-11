Feature: MainPageFuncionality

Сhecking the main functional features of the Steam main page

@MainPageFuncionality
Scenario: Change interface language
	Given list of languages is opened
	When Deutsch language is selected
	Then name of the button for opening the list of languages ​​is now in Deutsch

@MainPageFuncionality
Scenario: Game search via search fields
	Given game title <gameTitle> is setted to search field 
	When search game button is clicked
	Then name of the first game in the list <expectedFirstGameName> is equal to the title that was typed into the search field

	  Examples:
    | gameTitle |           expectedFirstGameName|
    |         cs|Counter-Strike: Global Offensive|
    |       dota|                          Dota 2|

@MainPageFuncionality
Scenario: Login through main page
	Given login button is clicked
	When login "Mars412" is setted to login field
	And password "Svs_21!" is setted to password field
	And confirm login button is clicked
	Then account name on mainpage is displayed

@MainPageFuncionality
Scenario: Find games by tags
	Given tags button is clicked
	When indie tag is clicked
	Then game header appears

@MainPageFuncionality
Scenario: Download Steam app exe
	Given intstal steam button is clicked
	When confirm steam instal button is clicked
	Then steam app file is downloaded
