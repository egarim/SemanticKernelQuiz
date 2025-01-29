using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SemanticKernelQuiz
{
    public class QuizQuestion
    {
        [JsonPropertyName("question")]
        [Description("The question to ask the user")]
        public string Question { get; set; }
        [JsonPropertyName("answer")]
        [Description("The answer to the question")]
        public string Answer { get; set; }
        [JsonPropertyName("options")]
        [Description("The options to choose from")]
       public List<string> Options { get; set; }

        [JsonPropertyName("weight")]
        [Description("the evaluation weight of the question")]
        public double Weight { get; set; }
    }
   
    public class Quiz
    {
        [JsonPropertyName("subject")]
        [Description("The subject of the quiz base on the topic to study")]
        public string Subject { get; set; }

        [JsonPropertyName("questions")]
        List<QuizQuestion> Questions { get; set; }
    }
}
