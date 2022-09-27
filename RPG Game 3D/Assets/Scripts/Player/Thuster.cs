using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAME3D.Scripts.Thuster{

    [RequireComponent(typeof(Light))]
public class Thuster : MonoBehaviour
{
  
   private Light thrusterLight;


   void Awake()
   {
   
    thrusterLight = GetComponent <Light>();
   }

    void Start()
    {  
        thrusterLight.enabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Activate();
        }else if (Input.GetKeyUp(KeyCode.W))
        {
        Activate(false);
        }
    }
   public void Activate(bool activate =true )
    {
        if(activate)
        {
          
            thrusterLight.enabled = true;

        }else
        {
            
            thrusterLight.enabled = false;
        }
    }
    }
}