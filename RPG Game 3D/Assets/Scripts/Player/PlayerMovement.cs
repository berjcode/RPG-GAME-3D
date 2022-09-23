using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GAME3D.Scripts.PlayerMovement{
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 10f;
    [SerializeField] private float _turnSpeed= 30f;


    #region  Movement Variables 
    private float _horizontal;
    private float _vertical;
    private float _Pitch;
    private float _Roll;

    Transform myT;
    #endregion

    void Awake()
    {
        myT=transform;
    }
    void Update()
    {   
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        _Pitch = Input.GetAxis("Pitch");
        _Roll = Input.GetAxis("Roll");
        Turn();
       Thrust();
    }


    void Turn()
    {
        float  _yaw= _turnSpeed * Time.deltaTime * _horizontal;
        float  _pitch= _turnSpeed * Time.deltaTime * _Pitch;
        float  _roll= _turnSpeed * Time.deltaTime * _Roll;
        myT.Rotate(-_pitch,_yaw,-_roll);
    }

    void Thrust()
    {
        if(Input.GetAxis("Vertical")> 0)
            myT.position+= myT.forward*_movementSpeed*Time.deltaTime* _vertical;
    }
   
}
}