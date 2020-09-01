using EDDLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDTools.Models
{
    public class Tool : BaseModel
    {
        public static Tool CreateTool() { return new Tool(); }
        public static Tool CreatTool(string id_tool, string toolName, string toolShortName, string toolExe, string toolImage, string toolDesc) => new Tool()
        {
            Id_Tool = id_tool,

            ToolName = toolName,
            ToolShortName = toolShortName,
            ToolExe = toolExe,
            ToolImage = toolImage,
            ToolDesc = toolDesc
        };

        #region Properties

        public string Id_Tool { get; set; }

        public string ToolName { get; set; }
        public string ToolShortName { get; set; }
        public string ToolExe { get; set; }
        public string ToolImage { get; set; }
        public string ToolDesc { get; set; }

        #endregion
    }
}
