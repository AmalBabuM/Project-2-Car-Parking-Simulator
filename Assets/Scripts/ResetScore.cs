using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    public SceneScore JJ;
    // Start is called before the first frame update
    void Start()
    {
        JJ.ResetNum();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
