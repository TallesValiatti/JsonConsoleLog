namespace WorkerApp;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
            // Create a new generic process
            var process = new Process(hasAllTheNecessaryInfo: true);

            _logger.LogInformation(ProcessLogEvents.Started, "Process: {Id}", process.Id);
            
            if(process.hasAllTheNecessaryInfo)
            {
                // Execute the process
                process.Execute();
                _logger.LogInformation(ProcessLogEvents.Finished, "Process: {Id}", process.Id);    
            }
            else
                _logger.LogInformation(ProcessLogEvents.IncompleteInfos, "Process: {Id}", process.Id);

            await Task.Delay(1000, stoppingToken);
    }
}