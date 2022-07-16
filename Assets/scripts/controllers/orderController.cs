
using UnityEngine;
using UnityEngine.UI;

public class orderController : MonoBehaviour
{

    [Header("ORDER DATA")]
    public int orderSlot;
    public int itemsInOrder;
    public string[] family;
    public int[] tier;
    public int price;
    // TIME
    public bool isTimeOrder;
    public bool isSpecialOrder;
    public int refreshTime;
    public int rewardMultiplier;
    public int timeLeft;

    [Header("OBJECTS")]
    public GameObject[] orderItems;
    public Image[] itemImage;
    public Sprite[] imageLoaded;
    public Text priceText;
    public GameObject orderUi;

    [Header("AVAILABILITY")]
    public GameObject[] readyImage;
    public bool isReady;
    public GameObject readyFeedback;
    public bool[] itemIsAvailable;
    public GameObject[] itemsToSell;
    public Image backgroundImage;
    public Color[] backgroundColors;


    saveManager saveManager;

    void Start()
    {
        saveManager = GameObject.Find("gameProperties").GetComponent<saveManager>();
        Debug.LogWarning("Start");
        StartingOrder();
    }

    
    public void StartingOrder()
    {
        //Debug.Log("Checking " + gameObject.name);
        if (saveManager.GetSavedInt(gameObject.name + "isUnlocked") >0)
        {
            //Debug.Log(gameObject.name+" is unlocked");
            itemsInOrder = saveManager.GetSavedInt(gameObject.name + "_itemCount");
            family[0] = saveManager.GetSavedString(gameObject.name + "_family_0");
            family[1] = saveManager.GetSavedString(gameObject.name + "_family_1");
            tier[0] = saveManager.GetSavedInt(gameObject.name + "_tier_0");
            tier[1] = saveManager.GetSavedInt(gameObject.name + "_tier_1");
            price = saveManager.GetSavedInt(gameObject.name + "_price");
            InitiateOrder(itemsInOrder, family, tier, price);
        }
    }
    

    public void InitiateOrder(int itemCount, string[] m_family, int[] m_tier, int m_price)
    {

       // Debug.Log("Initiating order, item count: " + itemCount);

        ///// SET ACTIVE
        orderUi.SetActive(true);


        ///////////////////////    START ANIMATION
        if (GetComponent<Animation>())
        {
            GetComponent<Animation>().Stop("order_spawn");
            GetComponent<Animation>().Play("order_spawn");
        }


        ///////////////////////    PRICE
        price = m_price;

        ///////////////////////    HOW MANY ITEMS
        itemsInOrder = itemCount;
        for (int i=0; i < 2; i++)
        {
            orderItems[i].SetActive(false);
            if(i< itemCount)
                orderItems[i].SetActive(true);
        }

        ///////////////////////    UPDATE VALUES
        for (int i = 0; i < itemCount; i++)
        {
            family[i] = m_family[i];
            tier[i] = m_tier[i];


            ///////////////////////    ICONS
            Debug.Log("UI/icons/items/" + family[i] + "_" + tier[i].ToString());
            imageLoaded[i] = Resources.Load<Sprite>("UI/icons/items/" + family[i] + "_" + tier[i].ToString());
            itemImage[i].sprite = imageLoaded[i];

        ///////////////////////    PRICE TEXT
            priceText.text = price.ToString();

        }

    }
    /*
    public void UnlockOrder()
    {
        PlayerPrefs.SetInt(gameObject.name + "isUnlocked", 1);
    }
    */

    public void Update()
    {
        
        if (isReady)
        {
            backgroundImage.color = backgroundColors[0];
            readyFeedback.GetComponent<Animation>().Play("a_order_ready");
            readyFeedback.SetActive(true);
        }
        else
        {
            backgroundImage.color = backgroundColors[1];
            readyFeedback.SetActive(false);
        }
    }

}
