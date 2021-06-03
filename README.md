# Game Finder App
> Store and manage game titles, searchable and organized by genre & game system.

## Table of Contents
* [User Stories](#user-stories)
* [Tasks/Tickets](#tasks)
* [Acceptance Criteria/Tests](#acceptance-criteria)
* [Sprint Planning](#spring-planning)
* [Assigned Tasks](#assigned-tasks)
* [Created By](#created-by)
* [Screenshots](#screenshots)
* [Links](#links)


## User Stories
1. As a store manager, I want to Create/Post games to the database so that users can find them.

2. As a store manager, I want to Update/Put a game’s information or data in case a mistake needs to  be corrected or updated information becomes available (like a release date, price change, on sale, etc.).

3. As a store manager, I want to Delete a game from the database when it is no longer available.

4. As a store manager, I want to Read/Get the ratings for games by user, in case a single user goes rogue and is giving bad ratings inappropriately.

5. As a customer, I want to Read/Get games by title for more information on that game (such as stock availability, price, rating, etc.)

6. As a customer, I want to Read/Get games by genre to find other titles similar to ones I know I like.

7. As a customer, I want to Read/Get games by system to see what games are compatible with the video game consoles I own.

8. As a customer, I want to Create/Post a rating on a game, to share with others how I felt about a particular title.

9. As a customer, I want to see the star ratings of a given game when I search for a game title, so that I can easily choose a game that is well made.

10. As a customer, I want to see the maturity rating of a given game, so that I can ensure a game is family friendly for my young kids.

11. As a game developer, I want to see the star ratings of a given game, so that I can compare my game with my competitors' games. 



## Tasks/Tickets
1. Create the github - **Points: 2**
2. Create the readme - **Points: 1**
3. Create initial scaffolding - **Points: 1**
4. Create Game class (id, name, description, price) (data layer) - **Points: 1**
5. Create GameSystem class (id, name, manufacturer, year of release) (data layer) - **Points: 1**
6. Create Genre class (id, genre) (data layer) - **Points: .5**
7. Create Game controller - **Points: 1**
8. Create GameSystem controller - **Points: 2**
9. Create Genre controller - **Points: 3**
10. Create Rating class (id, (int) star rating,  (string) expanded rating) (data layer) - **Points: 1**
11. Create Rating controller - **Points: 2**
12. Create Game service - **Points: 5**
13. Create GameSystem service - **Points: 3**
14. Create Genre service - **Points: 3**
15. Create Rating service - **Points: 3**
16. Create entity models for Game - **Points: 5**
17. Create entity models for GameSystem - **Points: 3**
18. Create entity models for Genre - **Points: 3**
19. Create entity models for Rating - **Points: 3**


## Acceptance Criteria/Tests
**User story 1:** Post’s game without required fields- Get’s 400 error “[field] is required”
**User story 1:** Post game successfully - gets 200 Ok, “Game added successfully”

**User story 2:** Updates game successfully - gets 200 OK, “Game updated successfully”, returns game
**User story 2:** Updates game without required fields - Gets 400 error “[field] is required”
**User story 2:** Tries to update a game that does not exist - Gets 404 error

**User story 3:** Deletes game successfully - gets 200 OK, “Game deleted successfully”
**User story 3:** Tries to delete a game that does not exist - Gets 404 error

**User story 4:** Get ratings from a user that doesn’t exist - 400 error “User doesn’t exist”
**User story 4:** Get ratings from a valid user id - 200 Ok

**User story 5:** Get title by valid id - 200 ok with information from game data table
**User story 5:** Get title with invalid id - 400 error “Game with that Id doesn’t exist”

**User story 6:** Get Games by genre - 200 returns all games with the selected genre
**User story 6:** Get games by genre in which no games exist - 400 error “No games exist within genre”

**User story 7:** Get All games that have the selected system - 200 ok returns all games on that system
**User story 7:** Get all games on a system that doesn’t exist, 400 error “We do not have that system in our database”

**User story 8:** Post a new rating for a game - 200 ok Posts attached to game
**User story 8:** Posts a new rating 

**User story 9:** Search game by title – Should return Game Title with Star Ratings
**User story 9:** Users did not enter a valid title – Should Return 404 error 

**User story 10:** Game maturity rating E, T– Return True Is Kid Friendly - 200 Ok
**User story 10:** Game maturity rating M – Return False Is NOT kid friendly - 200 Ok

**User story 11:** Search games by specified rating – Return 200 Ok
**User story 11:** Search games with incorrect int – Return 400 error 


## Sprint Planning
### Assigned Tasks:
**Rachel:** 1, 2, 3, 6, 9

**Tad:** 5, 8, 13, 14, 17

**Ben:** 4, 7, 12, 16, 18

**Backlog:** 19, 10, 11, 15


### Stretch Goals:
1. Method to Read/Get Games by price range - 4

2. Method to Read/Get Games by Maturity Rating - 4


## Screenshots
![Example screenshot](./img/screenshot.png)
<!-- If you have screenshots you'd like to share, include them here. -->


## Created By
- Ben Ellis

- Tad Luedeke

- Rachel Bellwood


## Links
[PlanITPoker](https://www.planitpoker.com/board/#/room/eee6c51b6bec4287811e1d19a3dcdb0c)

[Trello Board](https://trello.com/b/DodphMPn/agile-project)

