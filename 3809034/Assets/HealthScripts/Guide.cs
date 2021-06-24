using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    /* 
     * Health Guide
     This document explains what the behaviours in this package does and how it 
     can work effectively

     # HealthScript
     This script should be applied to the to the main player. The script has integers
     that can be configued to fit your game the way you would like.
     The integers that can be configued are:

     -Max Health  - The maximum the health can be.
     -Current Health - The health at the current momement.

     There are two functions within the health script which would help with taking
     damage and being healed. 

     #Take Damage
     This function allows the player to take damage and lose one or more health, 
     depending on what you want for your game. These will be public so they can be called
     on from different scripts. It will be displayed on the UI.

     #Heal
     This function allows the player to regain some health, if the player is at max 
     health it will stay at the max and wont go above. These will be public so they can be called
     on from different scripts. It will be displayed on the UI.

    * Example Scene
      The example scene a box which is controlled by the player and two other boxes, 
      one damages the player and the other heals the player,
      













     */


}
