# API Player
Sample code for rendering Typsy Lessons returned from the API

![Image of Typsy Player embedded using API](http://images.typsy.com/images/integrations/typsy-web-player-api.png?width=850)

# Notes
The Typsy videos/lessons will not play until your domain has been added to a whitelist. In the interim, you can hard-code the required PlayerId (in LessonService.cs)  to 
```
PlayerId = "j38ihh83m5"
````
to prove the video player works while the whitelist is not in place.

# Authenticating
In the code samples you will need to enter the values (provided by your Typsy account manager) for the following items.
```
TYPSY_ACCOUNT_ID = "INSERT THE ACCOUNT ID";
TYPSY_SOURCE = "INSERT THE SOURCE NAME";
TYPSY_KEY = "INSERT THE KEY";
```
