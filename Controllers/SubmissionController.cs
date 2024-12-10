using Microsoft.AspNetCore.Mvc;
using LifeTracker.Models;

namespace Controllers;

[ApiController]
[Route("[controller]")]
public class SubmissionController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<SubmissionController> _logger;

    public SubmissionController(ILogger<SubmissionController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSubmission")]
    public IEnumerable<Submission> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Submission
        {
            
        })
        .ToArray();
    }

    [HttpPost(Name = "PostSubmission")]
    public IEnumerable<Submission> Post()
    {
        return Enumerable.Range(1, 5).Select(index => new Submission
        {
        })
        .ToArray();
    }

    [HttpPut(Name = "PutSubmission")]
    public IEnumerable<Submission> Put()
    {
        return Enumerable.Range(1, 5).Select(index => new Submission
        {
        })
        .ToArray();
    }

    [HttpDelete(Name = "DeleteSubmission")]
    public IEnumerable<Submission> Delete()
    {
        return Enumerable.Range(1, 5).Select(index => new Submission
        {

        })
        .ToArray();
    }
}
