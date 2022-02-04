using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFade : MonoBehaviour
{

    // the image you want to fade, assign in inspector
    //public Image img;
    public Material currentMat;
    public GameObject objectToFade;

    private void Start()
    {
        currentMat = objectToFade.GetComponent<Renderer>().material;
        StartCoroutine(FadeImageOut());
    }

    public void FadeCirclesInAndOut()
    {
        // fades the image out when you click
        StartCoroutine(FadeImageInAndOut());
    }

    IEnumerator FadeImageInAndOut()
    {
        // fade from transparent to opaque
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                currentMat.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from opaque to transparent
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                currentMat.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }

    }

    IEnumerator FadeImageOut()
    {
        // fade from opaque to transparent
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                currentMat.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }

    }
}
