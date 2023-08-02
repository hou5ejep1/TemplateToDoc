using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace TemplateToDoc.Models
{
    class ExportSettings
    {
        public StringBuilder TargetPath = new();
        public int CurrentStepExporting;
        public int MaxStepsCount;
    }
}
