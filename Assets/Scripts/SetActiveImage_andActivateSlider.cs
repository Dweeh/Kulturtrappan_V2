using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make sure that image shader is UI/Unlit/Transparent 
// and that image is saved as a .png

public class SetActiveImage_andActivateSlider : MonoBehaviour
{
    public MakeImageTransparent makeImageTransparent;
    public GameObject thisGameobject;


    public void SetActiveImageandActivateSlider()
    {
        makeImageTransparent.NewImageIsActive(thisGameobject);
    }

    public void DeactivateSlider()
    {
        makeImageTransparent.ImageIsNotActive();
    }

    // Start is called before the first frame update
    void Start()
    {
        thisGameobject = this.gameObject;
    }

}
