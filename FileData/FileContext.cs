using System.Text.Json;

namespace FileData;

public class FileContext
{
    private const string filepath = "data.json";

    private DataContainer? dataContainer;

    public ICollection<User> Users
    {
        get
        {
            LoadData();
            return dataContainer !.Users;
        }
    }

    public ICollection<Recepie> Recepies
    {
        get
        {
            LoadData();
            return dataContainer !.Recepis;
        }
    }

    private void LoadData()
    {
        if (dataContainer != null) return;

        if (!File.Exists(filepath))
        {
            dataContainer = new()
            {
                Recepis = new List<Recepi>(),
                Users = new List<User>()
            };
            return;
        }

        string content = File.ReadAllText(filepath);
        dataContainer = JsonSerializer.Deserialize<DataContainer>(content);
    }
}