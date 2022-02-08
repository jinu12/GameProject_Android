using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.InteractiveTutorials;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.Events;
using UnityEngine.UI;


public class MainStatus : MonoBehaviour
{
    public UnityEvent OnDeath;
    public UnityEvent OnRespawn;
    public float respawnDelay = 1;
    public UnityEvent Collision;

    GameController gameController;
    Animator animator;
    WaitForSeconds delay;
    new CapsuleCollider collider;

    [SerializeField] int maxHp; //최대 체력
    int currentHp; //현재 체력
    bool isInvicibleMode = false;

    [SerializeField] float blinkSpeed;
    [SerializeField] int blinkCount;

    [SerializeField] SkinnedMeshRenderer mesh_PlayerGraphics;
    [SerializeField] Image[] img_HpArray; //  체력 UI

    void Start()
    {
        currentHp = maxHp;
        UpdateHpStatus();
       
    }
    public void DecreaseHp(int _num)
    {
        if (!isInvicibleMode)
        {
            Collision.Invoke();
            StartCoroutine(BlinkCoroutine());
            Debug.Log("DecreaseHp");
            currentHp -= _num;
            UpdateHpStatus();
            if (currentHp <= 0)
            {
                Die();
                return;
            }
        }
    }
    

    public void UpdateHpStatus()
    {
        for (int i = 0; i < img_HpArray.Length; i++)
        {
            if (i < currentHp)
                img_HpArray[i].gameObject.SetActive(true);
            else
                img_HpArray[i].gameObject.SetActive(false);
        }
    }
    public void IncreaseHp(int _num)
    {
        if (currentHp == maxHp)
            return;

        currentHp += _num;
        if (currentHp > maxHp)
            currentHp = maxHp;

        UpdateHpStatus();
    }
    IEnumerator BlinkCoroutine()
    {
        isInvicibleMode = true;
        for (int i = 0; i < blinkCount * 2; i++)
        {
            mesh_PlayerGraphics.enabled = !mesh_PlayerGraphics.enabled;
            yield return new WaitForSeconds(blinkSpeed);
        }
        isInvicibleMode = false;
    }
  
    void Awake()
    {
        animator = GetComponent<Animator>();
        collider = GetComponent<CapsuleCollider>();
        delay = new WaitForSeconds(respawnDelay);
        gameController = FindObjectOfType<GameController>();
    }

    public void Die()
    {
        StartCoroutine(DieThenRespawn());
    }

    IEnumerator DieThenRespawn()
    {
        animator.SetBool("DeathTrigger", true);

        yield return delay;




        collider.height = 1.6f;



        gameController.RestartLevel();
    }
   
    
}

