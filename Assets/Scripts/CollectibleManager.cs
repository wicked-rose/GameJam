using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleManager : MonoBehaviour
{
    [SerializeField] private Text Gems;
    [SerializeField] private int collected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gems.text = "Gems " + collected;
    }

    public void Collected(int value)
    {
        collected += value;
    }

}
