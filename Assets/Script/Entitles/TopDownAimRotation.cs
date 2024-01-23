using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private Transform charTrans;

    [SerializeField] private SpriteRenderer characterRenderer1;
    [SerializeField] private SpriteRenderer characterRenderer2;

    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();    
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateChar(newAimDirection);
    }

    private void RotateChar(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        string myChar = GameManager.I.SelectChar();
        if (myChar == "selectChar1")
        {
            if(rotZ < 90 && rotZ > -90)
            {
                characterRenderer1.flipX = false;
            } else
            {
                characterRenderer1.flipX = true;
            }
        } else
        {
            if (rotZ < 90 && rotZ > -90)
            {
                characterRenderer2.flipX = false;
            }
            else
            {
                characterRenderer2.flipX = true;
            }
        }
    }
}