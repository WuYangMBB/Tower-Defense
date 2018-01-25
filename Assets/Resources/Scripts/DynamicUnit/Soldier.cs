using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : DynamicUnit
{
    private float timer;

    void Start () {
        target = FindClosestEnemy();
        attackTarget = target.GetComponent<Unit>();
        transform.LookAt(target.GetComponent<Transform>());
    }

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (target == null || attackTarget == null)
        {
            target = FindClosestEnemy();
            attackTarget = target.GetComponent<Unit>();
            transform.LookAt(target.GetComponent<Transform>());
        }
        float dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist>attackRange)
        {
            Advance();
        }
        else
        {
            if (timer >= attackCoolDown)
            {
                Attack();
                timer = 0;
            }
        }
    }

    public GameObject FindClosestEnemy()
    {
        string enemyTag;
        if (team == TEAM.Blue)
        {
            enemyTag = "Purple";
        }
        else
        {
            enemyTag = "Blue";
        }
        GameObject closest = GameObject.FindWithTag(enemyTag);
        if (GameObject.FindGameObjectsWithTag(enemyTag) != null)
        {
            GameObject[] gos;
            gos = GameObject.FindGameObjectsWithTag(enemyTag);
            var distance = Mathf.Infinity;
            var position = transform.position;
            foreach (GameObject go in gos)
            {
                var diff = (go.transform.position - position); //计算player与Enemy的向量距离差
                var curDistance = diff.sqrMagnitude; //将向量距离平方（防止有负数产生）
                if (curDistance < distance)
                { //找出最近距离 
                    closest = go; //更新最近距离敌人 
                    distance = curDistance; //更新最近距离
                }
            }
        }
        return closest;
    }

    public void Attack()
    {
        if (attackTarget != null)
        {
            attackTarget.ApplyDamage(damage);
        }
    }
}
