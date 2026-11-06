This is a bonus exam for Game Engine

Snake game basically works with losing and gaining poitns and spawning fruit, but snake does not grow.

Singleton is the snake player, and the fruit spawner. The fruits activate functions in both when the player eats a fruit, and the spawner reads the player's score to know when to spawn a golden fruit. Singleton is regularly used if you an object to only be one in existance and can easily be accessed by other objects, such as a gamemanager or timer.

OOP, has 2 fruits, a normal base fruit and a golden fruit. Base fruit deletes itself, and gives player points, while golden fruit does the same thing, but increase players movement speed.

Fruit factory spawns which fruit with golden fruit having a extra notification, but can also do like particle effects or something.
Fruit spawner detects if a player is at a % of 5 points and if it is, spawns a golden fruit next time around. Factory is often used if you have similar objects that need to be spawned, but don't want to create a lot of function in the spawner that makes it messy and fills it up. Making factories you can seperate the different logic and make it clean, and can keep making more factories without filling up 1 script

<img width="737" height="600" alt="image" src="https://github.com/user-attachments/assets/d919a7e3-b450-4aae-a716-46746958efbc" />
The regular fruit is not is not inherited cause im running out of time
