using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormExample.Entity
{
    public class Question
    {
        public string Title { get; set; } = string.Empty;
        public string Anser1 { get; set; } = string.Empty;
        public string Anser2 { get; set; } = string.Empty;
        public string Anser3 { get; set; } = string.Empty;
        public string Anser4 { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
    }
}
