﻿using NMemory.Tables;
using NMemory.Transactions;

namespace NMemory.Modularity
{
    public interface IDatabase
    {
        ITableFactory TableFactory
        {
            get;
        }

        IConcurrencyManager ConcurrencyManager
        {
            get;
        }

        IQueryCompiler Compiler
        {
            get;
        }

        IQueryExecutor Executor
        {
            get;
        }

        TransactionHandler TransactionHandler
        {
            get;
        }

        ILoggingPort LoggingPort
        {
            get;
        }

        TableCollection Tables
        {
            get;
        }
    }
}