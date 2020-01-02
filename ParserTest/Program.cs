using System;
using System.Data;
using System.Data.SqlClient;
using System.IO.Enumeration;
using System.Linq;
using System.Text.RegularExpressions;
using CommandLine;
using Dapper;
using Dapper.Contrib.Extensions;

namespace ParserTest
{

    public class ParameterParser
    {

        

    }

    class Program
    {

        [Verb("test", HelpText = "test")]
        public class Options
        {
            [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
            public bool Verbose { get; set; }

            [Option('p', "path",Required = true, HelpText = "Path to a file")]
            public string Path { get;set;}

        }

        [Verb("add", HelpText = "Add file contents to the index.")]
        class AddOptions
        { //normal options here
        }
        [Verb("commit", HelpText = "Record changes to the repository.")]
        class CommitOptions
        { //normal options here
        }
        [Verb("clone", HelpText = "Clone a repository into a new directory.")]
        class CloneOptions
        { //normal options here
        }

        public class DbRunEvidence
        {
            public long Id { get;set;}
            public string FileName { get;set;}
            public byte[] FileHash { get; set; }
            public DateTime DateRun { get; set; }
            public string Author { get; set; }
            public string Location { get; set; }

            public override string ToString()
            {
                return $"{nameof(Id)}: {Id}, {nameof(FileName)}: {FileName}, {nameof(FileHash)}: {FileHash}, {nameof(DateRun)}: {DateRun}, {nameof(Author)}: {Author}, {nameof(Location)}: {Location}";
            }
        }

        static void Main(string[] args)
        {

            using (IDbConnection conn = new SqlConnection(@"Server=JJ-HQ-DESKTOP\SQLEXPRESS;Database=TestDb;Trusted_Connection=True;"))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = Resource.CreateEvicenceDbScript;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            using (IDbConnection conn = new SqlConnection(@"Server=JJ-HQ-DESKTOP\SQLEXPRESS;Database=TestDb;Trusted_Connection=True;"))
            {
                
                var record = new DbRunEvidence()
                {
                    Author = "Jan Joska",
                    FileName = "20200101135563 - Initial script.sql",
                    FileHash = new byte[] {255,0,255,250},
                    Location = "system",
                    DateRun = DateTime.Now

                };
                conn.Open();
                conn.Insert<DbRunEvidence>(record);
                conn.Close();
            }

            using (IDbConnection conn = new SqlConnection(@"Server=JJ-HQ-DESKTOP\SQLEXPRESS;Database=TestDb;Trusted_Connection=True;"))
            {
                conn.Open();
                var records = conn.Query<DbRunEvidence>(new CommandDefinition("SELECT * FROM [dbo].[DbRunEvidences] ORDER BY [Id]")).ToArray();
                conn.Close();
                foreach (var record in records)
                {
                    Console.WriteLine(record);
                }
            }


            //Parser.Default.ParseArguments<Options,AddOptions, CommitOptions, CloneOptions>(args)
            //    .WithParsed<Options>(o =>
            //    {
            //        if (o.Verbose)
            //        {
            //            Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
            //            Console.WriteLine("Quick Start Example! App is in Verbose mode!");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Current Arguments: -v {o.Verbose}");
            //            Console.WriteLine("Quick Start Example!");
            //        }

            //        Console.WriteLine(o.Path);

            //    });
            Console.ReadLine();
        }
    }
}
