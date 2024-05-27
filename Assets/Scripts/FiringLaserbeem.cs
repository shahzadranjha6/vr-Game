using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class FiringLaserbeem : MonoBehaviour
{

    public ParticleSystem LaserBeam;
    public LayerMask layer;
    public Transform ShootSource;
    public float Distance = 10;
    //public GameObject Enemy;

    public bool LaserIsActive = false;

    void Start()
    {
        XRGrabInteractable GrabInteractable = GetComponent<XRGrabInteractable>();
        GrabInteractable.activated.AddListener(x => FiringBeam());
        GrabInteractable.deactivated.AddListener(x => StopFiringBeam());
    }
    public void FiringBeam()
    {
        LaserBeam.Play();
        LaserIsActive = true;
    }
    public void StopFiringBeam()
    {
        LaserBeam.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        LaserIsActive=false;
    }

    void Raycast()
    {
        RaycastHit hit;

        bool hashit = Physics.Raycast(ShootSource.position, ShootSource.forward,out hit, Distance,layer);
        
        if (hashit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
            //Enemy.SetActive(false);
        }
    }
  
    void Update()
    {
        if(LaserIsActive)
        {
            Raycast();
        }
        
    }
}
