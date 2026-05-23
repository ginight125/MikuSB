using Newtonsoft.Json;

namespace MikuSB.Data.Excel;

[ResourceEntity("challenge/climbtower/climb_tower_time.json")]
public class ClimbTowerTimeExcel : ExcelResource
{
    [JsonProperty("ID")] public uint ID { get; set; }
    [JsonProperty("StartTime")] public string StartTime { get; set; } = "";
    [JsonProperty("EndTime")] public string EndTime { get; set; } = "";

    public override uint GetId() => ID;

    public override void Loaded()
    {
        GameData.ClimbTowerTimeData[ID] = this;
    }
}
