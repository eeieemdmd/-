using UnityEngine;
using UnityEngine.UI;

public class ProtectiveBuildingsHP : MonoBehaviour
{
    public Slider hpSlider;
    public float maxHP = 100f;
    public float currentHP;

    void Start()
    {
        currentHP = maxHP;
        hpSlider.maxValue = maxHP;
        hpSlider.minValue = 0;
        UpdateHPBar();
    }

    private void Update()
    {
        // ���� ���� ���� Ȯ��
        if (hpSlider.value <= 0)
        {
            Debug.Log("GameOver");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy1"))
        {
            Debug.Log("������~~~~~~~~~!");
            currentHP -= 3f;  // HP ����
            currentHP = Mathf.Clamp(currentHP, 0, maxHP); 
            UpdateHPBar();  
            Destroy(other.gameObject); 
        }
    }

    void UpdateHPBar()
    {
        hpSlider.value = currentHP;  
    }
}
