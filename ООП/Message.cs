using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООП.Options;

namespace ООП
{
    public class Message
    {
        public string Text { get; set; }
        public string SenderName { get; set; }
        public string SenderType { get; set; }
        public MessageType MessageType { get; set; }
    }
}
