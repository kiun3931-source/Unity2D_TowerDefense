using UnityEngine;
using UnityEngine.UI;

public class EnemyHPViewer : MonoBehaviour
{
    private Enemy_HP enemyHP;
    private Slider slider;

    public void Setup(Enemy_HP enemyHP)
    {
        slider = GetComponent<Slider>();   
        this.enemyHP = enemyHP;
    }

    private void Update()
    {
        slider.value = enemyHP.CurrentHP / enemyHP.MaxHP;
    }
}
