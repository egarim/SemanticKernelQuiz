// See https://aka.ms/new-console-template for more information

//GPT 4 min does not do a good count
//string modelId = "gpt-4o-mini"; 
using Microsoft.Extensions.AI;
using OpenAI;
using SemanticKernelQuiz;

string modelId = "gpt-4o";
string OpenAiKey = Environment.GetEnvironmentVariable("OpenAiTestKey");


var courseInfo = System.IO.File.ReadAllText("CourseInfo.txt");

var prompt = System.IO.File.ReadAllText("Prompt.txt");

var FullPrompt =   prompt.Replace("$CourseInfo", courseInfo);

var client = new OpenAIClient(new System.ClientModel.ApiKeyCredential(OpenAiKey));

var ChatClient= new OpenAIChatClient(client, modelId)
    .AsBuilder()
    .UseFunctionInvocation()
    .Build();

var Message = new ChatMessage(ChatRole.User, FullPrompt);
//var Result=await ChatClient.CompleteAsync<Quiz>(new List<ChatMessage>() { Message }); 

var Result = await ChatClient.CompleteAsync<List<QuizQuestion>>(new List<ChatMessage>() { Message });
Console.WriteLine("Hello, World!");
