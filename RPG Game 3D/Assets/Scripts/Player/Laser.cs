using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GAME3D.Scripts.PlayerLaser{
    [RequireComponent(typeof(LineRenderer))]
public class Laser : MonoBehaviour
{
    

   
    [SerializeField] private LineRenderer lr;
    
 public Transform target;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
       
    }
    void Start()
    {
        lr.enabled = false;
    }

    void Update()
    {
       
       
       if(Input.GetKey(KeyCode.Space))
       {
         transform.position = target.position;
       lr.enabled = true;
       }else
       {
        lr.enabled = false;
       }
    }

   

}
}