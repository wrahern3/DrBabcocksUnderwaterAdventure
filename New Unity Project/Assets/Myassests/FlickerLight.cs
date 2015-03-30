using UnityEngine;
using System.Collections;


public class FlickerLight : MonoBehaviour {

    private Light theLight;
    float lightChange;
    //private Light defaultLight;
    
    // Use this for initialization
	void Start () {
        theLight = this.GetComponent<Light>();
        //defaultLight = this.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

        lightChange = Random.value;

        if ((lightChange * 10) % 2 > 1)
            theLight.intensity += lightChange;
        else
            theLight.intensity -= lightChange;
	}
}
