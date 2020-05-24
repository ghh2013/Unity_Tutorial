using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test17 : MonoBehaviour
{
    
    [SerializeField] private GameObject go_BulletPrefab;

    private float createTime = 1f;
    private float currentCreateTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCreateTime += Time.deltaTime;
        

        if(currentCreateTime >= createTime)
        {
            currentCreateTime = 0f;
            RaycastHit hitInfo;

            if (Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, 10f))
            {

                if (hitInfo.transform.tag == "Player")
                {
                    Instantiate(go_BulletPrefab, transform.position, Quaternion.LookRotation(hitInfo.transform.position - transform.position));
                }
            }
        }

        
    }
}
