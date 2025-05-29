Feature: Retrieve all todo items

As a user, I want to get a list of all todo items
	
	Background: 
		Given the endpoint is "http://localhost:5274/todo"

	Scenario: Todo items are successfully retrieved
		When the endpoint is called
		Then the result is:
			"""
			[
			 {
			     "id": 1,
			     "name": "brush teeth",
			     "isComplete": true
			 }
			]
			"""