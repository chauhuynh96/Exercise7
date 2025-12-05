using UnityEngine;
using System.IO;

public static class DataBetweenScene 
{
    public static string playerName;

    [System.Serializable]
    public class SaveData
    {
        public float score;
        public string name;
    }

    public static void SaveHighScore(float highScore, string highName)
    {
        SaveData data = new SaveData();
        data.score = highScore;
        data.name = highName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public static SaveData LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            return data;
        }else
        {
            return null;
        }
    }
}

