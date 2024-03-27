using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cum_here : MonoBehaviour
{
    public GameObject grb;
    public GameObject hevanly_father;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grb.transform.position = Vector3.MoveTowards(grb.transform.position, hevanly_father.transform.position, speed);
    }
}
