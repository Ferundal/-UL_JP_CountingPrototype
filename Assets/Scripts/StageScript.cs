using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool skipFirst = transform.childCount > 4;
        GameObject[] portions = new GameObject[skipFirst ? transform.childCount - 1 : transform.childCount];
        for (int i = 0; i < portions.Length; i++)
        {
            portions[i] = transform.GetChild(skipFirst ? i + 1 : i).gameObject;
        }
        int stage = Random.Range(0, portions.Length);
        for (int i = 0; i < portions.Length; i++)
        {
            if (i == stage)
            {
                portions[i].SetActive(true);
            }
            else
            {
                portions[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
