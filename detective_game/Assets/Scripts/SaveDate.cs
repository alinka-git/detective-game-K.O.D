using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveDate : MonoBehaviour
{
    public static SaveDate Instance; // Статическая ссылка на экземпляр скрип
    public static SaveDate Instance1;
    public static SaveDate Instance2;
    public static SaveDate Instance3;
    public static SaveDate Instance4;
    public static SaveDate Instance5;
    public static SaveDate Instance6;
    public static SaveDate Instance7;
    public static SaveDate Instance8;
    public static SaveDate Instance9;
    public static SaveDate Instance10;
    public static SaveDate Instance11;
    public static SaveDate Instance12;
    public static SaveDate Instance13;
    public static SaveDate Instance14;
    public static SaveDate Instance15;
    public static SaveDate Instance16;
    public static SaveDate Instance17;
    public static SaveDate Instance18;
    public static SaveDate Instance19;
    public static SaveDate Instance20;
    [SerializeField] InputField Key1;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Не уничтожать объект при загрузке новой сцены
        }
        else
        {
            Destroy(gameObject); // Уничтожить дублирующийся объект
        }
    }
    void Start()
    {
        if (PlayerPrefs.HasKey("SavedData"))
        {
            string savedData = PlayerPrefs.GetString("SavedData");
            Key1.text = savedData;
        }

        if (PlayerPrefs.HasKey("SavedData1"))
        {
            string savedData1 = PlayerPrefs.GetString("SavedData1");
            Key2.text = savedData1;
        }

        if (PlayerPrefs.HasKey("SavedData2"))
        {
            string savedData2 = PlayerPrefs.GetString("SavedData2");
            Key3.text = savedData2;
        }
        if (PlayerPrefs.HasKey("SavedData3"))
        {
            string savedData3 = PlayerPrefs.GetString("SavedData3");
            Key4.text = savedData3;
        }
        if (PlayerPrefs.HasKey("SavedData4"))
        {
            string savedData4 = PlayerPrefs.GetString("SavedData4");
            Key5.text = savedData4;
        }
        if (PlayerPrefs.HasKey("SavedData5"))
        {
            string savedData5 = PlayerPrefs.GetString("SavedData5");
            Key6.text = savedData5;
        }
        if (PlayerPrefs.HasKey("SavedData6"))
        {
            string savedData6 = PlayerPrefs.GetString("SavedData6");
            Key7.text = savedData6;
        }
        if (PlayerPrefs.HasKey("SavedData7"))
        {
            string savedData7 = PlayerPrefs.GetString("SavedData7");
            Key8.text = savedData7;
        }
        if (PlayerPrefs.HasKey("SavedData8"))
        {
            string savedData8 = PlayerPrefs.GetString("SavedData8");
            Key9.text = savedData8;
        }
        if (PlayerPrefs.HasKey("SavedData9"))
        {
            string savedData9 = PlayerPrefs.GetString("SavedData9");
            Key10.text = savedData9;
        }
        if (PlayerPrefs.HasKey("SavedData10"))
        {
            string savedData10 = PlayerPrefs.GetString("SavedData10");
            Key11.text = savedData10;
        }
        if (PlayerPrefs.HasKey("SavedData11"))
        {
            string savedData11 = PlayerPrefs.GetString("SavedData11");
            Key12.text = savedData11;
        }
        if (PlayerPrefs.HasKey("SavedData12"))
        {
            string savedData12 = PlayerPrefs.GetString("SavedData12");
            Key13.text = savedData12;
        }
        if (PlayerPrefs.HasKey("SavedData13"))
        {
            string savedData13 = PlayerPrefs.GetString("SavedData13");
            Key14.text = savedData13;
        }
        if (PlayerPrefs.HasKey("SavedData14"))
        {
            string savedData14 = PlayerPrefs.GetString("SavedData14");
            Key15.text = savedData14;
        }
        if (PlayerPrefs.HasKey("SavedData15"))
        {
            string savedData15 = PlayerPrefs.GetString("SavedData15");
            Key16.text = savedData15;
        }
        if (PlayerPrefs.HasKey("SavedData16"))
        {
            string savedData16 = PlayerPrefs.GetString("SavedData16");
            Key17.text = savedData16;
        }
        if (PlayerPrefs.HasKey("SavedData17"))
        {
            string savedData17 = PlayerPrefs.GetString("SavedData17");
            Key18.text = savedData17;
        }
        if (PlayerPrefs.HasKey("SavedData18"))
        {
            string savedData18 = PlayerPrefs.GetString("SavedData18");
            Key19.text = savedData18;
        }
        if (PlayerPrefs.HasKey("SavedData19"))
        {
            string savedData19 = PlayerPrefs.GetString("SavedData19");
            Key20.text = savedData19;
        }
        if (PlayerPrefs.HasKey("SavedData20"))
        {
            string savedData20 = PlayerPrefs.GetString("SavedData20");
            Key12.text = savedData20;
        }
    }
    public void DataSave()
    {
        string dataToSave = Key1.text;
        PlayerPrefs.SetString("SavedData", dataToSave);
        PlayerPrefs.Save();
    }
    public void LoadData()
    {
        if (PlayerPrefs.HasKey("SavedData"))
        {
            string savedData = PlayerPrefs.GetString("SavedData");
            Key1.text = savedData;
        }
    }
    [SerializeField] InputField Key2;
    void Awake1()
    {
        if (Instance1 == null)
        {
            Instance1 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave1()
    {
        string dataToSave1 = Key2.text;
        PlayerPrefs.SetString("SavedData1", dataToSave1);
        PlayerPrefs.Save();
    }
    public void LoadData1()
    {
        if (PlayerPrefs.HasKey("SavedData1"))
        {
            string savedData1 = PlayerPrefs.GetString("SavedData1");
            Key2.text = savedData1;
        }
    }
    [SerializeField] InputField Key3;
    void Awake2()
    {
        if (Instance2 == null)
        {
            Instance2 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave2()
    {
        string dataToSave2 = Key3.text;
        PlayerPrefs.SetString("SavedData2", dataToSave2);
        PlayerPrefs.Save();
    }
    public void LoadData2()
    {
        if (PlayerPrefs.HasKey("SavedData2"))
        {
            string savedData2 = PlayerPrefs.GetString("SavedData2");
            Key3.text = savedData2;
        }
    }
    [SerializeField] InputField Key4;
    void Awake3()
    {
        if (Instance3 == null)
        {
            Instance3 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave3()
    {
        string dataToSave3 = Key4.text;
        PlayerPrefs.SetString("SavedData3", dataToSave3);
        PlayerPrefs.Save();
    }
    public void LoadData3()
    {
        if (PlayerPrefs.HasKey("SavedData3"))
        {
            string savedData3 = PlayerPrefs.GetString("SavedData3");
            Key4.text = savedData3;
        }
    }
    [SerializeField] InputField Key5;
    void Awake4()
    {
        if (Instance4 == null)
        {
            Instance4 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave4()
    {
        string dataToSave4 = Key5.text;
        PlayerPrefs.SetString("SavedData4", dataToSave4);
        PlayerPrefs.Save();
    }
    public void LoadData4()
    {
        if (PlayerPrefs.HasKey("SavedData4"))
        {
            string savedData4 = PlayerPrefs.GetString("SavedData4");
            Key5.text = savedData4;
        }
    }
    [SerializeField] InputField Key6;
    void Awake5()
    {
        if (Instance5 == null)
        {
            Instance5 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave5()
    {
        string dataToSave5 = Key6.text;
        PlayerPrefs.SetString("SavedData5", dataToSave5);
        PlayerPrefs.Save();
    }
    public void LoadData5()
    {
        if (PlayerPrefs.HasKey("SavedData5"))
        {
            string savedData5 = PlayerPrefs.GetString("SavedData5");
            Key6.text = savedData5;
        }
    }
    [SerializeField] InputField Key7;
    void Awake6()
    {
        if (Instance6 == null)
        {
            Instance6 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave6()
    {
        string dataToSave6 = Key7.text;
        PlayerPrefs.SetString("SavedData6", dataToSave6);
        PlayerPrefs.Save();
    }
    public void LoadData6()
    {
        if (PlayerPrefs.HasKey("SavedData6"))
        {
            string savedData6 = PlayerPrefs.GetString("SavedData6");
            Key7.text = savedData6;
        }
    }
    [SerializeField] InputField Key8;
    void Awake7()
    {
        if (Instance7 == null)
        {
            Instance7 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave7()
    {
        string dataToSave7 = Key8.text;
        PlayerPrefs.SetString("SavedData7", dataToSave7);
        PlayerPrefs.Save();
    }
    public void LoadData7()
    {
        if (PlayerPrefs.HasKey("SavedData7"))
        {
            string savedData7 = PlayerPrefs.GetString("SavedData7");
            Key8.text = savedData7;
        }
    }
    [SerializeField] InputField Key9;
    void Awake8()
    {
        if (Instance8 == null)
        {
            Instance8 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave8()
    {
        string dataToSave8 = Key9.text;
        PlayerPrefs.SetString("SavedData8", dataToSave8);
        PlayerPrefs.Save();
    }
    public void LoadData8()
    {
        if (PlayerPrefs.HasKey("SavedData8"))
        {
            string savedData8 = PlayerPrefs.GetString("SavedData8");
            Key9.text = savedData8;
        }
    }
    [SerializeField] InputField Key10;
    void Awake9()
    {
        if (Instance9 == null)
        {
            Instance9 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave9()
    {
        string dataToSave9 = Key10.text;
        PlayerPrefs.SetString("SavedData9", dataToSave9);
        PlayerPrefs.Save();
    }
    public void LoadData9()
    {
        if (PlayerPrefs.HasKey("SavedData9"))
        {
            string savedData9 = PlayerPrefs.GetString("SavedData9");
            Key10.text = savedData9;
        }
    }
    [SerializeField] InputField Key11;
    void Awake10()
    {
        if (Instance10 == null)
        {
            Instance10 = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave10()
    {
        string dataToSave10 = Key11.text;
        PlayerPrefs.SetString("SavedData10", dataToSave10);
        PlayerPrefs.Save();
    }
    public void LoadData10()
    {
        if (PlayerPrefs.HasKey("SavedData10"))
        {
            string savedData10 = PlayerPrefs.GetString("SavedData10");
            Key11.text = savedData10;
        }
    }
    [SerializeField] InputField Key12;
    void Awake11()
    {
        if (Instance11 == null)
        {
            Instance11 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave11()
    {
        string dataToSave11 = Key12.text;
        PlayerPrefs.SetString("SavedData11", dataToSave11);
        PlayerPrefs.Save();
    }
    public void LoadData11()
    {
        if (PlayerPrefs.HasKey("SavedData11"))
        {
            string savedData11 = PlayerPrefs.GetString("SavedData11");
            Key12.text = savedData11;
        }
    }
    [SerializeField] InputField Key13;
    void Awake12()
    {
        if (Instance12 == null)
        {
            Instance12 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave12()
    {
        string dataToSave12 = Key13.text;
        PlayerPrefs.SetString("SavedData12", dataToSave12);
        PlayerPrefs.Save();
    }
    public void LoadData12()
    {
        if (PlayerPrefs.HasKey("SavedData12"))
        {
            string savedData12 = PlayerPrefs.GetString("SavedData12");
            Key13.text = savedData12;
        }
    }
    [SerializeField] InputField Key14;
    void Awake13()
    {
        if (Instance13 == null)
        {
            Instance13 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave13()
    {
        string dataToSave13 = Key14.text;
        PlayerPrefs.SetString("SavedData13", dataToSave13);
        PlayerPrefs.Save();
    }
    public void LoadData13()
    {
        if (PlayerPrefs.HasKey("SavedData13"))
        {
            string savedData13 = PlayerPrefs.GetString("SavedData13");
            Key14.text = savedData13;
        }
    }
    [SerializeField] InputField Key15;
    void Awake14()
    {
        if (Instance14 == null)
        {
            Instance14 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave14()
    {
        string dataToSave14 = Key15.text;
        PlayerPrefs.SetString("SavedData14", dataToSave14);
        PlayerPrefs.Save();
    }
    public void LoadData14()
    {
        if (PlayerPrefs.HasKey("SavedData14"))
        {
            string savedData14 = PlayerPrefs.GetString("SavedData14");
            Key15.text = savedData14;
        }
    }
    [SerializeField] InputField Key16;
    void Awake15()
    {
        if (Instance15 == null)
        {
            Instance15 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave15()
    {
        string dataToSave15 = Key16.text;
        PlayerPrefs.SetString("SavedData15", dataToSave15);
        PlayerPrefs.Save();
    }
    public void LoadData15()
    {
        if (PlayerPrefs.HasKey("SavedData15"))
        {
            string savedData15 = PlayerPrefs.GetString("SavedData15");
            Key16.text = savedData15;
        }
    }
    [SerializeField] InputField Key17;
    void Awake16()
    {
        if (Instance16 == null)
        {
            Instance16 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave16()
    {
        string dataToSave16 = Key17.text;
        PlayerPrefs.SetString("SavedData16", dataToSave16);
        PlayerPrefs.Save();
    }
    public void LoadData16()
    {
        if (PlayerPrefs.HasKey("SavedData16"))
        {
            string savedData16 = PlayerPrefs.GetString("SavedData16");
            Key17.text = savedData16;
        }
    }
    [SerializeField] InputField Key18;
    void Awake17()
    {
        if (Instance17 == null)
        {
            Instance17 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave17()
    {
        string dataToSave17 = Key18.text;
        PlayerPrefs.SetString("SavedData17", dataToSave17);
        PlayerPrefs.Save();
    }
    public void LoadData17()
    {
        if (PlayerPrefs.HasKey("SavedData17"))
        {
            string savedData17 = PlayerPrefs.GetString("SavedData17");
            Key18.text = savedData17;
        }
    }
    [SerializeField] InputField Key19;
    void Awake18()
    {
        if (Instance18 == null)
        {
            Instance18 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave18()
    {
        string dataToSave18 = Key19.text;
        PlayerPrefs.SetString("SavedData18", dataToSave18);
        PlayerPrefs.Save();
    }
    public void LoadData18()
    {
        if (PlayerPrefs.HasKey("SavedData18"))
        {
            string savedData18 = PlayerPrefs.GetString("SavedData18");
            Key19.text = savedData18;
        }
    }
    [SerializeField] InputField Key20;
    void Awake19()
    {
        if (Instance19 == null)
        {
            Instance19 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave19()
    {
        string dataToSave19 = Key20.text;
        PlayerPrefs.SetString("SavedData19", dataToSave19);
        PlayerPrefs.Save();
    }
    public void LoadData19()
    {
        if (PlayerPrefs.HasKey("SavedData19"))
        {
            string savedData19 = PlayerPrefs.GetString("SavedData19");
            Key20.text = savedData19;
        }
    }
    [SerializeField] InputField Key21;
    void Awake20()
    {
        if (Instance20 == null)
        {
            Instance20 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void DataSave20()
    {
        string dataToSave20 = Key21.text;
        PlayerPrefs.SetString("SavedData20", dataToSave20);
        PlayerPrefs.Save();
    }
    public void LoadData20()
    {
        if (PlayerPrefs.HasKey("SavedData20"))
        {
            string savedData20 = PlayerPrefs.GetString("SavedData20");
            Key21.text = savedData20;
        }
    }
}
