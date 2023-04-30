using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ULURotation : MonoBehaviour
{
    public GameObject hex;

    void Start()
    {
        hex = GetComponent<GameObject>();
    }

    public void OnMouseDown()
    {
        transform.Rotate(0, 0, 60);

        if (Mathf.Round(transform.rotation.eulerAngles.z) == 210)
        {
            transform.Rotate(0, 0, 180);
        }
    }
}
