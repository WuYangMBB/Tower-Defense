using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TEAM
{
    Blue,Purple
}

public class Unit : MonoBehaviour {
    
    public int hp;
    public GameObject deadEffect;
    public TEAM team;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void ApplyDamage(int damage)
    {
        if (hp > damage)
        {
            hp -= damage;
        }
        else
        {
            Destruct();
        }
    }

    public void Destruct()
    {
        if (deadEffect != null)
        {
            Instantiate(deadEffect,transform.position,transform.rotation);
        }
        Destroy(gameObject);
    }

}
