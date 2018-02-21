using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
//David Soto y Kevin Macario

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {
    private VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        birdAnim.SetTrigger("sing");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);

    }

    // Update is called once per frame
    void Update () {
		
	}

}
