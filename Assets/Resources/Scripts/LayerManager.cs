using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour {

    static public int blueLayer=10;
    static public int purpleLayer=11;

    static public LayerMask GetEnemyLayer(TEAM team)
    {
        LayerMask mask=0;
        switch (team)
        {
            case TEAM.Blue:
                mask = (1 << purpleLayer);
                break;

            case TEAM.Purple:
                mask = (1 << blueLayer);
                break;
        }
       return mask;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
