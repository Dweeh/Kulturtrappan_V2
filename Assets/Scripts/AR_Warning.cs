using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Warning : MonoBehaviour
{
    public GameObject warningObject;

    private void Start()
    {
        warningObject.SetActive(true);
    }

    public void CloseWarning()
    {
        warningObject.SetActive(false);
    }
}
