using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kim_Face_Swap : MonoBehaviour
{
    public Sprite Happy;
    public Sprite Angry;

    public void happy()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Happy;
    }
    public void angry()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Angry;
    }
        
}
