using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    private GameObject gate;
    
    public void DestroyGate()
    {
        Destroy(gate);
    }
}
