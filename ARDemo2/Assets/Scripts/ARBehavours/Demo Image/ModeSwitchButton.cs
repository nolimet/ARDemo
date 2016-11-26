using UnityEngine;
using System.Collections;

public class ModeSwitchButton : MonoBehaviour {
    public GameObject[] objects;
    int current;
    int count;
    
    public void Start()
    {
        count = objects.Length;
        current = 0;

        foreach(GameObject g in objects)
        {
            g.SetActive(false);
        }

        objects[current].SetActive(true);
    }

    public void Pressed()
    {
        objects[current].SetActive(false);
        current++;
        if (current >= count)
        {
            current = 0;
        }
        objects[current].SetActive(true);
    }
}
