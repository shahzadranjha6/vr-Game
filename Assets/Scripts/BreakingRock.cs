using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingRock : MonoBehaviour
{
    public List<GameObject> Breakable;
    public float timeToBreak = 2;
    public float timer = 0;

    void Start()
    {
        foreach(var obj in Breakable)
        {
            obj.SetActive(false);
        }   
    }

    public void Break()
    {
        timer += Time.deltaTime;
        if(timer > timeToBreak)
        {
            foreach (var obj in Breakable)
            {
                obj.SetActive(true);
                obj.transform.parent = null;
            }
            gameObject.SetActive(false);
        }
    }
}
