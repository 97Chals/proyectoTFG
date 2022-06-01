using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class save_manager
{
    public static void SavePlayerData(coin_controller c, enemy_controller enemy, level_controller lvl)
    {
        save_data sd = new save_data(c, enemy, lvl);
        string dataPath = Application.persistentDataPath + "/player.save";
        FileStream fs = new FileStream(dataPath, FileMode.OpenOrCreate);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, sd);

        fs.Close();
    }

    public static save_data LoadSaveData()
    {
        string dataPath = Application.persistentDataPath + "/player.save";
        //string dataPath = "Assets/player.save";
        if (File.Exists(dataPath))
        {
            FileStream fs = new FileStream(dataPath, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            save_data playerData = (save_data)bf.Deserialize(fs);

            fs.Close();
            return playerData;
        }
        else
        {
            return null; 
        }

    }
}
