# Year 2 Semester 2 Learning Journal

## Tuesday 16th February 2021

I had a small problem with making the minimap camera show the plane in the scene, even though I did exactly what the video showed how to do it. I thought it was because of the size of it as I haven't made a minimap camera in a while and I never experienced this issue before, but after resizing it, I realised it was the size of the camera as it showed the character I wanted moving around the scene.

I also had some confusions with writing the movement script for the character, which is mostly because I have never done it without the character controller and I never tied to do it like I did in the 2D games I made. I realised that the reason why I was struggling to write the movement for the 3D character was because I never wrote wrote the movements without using the Character Controller Component and I thought I could succeed without it.

When writing the script that would allow the script to manage the minimap camera's ability to rotate along with the character, I encountered an error with how it worked. It only worked on the same script and would not work if it is part of a different script. I do not know what I did wrong with the script, but I think it might have something to do with how I called the functions from the other scripts as I might have written it wrong and got confused on how I did it for my other assignments that involved using code.

## Tuesday 23rd February 2021

I encountered a problem with why when the pistol runs out of ammo, it stays in the reload position instead of returning to its idle position for the AmmoManagement Package. I thought it was because I missed something in the videos I watched, and it turned out that I did miss something: I had to set the booleon for pistol the animation back to false to return to the idle position because if I did not, it would stay at the idle position and never change after the reload animation is set to true.

As I progressed through the AmmoManagement Script, I got confused as to how I could re-write the script I wrote after watching the first video to work similarly to the script in the other video I watched as they did not contain all of the same variables to each other. I knew that if I wanted to give it a certain amount of ammo before running out and never be able to fire again, I needed to add more variables, but I did not know how to make sure that when the weapon reloads, the max ammo did not turn into a negative number.

I thought this is because I had to re-write the other bits of script that had nothing to do with the general firing commands, but I figured out that I did not need to touch the firing functions, I just had to re-write the ammo variables and add more to them. I planned on writting it after watching the second video, but later I decided to leave it and write it in the documentation instead as I already got the basic part of it done, I did not include any movement scripts to it and I did not feel that it was needed as it's mainly about shooting and reloading.

After I exported my package for the Minimap and re-apllied it to a new unity project, I found out that there was a small problem with the main camera: it no longer moves or rotates with the camera, but the minimap camera still works fine. I thought it was because the script got lost and that re-assigning it to the approproate gameobject would fix it, but then I realised that it may be because the camera mainly moved and rotated with the character because I used Cinemachine and the new project did not have it or obtain it after importing the package.

I think the best way I can fix this is to utilise the minimap camera script and write similar variables into the main camera script as the minimap camera is not parented to the player and it can move and rotate along with the player entirely through the script.

## Saturday 27th February 2021

I tried to re-write the script to make two that work together, but it still didn't work correctly even though I know I wrote the methods correctly and I successfuly referenced them in the other scripts without encountering any errors. I no longer think this is because of how I wrote the code in terms of the methods, but I now think it is either because some scripts can't handle certain methods begin referenced in other scripts, such as the transform data, or because I need to use certain void functions which I don't now which one will work.

## Tuesday 2nd March 2021

As I was writing the script for the sniper scope, I had a slight confusion with the code as when I set isScoped to true, the game objects that were supposed to be visible were not showing even though I wrote the script correctly while watching the video that showed how to write it. When I looked at the gameobject, I realized that the reason it was not showing is because the set layer of the game object was set in a way so it would not stay visible when zoomed in.

## Tuesday 9th March 2021

When I was writing the script for the Third Person Camera & Player Controller script, I came accross an error with the way the camera rotated, as whenever I moved the mouse up, it moved down and vise versa. I assumed that it had something to do with how I wrote the script handled the values of the rotation, and I was correct as I wrote a plus (+) where I should've wrote a minus (-).

I encountered another error while nearing the end of the script that was supposed to make sure that whatever blocked the camera's view, or collided with it, would turn off its mesh so it would not look like it's visible: when nothing was obstructing the camera, there was a slight delay before the mesh turned back on. I thought this was because I wrote a delay somewhere or something else that I had not clue, but now I think it might be because of the performance of my laptop as the mesh eventually turned back on.

At the very end, encountered a simimlar error that occurd when I tried to get the two scripts to work together in the Minimap Package: the camera would not longer rotate with the mouse when I tried to find a way to get another script to make the camera look at the desired location on the player, as well get another script to handle the mouse rotation.

I though it happened for the same reason why the minimap script didn't work: the way I wrote the functions in each script to make sure that they worked together, but now I think it's because the scipts can get confused easily when I try to reference a certain function from another script, as I managed to get a slight result when making a new script component that mainly used its own valuse.

## Wednesday 10th March 2021

After succeeding in making another script for the Weapon Scope Package, I now think that the real reason why I was not able get two scripts to work together in the Minimap Package or the Third Person Camera & Player Controller Package is because I did not reference then in either a Start function or an Awake function.

## Saturday 13th March 2021

After creating an Awake function in the Minimap Package, it turned out that the reason why I could not get two script to work together was becaue I did not reference it in an Awake function, because without it, it does not work. That is also the reason why it did not work for the Third Person Camera & Player Controller as I did not create an Awake method.

## Monday 15th March 2021

When I first started writing the code for the First Person Camera & Movement script, I encountered an error with the camera when the game was playing: the rotation went off and for some reason even though I wrote the script correctly.

I thought the problem was the script as the videos I watched to make a First Person movement script were different from the Third Person Movement scripts, but after I finished writing the script which was similar to the previous ones, I realise that it could have been where the parented camera was positioned on the character as I moved it out a bit and that can cause irregularities with the rotation like moved pivot points.

## Tuesday 16th March 2021

As I applied the packages I made into one project for the small game I planned on making, I encountered a few errors. One of them involved the weapon no longer being able to fire when the weapon is empty and the second one involves the weapon not being able to do damage while using a weapon scope.

I thought the problem for the first error was because was because of the zoom in, as the camera that is used to cause damage is not longer used when zoomed in. A while later, I realised that the real reason was because of the animation conditions in the script, because before the weapon reloads, it looks for the animation before finishing the reload. Commenting it out fixed it, but now it no longer plays the animation.

I thought the problem for the second error was because it had nothing to refer to, and that I needed to create a new Camera variable for the Gun script to use, but this did not work as it still did not deal damage.

## Tuesday 23rd March 2021

As I was trying to figure out why the Gun script no longer fired when zoomed in, I figured out the reason why it didn't work: the objects of the weapon were blocking the Raycasts through their colliders. It turned out that Raycasts will interact with anything that has a collider component, whether it is set as a trigger or not. So the only way to make sure that it stopped blocking the Raycast was to either remove or disable the colliders.

## Tuesday 20th April 2021

I encountered a problem coding the scoring system for my small game: the methods I used for the previous games I made were not working and I did not know why, even though I knew I wrote them correctly. I thought it was because of the way I referenced the script that handles the scoring as it did not work for either way I ordered the script and one of the ways I ordered them stopped the objects from being destroyed when their health reached 0.

I then realised that it was due to the way I wrote the reference, as I referenced the other scripts in the Awake method, but that didn't work. When I made the public void method and referenced it straight in the destroy method above the script that destroys the game object, the points started going up and the objects were destroyed without any issues.

## Tuesday 4th May 2021

I struggled with editing the script so it shows the amount of targets there are in the game for the max amount of targets on the UI Score canvas: the method I tried to write it in came up with errors as I tried to write it as an array and define the calculation of the maxTarget int variable on the same line as the variable itself.

    int maxTarget = targets.Length

I tried changing the array to a public list of GameObjects and write the maxTarget variable as targets.Count as I thought that was the problem, but the problem persisted. I managed to fix it by defining the maxTarget int variable in the start function as there were not errors when I did this and whenever there is any amount of GameObjects in the list, it displays the amount in the UI Score canvas.

I believe that the reason it wasn't working is because not all variables can handle a cartain definition being used, as the definition matters.

## Sunday 17th May 2021

I encountered a small error with my game as I play tested it today: the character no longer jumped when I pressed the space bar. At first I thought for some reason it somehow had somthing to do with the new code I wrote for the UI elements to be turned off, but then I realised that it was the ground controller gameObject not touching the ground as I accidentally moved it upwards as the parent for my whole character was off and I wanted to snap it to the centre.
