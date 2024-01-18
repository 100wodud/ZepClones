using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    public GameObject Player;  //A라는 GameObject변수 선언
    Transform AT;
    void Start()
    {
        AT = Player.transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(AT.position.x, AT.position.y, transform.position.z);
    }
}
