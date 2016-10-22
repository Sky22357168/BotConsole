using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class TestClas
    {

        public class Rootobject
        {
            public Attachment attachment { get; set; }
        }

        public class Attachment
        {
            public string type { get; set; }
            public Payload payload { get; set; }
        }

        public class Payload
        {
            public string template_type { get; set; }
            public string text { get; set; }
            public Button[] buttons { get; set; }
        }

        public class Button
        {
            public string type { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string payload { get; set; }
        }


    }


}
