using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomUi : MonoBehaviour
{
    public GameObject StartPannel;
    public GameObject SelectPannel;
    public GameObject NamePannel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickNameSelect()
    {
        StartPannel.SetActive(true);
        NamePannel.SetActive(true );
        SelectPannel.SetActive(false);
    }
    public void ClickCharSelect()
    {
        StartPannel.SetActive(true);
        NamePannel.SetActive(false);
        SelectPannel.SetActive(true);
    }
}
