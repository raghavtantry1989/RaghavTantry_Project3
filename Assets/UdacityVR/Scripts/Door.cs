using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	bool locked = true;
	bool opening = false;
	public GameObject doorToOpen;

	public AudioSource audioSource;
	public AudioClip doorLocked;
	public AudioClip doorOpened;

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		if(opening){
			transform.Translate (0, 2.3f * Time.deltaTime, 0, Space.World);
		}
    }

	public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
		if (locked) {
			//Nothing
			audioSource.clip = doorLocked;
		} else {
			opening = true;
			audioSource.clip = doorOpened;
		}
		audioSource.Play ();
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
