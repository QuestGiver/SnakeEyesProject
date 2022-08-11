using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    [SerializeField] List<GameObject> toggledObjects = new List<GameObject>();


    public void Toggle()
    {
        foreach (GameObject item in toggledObjects)
        {
            if(item.activeInHierarchy)
            {
                item.SetActive(false);
            }
            else
            {
                item.SetActive(true);
            }
        }
    }
}
