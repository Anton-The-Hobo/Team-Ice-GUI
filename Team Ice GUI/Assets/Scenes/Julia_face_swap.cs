using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Julia_face_swap : MonoBehaviour
{
    public Sprite happy;
    public Sprite puss;

    public void Happy()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = happy;
    }

    public void Puss()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = puss;
    }
}   
