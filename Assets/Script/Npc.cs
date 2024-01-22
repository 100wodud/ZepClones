using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public GameObject Npc1;
    public GameObject NpcPannel;
    public GameObject Player;
    public GameObject Portal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == Player && gameObject == Npc1)
        {
            NpcPannel.SetActive(true);
        } else if(gameObject == Portal)
        {
            Vector3 position = Player.transform.localPosition;
            position.x = 0;
            position.y = 0;
            Player.transform.localPosition = position;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == Player && gameObject == Npc1)
        {
            NpcPannel.SetActive(false);
        }
        else if (gameObject == Portal)
        {
            Debug.Log("portal");
        }
    }
}
