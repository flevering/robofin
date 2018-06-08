using System;
using System.Collections.Generic;

namespace Model
{
    public class WatsonModel
    {

        public Input input { get; set; }
        public Context context { get; set; }

        public class Input
        {
            public string text { get; set; }
        }

        public class DialogStack
        {
            public string dialog_node { get; set; }
        }

        public class System
        {
            public List<DialogStack> dialog_stack { get; set; }
            public int dialog_turn_counter { get; set; }
            public int dialog_request_counter { get; set; }
            public Dictionary<string, List<int>> _node_output_map { get; set; }
        }

        public class Context
        {
            public string conversation_id { get; set; }
            public System system { get; set; }
            public double? Inkomen { get; set; }
            public double? RVP { get; set; }
            public double? Schulden { get; set; }

        }
    }
}
