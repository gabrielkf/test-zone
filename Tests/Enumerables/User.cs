using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TestZone.Enumerables;

public class User
{
    [JsonPropertyName("firstName")] public string FirstName { get; set; }

    [JsonPropertyName("middleName")] public string MiddleName { get; set; }

    [JsonPropertyName("lastName")] public string LastName { get; set; }

    public TaskField[] ToFields()
    {
        var properties = GetType().GetProperties();
        var taskFields = new List<TaskField>(properties.Length);

        taskFields.AddRange(
            from prop in properties
            let fieldName = prop.Name
            let fieldValue = (string)prop.GetValue(this)!
            select new TaskField(fieldName, fieldValue));

        return taskFields.ToArray();
    }
}

public class TaskField
{
    public TaskField(string fieldName, string fieldValue)
    {
        FieldName = fieldName;
        FieldValue = fieldValue;
    }

    public string FieldName { get; }

    public string FieldValue { get; }
}
