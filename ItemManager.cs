using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemManager : MonoBehaviour
{
    private static ItemManager _instance;

    public static ItemManager Instance { get { return _instance; } }

    public static bool MeatballCollected { get { return Instance._meatballCollected; } set { Instance._meatballCollected = value; } }
    public static bool SauceCollected { get { return Instance._sauceCollected; } set { Instance._sauceCollected = value; } }
    public static bool NoodleCollected { get { return Instance._noodleCollected; } set { Instance._noodleCollected = value; } }

    private bool _meatballCollected;
    private bool _sauceCollected;
    private bool _noodleCollected;

    [SerializeField]
    private GameObject gate;
    
    void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
