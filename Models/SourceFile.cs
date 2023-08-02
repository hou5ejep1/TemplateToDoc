using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateToDoc.Models
{
    [ObservableObject]
    partial class SourceFile
    {
        public StringBuilder Path = new StringBuilder();
        public DataTable Data = new DataTable();
    }
}
