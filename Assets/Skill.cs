using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
    public GameObject skillEffect;
    public float cooldown;
    public float counter;
    public bool skillReady;
    public Image cooldownImage;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < cooldown && skillReady == false)
        {
            counter += Time.deltaTime;
        }
        else
        {
            skillReady = true;
            counter = 0;
        }

        cooldownImage.fillAmount = counter / cooldown;

    }

    public void UseSkill()
    {
        if (skillReady == true)
        {
            GameObject skillEffectInstance = Instantiate(skillEffect, player.transform.position, Quaternion.identity);
            Destroy(skillEffectInstance, 5);
            counter = 0;
            skillReady = false;
        }
    }

}
