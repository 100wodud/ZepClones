using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

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
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        armRenderer.flipY = Mathf.Abs(rotZ) > 90f;
        string myChar = GameManager.I.SelectChar();
        if (myChar == "selectChar1")
        {
            characterRenderer1.flipX = armRenderer.flipY;
        } else
        {
            characterRenderer2.flipX = armRenderer.flipY;
        }
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}