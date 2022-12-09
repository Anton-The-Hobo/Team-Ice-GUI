using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMan : MonoBehaviour
{
    public Sprite cool;
    public Sprite green;

    public void Cool()
    {
    this.gameObject.GetComponent<SpriteRenderer>().sprite = cool;
    }

public void Green()
{
    this.gameObject.GetComponent<SpriteRenderer>().sprite = green;
}

}
