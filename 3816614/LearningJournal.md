# Connor Howard Y2S2 Learning Journal

## 16/02/21

### Main Menu Scene

I started off by setting up the Unity scene, I created a UI canvas named "Main Menu Canvas" and inside created 3 buttons, I changed the text of these buttons to "PLAY", "SETTINGS"
and "QUIT", I then resized these buttons to better fit the screen. Next I knew I would need to prove the validity of this script by demonstrating the functions of the buttons so 
I created 2 extra scenes representing the scenes the user will go to when pressing play and settings. Inside these scenes I used a UI text element to display which scene this was
to prove which scene each button will take you too when the project runs. I then made sure the heirarchy had a "EventSystem" object to allow functionality for the buttons and 
lastly I created an empty game object called "Main Menu Controller" as well as a script called "MainMenuController" and attatched it to this empty object.
This was the scene set up now ready for the script to be made.
![1](https://user-images.githubusercontent.com/72077595/118699817-e5875480-b809-11eb-9a4b-8d38352c2d71.PNG)

### Main Menu Script

After doing some research into the different types of methods that would work with UI button functionality I created several public methods to act as the buttons functions which
I would then later in the scene assing within the buttons inspector. I made sure to add "using UnityEngine.SceneManagement;" at the top to allow access to the use of scene
management. Inside the Play method I wrote "SceneManager.LoadScene("Scene1");" which upon running would take the user to the scene specified within the speech marks (I made sure to
add a comment above telling the user to change the name of the scene to whatever their play scene is called, I also reminded them of this within the Read Me file I made and placed
inside the project folder). The Quit method runs the "Application.Quit();" function which will quit the program, to prove this method runs I also added in a "Debug.Log("Quit the application");"
to display the method running within the console window. Lastly the Settings method much like the Play method uses "SceneManager.LoadScene("Settings");" to transition between scenes
which I again added a comment in the script and Read Me files reminding them to change the name to fit their scene names.
![2](https://user-images.githubusercontent.com/72077595/118701128-49f6e380-b80b-11eb-8a6f-5b19b6d5fd9d.PNG)

### Main Menu Finalising

After the script was made I made sure the scenes I made where all added to the build settings then the only thing left to do was make the connection between the public methods and 
the assosiated buttons. Inside the Inspector window of each button I added an "OnClick()" function, placed the "Main Menu Controller" game object in and selected the appropriate 
method name for that button, I made sure to include these steps also within the Read Me file.

![3](https://user-images.githubusercontent.com/72077595/118702395-c63df680-b80c-11eb-8872-64b2946bd07e.PNG)

## 23/02/21

### Pause Menu Scene Set Up

To set this scene up I first created a  UI canvas named "PauseCanvas" and created 3 buttons, 1 would resume the game and unpause the menu, the 2nd would take the user back to their
main menu scene and the last would quit the game. I then added a UI text that would display "PAUSED" on screen and resized all elements accordingly. I knew that in order to demonstrate
this working I would need something moving to become paused when this script is used so I set up a simple cube as a floor and a sphere with a rigidbody attatched in the air so upon 
running the scene, the sphere would fall and the user could pause while it fell to demonstrate it working. Just like the previous package I made an empty gameobject called 
"PauseMenuController" and made sure the scene had an event system in for button functionality. Lastly I made a scene to represent the main menu with a UI text element displaying the scene
in. Finally I made the "PauseMenuController" script, added it to the empty game object and disabled the "PasueCanvas" object as I knew this would need to start with it off.
![4](https://user-images.githubusercontent.com/72077595/118704095-aad3eb00-b80e-11eb-821b-9dee38cdf1a6.PNG)


### Pause Menu Script

To start I added "using UnityEngine.SceneManagement;" to the top. Then I created a public gameobject to represent the pause canvas and a private boolean 
to set when the pasued state is active or not. Beceause to pasue the game I would be directly effecting the time state I made sure inside the start method to have the "Time.TimeScale" 
set to 1. Inside Update I placed an input check if the user pressess the "Escape" key which upon pressed would then check the state of the boolean, if "isPaused" is false it would 
activate the canvas object, set the "Time.TimeScale" to 0 and set the boolean to true, if it is already set to true then the opposite would occur. Much like the previous package I 
amde a public method to run the Resume, Main Menu and Quit button functions. The Resume function would disable the canvas, reset the "Time.TimeScale" to 1 and set the boolean to false.
The Main Menu method would take the user to the "MainMenu" scene and the Quit method woud use "Application.Quit();" and run a "Debug.Log" to represent functionality within the console.
![5](https://user-images.githubusercontent.com/72077595/118705565-4f0a6180-b810-11eb-8527-37a6bfccecd8.PNG)

### Pause Menu Finalising

Last thing to do was add the Main Menu scene to the build settings, then link the public methods to the buttons within the inspector window using the same method explained above in 
the previous package. I again made a Read Me file for the user inside the project folder.
![6](https://user-images.githubusercontent.com/72077595/118706012-ccce6d00-b810-11eb-9616-4d92f26a5a0e.PNG)

## 02/03/21

### Player Movement Scene Set Up

So for the scene set up I wanted to give an example scene that demonstrates the scripts use on different mesh shapes, so I created 3 gameobjects, a sphere, capsule and cube and 
made sure they all had rigidbodies. For the Box and Capsules I applied constraints to all rotations to avoid them rolling during movoment. Lastly I made the "PlayerMovement" script and attatched it to each of the 3 game objects.
![7](https://user-images.githubusercontent.com/72077595/118747394-d4623600-b851-11eb-8ab0-454e1e143b81.PNG)

### Player Movement Script
To start I made a public float variable to represent the force that will be applied to the objects rigidbody. I then made a private reference to the rigidbody itself and 2 booleans to set the states of moving left or right. In the start method I linked the rigidbody using "GetComponent<Rigidbody>();" and set the booleans to false. Next I wanted to split my input checks and physics calculations, I used the update method to run if statements to check if the user has pressed the A or D keys to set the boolean states for that direction and used the fixed update method to apply force to the rigidbody when these boolean states are true using "rb.AddForce(Vector3.left * thrust * Time.fixedDeltaTime);" and "rb.AddForce(Vector3.right * thrust * Time.fixedDeltaTime);".
![8](https://user-images.githubusercontent.com/72077595/118747728-7124d380-b852-11eb-9574-1ba364200fa7.PNG)
  
 ### Play Movement Finalising
  
The only thing left to do was to set the public thrust variable for each object, different collider types required different amounts of this variable to get a solid amount of force applied to move fast enough, the user is free to change these variables as they wish but for this example scene I applied 200 to the sphere, 1000 to the cube and 200 to the capsule. Lastly to avoid all objects being active at once during play I disabled 2 of them.
![9](https://user-images.githubusercontent.com/72077595/118845348-9c93d680-b8c3-11eb-9837-42d535a41351.PNG)

  
 ## 09/03/21
  
 ### Interactable Objects Scene Set Up
 
For this package example scene I created 2 sphere gameobjects, one to represent the pick up object and the other to represent the player object that would interact with this object and "pick it up". I made sure to assign a new tag called "PickUp" to the pick up object and also attatch a rigidbody to the player which for this example I set to kinematic to avoid the object falling off screen. I made sure the pick up object's collider was set to "is trigger" and made 2 materials applied to both objects to help differentiate between the two. I then created the "InteractWithObjects" script and attatched it to the player and did some research into different types of collision.
  ![10](https://user-images.githubusercontent.com/72077595/118846466-a2d68280-b8c4-11eb-9d50-75664c595d68.PNG)

### Interactable Objects Script
  
To start I made 2 private variable refrences to the act as the target object the player will interact with and a boolean to set the state of when something can be interacted with which I set to false in the start method. Inside the update method I ran an if statement to check for inputs for the E key which would then run a secondary if statement to check the condition of the interact boolean, if it is true it would destroy the target gameobject. I used an "OnTriggerEnter(Collider other)" method to check for tags and if the "PickUp" tag was found upon collision then the boolean would be set to true and the target object would equal the object currently being collided with. To make sure the boolean gets set to false again I used an "OnTriggerExit(Collider other)" method which again would check for the "PickUp" tag and if these conditions are met the boolean would be set to false.
  ![11](https://user-images.githubusercontent.com/72077595/118847204-67888380-b8c5-11eb-8f7d-3c721081bff2.PNG)

### Interactable Objects Finalising
 
There was nothing else I needed to do prior to the intial set up and script making so this package was all ready to go, I simply made a Read Me file inside the project folder and it was all set to go.
  
## 16/03/21
  
### Game Project Scene Set Up

To start setting this game up I started with the main menu package, I made the UI canvas and buttons just like before and added in the script which I atattched to an empty game object called "Menu Controller". Next I made the settings and play scenes and linked the scripts functions to the buttons. In the play scene I set about setting up the pause menu and player movement, I created a UI canvas for the pause menu and set it up the same way I did in the package, I then created a simple box border and placed a player sphere inside, I wanted to make a game that would be a playfull spin off the notorious dvd idle screen in which the dvd logo would move around the borders of the tv screen and would bounce off the border walls changing colour. To do this I downloaded a dvd logo off the internet as a png and placed this sprite on the player object as a child then disabled the player objects mesh renderer component. I gave the player a rigidbody and set the collision detection to "Continous Dynamic" and attatched the "PlayerMovement" script to it setting the thrust variable to 200. I made 3 materials to represent the background colour, pick up object and player, I also created a physics material to allow the object to bounce around the borders of the box, I set the dynamic friction to 0, static friction to 0, the bounciness to 1, the friction combine to minimum and the bounce combine to maximum then applied this material to the players collider. The background is simply a cube stretched with no collision and the background black material applied to it. I made an empty game object for the pause menu controller and applied the pause menu script to it then linked in the canvas object. Lastly I made a pick up prefab object using a sphere with the pick up material applied and carried out the same set up I did within the pick up package scene. With this all in place the packages made were all set in place within this game project and now the main menu, player movement, pause menu and interact with objects packages all function correctly within the project.
![12](https://user-images.githubusercontent.com/72077595/118857268-c0f5b000-b8cf-11eb-841e-8a83a61c48f1.PNG)

  
## 23/03/21
  
## Extra Work On The Project

### Pick Up Spawner
  
I like the project I have made and decided to spend more time working on it adding in extra features for example, rather than having the pick up object placed in the scene I wanted to have them randomly instantiate within the scene in random locations. To do this I made a script called "SpawnPickUp" and attatched it to an empty gameobject called "Spawner. I then created 2 empty gameobjects to represent the two spawn points I would use to instantiate randomly in-between. Inside the script I made public references to to the 2 spawn point game objects and the pick up prefab. I then made a private float to act as a counter and a private vector2 to represent the position in which the pick up objects will be instantiated at. Inside the update method I increased the counter by "+= Time.DeltaTime" and made an if statement that checks when this variable is greater than or equal to 3, once it is the position vector2 is set to be randomised on the X axis between the 2 spawn point game objects and randomly between 4 and -2 on the Y axis using "pos = new Vector2(Random.Range(spawnOne.transform.position.x, spawnTwo.transform.position.x), Random.Range(4f, -2f));". It would then instantiate the pick up object at this position vector and then reset the counter to 0 to run this process again.
  ![13](https://user-images.githubusercontent.com/72077595/118859463-2b0f5480-b8d2-11eb-8a92-826d477a720d.PNG)

### Colour Changer

Just like the dvd logo idle screen I wanted the sprite to change to a randomised vibrant colour when it bounces off the borders of the screen, to do this I did some research into the methods best for this and came across one that I would implement into my script, I made a script called "ColourChanger" and attatched it to the Player game object. Inside the script I made a public reference to the dvd child gameobject, then I used an "OnCollisionEnter(Collision collision)" method to check for collision tags, this would check for the tag "Wall" and if the condition is met I used the line I found during my research to grab the dvd logo's material on the renderer component and set its value to randomise to a vibrant colour using "Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);". I then made sure to assign the "Wall" tag to the borders and now the game has colour changing functionality.
  ![14](https://user-images.githubusercontent.com/72077595/118860317-26976b80-b8d3-11eb-9656-a418caf9acfd.PNG)

I plan on continuing this project in my own time and developing more features such as making something happen when the dvd logo hits the corners of the border, polishing the art work and adding in sounds. 
