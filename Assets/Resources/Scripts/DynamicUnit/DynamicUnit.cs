using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicUnit : Unit {

    public float moveSpeed;
    public float rotateSpeed;
    public float enemySearchRange;
    public float attackRange;
    public float attackCoolDown;
    public int damage;
    public Unit attackTarget;
    public GameObject target;

    // Use this for initialization
    void Start () {
//        SearchEnemy();
    }
	
	// Update is called once per frame
	void Update () {

	}

/*    public void SearchEnemy()
    {
        transform.LookAt(target);
    }
*/
    public void Advance()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }


}
