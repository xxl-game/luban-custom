using Luban.RawDefs;

namespace Luban.Schema;

public class LubanConfig
{
    public List<RawGroup> Groups { get; set; }

    public List<RawTarget> Targets { get; set; }

    public List<SchemaFileInfo> Imports { get; set; }

    public string InputDataDir { get; set; }
}
