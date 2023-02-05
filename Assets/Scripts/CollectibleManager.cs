using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleManager : MonoBehaviour
{
    [SerializeField] private Text Gems;
    [SerializeField] private Text Meters;
    [SerializeField] private int collected = 0;

    private float dist = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist += Time.deltaTime;
        Gems.text = collected.ToString();
        Meters.text = "Meters: " + dist.ToString("n2");
    }

    public void Collected(int value)
    {
        collected += value;
    }

}
