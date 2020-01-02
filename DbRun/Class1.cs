using System;

namespace DbRun
{

    // Run command in sql script file against db
    // Run command in sql script only once against db
    // Run one file
    // Run folder structure recursively
    // List files run against db
    // Purge list 

    // What is needed
    // Connection string
    // Database name
    // file path
    // folde path

    // How
    // Discover, sort by name, calculate hash, compare and run in order, remeber
    // Update repository only when success

    // Table structure
    // Id, int , identity
    // FileName nvarcher(1024)
    // FileHash varbinary
    // DateOfRun datetime

    public class ConnectionInfo
    {
        public string ConnectionString { get; }

        public ConnectionInfo(string connectionString)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
    }

    public class RunSingleFileScript
    {

    }

    public class RunScriptFolder
    {

    }

    public class 

}


