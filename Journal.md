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

## Week 5-6

### Overview

This week in class we started working on a different scene in the Breakout file. Shmup. A scene composing of a rocking ship at sea with birds flapping their wings at the top of the screen. We learned how to animate the birds to make them look like theyre flapping their wings by rotating them back and forth using the animation timeline. It sounds simple and the action of their animtation looked simple but It was quite confusing the first time around. 

### Prototyping

This week's prototyping, I wanted to fix the issue of my last week's prototyping about the power up not showing up. I managed to fix it but i had to go to chatgpt to help me debug some issues. I managed to to make the triangles (power ups) to show up and fall down. Created the Triangles by making it a prefab, and adding a script to it called PowerUp.cs. It took alot of deubgs to understand which part is not going through during the game phase. Using instantiate in the BrickScript.cs to spawn children objects for different variables. Using _public void SetVisible(bool isVisible)_ in the breakoutPaddle to turn it invisible when the paddle hits the invisibilty power ups. I didn't want to make multiple color/shape for powerups because I don't want the player to be able to distinguish the difference of the power ups. I want a luck/gambling element in the game. One of the things that was funny to me was one of the power up or maybe power down in this case. This ability makes the paddle in scale, not horizontally but vertically. So by the end of my game, my paddle almost reached the top of the first half of the screen. And this makes it way harder to hit the ball since if u miss and the ball hits the side of your paddle, then it would just bounce infinitely until it reaches the bottom of the screen. Another ability is the ability for the ball to slow down, I don't know if I consider this a good ability in favor of the players since it could disrupt the flow of the game especially if it happens towards the end of the game. Players could be used to the pattern, timing of the ball and suddenly it slows down. My favorite ability is the invisibilty since it really challenges you to predict and understand where your paddle is without any visual cue. The first time it happened to me, even I was confused as to what had just happened, thinking my game has gone mad. But I figured out a trick to play with no paddle a few trys later. Overall, it was fun playing around with the abilities.

## Week 6-7

### Overview

Last class we started discussing about our final project. We discussed about the various techniques people do to get new ideas. So for last class, we were asked to make a list of keywords that pops up in our minds about our idea. Freestyling those keywords onto our notes we were then asked to find and pair up with a classmate to compare our keywords and find new connection. 3 rounds of this making it feel like speed dating. By picking at random one of our keywords each, hew ideas and mechanics could hopefully developped. Each round students have came up with funny yet interesting and unique ideas that are surprinsingly good. After three rounds of this, there were so many good ideas. 

### Ideation Process

My idea started when I randomly thought about my last week's chinese new year celebration. Each year for Chinese New Year, at the end of the night my family and I would play this Vietnamese dice betting game called _Bầu Cua Cá Cọp_. In that game, players bet on symbols and the three dices would determine the payout. The 6 symbols are layed out on a grid like pattern, and players would put money on the ones that feel like the dices would predict. The dices are normal 6 face dices with symbols on each face. Once rolled, the face facing up is the one we should look for. The three dices are placed in a salad bowl and a plate to close the top (that's our budget). Once shaken, the dealer would flip the think over and pulls up the salad bowl to reveal the three dices on the plate. This game made me realize that the structure of the game is simple yet full of tension, especially during the reveal moment. 

So i thought about gambling mechanics and how some games treat luck as something the player must overcome. Now what if I reverse the dynamic, what if the player is the dealer and not the one gambling? Instead of trying to beat the system, and win all the money, you become the house. The player is the house and their objective is to bankrupt the table. Kind of reinforcing the saying "_The house always wins_". I wanted to add a twist and the main mechanic of the game: Giving the player the ability influence the outcome of the game through game mechanics. Creating a good blend between randomness and control.

A few of the ideas that I got from my 5 minute conversations with my classmates are really good but quite complex. Although it is a simple gambling game, I'm aiming to integrate them into my game. 

Ideas:
- A cheating mechanic where the dealer can shake the bowl for an extra 1-2 seconds but at the risk of being caught. Only do it when the NPCs are not looking. 
- the ability to activitate your X-Ray ability to see the dices as you toss them but this ability don't last long.
- Reactive/adaptive NPCs. If the player manipulates the results too consistenly, NPCs become suspicious and become emotional (frustration, suspicion, joy, etc)

My three main vision for this game is the use of the dealer's POV with partial NPC visibilty. By positioning the camera in the dealer's perspective, it gives off a social vibe while still putting the main focus on the table. Giving the dealer the ability to see through the bowl gives a sense of control and don't make the player depend solely on chance to win the game. The suspiscion system is really interesting because it opens up so many opportunity. For example if the some symbols rarely appears, the npc would raise suspicion on you and bet less money or pulls out which is not what you want. This balances skill, timing and prevents obvious cheating.

The gameplay loop would be something like this
NPCs places bets on the 6 images -->> The player shakes the dices -->> The payout/reveal -->> suspicion check/reactions -->> End round

I was thinking that there would be a mandatory 5 second shake window, and another 2 second extra shake window right after. This would be indicated using a timer bar that goes down during the shaking phase to indicate when and how long the player has to shake. I think this its important to give the player a tracking system to keep the player hooked and wanting to play more. The tracking system is a score/money system that keeps track of everyones money. And the gols is to exhaust them until they have no money to their name.


<img src="images/IMG_8177.jpeg" width="500">
<img src="images/IMG_8178.jpeg" width="500">

## Week 8-9

### Overview

For the second stage of my prototyping process, I wanted to start testing out the different possible mechanics of the dice in my game. During the reading week, I though long and hard about how I will be able to bring this game to reality with just basic knowledge of Unity. I guess the questions that I needed answers to the most are implementations rather than visuals. I wanted to know whether I can create a working dice system in Unity that feels believable, free, and real while still holding a certain level of simplicity to it. For this week, I focused on searching on youtube for a good and solid tutorials to guid me through the process of building a working dice in Unity.

Reading week
- Found this video from youtube for the dice: https://www.youtube.com/watch?v=0-v4CbuJ5jI
- Easy, straight to the point.
- I just realized that almost all the videos/tutorial on youtube show a click mechanic for the dice. So there isn't any free movement to shake the dice. Since I haven't learned 3d yet I'm starting worry.
- Tutorial was a success but I'm now considering changing the overall mechanics of the games.

My initial idea was too big. NPC suspicion/detection, reations/emotions, the whole 3d scene with 3d charaters and money, advanced cheating mechanics, etc. These are all too complicated. I should build the main core mechanics first. 

After completing the dice tutorials, I realized that focusing on one mechanic at a time makes the project feel less overwhelming. Sometimes thinking about the whole project could be alot. If I could just single out each part at a time and take it one step at a time it would make the journey more easy and enjoyable. 

Took a break from unity and turned to Blender to create some assets. I saw tht you can easily bring Blender files into unity to used as assets so I was excited to create some models. I currently have a class on Blender so I wanted to put my knowledge to the test. I created a board with the Fish, Prawn, Crab images. I also made the three dices with the six different images on each faces. 

## Week 9-10

### Overview

Got really sick... 

After struggling with my Vietnamese dice game, I decided to change completely the scope of the game. Since I could barely sleep at night due to the pain, I took a lot of naps during the day. And suddenly I had this idea. Its a simple game but I realized how everytime I thought about a game, my first thought always goes back to the first time i discovered gaming. I was 6 years old when my dad came home and decided that I would get a gift that day. It was a DS zelda edition. So my first game was _Zelda: Phantom Hourglass_. The top down view was one of the most stand out feature for me. I was always used to playing 2d web browser games. And I think its because of zelda that I got this idea for a my game. A top down view game about a food deliver guy having to deliver to various locations throughout the city. But he picked up this job during the great Covid times. And he can only work late due to school. So he has to sneak out and deliver food without being caught by anyone, especially not by the authorities because of the curfew. I couldn't do much during the whole of this last week. So I will be doing much more this week.


