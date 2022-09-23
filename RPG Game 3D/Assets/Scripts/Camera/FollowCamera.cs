using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GAME3D.Scripts.Camera{

public class FollowCamera : MonoBehaviour
{

    #region  Variables
   [SerializeField] private Transform _target;
   [SerializeField] private Vector3 _defaultDistance = new Vector3 (0f,2f,-10f);
    [SerializeField] private float _distanceDamp = 10f;
    [SerializeField] private float _rotationDamp = 10f;

    Transform myT;
    #endregion



    void Awake()
    {
        myT =transform;
    }


    void LateUpdate()
    {
        Vector3 toPos = _target.position + (_target.rotation * _defaultDistance);
        Vector3 curPos = Vector3.Lerp(myT.position, toPos, _distanceDamp * Time.deltaTime);
        myT.position = curPos;

        Quaternion toRot = Quaternion.LookRotation(_target.position - myT.position, _target.up);
        Quaternion curRot = Quaternion.Slerp(myT.rotation, toRot,_rotationDamp * Time.deltaTime);


    }
}
}