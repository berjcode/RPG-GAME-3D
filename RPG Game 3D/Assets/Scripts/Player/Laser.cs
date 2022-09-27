using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GAME3D.Scripts.PlayerLaser{
    [RequireComponent(typeof(LineRenderer))]
public class Laser : MonoBehaviour
{
    [SerializeField] private  float laserOffTime = 5f;
   // [SerializeField] private  float maxDistance = 300f;
    [SerializeField] private bool canFire;
    [SerializeField] private LineRenderer lr;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Start()
    {
        lr.enabled = false;
    }
/*
    void Update()
    {
        FireLaser(transform.forward* maxDistance );
    }
*/
    public void FireLaser(Vector3 targetPosition )
    {
        if(canFire)
        {
        lr.SetPosition(0,transform.position);
        lr.SetPosition(1,targetPosition);
         lr.enabled = true;
         canFire = false;
        }
       
       
        Invoke ("TurnOffLaser", laserOffTime);
    }

    void TurnOffLaser()
    {
        lr.enabled = false;
        canFire = true;
    }


}
}