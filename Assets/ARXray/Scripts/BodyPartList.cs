using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BodyPartList : MonoBehaviour
{

    public Image brainIcon;
    public Image rightLungIcon;
    public Image heartIcon;

    public void OnBrainFound()
    {
        //brainIcon.enabled = false;
        brainIcon.color = new Color(1, 1, 1, 0.3f);
    }

    public void OnRightLungFound()
    {
        //rightLungIcon.enabled = false;
        rightLungIcon.color = new Color(1, 1, 1, 0.3f);
    }

    public void OnHeartFound()
    {
        //heartIcon.enabled = false;
        heartIcon.color = new Color(1, 1, 1, 0.3f);
    }
}
