using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Attributes;

[RequireComponent(typeof(Renderer))]
public class Ice : MonoBehaviour
{
    [SerializeField]
    private Health health;
    private Renderer meshRenderer;
    [SerializeField]
    private Material ice1;
    [SerializeField]
    private Material ice2;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        meshRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health.GetHealthPoints() == 10)
        {
            meshRenderer.material = ice1;
        }
        else if(health.GetHealthPoints() == 5)
        {
            meshRenderer.material = ice2;
        }
    }
}
