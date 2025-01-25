using TMPro;
using UnityEngine;

public class Wave : MonoBehaviour
{    
    public EnemySpawner enemySpawner;
    public TextMeshProUGUI  waves;
    public int wavetime = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SummonWaves();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SummonWaves(){
        if(wavetime > 0){
        waves.text = "Next Wave Time : " + (wavetime--);
        }
         else if(wavetime <=0){
            wavetime = 30;
            enemySpawner.OrignCount += Random.Range(2, 5);
            enemySpawner.count = enemySpawner.OrignCount;
            enemySpawner.Spawner();
        }
        Invoke(nameof(SummonWaves), 1f);

    }
}
