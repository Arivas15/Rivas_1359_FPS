using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class States : MonoBehaviour
{
    public static States record;
    public int score = 0;

    public static States health;
    public int hp = 4;

    public static States magazine;
    public int ammo = 10;

    [SerializeField]
    Image hpBar;

    [SerializeField]
    Image ammoBar;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHUD();

        if (record == null)
        {
            record = this;
        }
        if (record != this)
            Destroy(gameObject);

        if (health == null)
        {
            health = this;
        }
        if (health != this)
            Destroy(gameObject);

        if (magazine == null)
        {
            magazine = this;
        }
        if (magazine != this)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHUD();
    }
    void UpdateHUD()
    {
        hpBar.fillAmount = (float)hp / 4;
        ammoBar.fillAmount = (float)ammo / 10;
    }
}