using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TemplateToDoc.Models
{
    [ObservableObject]
    partial class TemplateFile
    {
        public StringBuilder Path = new();
        public Image TemplateImage = new();
    }
}
