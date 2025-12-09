using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalAccess : MonoBehaviour
{
    public GameObject portal;
    public GameObject portalEffect;
    public GameObject item;

    private Scene currentScene;
    private int sceneIndex;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneIndex = currentScene.buildIndex;

        portalEffect.SetActive(false);
        portal.GetComponent<Collider>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        portalEffect.SetActive(true);
        portal.GetComponent<Collider>().enabled = true;

        if(sceneIndex == 2)
        {
            ItemManager.MeatballCollected = true;
        }
        else if(sceneIndex == 3)
        {
            ItemManager.SauceCollected = true;
        }
        else if(sceneIndex == 4)
        {
            ItemManager.NoodleCollected = true;
        }
        Debug.Log("Item Meatball" + ItemManager.MeatballCollected);
        Debug.Log("Item Sauce" + ItemManager.SauceCollected);
        Debug.Log("Item Noodle" + ItemManager.NoodleCollected);
        Destroy(item);
    }
}
