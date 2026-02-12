# Weekly Journal

## Week 1-2: Make a Thing!

### overview
My first assignment was to create something using a game engine. I missed the first day of class due to some family business outside of Canada. I got back during the second week, so I went through the slides and course outline to see what I needed to do for the second class.

### process
For this assignment, I decided to use the Bitsy tool to create a simple game. Since I was in Houston visiting my family, food was a big part of my day, especially since they are known for making some of the best BBQ. When I got back, it was still stuck in my mind. So for the game I created, I wanted to make something that revolves around Houston and food.

Bitsy is a very easy tool to work with, but sometimes I encountered bugs that I just couldn’t get around, which made me rethink and rebuild the gameplay—sort of building around the issues instead of eliminating them, since I couldn’t find a solution. One of the issues was that when adding more than two sprites, the game would bug out and give me a blue screen with white lines. I couldn’t do anything except restart from the beginning, and this happened so often that it took me much longer than expected.

Another problem I encountered was with the “item” sprite. I wanted to be able to pick up the item and bring it to a tile that would end the game, but I couldn’t figure out how to program it. I’m sure that if I had more time, I would have been able to find a solution.

All in all, it was an enjoyable experience creating the map, sprites, and animation. I went with a yellow and black color palette to simplify the visuals and help players distinguish the road from the buildings.

## Week 2-3

### overview

For this week, we started Unity and created are first project. I downloaded rider to facilitate my journey with Unity (or so I was told). I had a fee issues with guthub and connecting my github with Unity but figured it out quickly. There wasn't anything due next class but the teacher mentionned playing around with the Unity to familiarise ourselves with the engine.

### impression
My first time using Unity was easy going. I knew it was complex but it wasn't as confusing as i thought it would be. Creating sprites and coding them on rider was easy to understand. 

## Week 3-4

### Overview

This week we dove deeper into the mechanism and functions of the _Catch em all_ game. Learned how to add textboxes and a point system that would react to the game and update the scoreboard at the top of the screen. We also went over the triangle of prototyping which consists of role, look and feel, and implementation. _Catch Em ALl_ wasn't the only game we did, towards the end of the class we also went over a pong game. The teacher went through the game, explaining each line of codes but we didn't build it from scratch like the first game.

Although _Catch Em All_ was a simple game, it still holds a level of complexity that I haven't gotten used to yet. Same goes for the pong game. i think the main issue is the overlay and menus, that I am not comfrotable with yet. I'm not too worried since this is normal and goes for any other programs when you start learning.

### Prototype ideas

The teacher asked us to come up with an idea simple or complex to add or change in the Pong game that we just checked out. I immediately had an idea, _**Blind Pong**_ and the core idea is to make the paddles become invisible after 3-5 seconds of gameplay. I think this would be in the Feel/Role category. This change would play with the player's focus, tensions as well as predictions and timing since the a visual information is removed, the player would need to rely on their spatial memory. This change does not completely strip the game of its identity but explores more of the player psychology. How would a player react and perform if a major piece of visual information is removed during gameplay? That's the main question of this prototype. To put this prototype from paper to unity is something I haven't tried yet. But I do have some ideas such as adding a fade in and out for the paddles, and a sound cue whenever the ball hits the invisible paddle to give the player an audio feedback. This would confirm a hit as well as giving players a small dopamine reward. This keeps the game satisfying while making players track success through sound instead of sight.

## Week 4-5

### Overview

This week we went over the process of making the classic _Breakout_ game, learning the coding. The teacher explained how to add sound effects, to each of the variables and where to download them. The website instroduced by the teacher was actually very helpful. I can see myslef using that for future projects especially because its free for public use. We learned how to connect each scenes to each other through a seperate window (which is kinda clunky in my opinion). Created a death/game over scene for when the ball touches the bottom barrier. Went over the point system as well as a highscore screen which is shared with the game over screen.

### Prototyping

For this week's prototyping, we were given a task of coming up with some sort of features using what we learned in class. My idea was to create a powerup system that would drop whenever a brick has been hit. But I want to make it different from the traditional power up system. Most breakout games would give players power ups but they would either be good or bad depending on their colors for example. Me, I want to add gambling to the mix. By making the power ups mixed in with power downs, it makes the player second guess wether they would want to take the drops or not. The idea is to give the power ups the traditional effects such as multiple balls, slow balls, bigger paddle etc. But the power downs are the main focus. Giving them the ability to lessen the players senses (visual, hearing, etc.) This would disturb the players flow, and make them stay on their toes. The main idea was to make the paddle invisble so the player would have to rely on their paddle placement/mermory and to predict the paddle's speed. Taking away sound could be a good power down since it would disturb the flow of a player who has been hearing the hit sound and suddenly it goes quiet.

Creating a new script for powerUps, and in BrickScript.cs i added a powerUp prefab in drop (0.3) whenever a brick is hit. The powerUp would have a OnTriggerEnter2D when colliding with the paddle which calls the GameManager to apply the effect. But as time is running out, I find myself stuck and can't get the power up prefab to fall. Other minor issues are just syntac errors that caused a good chunk of my time.

So was it a success?
Not yet, I'm struggling to get this to work and am continuing to find the solution. But so far I feel good about this prototyping.
