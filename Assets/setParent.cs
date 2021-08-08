using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setParent : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform Parent;
    void Awake()
    {
        this.transform.SetParent(Parent);
    }
}
