using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private UIScreenRed screenUI;
    [SerializeField]
    private float maxHP = 20;
    private float currentHP;

    public float MaxHp => maxHP; //  최대 체력
    public float CurrentHP => currentHP; // 현재 체력

    private void Awake()
    {
        currentHP = maxHP; 
    }
    
    public void TakeDamage(float damage)
    {
        // 현재 체력을 damage만큼 감소
        currentHP -= damage;

        screenUI.OnHitAnimation();

        // 체력이 0이 되면 게임오버
        if (currentHP <= 0)
        {

        }
    }
}
