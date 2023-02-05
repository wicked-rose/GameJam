using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nutrients : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth = 100;
    public GameObject HealthBar;
    public bool useHealthBar = true;
    public bool star = false;
    [HideInInspector] public int index = 0;

    public SpriteRenderer sprite;
    private TrailRenderer trail;
    public Material redMaterial;
    public Material blueMaterial;
    public Material ogMaterial;

    public GameSceneManager SceneManager;

    void Start()
    {
        currentHealth = 100;
        trail = GetComponent<TrailRenderer>();
        //SceneManager = GetComponent<GameSceneManager>();
        SetUpHealth();
    }

    private void Update()
    {
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void SetUpHealth()
    {
        if (HealthBar)
        {
            HealthBar.GetComponent<Image>().type = Image.Type.Filled;
            HealthBar.GetComponent<Image>().fillMethod = (int)Image.FillMethod.Horizontal;
            HealthBar.GetComponent<Image>().fillOrigin = (int)Image.OriginHorizontal.Left;
            UpdateHealthBar();
        }
    }

    public void DecreaseHealth(int value)
    {
        currentHealth -= value;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
        UpdateHealthBar();
    }

    public void IncreaseHealth(int value)
    {
        currentHealth += value;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        Debug.Log(currentHealth);
        if (useHealthBar)
        {
            float fillAmount = (float)currentHealth / maxHealth;
            if (fillAmount > 1)
            {
                fillAmount = 1.0f;
            }

            HealthBar.GetComponent<Image>().fillAmount = fillAmount;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D thisCollision = GetComponent<Collider2D>();
        if (collision.otherCollider == thisCollision)
        {
            if (collision.gameObject.tag == "Obstacle" && !star)
            {
                DecreaseHealth(10);        
            }

            if (collision.gameObject.tag == "Nutrient")
            {
                IncreaseHealth(10);
                Destroy(collision.gameObject);           
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collider2D thisCollider = GetComponent<Collider2D>();
        if (collision.IsTouching(thisCollider))
        {
            if (collision.gameObject.tag == "Obstacle" && !star)
            {
                DecreaseHealth(10);
                StartCoroutine(FlashRed());
            }

            if (collision.gameObject.tag == "Nutrient")
            {
                IncreaseHealth(10);
                Destroy(collision.gameObject);
            }

            if (collision.gameObject.tag == "Item" && star == true)
            {
                StartCoroutine(FlashBlue());
            }
        }
    }

    public IEnumerator FlashRed()
    {
        sprite.color = Color.red;
        ChangeRedMaterial();

        yield return new WaitForSeconds(0.3f);

        sprite.color = Color.white;
        OGMaterial();
    }

    public IEnumerator FlashBlue()
    {
        sprite.color = Color.blue;
        ChangeBlueMaterial();

        yield return new WaitForSeconds(0.3f);

        sprite.color = Color.white;
        OGMaterial();
    }

    public void ChangeRedMaterial()
    {
        trail.material = redMaterial;
    }

    public void ChangeBlueMaterial()
    {
        trail.material = blueMaterial;
    }


    public void OGMaterial()
    {
        trail.material = ogMaterial;
    }

}
