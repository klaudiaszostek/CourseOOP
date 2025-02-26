# 6 States and strategies

Prisoner's dilemma is a type of turn-based game in which two players make decisions to cooperate or betray their partner. If both players
cooperate, both benefit from it, receiving (in our version) +10 points each. If one player is focused on cooperation and the other betrays him, the betrayer wins (+15 points), while the betrayed player receives penalty points (-10 points). 
If both players try to betray each other, both receive zero points for that round. Each game consists of many rounds (in our version - thirty) against the same partner, with the players having the right to record the opponent's moves so far and decide on this basis how trustworthy they consider him. You have: class files Program, Game, Player, IStrategy andStrategyAlwaysTrue, simulating a single game of Prisoner's Dilemma for a simple sample strategy. 
Please write five of your own strategies inheriting from IStrategy, and then modify the program to play a tournament between them on a
"round robin" basis. (That is, a total of ten games of thirty rounds each). Finally, please display the tournament score on the console screen.

https://en.wikipedia.org/wiki/Prisoner%27s_dilemma


# Result

Player1 score: 5
Player2 score: 5

Player1 score: 5
Player3 score: 5

Player1 score: 0
Player4 score: 0

Player1 score: 295
Player5 score: 270

Player2 score: 300
Player3 score: 300


Player2 score: 425
Player4 score: -275

Player2 score: 425
Player5 score: -275

Player3 score: 425
Player4 score: -275

Player3 score: 425
Player5 score: -275

Player4 score: 295
Player5 score: 270