using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public string winScreen;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collisionData)
    {
        //Get the objected collided with.
        Collider2D objectCollidedWith = collisionData;

        //Get PlayerHealth attached to that object (if there is one).
        PlayerHealth player = objectCollidedWith.GetComponent<PlayerHealth>();

        //Check if a player health script was found on the object collided with. 
        //This if statement is true if the player variable is NOT null (not empty).
        if (player != null)
        {
            //This means there WAS a PlayerHealth script attached to the object collided with.
            //This means this object is the player.

            //Therefore perform the action.
            SceneManager.LoadScene(winScreen);
        }
    }
}
