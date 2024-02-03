using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourcesManager : MonoBehaviour
{
    public int goldAmount;
    public TMP_Text goldDisplay;
    public int woodAmount;
    public TMP_Text woodDisplay;

    // Start is called before the first frame update
    void Start()
    {
        goldAmount = 0;
        woodAmount  = 0;
        goldDisplay.text = goldAmount.ToString();
        woodDisplay.text = woodAmount.ToString();
    }
}