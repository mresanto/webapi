using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class CommentModel
    {
        public string comment_id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string visualizacoes { get; set; }
        public string data_comment { get; set; }
        public string comment_post { get; set; }
    }
}
