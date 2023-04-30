using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Operations : MonoBehaviour
{
    public GameObject[] hexes;
    public GameObject[] solution;

    public float[] angles;
    private bool[] test;

    public Animator anim;

    void Start()
    {
        test = new bool[angles.Length];
    }


    void Update()
    {
        for (int i = 0; i < hexes.Length; i++)
        {
            if (Mathf.Round(hexes[i].transform.rotation.eulerAngles.z) == angles[i])
            {
                test[i] = true;
            }
            else
            {
                test[i] = false;
            }
        }
        if (CheckIfAllTrue())
        {
            for (int x = 0; x < hexes.Length; x++)
            {
                hexes[x].SetActive(false);
                solution[x].SetActive(true);
                anim.Play("ReverseTilt");
            }
            StartCoroutine(NextScene());
        }
    }

    public bool CheckIfAllTrue()
    {
        for (int j = 0; j < test.Length; j++)
        {
            if (test[j] == false)
            {
                return false;
            }
        }
        return true;
    }

    private IEnumerator NextScene()
    {
        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
