using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MLURLRotation : MonoBehaviour
{
    public GameObject hex;

    void Start()
    {
        hex = GetComponent<GameObject>();
    }

    public void OnMouseDown()
    {
        transform.Rotate(0, 0, 60);

        if (Mathf.Round(transform.rotation.eulerAngles.z) == 120)
        {
            transform.Rotate(0, 0, -120);
        }
        if (Mathf.Round(transform.rotation.eulerAngles.z) == 180)
        {
            transform.Rotate(0, 0, -120);
        }
    }
}

