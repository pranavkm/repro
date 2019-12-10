using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var payload = "{\"type\":\"https://tools.ietf.org/html/rfc7231#section-6.5.4\",\"title\":\"Not Found\",\"status\":404,\"traceId\":\"|2b127cb8-48a6a0aa0a2beaf9.\"}";
            var problemDetails = JsonSerializer.Deserialize<ProblemDetails>(payload);

            Console.WriteLine(problemDetails.Type);
            Console.WriteLine(problemDetails.Extensions["traceId"]);
        }
    }
}
