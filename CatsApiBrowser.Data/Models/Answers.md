##Please answer all these questions in a Markdown document.

###1. How long did you spend on the coding test?

2:15 to have a working solution, with mocked data.
Another 30 minutes with real data. 1 hour to answer and format this file..

###2. What would you change / implement in your application given more time?
Handling errors, find a solution to deal with heavy pictures, improve tests, improve UI, rename some classes and review everything a bit more relaxed to see where I can find better solutions.

###3. Did you use IOC? Please explain your reasons either way.
Honestly, is the first time I heard about IOC. Apart from the fact I looked for it now,  I need to have a look further to understand better what does it mean. The answer is no.

###4. How would you debug an issue in production code?
Depends on the type of issue. First try to understand exactly what the issue is. Some of the possible actions:

* Refresh the page
* Inspect the page with the browser debugger for any JS errors
* Check if a deploy has been done recently
* Call a colleague or a two
* Check if there’s any potential dependency not working  (external or internal services, database down, etc)
* Check error logs
* Log-in into the production machines and have a look there
* Have a look at the deployed code.
* etc.

###5. What improvements would you make to the cat API?
Use json instead of xml, handle image size, return something different than cats, or at least related to given category: cats in space, cats with hats, etc.

###6. What are you two favourite frameworks for .Net?
AspNet MVC, SignalR

###7. What is your favourite new feature in .Net?
C# syntax improvements. 


###8. Describe yourself in JSON.
    {
        "Mind": {
            "Attitude": "Analyze everything. I love it.",
            "Interests": "Almost too many, but I said almost. Is good like that.",
            "LateralThinker": true
        },
        "Body": {
            "Structure": "Quite fit, but there's always room for improvement.",
            "Activity": "As much as I can.",
            "Born": "1980-03-21T00:00:00"
        },
        "Soul": {
            "Idealist": "If there is a problem, there is a solution.",
            "Optimist": "If there is a problem, there is a solution.",
            "Feel": "The energy around us.",
            "Hope": "God."
        }
    }
