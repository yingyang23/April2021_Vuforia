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
        brainIcon.enabled = false;
    }

    public void OnRightLungFound()
    {
        rightLungIcon.enabled = false;
    }

    public void OnHeartFound()
    {
        heartIcon.enabled = false;
    }
}
