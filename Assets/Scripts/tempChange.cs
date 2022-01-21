using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class tempChange : MonoBehaviour
{
    public TextMeshPro c1;
    private void Start() {
        c1.GetComponent<TextMeshPro>();
    }
    public void changeTemp()
    {
        c1.text = "612 °C";
        c1.color = new Color(255, 0, 0);
    }
}
