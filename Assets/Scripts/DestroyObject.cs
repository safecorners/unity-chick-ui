using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float deleteTime = 2.0f;
    void Start()
    {
        Destroy(this.gameObject, deleteTime);
    }
}
