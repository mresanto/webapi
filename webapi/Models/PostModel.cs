using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class PostModel
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public string subtitulo { get; set; }
        public string descricao { get; set; }
        public string visualizacoes { get; set; }
        public string data { get; set; }
        public string postauthor { get; set; }
    }
}
