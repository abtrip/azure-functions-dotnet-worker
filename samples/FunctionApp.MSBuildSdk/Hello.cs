// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace FunctionApp;

public class Hello(ILogger<Hello> logger)
{
    [Function("hello")]
  public async Task<IActionResult> HelloImpl(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
{
    logger.LogInformation("C# HTTP trigger function processed a request.");

    // Simulate a slow operation: wait for 10 seconds
    await Task.Delay(10000);

    return new OkObjectResult("Welcome to Azure Functions! Response delayed by 10 seconds.");
}
}
