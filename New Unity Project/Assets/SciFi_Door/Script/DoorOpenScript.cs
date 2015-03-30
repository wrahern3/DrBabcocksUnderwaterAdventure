using UnityEngine;
using System.Collections;

public class DoorOpenScript : MonoBehaviour {

    Animation anim;
    bool isOpen;
    bool isNear;
    
    // Use this for initialization
	void Start () {
        var parent = transform.parent;
        var parentDoor = parent.FindChild("door");
        anim = parentDoor.GetComponent<Animation>();
        isOpen = false;
        isNear = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (!anim.isPlaying)
        {
            if (isOpen && !isNear)
            {
                anim.Play("close");
                isOpen = false;
            }
            else if (!isOpen && isNear)
            {
                anim.Play("open");
                isOpen = true;
            }
        }
	}

    void OnTriggerEnter () 
    {
        isNear = true;
    }

    void OnTriggerExit()
    {
        isNear = false;
    }
}