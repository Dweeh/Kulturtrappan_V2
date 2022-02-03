using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Make sure that image shader is UI/Unlit/Transparent 
// and that image is saved as a .png

public class MakeImageTransparent : MonoBehaviour
{
    [SerializeField]
    GameObject currentActiveImage;
    public GameObject slider;
    
    // public GameObject relocateButton;

    public float alpha = 1f;
    //Get current material
    private Material currentMat;

    // Start is called before the first frame update
    void Start()
    {
        
        //currentGameObject = gameObject;
        if (currentActiveImage != null)
        {
            currentMat = currentActiveImage.GetComponent<Renderer>().material;
        }

        slider.SetActive(false);
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);
    }


    public void ChangeAlphaOnValueChange(Slider slider)
    {
        ChangeAlpha(currentMat, slider.value);
        currentMat = currentActiveImage.GetComponent<Renderer>().material;
    }

    //Called from collidercube around imageViewPoint - VisibilityCube_ViewPoint_ON
    public void NewImageIsActive(GameObject theActiveImage)
    {
        slider.SetActive(true);
        currentActiveImage = theActiveImage;
        currentMat = currentActiveImage.GetComponent<Renderer>().material;
       // relocateButton.SetActive(false);
    }

    //Called from collidercube around imageViewPoint - VisibilityCube_ViewPoint_OFF
    public void ImageIsNotActive()
    {
        slider.SetActive(false);
       // relocateButton.SetActive(true);
    }
}
