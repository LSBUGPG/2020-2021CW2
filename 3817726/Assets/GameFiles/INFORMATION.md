# Package 1 // Character Movement 
The first package in this is a walking cycle with a jump. Very simple as it is a walking from left to right and ofcourse jumping up.
	
	L Arrow = Left Walk
	R Arrow = Right Walk
	Space = Jump 

The person using package-1 can use this mainly on 2.5/3D platform games as it is using 3D camera positionings. It is perfered that the person that is going to be using the script to put the camera facing the Z axis as left would be the -X axis, right the X axis and jumping is the Y axis. If needed the user of the package can change the jumping force and the player speed in the inspector of Unity.			DEFAULT - MOVE SPEED = 3		JUMP HEIGHT = 300 

# Package 2 // Turret

This second code is sorced from online and is used to make a turret. The model was sorced from this site https://inscope.itch.io/turret?download, and the creator of the code was giving demonstrations on how to use this. https://www.youtube.com/watch?v=VnfD5wGEXFw
This turret is AI controlled so the player will not be in charge but it will be targeting the player and you have to be ready to dodge. This will follow the characters movment when it is in the range (used with a box collider found on the turret in the inspector), you can reduce the range if you wanted to make it a smaller shooting range or make it longer for a longer shooting range. 

AimOffset is in the inspector if you are needed to ajust the angle of the turret if it is looking at the ground or the sky and not the player. 

ghostRotator in the inspector is used to make it so that the turret is not going to be turning at a faster and snapy state, you can input a varieble to the rotation speed (defualt is 300) to see and find something that is going to be best suited for you. 


# Package 3 // Health
The character has a starting health of 100 total health and each time the player has taken damage by something with the Tag "Projectile", it will take 10 damage and once the playerHealth has hit 0 character will be destroyed. You are able to increase the health in the inspector if you chose to do so. 

# Package 4 // Main Menu
I created a basic main menu scene to make sure its clear for the user. This main menu can be customisable for anyuones prefrence and with this main menu it takes some use of text mesh pro as it is a good use of text tools in unity. the menu is simple to use and understand with a play button for the next scene and a quit to quit the game. 

# Package 5 // End Game



