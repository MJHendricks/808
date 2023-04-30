using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject hex;

    void Start()
    {
        hex = GetComponent<GameObject>();
    }

    public void OnMouseDown()
    {
        transform.Rotate(0,0,60);
    }
}
