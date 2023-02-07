using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //5行ごとに敵を生成するために
    IEnumerator SpawnRoutine() 
    {
        //yield return null; // 1フレームまつ

        //yield return new WaitForSeconds(5.0f);

        while(true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8f, 8f), 7 , 0);
            Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
