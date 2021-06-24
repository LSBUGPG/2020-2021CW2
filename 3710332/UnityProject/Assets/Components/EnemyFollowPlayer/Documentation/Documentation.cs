//EnemyFollow Guide:

//This document is to explain the behavaviour in this package and how it is used within the example scene provided. This document will also explain what is present in the scene as well as what will be needed if used elsewhere.

//What is present in the example:

//    - Player(PlayerController)
//    - Enemy(Any 3D object with "EnemyFollow" script attached)
//    - Ground
//    - Obstacles
//    - NavMesh Agent

//What is needed:

//    - Player
//    - Enemy Object
//    - Navmesh Agent

//How the script works:

//This script will make the nemy object follow the player consantly at a set speed. Bu using the navemesh agent, the enemy can also navigate around objects to eventually get to the player. Once the enemy get within a set range of the player, they will stop moving umtil the player is out of range again.

//This script will not work without a navmesh
