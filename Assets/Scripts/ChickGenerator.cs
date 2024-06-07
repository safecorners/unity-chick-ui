using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickGenerator : MonoBehaviour
{
    public GameObject chickPrefab;
    public float interval = 1.0f;
    
    void Start()
    {
        InvokeRepeating(nameof(GenerateChick), 0.1f, interval);   
    }

    void GenerateChick()
    {
        Instantiate(chickPrefab, transform.position, transform.rotation);
    }
}
